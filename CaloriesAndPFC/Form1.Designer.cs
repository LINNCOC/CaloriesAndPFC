namespace CaloriesAndPFC
{
    partial class Calories
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculate = new System.Windows.Forms.Button();
            this.SaveTxt = new System.Windows.Forms.Button();
            this.SaveDb = new System.Windows.Forms.Button();
            this.ShowHistory = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Goal = new System.Windows.Forms.ComboBox();
            this.Activity = new System.Windows.Forms.ComboBox();
            this.Weight = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Records = new System.Windows.Forms.ListView();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCalories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProtein = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCarbs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SortByDate = new System.Windows.Forms.Button();
            this.SortByCalories = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Filter = new System.Windows.Forms.Button();
            this.FilterGoal = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Edit = new System.Windows.Forms.Button();
            this.labelFoodSelect = new System.Windows.Forms.Label();
            this.FoodSelect = new System.Windows.Forms.ComboBox();
            this.labelFoodWeight = new System.Windows.Forms.Label();
            this.labelMealType = new System.Windows.Forms.Label();
            this.ProgressStatus = new System.Windows.Forms.Label();
            this.FoodWeight = new System.Windows.Forms.NumericUpDown();
            this.MealTypeSelect = new System.Windows.Forms.ComboBox();
            this.btnAddToDiary = new System.Windows.Forms.Button();
            this.btnRemoveFromDiary = new System.Windows.Forms.Button();
            this.DiaryList = new System.Windows.Forms.ListView();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.colDiaryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaryWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaryCal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaryProt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaryFat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaryCarb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaryMeal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEditDiary = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.btnSearchDiary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodWeight)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.LightGreen;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate.ForeColor = System.Drawing.Color.Black;
            this.Calculate.Location = new System.Drawing.Point(7, 9);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(178, 83);
            this.Calculate.TabIndex = 11;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // SaveTxt
            // 
            this.SaveTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SaveTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveTxt.ForeColor = System.Drawing.Color.Black;
            this.SaveTxt.Location = new System.Drawing.Point(393, 9);
            this.SaveTxt.Name = "SaveTxt";
            this.SaveTxt.Size = new System.Drawing.Size(178, 83);
            this.SaveTxt.TabIndex = 12;
            this.SaveTxt.Text = "Сохранить в TXT";
            this.SaveTxt.UseVisualStyleBackColor = false;
            this.SaveTxt.Click += new System.EventHandler(this.SaveTxt_Click);
            // 
            // SaveDb
            // 
            this.SaveDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SaveDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDb.ForeColor = System.Drawing.Color.Black;
            this.SaveDb.Location = new System.Drawing.Point(198, 9);
            this.SaveDb.Name = "SaveDb";
            this.SaveDb.Size = new System.Drawing.Size(178, 83);
            this.SaveDb.TabIndex = 13;
            this.SaveDb.Text = "Сохранить в БД";
            this.SaveDb.UseVisualStyleBackColor = false;
            this.SaveDb.Click += new System.EventHandler(this.SaveDb_Click);
            // 
            // ShowHistory
            // 
            this.ShowHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ShowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowHistory.ForeColor = System.Drawing.Color.Black;
            this.ShowHistory.Location = new System.Drawing.Point(583, 9);
            this.ShowHistory.Name = "ShowHistory";
            this.ShowHistory.Size = new System.Drawing.Size(178, 83);
            this.ShowHistory.TabIndex = 14;
            this.ShowHistory.Text = "Показать историю";
            this.ShowHistory.UseVisualStyleBackColor = false;
            this.ShowHistory.Click += new System.EventHandler(this.ShowHistory_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Result.Location = new System.Drawing.Point(7, 400);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1329, 202);
            this.Result.TabIndex = 15;
            this.Result.Text = "";
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaloriesAndPFC.Properties.Resources.burn;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(313, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вес (кг):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Рост(см):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возраст:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(330, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Цель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(237, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Уровень активности:";
            // 
            // Goal
            // 
            this.Goal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Goal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Goal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Goal.Font = new System.Drawing.Font("Consolas", 10F);
            this.Goal.ForeColor = System.Drawing.Color.White;
            this.Goal.FormattingEnabled = true;
            this.Goal.Location = new System.Drawing.Point(376, 41);
            this.Goal.Name = "Goal";
            this.Goal.Size = new System.Drawing.Size(391, 23);
            this.Goal.TabIndex = 10;
            this.Goal.Text = "Набор мышечной массы, Похудение, Поддержание формы";
            this.Goal.SelectedIndexChanged += new System.EventHandler(this.Goal_SelectedIndexChanged);
            // 
            // Activity
            // 
            this.Activity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Activity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Activity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Activity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Activity.Font = new System.Drawing.Font("Consolas", 10F);
            this.Activity.ForeColor = System.Drawing.Color.White;
            this.Activity.FormattingEnabled = true;
            this.Activity.Location = new System.Drawing.Point(376, 12);
            this.Activity.Name = "Activity";
            this.Activity.Size = new System.Drawing.Size(391, 23);
            this.Activity.TabIndex = 9;
            // 
            // Weight
            // 
            this.Weight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Weight.Font = new System.Drawing.Font("Consolas", 10F);
            this.Weight.ForeColor = System.Drawing.Color.White;
            this.Weight.Location = new System.Drawing.Point(377, 70);
            this.Weight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(64, 23);
            this.Weight.TabIndex = 8;
            // 
            // Height
            // 
            this.Height.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Height.Font = new System.Drawing.Font("Consolas", 10F);
            this.Height.ForeColor = System.Drawing.Color.White;
            this.Height.Location = new System.Drawing.Point(88, 67);
            this.Height.Maximum = new decimal(new int[] {
            230,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(141, 23);
            this.Height.TabIndex = 7;
            // 
            // Age
            // 
            this.Age.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Age.Font = new System.Drawing.Font("Consolas", 10F);
            this.Age.ForeColor = System.Drawing.Color.White;
            this.Age.Location = new System.Drawing.Point(88, 38);
            this.Age.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(141, 23);
            this.Age.TabIndex = 6;
            // 
            // Gender
            // 
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender.Font = new System.Drawing.Font("Consolas", 10F);
            this.Gender.ForeColor = System.Drawing.Color.White;
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(88, 12);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(141, 23);
            this.Gender.TabIndex = 1;
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(598, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Расчет калорий и БЖУ - Персональный фитнес-помощник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пол:";
            // 
            // Records
            // 
            this.Records.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Records.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Records.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colid,
            this.colDate,
            this.colCalories,
            this.colProtein,
            this.colFats,
            this.colCarbs});
            this.Records.FullRowSelect = true;
            this.Records.GridLines = true;
            this.Records.HideSelection = false;
            this.Records.Location = new System.Drawing.Point(285, 261);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(492, 133);
            this.Records.TabIndex = 19;
            this.Records.UseCompatibleStateImageBehavior = false;
            this.Records.View = System.Windows.Forms.View.Details;
            this.Records.SelectedIndexChanged += new System.EventHandler(this.Records_SelectedIndexChanged);
            // 
            // colid
            // 
            this.colid.Text = "ID";
            this.colid.Width = 50;
            // 
            // colDate
            // 
            this.colDate.Text = "Дата";
            this.colDate.Width = 120;
            // 
            // colCalories
            // 
            this.colCalories.Text = "Калории";
            this.colCalories.Width = 80;
            // 
            // colProtein
            // 
            this.colProtein.Text = "Белки";
            this.colProtein.Width = 80;
            // 
            // colFats
            // 
            this.colFats.Text = "Жиры";
            this.colFats.Width = 80;
            // 
            // colCarbs
            // 
            this.colCarbs.Text = "Углеводы";
            this.colCarbs.Width = 80;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(156)))));
            this.Add.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(7, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(161, 23);
            this.Add.TabIndex = 20;
            this.Add.Text = "Добавить запись";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(54)))), ((int)(((byte)(51)))));
            this.Delete.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(6, 100);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(161, 23);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Удалить запись";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SortByDate
            // 
            this.SortByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SortByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByDate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByDate.ForeColor = System.Drawing.Color.Black;
            this.SortByDate.Location = new System.Drawing.Point(7, 29);
            this.SortByDate.Name = "SortByDate";
            this.SortByDate.Size = new System.Drawing.Size(161, 23);
            this.SortByDate.TabIndex = 22;
            this.SortByDate.Text = "Сортировать по дате";
            this.SortByDate.UseVisualStyleBackColor = false;
            this.SortByDate.Click += new System.EventHandler(this.SortByDate_Click);
            // 
            // SortByCalories
            // 
            this.SortByCalories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SortByCalories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByCalories.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByCalories.ForeColor = System.Drawing.Color.Black;
            this.SortByCalories.Location = new System.Drawing.Point(6, 56);
            this.SortByCalories.Name = "SortByCalories";
            this.SortByCalories.Size = new System.Drawing.Size(162, 40);
            this.SortByCalories.TabIndex = 23;
            this.SortByCalories.Text = "Сортировать по калориям";
            this.SortByCalories.UseVisualStyleBackColor = false;
            this.SortByCalories.Click += new System.EventHandler(this.SortByCalories_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 42);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.Filter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.FilterGoal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Gender);
            this.panel2.Controls.Add(this.Age);
            this.panel2.Controls.Add(this.Height);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Goal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Activity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Weight);
            this.panel2.Location = new System.Drawing.Point(7, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 100);
            this.panel2.TabIndex = 25;
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter.ForeColor = System.Drawing.Color.White;
            this.Filter.Location = new System.Drawing.Point(593, 69);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(95, 24);
            this.Filter.TabIndex = 28;
            this.Filter.Text = "Фильтровать";
            this.Filter.UseVisualStyleBackColor = false;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // FilterGoal
            // 
            this.FilterGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.FilterGoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterGoal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterGoal.ForeColor = System.Drawing.Color.White;
            this.FilterGoal.FormattingEnabled = true;
            this.FilterGoal.Location = new System.Drawing.Point(466, 70);
            this.FilterGoal.Name = "FilterGoal";
            this.FilterGoal.Size = new System.Drawing.Size(121, 23);
            this.FilterGoal.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.Calculate);
            this.panel3.Controls.Add(this.SaveDb);
            this.panel3.Controls.Add(this.SaveTxt);
            this.panel3.Controls.Add(this.ShowHistory);
            this.panel3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(7, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 100);
            this.panel3.TabIndex = 26;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel4.Controls.Add(this.SortByDate);
            this.panel4.Controls.Add(this.Edit);
            this.panel4.Controls.Add(this.Add);
            this.panel4.Controls.Add(this.Delete);
            this.panel4.Controls.Add(this.SortByCalories);
            this.panel4.Location = new System.Drawing.Point(7, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 133);
            this.panel4.TabIndex = 27;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(175, 3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 127);
            this.Edit.TabIndex = 15;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // labelFoodSelect
            // 
            this.labelFoodSelect.AutoSize = true;
            this.labelFoodSelect.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFoodSelect.ForeColor = System.Drawing.Color.White;
            this.labelFoodSelect.Location = new System.Drawing.Point(24, 12);
            this.labelFoodSelect.Name = "labelFoodSelect";
            this.labelFoodSelect.Size = new System.Drawing.Size(63, 15);
            this.labelFoodSelect.TabIndex = 28;
            this.labelFoodSelect.Text = "Продукт:";
            // 
            // FoodSelect
            // 
            this.FoodSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.FoodSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoodSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodSelect.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodSelect.ForeColor = System.Drawing.Color.White;
            this.FoodSelect.FormattingEnabled = true;
            this.FoodSelect.Location = new System.Drawing.Point(93, 10);
            this.FoodSelect.Name = "FoodSelect";
            this.FoodSelect.Size = new System.Drawing.Size(168, 23);
            this.FoodSelect.TabIndex = 29;
            // 
            // labelFoodWeight
            // 
            this.labelFoodWeight.AutoSize = true;
            this.labelFoodWeight.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFoodWeight.ForeColor = System.Drawing.Color.White;
            this.labelFoodWeight.Location = new System.Drawing.Point(24, 38);
            this.labelFoodWeight.Name = "labelFoodWeight";
            this.labelFoodWeight.Size = new System.Drawing.Size(63, 15);
            this.labelFoodWeight.TabIndex = 30;
            this.labelFoodWeight.Text = "Вес (г):";
            // 
            // labelMealType
            // 
            this.labelMealType.AutoSize = true;
            this.labelMealType.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMealType.ForeColor = System.Drawing.Color.White;
            this.labelMealType.Location = new System.Drawing.Point(3, 65);
            this.labelMealType.Name = "labelMealType";
            this.labelMealType.Size = new System.Drawing.Size(84, 15);
            this.labelMealType.TabIndex = 31;
            this.labelMealType.Text = "Приём пищи:";
            this.labelMealType.Click += new System.EventHandler(this.label9_Click);
            // 
            // ProgressStatus
            // 
            this.ProgressStatus.AutoSize = true;
            this.ProgressStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressStatus.ForeColor = System.Drawing.Color.White;
            this.ProgressStatus.Location = new System.Drawing.Point(3, 133);
            this.ProgressStatus.Name = "ProgressStatus";
            this.ProgressStatus.Size = new System.Drawing.Size(49, 15);
            this.ProgressStatus.TabIndex = 32;
            this.ProgressStatus.Text = "Status";
            // 
            // FoodWeight
            // 
            this.FoodWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.FoodWeight.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodWeight.ForeColor = System.Drawing.Color.White;
            this.FoodWeight.Location = new System.Drawing.Point(93, 37);
            this.FoodWeight.Name = "FoodWeight";
            this.FoodWeight.Size = new System.Drawing.Size(168, 23);
            this.FoodWeight.TabIndex = 33;
            this.FoodWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // MealTypeSelect
            // 
            this.MealTypeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MealTypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MealTypeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MealTypeSelect.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MealTypeSelect.ForeColor = System.Drawing.Color.White;
            this.MealTypeSelect.FormattingEnabled = true;
            this.MealTypeSelect.Location = new System.Drawing.Point(93, 63);
            this.MealTypeSelect.Name = "MealTypeSelect";
            this.MealTypeSelect.Size = new System.Drawing.Size(168, 23);
            this.MealTypeSelect.TabIndex = 34;
            this.MealTypeSelect.SelectedIndexChanged += new System.EventHandler(this.MealTypeSelect_SelectedIndexChanged);
            // 
            // btnAddToDiary
            // 
            this.btnAddToDiary.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToDiary.Location = new System.Drawing.Point(381, 79);
            this.btnAddToDiary.Name = "btnAddToDiary";
            this.btnAddToDiary.Size = new System.Drawing.Size(162, 56);
            this.btnAddToDiary.TabIndex = 35;
            this.btnAddToDiary.Text = "Добавить в дневник";
            this.btnAddToDiary.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromDiary
            // 
            this.btnRemoveFromDiary.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveFromDiary.Location = new System.Drawing.Point(381, 12);
            this.btnRemoveFromDiary.Name = "btnRemoveFromDiary";
            this.btnRemoveFromDiary.Size = new System.Drawing.Size(162, 56);
            this.btnRemoveFromDiary.TabIndex = 36;
            this.btnRemoveFromDiary.Text = "Удалить из дневника";
            this.btnRemoveFromDiary.UseVisualStyleBackColor = true;
            this.btnRemoveFromDiary.Click += new System.EventHandler(this.btnRemoveFromDiary_Click);
            // 
            // DiaryList
            // 
            this.DiaryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DiaryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDiaryId,
            this.colDiaryName,
            this.colDiaryWeight,
            this.colDiaryCal,
            this.colDiaryProt,
            this.colDiaryFat,
            this.colDiaryCarb,
            this.colDiaryMeal});
            this.DiaryList.FullRowSelect = true;
            this.DiaryList.GridLines = true;
            this.DiaryList.HideSelection = false;
            this.DiaryList.Location = new System.Drawing.Point(783, 261);
            this.DiaryList.MultiSelect = false;
            this.DiaryList.Name = "DiaryList";
            this.DiaryList.ShowGroups = false;
            this.DiaryList.Size = new System.Drawing.Size(553, 133);
            this.DiaryList.TabIndex = 37;
            this.DiaryList.UseCompatibleStateImageBehavior = false;
            this.DiaryList.View = System.Windows.Forms.View.Details;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(3, 151);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(372, 52);
            this.ProgressBar.TabIndex = 38;
            // 
            // colDiaryId
            // 
            this.colDiaryId.Text = "ID";
            this.colDiaryId.Width = 0;
            // 
            // colDiaryWeight
            // 
            this.colDiaryWeight.DisplayIndex = 1;
            this.colDiaryWeight.Text = "Вес (г)";
            this.colDiaryWeight.Width = 70;
            // 
            // colDiaryCal
            // 
            this.colDiaryCal.DisplayIndex = 2;
            this.colDiaryCal.Text = "Ккал";
            this.colDiaryCal.Width = 70;
            // 
            // colDiaryProt
            // 
            this.colDiaryProt.DisplayIndex = 3;
            this.colDiaryProt.Text = "Белки";
            this.colDiaryProt.Width = 70;
            // 
            // colDiaryFat
            // 
            this.colDiaryFat.DisplayIndex = 4;
            this.colDiaryFat.Text = "Жиры";
            this.colDiaryFat.Width = 70;
            // 
            // colDiaryCarb
            // 
            this.colDiaryCarb.DisplayIndex = 5;
            this.colDiaryCarb.Text = "Углеводы";
            this.colDiaryCarb.Width = 70;
            // 
            // colDiaryMeal
            // 
            this.colDiaryMeal.DisplayIndex = 6;
            this.colDiaryMeal.Text = "Приём";
            this.colDiaryMeal.Width = 80;
            // 
            // colDiaryName
            // 
            this.colDiaryName.DisplayIndex = 7;
            this.colDiaryName.Text = "Продукт";
            this.colDiaryName.Width = 120;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.btnSearchDiary);
            this.panel5.Controls.Add(this.SearchBox);
            this.panel5.Controls.Add(this.btnEditDiary);
            this.panel5.Controls.Add(this.ProgressBar);
            this.panel5.Controls.Add(this.FoodSelect);
            this.panel5.Controls.Add(this.FoodWeight);
            this.panel5.Controls.Add(this.MealTypeSelect);
            this.panel5.Controls.Add(this.ProgressStatus);
            this.panel5.Controls.Add(this.btnRemoveFromDiary);
            this.panel5.Controls.Add(this.labelFoodSelect);
            this.panel5.Controls.Add(this.btnAddToDiary);
            this.panel5.Controls.Add(this.labelFoodWeight);
            this.panel5.Controls.Add(this.labelMealType);
            this.panel5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(783, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(553, 206);
            this.panel5.TabIndex = 39;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnEditDiary
            // 
            this.btnEditDiary.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditDiary.Location = new System.Drawing.Point(381, 148);
            this.btnEditDiary.Name = "btnEditDiary";
            this.btnEditDiary.Size = new System.Drawing.Size(162, 56);
            this.btnEditDiary.TabIndex = 37;
            this.btnEditDiary.Text = "Редактировать запись";
            this.btnEditDiary.UseVisualStyleBackColor = true;
            this.btnEditDiary.Click += new System.EventHandler(this.btnEditDiary_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(93, 106);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(87, 23);
            this.SearchBox.TabIndex = 39;
            // 
            // btnSearchDiary
            // 
            this.btnSearchDiary.Location = new System.Drawing.Point(186, 105);
            this.btnSearchDiary.Name = "btnSearchDiary";
            this.btnSearchDiary.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDiary.TabIndex = 40;
            this.btnSearchDiary.Text = "найти";
            this.btnSearchDiary.UseVisualStyleBackColor = true;
            this.btnSearchDiary.Click += new System.EventHandler(this.btnSearchDiary_Click);
            // 
            // Calories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1339, 606);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.DiaryList);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Result);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Calories";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "y";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoodWeight)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button SaveTxt;
        private System.Windows.Forms.Button SaveDb;
        private System.Windows.Forms.Button ShowHistory;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Goal;
        private System.Windows.Forms.ComboBox Activity;
        private System.Windows.Forms.NumericUpDown Weight;
        private System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Records;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button SortByDate;
        private System.Windows.Forms.Button SortByCalories;
        private System.Windows.Forms.ColumnHeader colid;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colCalories;
        private System.Windows.Forms.ColumnHeader colProtein;
        private System.Windows.Forms.ColumnHeader colFats;
        private System.Windows.Forms.ColumnHeader colCarbs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox FilterGoal;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Label labelFoodSelect;
        private System.Windows.Forms.ComboBox FoodSelect;
        private System.Windows.Forms.Label labelFoodWeight;
        private System.Windows.Forms.Label labelMealType;
        private System.Windows.Forms.Label ProgressStatus;
        private System.Windows.Forms.NumericUpDown FoodWeight;
        private System.Windows.Forms.ComboBox MealTypeSelect;
        private System.Windows.Forms.Button btnAddToDiary;
        private System.Windows.Forms.Button btnRemoveFromDiary;
        private System.Windows.Forms.ListView DiaryList;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.ColumnHeader colDiaryId;
        private System.Windows.Forms.ColumnHeader colDiaryName;
        private System.Windows.Forms.ColumnHeader colDiaryWeight;
        private System.Windows.Forms.ColumnHeader colDiaryCal;
        private System.Windows.Forms.ColumnHeader colDiaryProt;
        private System.Windows.Forms.ColumnHeader colDiaryFat;
        private System.Windows.Forms.ColumnHeader colDiaryCarb;
        private System.Windows.Forms.ColumnHeader colDiaryMeal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnEditDiary;
        private System.Windows.Forms.Button btnSearchDiary;
        private System.Windows.Forms.TextBox SearchBox;
    }
}

