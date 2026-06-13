using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesAndPFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Gender.Items.AddRange(new string[] { "Мужской", "Женский" });
            Gender.SelectedIndex = 0;

            Activity.Items.AddRange(new string[] { "Минимальная", "Низкая", "Средняя", "Высокая", "Экстремальная" });
            Activity.SelectedIndex = 2;

            Goal.Items.AddRange(new string[] { "Набор массы", "Похудение", "Поддержание" });
            Goal.SelectedIndex = 0;

            CreateDatabase();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CreateDatabase()
        {
            try
            {
                using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
                {
                    conn.Open();
                    string sql = @"CREATE TABLE IF NOT EXISTS History (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Date TEXT,
                Gender TEXT,
                Age INTEGER,
                Height REAL,
                Weight REAL,
                Activity TEXT,
                Goal TEXT,
                Calories REAL,
                Protein REAL,
                Fats REAL,
                Carbs REAL)";
                    using (var cmd = new SQLiteCommand(sql, conn))
                        cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка БД: " + ex.Message);
            }
        }
        private double GetCalories()
        {
            double age = (double)Age.Value;
            double height = (double)Height.Value;
            double weight = (double)Weight.Value;
            bool isMale = Gender.SelectedIndex == 0;

            // Формула Миффлина-Сан Жеора (базовый метаболизм)      
            double bmr = isMale
                ? 10 * weight + 6.25 * height - 5 * age + 5
                : 10 * weight + 6.25 * height - 5 * age - 161;

            double activity = 1.55;
            switch (Activity.SelectedIndex)
            {
                case 0: activity = 1.2; break;
                case 1: activity = 1.375; break;
                case 2: activity = 1.55; break;
                case 3: activity = 1.725; break;
                case 4: activity = 1.9; break;
            }

            double goal = 1.0;
            switch (Goal.SelectedIndex)
            {
                case 0: goal = 1.15; break;
                case 1: goal = 0.85; break;
                case 2: goal = 1.0; break;
            }

            return bmr * activity * goal;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double calories = GetCalories();
            double weight = (double)Weight.Value;
            var bzhu = GetBZHU(calories, weight);

            // Расчёт процентов БЖУ от калорийности
            double proteinPercent = (bzhu.protein * 4 / calories) * 100;
            double fatsPercent = (bzhu.fats * 9 / calories) * 100;
            double carbsPercent = (bzhu.carbs * 4 / calories) * 100;

            Result.Clear();
            Result.AppendText("========== РЕЗУЛЬТАТ РАСЧЁТА ==========\n\n");
            Result.AppendText($"Суточная норма калорий: {calories:F0} ккал\n\n");
            Result.AppendText("========== БЖУ В ГРАММАХ ==========\n\n");
            Result.AppendText($"Белки: {bzhu.protein:F1} г\n");
            Result.AppendText($"Жиры: {bzhu.fats:F1} г\n");
            Result.AppendText($"Углеводы: {bzhu.carbs:F1} г\n\n");
            Result.AppendText("========== РАСПРЕДЕЛЕНИЕ ПО КАЛОРИЯМ ==========\n\n");
            Result.AppendText($"Белки: {proteinPercent:F1}%\n");
            Result.AppendText($"Жиры: {fatsPercent:F1}%\n");
            Result.AppendText($"Углеводы: {carbsPercent:F1}%\n");
        }

        private void SaveTxt_Click(object sender, EventArgs e)
        {
            if (Result.Text == "")
            {
                MessageBox.Show("Сначала нажмите «Рассчитать»");
                return;
            }

            double calories = GetCalories();
            double weight = (double)Weight.Value;
            var bzhu = GetBZHU(calories, weight);

            string line = $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} | {Gender.Text} | {Age.Value} лет | {Height.Value} см | {Weight.Value} кг | {Activity.Text} | {Goal.Text} | {calories:F0} ккал | {bzhu.protein:F1}г б | {bzhu.fats:F1}г ж | {bzhu.carbs:F1}г у";
            File.AppendAllText("CalculationHistory.txt", line + Environment.NewLine);
            MessageBox.Show("Сохранено в CalculationHistory.txt");
        }

        private void SaveDb_Click(object sender, EventArgs e)
        {
            if (Result.Text == "")
            {
                MessageBox.Show("Сначала нажмите «Рассчитать»");
                return;
            }

            double calories = GetCalories();
            double weight = (double)Weight.Value;
            var bzhu = GetBZHU(calories, weight);

            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string sql = "INSERT INTO History (Date, Gender, Age, Height, Weight, Activity, Goal, Calories, Protein, Fats, Carbs) VALUES (@date, @gender, @age, @height, @weight, @activity, @goal, @cal, @prot, @fat, @carb)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@gender", Gender.Text);
                    cmd.Parameters.AddWithValue("@age", (int)Age.Value);
                    cmd.Parameters.AddWithValue("@height", (double)Height.Value);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@activity", Activity.Text);
                    cmd.Parameters.AddWithValue("@goal", Goal.Text);
                    cmd.Parameters.AddWithValue("@cal", calories);
                    cmd.Parameters.AddWithValue("@prot", bzhu.protein);
                    cmd.Parameters.AddWithValue("@fat", bzhu.fats);
                    cmd.Parameters.AddWithValue("@carb", bzhu.carbs);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Сохранено в базу данных");
        }

        private void ShowHistory_Click(object sender, EventArgs e)
        {
            Result.Clear();
            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string sql = "SELECT * FROM History ORDER BY Id DESC";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Result.AppendText($"--- Запись #{reader["Id"]} ---\n");
                        Result.AppendText($"Дата: {reader["Date"]}\n");
                        Result.AppendText($"Цель: {reader["Goal"]}\n");
                        Result.AppendText($"Калории: {Convert.ToDouble(reader["Calories"]):F0} ккал\n");
                        Result.AppendText($"Белки: {reader["Protein"]} г, Жиры: {reader["Fats"]} г, Углеводы: {reader["Carbs"]} г\n\n");
                    }
                }
            }
        }
        private (double protein, double fats, double carbs) GetBZHU(double calories, double weight)
        {
            double proteinPerKg = 1.8;
            switch (Goal.SelectedIndex)
            {
                case 0: proteinPerKg = 2.0; break;
                case 1: proteinPerKg = 1.6; break;
                case 2: proteinPerKg = 1.8; break;
            }

            double protein = weight * proteinPerKg;
            double proteinCalories = protein * 4;

            double fatPercentage = 0.25;
            switch (Goal.SelectedIndex)
            {
                case 0: fatPercentage = 0.28; break;
                case 1: fatPercentage = 0.22; break;
                case 2: fatPercentage = 0.25; break;
            }
            double fatCalories = calories * fatPercentage;
            double fatsFromPercent = fatCalories / 9;

            double minFats = weight * 0.5;
            double fats = fatsFromPercent;
            if (fats < minFats) fats = minFats;
            double maxFats = weight * 1.2;
            if (fats > maxFats) fats = maxFats;


            double carbsCalories = calories - proteinCalories - fatCalories;
            double carbs = carbsCalories / 4;  

            if (carbs < 0) carbs = 0;

            return (protein, fats, carbs);
        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
