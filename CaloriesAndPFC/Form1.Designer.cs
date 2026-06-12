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
            this.label1 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.Weight = new System.Windows.Forms.NumericUpDown();
            this.Activity = new System.Windows.Forms.ComboBox();
            this.Goal = new System.Windows.Forms.ComboBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.SaveTxt = new System.Windows.Forms.Button();
            this.SaveDb = new System.Windows.Forms.Button();
            this.ShowHistory = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пол:";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(128, 117);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 21);
            this.Gender.TabIndex = 1;
            this.Gender.Text = "Мужской, Женский";
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Рост(см):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вес (кг):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Уровень активности:";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(306, 117);
            this.Age.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(120, 20);
            this.Age.TabIndex = 6;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(306, 143);
            this.Height.Maximum = new decimal(new int[] {
            230,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(120, 20);
            this.Height.TabIndex = 7;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(306, 169);
            this.Weight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(120, 20);
            this.Weight.TabIndex = 8;
            // 
            // Activity
            // 
            this.Activity.FormattingEnabled = true;
            this.Activity.Location = new System.Drawing.Point(128, 143);
            this.Activity.Name = "Activity";
            this.Activity.Size = new System.Drawing.Size(121, 21);
            this.Activity.TabIndex = 9;
            this.Activity.Text = "Минимальная, Низкая, Средняя, Высокая, Экстремальная";
            // 
            // Goal
            // 
            this.Goal.FormattingEnabled = true;
            this.Goal.Location = new System.Drawing.Point(128, 170);
            this.Goal.Name = "Goal";
            this.Goal.Size = new System.Drawing.Size(121, 21);
            this.Goal.TabIndex = 10;
            this.Goal.Text = "Набор мышечной массы, Похудение, Поддержание формы";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(450, 117);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(110, 23);
            this.Calculate.TabIndex = 11;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // SaveTxt
            // 
            this.SaveTxt.Location = new System.Drawing.Point(450, 140);
            this.SaveTxt.Name = "SaveTxt";
            this.SaveTxt.Size = new System.Drawing.Size(111, 23);
            this.SaveTxt.TabIndex = 12;
            this.SaveTxt.Text = "Сохранить в TXT";
            this.SaveTxt.UseVisualStyleBackColor = true;
            this.SaveTxt.Click += new System.EventHandler(this.SaveTxt_Click);
            // 
            // SaveDb
            // 
            this.SaveDb.Location = new System.Drawing.Point(450, 166);
            this.SaveDb.Name = "SaveDb";
            this.SaveDb.Size = new System.Drawing.Size(110, 23);
            this.SaveDb.TabIndex = 13;
            this.SaveDb.Text = "Сохранить в БД";
            this.SaveDb.UseVisualStyleBackColor = true;
            this.SaveDb.Click += new System.EventHandler(this.SaveDb_Click);
            // 
            // ShowHistory
            // 
            this.ShowHistory.Location = new System.Drawing.Point(451, 192);
            this.ShowHistory.Name = "ShowHistory";
            this.ShowHistory.Size = new System.Drawing.Size(110, 23);
            this.ShowHistory.TabIndex = 14;
            this.ShowHistory.Text = "Показать историю";
            this.ShowHistory.UseVisualStyleBackColor = true;
            this.ShowHistory.Click += new System.EventHandler(this.ShowHistory_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(566, 119);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(223, 96);
            this.Result.TabIndex = 15;
            this.Result.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Цель:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ShowHistory);
            this.Controls.Add(this.SaveDb);
            this.Controls.Add(this.SaveTxt);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Goal);
            this.Controls.Add(this.Activity);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.NumericUpDown Weight;
        private System.Windows.Forms.ComboBox Activity;
        private System.Windows.Forms.ComboBox Goal;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button SaveTxt;
        private System.Windows.Forms.Button SaveDb;
        private System.Windows.Forms.Button ShowHistory;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.Label label6;
    }
}

