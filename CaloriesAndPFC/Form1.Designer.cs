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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(7, 9);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(178, 83);
            this.Calculate.TabIndex = 11;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // SaveTxt
            // 
            this.SaveTxt.Location = new System.Drawing.Point(393, 9);
            this.SaveTxt.Name = "SaveTxt";
            this.SaveTxt.Size = new System.Drawing.Size(178, 83);
            this.SaveTxt.TabIndex = 12;
            this.SaveTxt.Text = "Сохранить в TXT";
            this.SaveTxt.UseVisualStyleBackColor = true;
            this.SaveTxt.Click += new System.EventHandler(this.SaveTxt_Click);
            // 
            // SaveDb
            // 
            this.SaveDb.Location = new System.Drawing.Point(198, 9);
            this.SaveDb.Name = "SaveDb";
            this.SaveDb.Size = new System.Drawing.Size(178, 83);
            this.SaveDb.TabIndex = 13;
            this.SaveDb.Text = "Сохранить в БД";
            this.SaveDb.UseVisualStyleBackColor = true;
            this.SaveDb.Click += new System.EventHandler(this.SaveDb_Click);
            // 
            // ShowHistory
            // 
            this.ShowHistory.Location = new System.Drawing.Point(583, 9);
            this.ShowHistory.Name = "ShowHistory";
            this.ShowHistory.Size = new System.Drawing.Size(178, 83);
            this.ShowHistory.TabIndex = 14;
            this.ShowHistory.Text = "Показать историю";
            this.ShowHistory.UseVisualStyleBackColor = true;
            this.ShowHistory.Click += new System.EventHandler(this.ShowHistory_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Result.Location = new System.Drawing.Point(7, 400);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(770, 341);
            this.Result.TabIndex = 15;
            this.Result.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.Activity.Font = new System.Drawing.Font("Consolas", 10F);
            this.Activity.ForeColor = System.Drawing.Color.White;
            this.Activity.FormattingEnabled = true;
            this.Activity.Location = new System.Drawing.Point(376, 12);
            this.Activity.Name = "Activity";
            this.Activity.Size = new System.Drawing.Size(391, 23);
            this.Activity.TabIndex = 9;
            this.Activity.Text = "Минимальная, Низкая, Средняя, Высокая, Экстремальная";
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
            this.Gender.Font = new System.Drawing.Font("Consolas", 10F);
            this.Gender.ForeColor = System.Drawing.Color.White;
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(88, 12);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(141, 23);
            this.Gender.TabIndex = 1;
            this.Gender.Text = "Мужской, Женский";
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
            this.label7.Size = new System.Drawing.Size(611, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Расчет калорий и БЖУ — Персональный фитнес-помощник";
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
            this.Records.Location = new System.Drawing.Point(192, 261);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(585, 133);
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
            this.Add.Location = new System.Drawing.Point(8, 3);
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
            this.Delete.Location = new System.Drawing.Point(8, 32);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(161, 23);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Удалить запись";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SortByDate
            // 
            this.SortByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(156)))));
            this.SortByDate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByDate.ForeColor = System.Drawing.Color.White;
            this.SortByDate.Location = new System.Drawing.Point(7, 61);
            this.SortByDate.Name = "SortByDate";
            this.SortByDate.Size = new System.Drawing.Size(162, 23);
            this.SortByDate.TabIndex = 22;
            this.SortByDate.Text = "Сортировать по дате";
            this.SortByDate.UseVisualStyleBackColor = false;
            this.SortByDate.Click += new System.EventHandler(this.SortByDate_Click);
            // 
            // SortByCalories
            // 
            this.SortByCalories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(156)))));
            this.SortByCalories.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByCalories.ForeColor = System.Drawing.Color.White;
            this.SortByCalories.Location = new System.Drawing.Point(7, 90);
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
            this.panel1.Size = new System.Drawing.Size(786, 42);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.label1);
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
            this.panel4.Controls.Add(this.Add);
            this.panel4.Controls.Add(this.Delete);
            this.panel4.Controls.Add(this.SortByCalories);
            this.panel4.Location = new System.Drawing.Point(7, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 133);
            this.panel4.TabIndex = 27;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Calories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(784, 754);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Result);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Calories";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calories";
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
    }
}

