namespace Assignment_1
{
    partial class MailOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.SalesBonusTextbox = new System.Windows.Forms.TextBox();
            this.TotalSalesTextbox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextbox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextbox = new System.Windows.Forms.TextBox();
            this.EmployeeNameTextbox = new System.Windows.Forms.TextBox();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(126, 176);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(126, 147);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 16;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(31, 147);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 14;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(6, 45);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(58, 17);
            this.FrenchRadioButton.TabIndex = 13;
            this.FrenchRadioButton.Text = "French";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.FrenchRadioButton_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(5, 23);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishRadioButton.TabIndex = 12;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // SalesBonusTextbox
            // 
            this.SalesBonusTextbox.BackColor = System.Drawing.Color.White;
            this.SalesBonusTextbox.Location = new System.Drawing.Point(101, 112);
            this.SalesBonusTextbox.Name = "SalesBonusTextbox";
            this.SalesBonusTextbox.ReadOnly = true;
            this.SalesBonusTextbox.Size = new System.Drawing.Size(100, 20);
            this.SalesBonusTextbox.TabIndex = 11;
            // 
            // TotalSalesTextbox
            // 
            this.TotalSalesTextbox.Location = new System.Drawing.Point(101, 86);
            this.TotalSalesTextbox.Name = "TotalSalesTextbox";
            this.TotalSalesTextbox.Size = new System.Drawing.Size(100, 20);
            this.TotalSalesTextbox.TabIndex = 10;
            // 
            // HoursWorkedTextbox
            // 
            this.HoursWorkedTextbox.Location = new System.Drawing.Point(101, 60);
            this.HoursWorkedTextbox.Name = "HoursWorkedTextbox";
            this.HoursWorkedTextbox.Size = new System.Drawing.Size(100, 20);
            this.HoursWorkedTextbox.TabIndex = 9;
            // 
            // EmployeeIDTextbox
            // 
            this.EmployeeIDTextbox.Location = new System.Drawing.Point(101, 34);
            this.EmployeeIDTextbox.Name = "EmployeeIDTextbox";
            this.EmployeeIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDTextbox.TabIndex = 8;
            // 
            // EmployeeNameTextbox
            // 
            this.EmployeeNameTextbox.Location = new System.Drawing.Point(101, 8);
            this.EmployeeNameTextbox.Name = "EmployeeNameTextbox";
            this.EmployeeNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNameTextbox.TabIndex = 7;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(29, 115);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(66, 13);
            this.SalesBonusLabel.TabIndex = 5;
            this.SalesBonusLabel.Text = "Sales Bonus";
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(35, 89);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(60, 13);
            this.TotalSalesLabel.TabIndex = 4;
            this.TotalSalesLabel.Text = "Total Sales";
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(19, 63);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(76, 13);
            this.HoursWorkedLabel.TabIndex = 3;
            this.HoursWorkedLabel.Text = "Hours Worked";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(21, 37);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(74, 13);
            this.EmployeeIDLabel.TabIndex = 2;
            this.EmployeeIDLabel.Text = "Employee\'s ID";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(4, 11);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(91, 13);
            this.EmployeeNameLabel.TabIndex = 1;
            this.EmployeeNameLabel.Text = "Employee\'s Name";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(31, 176);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 15;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguageGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguageGroupBox.Location = new System.Drawing.Point(207, 12);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.Size = new System.Drawing.Size(73, 69);
            this.LanguageGroupBox.TabIndex = 18;
            this.LanguageGroupBox.TabStop = false;
            this.LanguageGroupBox.Text = "Language";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Assignment_1.Properties.Resources.DollarSign;
            this.LogoPictureBox.Location = new System.Drawing.Point(292, 24);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(117, 181);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 20;
            this.LogoPictureBox.TabStop = false;
            // 
            // MailOrderForm
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(421, 234);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LanguageGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesBonusTextbox);
            this.Controls.Add(this.TotalSalesTextbox);
            this.Controls.Add(this.HoursWorkedTextbox);
            this.Controls.Add(this.EmployeeIDTextbox);
            this.Controls.Add(this.EmployeeNameTextbox);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.MaximizeBox = false;
            this.Name = "MailOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.TextBox SalesBonusTextbox;
        private System.Windows.Forms.TextBox TotalSalesTextbox;
        private System.Windows.Forms.TextBox HoursWorkedTextbox;
        private System.Windows.Forms.TextBox EmployeeIDTextbox;
        private System.Windows.Forms.TextBox EmployeeNameTextbox;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}

