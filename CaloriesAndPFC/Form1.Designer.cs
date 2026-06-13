namespace CaloriesAndPFC
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Goal = new System.Windows.Forms.ComboBox();
            this.Activity = new System.Windows.Forms.ComboBox();
            this.Weight = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.Gender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(20, 240);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(156, 23);
            this.Calculate.TabIndex = 11;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // SaveTxt
            // 
            this.SaveTxt.Location = new System.Drawing.Point(246, 240);
            this.SaveTxt.Name = "SaveTxt";
            this.SaveTxt.Size = new System.Drawing.Size(156, 23);
            this.SaveTxt.TabIndex = 12;
            this.SaveTxt.Text = "Сохранить в TXT";
            this.SaveTxt.UseVisualStyleBackColor = true;
            this.SaveTxt.Click += new System.EventHandler(this.SaveTxt_Click);
            // 
            // SaveDb
            // 
            this.SaveDb.Location = new System.Drawing.Point(20, 265);
            this.SaveDb.Name = "SaveDb";
            this.SaveDb.Size = new System.Drawing.Size(156, 23);
            this.SaveDb.TabIndex = 13;
            this.SaveDb.Text = "Сохранить в БД";
            this.SaveDb.UseVisualStyleBackColor = true;
            this.SaveDb.Click += new System.EventHandler(this.SaveDb_Click);
            // 
            // ShowHistory
            // 
            this.ShowHistory.Location = new System.Drawing.Point(246, 265);
            this.ShowHistory.Name = "ShowHistory";
            this.ShowHistory.Size = new System.Drawing.Size(156, 23);
            this.ShowHistory.TabIndex = 14;
            this.ShowHistory.Text = "Показать историю";
            this.ShowHistory.UseVisualStyleBackColor = true;
            this.ShowHistory.Click += new System.EventHandler(this.ShowHistory_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(20, 290);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(382, 96);
            this.Result.TabIndex = 15;
            this.Result.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CaloriesAndPFC.Properties.Resources.burn;
            this.pictureBox1.Location = new System.Drawing.Point(191, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вес (кг):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Рост(см):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возраст:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Цель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Уровень активности:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пол:";
            // 
            // Goal
            // 
            this.Goal.FormattingEnabled = true;
            this.Goal.Location = new System.Drawing.Point(139, 190);
            this.Goal.Name = "Goal";
            this.Goal.Size = new System.Drawing.Size(155, 21);
            this.Goal.TabIndex = 10;
            this.Goal.Text = "Набор мышечной массы, Похудение, Поддержание формы";
            // 
            // Activity
            // 
            this.Activity.FormattingEnabled = true;
            this.Activity.Location = new System.Drawing.Point(139, 163);
            this.Activity.Name = "Activity";
            this.Activity.Size = new System.Drawing.Size(155, 21);
            this.Activity.TabIndex = 9;
            this.Activity.Text = "Минимальная, Низкая, Средняя, Высокая, Экстремальная";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(139, 137);
            this.Weight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(155, 20);
            this.Weight.TabIndex = 8;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(139, 111);
            this.Height.Maximum = new decimal(new int[] {
            230,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(155, 20);
            this.Height.TabIndex = 7;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(139, 85);
            this.Age.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(155, 20);
            this.Age.TabIndex = 6;
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(139, 58);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(156, 21);
            this.Gender.TabIndex = 1;
            this.Gender.Text = "Мужской, Женский";
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 408);
            this.Controls.Add(this.Goal);
            this.Controls.Add(this.Activity);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ShowHistory);
            this.Controls.Add(this.SaveDb);
            this.Controls.Add(this.SaveTxt);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Goal;
        private System.Windows.Forms.ComboBox Activity;
        private System.Windows.Forms.NumericUpDown Weight;
        private System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.ComboBox Gender;
    }
}

