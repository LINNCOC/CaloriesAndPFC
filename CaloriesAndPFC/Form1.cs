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
    public partial class Calories : Form
    {
        private bool isDateDescending = true;
        private bool isCaloriesDescending = true;
        private int editingId = -1;
        private int editingDiaryId = -1;
        private double savedNorm = 0;
        public Calories()
        {
            InitializeComponent();
            Gender.Items.AddRange(new string[] { "Мужской", "Женский" });
            Gender.SelectedIndex = 0;

            Activity.Items.AddRange(new string[] { "Минимальная", "Низкая", "Средняя", "Высокая", "Экстремальная" });
            Activity.SelectedIndex = 2;

            Goal.Items.AddRange(new string[] { "Набор массы", "Похудение", "Поддержание" });
            Goal.SelectedIndex = 0;
            FilterGoal.Items.AddRange(new string[] { "Все цели", "Набор массы", "Похудение", "Поддержание" });
            FilterGoal.SelectedIndex = 0;
            MealTypeSelect.Items.AddRange(new string[] { "Завтрак", "Обед", "Ужин", "Перекус" });
            MealTypeSelect.SelectedIndex = 0;   

            CreateDatabase();
            LoadDefaultFoods();
            LoadFoodsToComboBox();
            LoadRecordsToListView();
            LoadDiary();
            UpdateProgress();
            this.btnAddToDiary.Click += new EventHandler(this.AddToDiary_Click);
            this.btnRemoveFromDiary.Click += new EventHandler(this.RemoveFromDiary_Click);
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
                    string sqlHistory = @"CREATE TABLE IF NOT EXISTS History (
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

                    string sqlFoods = @"CREATE TABLE IF NOT EXISTS Foods (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Calories REAL NOT NULL,
                Protein REAL NOT NULL,
                Fats REAL NOT NULL,
                Carbs REAL NOT NULL)";

                    string sqlDiary = @"CREATE TABLE IF NOT EXISTS Diary (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Date TEXT NOT NULL,
                FoodId INTEGER NOT NULL,
                Weight REAL NOT NULL,
                MealType TEXT NOT NULL,
                FOREIGN KEY(FoodId) REFERENCES Foods(Id))";

                    using (var cmd = new SQLiteCommand(sqlHistory, conn))
                        cmd.ExecuteNonQuery();
                    using (var cmd = new SQLiteCommand(sqlFoods, conn))
                        cmd.ExecuteNonQuery();
                    using (var cmd = new SQLiteCommand(sqlDiary, conn))
                        cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка БД: " + ex.Message);
            }
        }
        private void LoadDefaultFoods()
        {
            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();

                string checkSql = "SELECT COUNT(*) FROM Foods";
                using (var checkCmd = new SQLiteCommand(checkSql, conn))
                {
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0) return;
                }

                var foods = new List<(string Name, double Calories, double Protein, double Fats, double Carbs)>()
        {
            ("Куриная грудка", 165, 31, 3.6, 0),
            ("Гречка", 343, 12.6, 3.3, 71.5),
            ("Рис", 344, 6.7, 0.7, 78.9),
            ("Овсянка", 366, 11.9, 7.2, 69.3),
            ("Яйцо куриное", 155, 12.7, 11.5, 0.7),
            ("Творог 5%", 121, 17, 5, 1.8),
            ("Кефир 1%", 40, 3, 1, 4),
            ("Молоко 2.5%", 52, 2.8, 2.5, 4.7),
            ("Хлеб ржаной", 201, 6.6, 1.2, 43.4),
            ("Макароны", 350, 12, 1.5, 72),
            ("Говядина", 250, 26, 16, 0),
            ("Рыба (минтай)", 72, 15.9, 0.9, 0),
            ("Яблоко", 52, 0.3, 0.2, 13.8),
            ("Банан", 89, 1.1, 0.3, 22.8),
            ("Авокадо", 160, 2, 14.7, 8.5),
            ("Орехи грецкие", 654, 15.2, 65.2, 13.7),
            ("Масло оливковое", 884, 0, 100, 0),
        };

                string insertSql = "INSERT INTO Foods (Name, Calories, Protein, Fats, Carbs) VALUES (@name, @cal, @prot, @fat, @carb)";
                foreach (var food in foods)
                {
                    using (var cmd = new SQLiteCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", food.Name);
                        cmd.Parameters.AddWithValue("@cal", food.Calories);
                        cmd.Parameters.AddWithValue("@prot", food.Protein);
                        cmd.Parameters.AddWithValue("@fat", food.Fats);
                        cmd.Parameters.AddWithValue("@carb", food.Carbs);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void LoadFoodsToComboBox()
        {
            FoodSelect.Items.Clear();
            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string sql = "SELECT Id, Name FROM Foods ORDER BY Name";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FoodSelect.Items.Add(reader["Name"].ToString());
                    }
                }
            }
            if (FoodSelect.Items.Count > 0)
                FoodSelect.SelectedIndex = 0;
        }
        private void LoadDiary()
        {
            DiaryList.Items.Clear();
            string today = DateTime.Now.ToString("dd.MM.yyyy");

            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string sql = @"
            SELECT d.Id, f.Name, d.Weight, f.Calories, f.Protein, f.Fats, f.Carbs, d.MealType,
                   ROUND(d.Weight * f.Calories / 100, 1) as TotalCal,
                   ROUND(d.Weight * f.Protein / 100, 1) as TotalProt,
                   ROUND(d.Weight * f.Fats / 100, 1) as TotalFat,
                   ROUND(d.Weight * f.Carbs / 100, 1) as TotalCarb
            FROM Diary d
            JOIN Foods f ON d.FoodId = f.Id
            WHERE d.Date = @date
            ORDER BY d.MealType, d.Id";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", today);
                    using (var reader = cmd.ExecuteReader())
                    {
                        double totalCal = 0, totalProt = 0, totalFat = 0, totalCarb = 0;

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Id"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(reader["Weight"].ToString());
                            item.SubItems.Add(Convert.ToDouble(reader["TotalCal"]).ToString("F1"));
                            item.SubItems.Add(Convert.ToDouble(reader["TotalProt"]).ToString("F1"));
                            item.SubItems.Add(Convert.ToDouble(reader["TotalFat"]).ToString("F1"));
                            item.SubItems.Add(Convert.ToDouble(reader["TotalCarb"]).ToString("F1"));
                            item.SubItems.Add(reader["MealType"].ToString());
                            DiaryList.Items.Add(item);

                            totalCal += Convert.ToDouble(reader["TotalCal"]);
                            totalProt += Convert.ToDouble(reader["TotalProt"]);
                            totalFat += Convert.ToDouble(reader["TotalFat"]);
                            totalCarb += Convert.ToDouble(reader["TotalCarb"]);
                        }

                        if (DiaryList.Items.Count > 0)
                        {
                            ListViewItem totalItem = new ListViewItem("--- ИТОГО ЗА ДЕНЬ ---");
                            totalItem.Font = new Font(DiaryList.Font, FontStyle.Bold);
                            totalItem.ForeColor = System.Drawing.Color.LimeGreen;
                            for (int i = 1; i < DiaryList.Columns.Count - 3; i++)
                                totalItem.SubItems.Add("");
                            totalItem.SubItems.Add(totalCal.ToString("F1"));
                            totalItem.SubItems.Add(totalProt.ToString("F1"));
                            totalItem.SubItems.Add(totalFat.ToString("F1"));
                            totalItem.SubItems.Add(totalCarb.ToString("F1"));
                            totalItem.SubItems.Add("");
                            DiaryList.Items.Add(totalItem);
                        }
                    }
                }
            }
            UpdateProgress();
        }
        private void UpdateProgress()
        {
            if (savedNorm == 0)
            {
                ProgressStatus.Text = "Сначала выполните расчёт нормы (кнопка «Рассчитать»).";
                ProgressBar.Value = 0;
                return;
            }

            string today = DateTime.Now.ToString("dd.MM.yyyy");
            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string sql = @"
            SELECT SUM(ROUND(d.Weight * f.Calories / 100, 1)) as TotalCal
            FROM Diary d
            JOIN Foods f ON d.FoodId = f.Id
            WHERE d.Date = @date";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", today);
                    object result = cmd.ExecuteScalar();
                    double eaten = result == DBNull.Value ? 0 : Convert.ToDouble(result);

                    double norm = savedNorm;
                    double percent = Math.Min(eaten / norm * 100, 100);
                    int percentInt = (int)percent;

                    ProgressBar.Value = percentInt;
                    ProgressStatus.Text = $"Съедено: {eaten:F0} / {norm:F0} ккал ({percentInt}%)";

                    if (percentInt < 80)
                        ProgressStatus.ForeColor = System.Drawing.Color.Yellow;
                    else if (percentInt <= 100)
                        ProgressStatus.ForeColor = System.Drawing.Color.LightGreen;
                    else
                        ProgressStatus.ForeColor = System.Drawing.Color.OrangeRed;
                }
            }
        }
        private void AddToDiary_Click(object sender, EventArgs e)
        {
            if (FoodSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите продукт.");
                return;
            }

            if (FoodWeight.Value <= 0)
            {
                MessageBox.Show("Введите корректный вес продукта.");
                return;
            }

            string selectedName = FoodSelect.SelectedItem.ToString();
            int foodId;
            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string sql = "SELECT Id FROM Foods WHERE Name = @name";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", selectedName);
                    foodId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            string mealType = MealTypeSelect.Text;
            double weight = (double)FoodWeight.Value;
            string today = DateTime.Now.ToString("dd.MM.yyyy");

            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();

                if (editingDiaryId == -1)
                {
                    string sql = "INSERT INTO Diary (Date, FoodId, Weight, MealType) VALUES (@date, @foodId, @weight, @meal)";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", today);
                        cmd.Parameters.AddWithValue("@foodId", foodId);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@meal", mealType);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Продукт добавлен в дневник.");
                }
                else
                {
                    string sql = @"UPDATE Diary SET 
                           FoodId = @foodId, 
                           Weight = @weight, 
                           MealType = @meal 
                           WHERE Id = @id";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@foodId", foodId);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@meal", mealType);
                        cmd.Parameters.AddWithValue("@id", editingDiaryId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Запись обновлена.");
                    editingDiaryId = -1; 
                }
            }

            LoadDiary();
        }
        private void RemoveFromDiary_Click(object sender, EventArgs e)
        {
            if (DiaryList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            ListViewItem selected = DiaryList.SelectedItems[0];
            if (selected.Text.Contains("---") || selected.Text == "")
            {
                MessageBox.Show("Нельзя удалить заголовок или итоговую строку.");
                return;
            }

            int id = Convert.ToInt32(selected.Text);
            DialogResult result = MessageBox.Show("Удалить запись из дневника?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
                {
                    conn.Open();
                    string sql = "DELETE FROM Diary WHERE Id = @id";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadDiary();
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
            if (Height.Value == 0 || Weight.Value == 0 || Age.Value == 0)
            {
                MessageBox.Show("Рост, вес и возраст не могут быть равны нулю");
                return;
            }
            double calories = GetCalories();
            double weight = (double)Weight.Value;
            var bzhu = GetBZHU(calories, weight);

            // Расчёт процентов БЖУ от калорийности
            double proteinPercent = (bzhu.protein * 4 / calories) * 100;
            double fatsPercent = (bzhu.fats * 9 / calories) * 100;
            double carbsPercent = (bzhu.carbs * 4 / calories) * 100;
            savedNorm = calories;

            Result.Clear();
            Result.AppendText("РЕЗУЛЬТАТ РАСЧЁТА\n\n");
            Result.AppendText($"Суточная норма калорий: {calories:F0} ккал\n\n");
            Result.AppendText("БЖУ В ГРАММАХ\n\n");
            Result.AppendText($"Белки: {bzhu.protein:F1} г\n");
            Result.AppendText($"Жиры: {bzhu.fats:F1} г\n");
            Result.AppendText($"Углеводы: {bzhu.carbs:F1} г\n\n");
            Result.AppendText("РАСПРЕДЕЛЕНИЕ ПО КАЛОРИЯМ\n\n");
            Result.AppendText($"Белки: {proteinPercent:F1}%\n");
            Result.AppendText($"Жиры: {fatsPercent:F1}%\n");
            Result.AppendText($"Углеводы: {carbsPercent:F1}%\n");

            Result.AppendText("\nРЕКОМЕНДАЦИЯ\n\n");

            weight = (double)Weight.Value;
            string goalName = Goal.Text;

            if (goalName == "Набор массы")
            {
                Result.AppendText($"Для набора массы рекомендуется увеличить калорийность на 300-500 ккал.\n");
                Result.AppendText($"Потребление белка должно составлять около 2 г/кг веса ({weight * 2:F0} г/сутки).\n");
                Result.AppendText("Включите в рацион: гречку, рис, овсянку, куриную грудку, яйца, творог.\n");
                Result.AppendText("Принимайте пищу 4-5 раз в день через равные промежутки времени.\n");
            }
            else if (goalName == "Похудение")
            {
                Result.AppendText($"Для снижения веса рекомендуется создать умеренный дефицит калорий (300-500 ккал).\n");
                Result.AppendText($"Потребление белка должно составлять около 1.6 г/кг веса ({weight * 1.6:F0} г/сутки).\n");
                Result.AppendText("Исключите: сахар, фастфуд, сладкие напитки, белый хлеб.\n");
                Result.AppendText("Увеличьте долю овощей, зелени и нежирного белка в рационе.\n");
            }
            else if (goalName == "Поддержание")
            {
                Result.AppendText($"Для поддержания текущей формы соблюдайте баланс калорий (поддерживающая калорийность).\n");
                Result.AppendText($"Потребление белка около 1.8 г/кг веса ({weight * 1.8:F0} г/сутки).\n");
                Result.AppendText("Разнообразьте рацион: рыба, крупы, овощи, фрукты, полезные жиры (орехи, авокадо).\n");
                Result.AppendText("Контролируйте размер порций и не пропускайте приёмы пищи.\n");
            }
            Result.AppendText("\n*Рекомендации носят общий характер и не заменяют консультацию специалиста.");
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

            string line = $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} | {Gender.Text} | {Age.Value} лет | {Height.Value} см " +
                $"| {Weight.Value} кг | {Activity.Text} | {Goal.Text} | " +
                $"{calories:F0} ккал | {bzhu.protein:F1}г б | {bzhu.fats:F1}г ж | {bzhu.carbs:F1}г у";
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
                string sql = "INSERT INTO History (Date, Gender, Age, Height, Weight, Activity, Goal, Calories, Protein, Fats, Carbs)" +
                    " VALUES (@date, @gender, @age, @height, @weight, @activity, @goal, @cal, @prot, @fat, @carb)";
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
            double fats = fatCalories / 9;

            double minFats = weight * 0.5;
            double maxFats = weight * 1.2;
            if (fats < minFats) fats = minFats;
            if (fats > maxFats) fats = maxFats;

            double fatCaloriesActual = fats * 9;

            double carbsCalories = calories - proteinCalories - fatCaloriesActual;
            double carbs = carbsCalories / 4;

            if (carbs < 0) carbs = 0;

            return (protein, fats, carbs);
        }
        private void LoadRecordsToListView()
        {
            Records.Items.Clear();
            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string sql = "SELECT Id, Date, Calories, Protein, Fats, Carbs FROM History ORDER BY Id DESC";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Date"].ToString());
                        item.SubItems.Add(Convert.ToDouble(reader["Calories"]).ToString("F0"));
                        item.SubItems.Add(Convert.ToDouble(reader["Protein"]).ToString("F1"));
                        item.SubItems.Add(Convert.ToDouble(reader["Fats"]).ToString("F1"));
                        item.SubItems.Add(Convert.ToDouble(reader["Carbs"]).ToString("F1"));
                        Records.Items.Add(item);
                    }
                }
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (Result.Text == "")
            {
                MessageBox.Show("Сначала выполните расчёт (кнопка «Рассчитать»).");
                return;
            }

            double calories = GetCalories();
            double weight = (double)Weight.Value;
            var bzhu = GetBZHU(calories, weight);

            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();

                string sql;
                if (editingId == -1) 
                {
                    sql = @"INSERT INTO History (Date, Gender, Age, Height, Weight, Activity, Goal, Calories, Protein, Fats, Carbs) 
                    VALUES (@date, @gender, @age, @height, @weight, @activity, @goal, @cal, @prot, @fat, @carb)";
                }
                else 
                {
                    sql = @"UPDATE History SET 
                    Date = @date,
                    Gender = @gender,
                    Age = @age,
                    Height = @height,
                    Weight = @weight,
                    Activity = @activity,
                    Goal = @goal,
                    Calories = @cal,
                    Protein = @prot,
                    Fats = @fat,
                    Carbs = @carb
                    WHERE Id = @id";
                }

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

                    if (editingId != -1)
                        cmd.Parameters.AddWithValue("@id", editingId);

                    cmd.ExecuteNonQuery();
                }
            }

            string action = editingId == -1 ? "добавлена" : "обновлена";
            editingId = -1; 
            LoadRecordsToListView();
            MessageBox.Show($"Запись успешно {action}.");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Records.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            int id = Convert.ToInt32(Records.SelectedItems[0].Text);
            DialogResult result = MessageBox.Show($"Удалить запись #{id}?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
                {
                    conn.Open();
                    string sql = "DELETE FROM History WHERE Id = @id";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        LoadRecordsToListView();
                    }
                }
            }
        }

        private void SortByDate_Click(object sender, EventArgs e)
        {
            isDateDescending = !isDateDescending;

            Records.Items.Clear();
            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string order = isDateDescending ? "DESC" : "ASC";
                string sql = $"SELECT Id, Date, Calories, Protein, Fats, Carbs FROM History ORDER BY Date {order}";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Date"].ToString());
                        item.SubItems.Add(Convert.ToDouble(reader["Calories"]).ToString("F0"));
                        item.SubItems.Add(Convert.ToDouble(reader["Protein"]).ToString("F1"));
                        item.SubItems.Add(Convert.ToDouble(reader["Fats"]).ToString("F1"));
                        item.SubItems.Add(Convert.ToDouble(reader["Carbs"]).ToString("F1"));
                        Records.Items.Add(item);
                    }
                }
            }
        }

        private void SortByCalories_Click(object sender, EventArgs e)
        {
            isCaloriesDescending = !isCaloriesDescending;

            Records.Items.Clear();
            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string order = isCaloriesDescending ? "DESC" : "ASC";
                string sql = $"SELECT Id, Date, Calories, Protein, Fats, Carbs FROM History ORDER BY Calories {order}";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Date"].ToString());
                        item.SubItems.Add(Convert.ToDouble(reader["Calories"]).ToString("F0"));
                        item.SubItems.Add(Convert.ToDouble(reader["Protein"]).ToString("F1"));
                        item.SubItems.Add(Convert.ToDouble(reader["Fats"]).ToString("F1"));
                        item.SubItems.Add(Convert.ToDouble(reader["Carbs"]).ToString("F1"));
                        Records.Items.Add(item);
                    }
                }
            }
        }

        private void Records_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Records.SelectedItems.Count == 0)
            {
                editingId = -1;
                return;
            }

            int id = Convert.ToInt32(Records.SelectedItems[0].Text);
            editingId = id;  

            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string sql = "SELECT * FROM History WHERE Id = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Gender.Text = reader["Gender"].ToString();
                            Age.Value = Convert.ToDecimal(reader["Age"]);
                            Height.Value = Convert.ToDecimal(reader["Height"]);
                            Weight.Value = Convert.ToDecimal(reader["Weight"]);
                            Activity.Text = reader["Activity"].ToString();
                            Goal.Text = reader["Goal"].ToString();
                            Calculate_Click(sender, e);
                        }
                    }
                }
            }
        }
        private void Filter_Click(object sender, EventArgs e)
        {
            {
                string filter = FilterGoal.Text;

                Records.Items.Clear();
                using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
                {
                    conn.Open();
                    string sql;
                    if (filter == "Все цели")
                        sql = "SELECT Id, Date, Calories, Protein, Fats, Carbs FROM History ORDER BY Id DESC";
                    else
                        sql = "SELECT Id, Date, Calories, Protein, Fats, Carbs FROM History WHERE Goal = @goal ORDER BY Id DESC";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        if (filter != "Все цели")
                            cmd.Parameters.AddWithValue("@goal", filter);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["Id"].ToString());
                                item.SubItems.Add(reader["Date"].ToString());
                                item.SubItems.Add(Convert.ToDouble(reader["Calories"]).ToString("F0"));
                                item.SubItems.Add(Convert.ToDouble(reader["Protein"]).ToString("F1"));
                                item.SubItems.Add(Convert.ToDouble(reader["Fats"]).ToString("F1"));
                                item.SubItems.Add(Convert.ToDouble(reader["Carbs"]).ToString("F1"));
                                Records.Items.Add(item);
                            }
                        }
                    }
                }

                if (Records.Items.Count == 0)
                    MessageBox.Show("Записей с выбранной целью не найдено.");
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if (Records.SelectedItems.Count == 0)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.");
                return;
            }

            Records_SelectedIndexChanged(sender, e);

            MessageBox.Show("Теперь вы можете изменить параметры в полях ввода. После изменений нажмите «Добавить запись» для сохранения.");
        }

        private void btnEditDiary_Click(object sender, EventArgs e)
        {
            if (DiaryList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите запись для изменения.");
                return;
            }

            ListViewItem selected = DiaryList.SelectedItems[0];
            if (selected.Text.Contains("---") || selected.Text == "")
            {
                MessageBox.Show("Нельзя изменить заголовок или итоговую строку.");
                return;
            }

            editingDiaryId = Convert.ToInt32(selected.Text);

            string productName = selected.SubItems[1].Text;
            double weight = Convert.ToDouble(selected.SubItems[2].Text);
            string mealType = selected.SubItems[7].Text;

            for (int i = 0; i < FoodSelect.Items.Count; i++)
            {
                if (FoodSelect.Items[i].ToString() == productName)
                {
                    FoodSelect.SelectedIndex = i;
                    break;
                }
            }

            FoodWeight.Value = (decimal)weight;
            MealTypeSelect.Text = mealType;

            MessageBox.Show("Теперь измените данные и нажмите «Добавить в дневник» для сохранения.");
        }
        private void btnSearchDiary_Click(object sender, EventArgs e)
        {
            string searchText = SearchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Введите текст для поиска.");
                return;
            }

            DiaryList.Items.Clear();
            string today = DateTime.Now.ToString("dd.MM.yyyy");

            using (var conn = new SQLiteConnection("Data Source=CalorieHistory.db;Version=3;"))
            {
                conn.Open();
                string sql = @"
            SELECT d.Id, f.Name, d.Weight, f.Calories, f.Protein, f.Fats, f.Carbs, d.MealType,
                   ROUND(d.Weight * f.Calories / 100, 1) as TotalCal,
                   ROUND(d.Weight * f.Protein / 100, 1) as TotalProt,
                   ROUND(d.Weight * f.Fats / 100, 1) as TotalFat,
                   ROUND(d.Weight * f.Carbs / 100, 1) as TotalCarb
            FROM Diary d
            JOIN Foods f ON d.FoodId = f.Id
            WHERE d.Date = @date AND (f.Name LIKE @search OR d.MealType LIKE @search)
            ORDER BY d.MealType, d.Id";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", today);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        double totalCal = 0, totalProt = 0, totalFat = 0, totalCarb = 0;

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Id"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(reader["Weight"].ToString());
                            item.SubItems.Add(Convert.ToDouble(reader["TotalCal"]).ToString("F1"));
                            item.SubItems.Add(Convert.ToDouble(reader["TotalProt"]).ToString("F1"));
                            item.SubItems.Add(Convert.ToDouble(reader["TotalFat"]).ToString("F1"));
                            item.SubItems.Add(Convert.ToDouble(reader["TotalCarb"]).ToString("F1"));
                            item.SubItems.Add(reader["MealType"].ToString());
                            DiaryList.Items.Add(item);

                            totalCal += Convert.ToDouble(reader["TotalCal"]);
                            totalProt += Convert.ToDouble(reader["TotalProt"]);
                            totalFat += Convert.ToDouble(reader["TotalFat"]);
                            totalCarb += Convert.ToDouble(reader["TotalCarb"]);
                        }

                        if (DiaryList.Items.Count > 0)
                        {
                            ListViewItem totalItem = new ListViewItem("--- ИТОГО ЗА ДЕНЬ (поиск) ---");
                            totalItem.Font = new Font(DiaryList.Font, FontStyle.Bold);
                            totalItem.ForeColor = System.Drawing.Color.LimeGreen;
                            for (int i = 1; i < DiaryList.Columns.Count - 3; i++)
                                totalItem.SubItems.Add("");
                            totalItem.SubItems.Add(totalCal.ToString("F1"));
                            totalItem.SubItems.Add(totalProt.ToString("F1"));
                            totalItem.SubItems.Add(totalFat.ToString("F1"));
                            totalItem.SubItems.Add(totalCarb.ToString("F1"));
                            totalItem.SubItems.Add("");
                            DiaryList.Items.Add(totalItem);
                        }
                        else
                        {
                            MessageBox.Show("По вашему запросу ничего не найдено.");
                        }
                    }
                }
            }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Goal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void MealTypeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromDiary_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
