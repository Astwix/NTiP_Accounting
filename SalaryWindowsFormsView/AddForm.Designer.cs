namespace SalaryWindowsFormsView
{
    partial class AddForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MonthlyWageGroupBox = new System.Windows.Forms.GroupBox();
            this.RewardTextBox = new System.Windows.Forms.TextBox();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.BountyCheckBox = new System.Windows.Forms.CheckBox();
            this.BountyTextBox = new System.Windows.Forms.TextBox();
            this.RateLabel = new System.Windows.Forms.Label();
            this.RewardLabel = new System.Windows.Forms.Label();
            this.HourlyWageGroupBox = new System.Windows.Forms.GroupBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.HourPriceTextBox = new System.Windows.Forms.TextBox();
            this.HourPriceLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HourlyWageRadioButton = new System.Windows.Forms.RadioButton();
            this.MonthlyWageRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.FirstnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.MonthlyWageGroupBox.SuspendLayout();
            this.HourlyWageGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.HourlyWageGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MonthlyWageGroupBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(459, 197);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // MonthlyWageGroupBox
            // 
            this.MonthlyWageGroupBox.Controls.Add(this.RewardLabel);
            this.MonthlyWageGroupBox.Controls.Add(this.RateLabel);
            this.MonthlyWageGroupBox.Controls.Add(this.BountyTextBox);
            this.MonthlyWageGroupBox.Controls.Add(this.BountyCheckBox);
            this.MonthlyWageGroupBox.Controls.Add(this.RateTextBox);
            this.MonthlyWageGroupBox.Controls.Add(this.RewardTextBox);
            this.MonthlyWageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthlyWageGroupBox.Location = new System.Drawing.Point(232, 3);
            this.MonthlyWageGroupBox.Name = "MonthlyWageGroupBox";
            this.MonthlyWageGroupBox.Size = new System.Drawing.Size(224, 191);
            this.MonthlyWageGroupBox.TabIndex = 20;
            this.MonthlyWageGroupBox.TabStop = false;
            this.MonthlyWageGroupBox.Text = "Monthly Wage";
            // 
            // RewardTextBox
            // 
            this.RewardTextBox.Location = new System.Drawing.Point(98, 19);
            this.RewardTextBox.Name = "RewardTextBox";
            this.RewardTextBox.Size = new System.Drawing.Size(100, 20);
            this.RewardTextBox.TabIndex = 15;
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(98, 45);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(100, 20);
            this.RateTextBox.TabIndex = 16;
            // 
            // BountyCheckBox
            // 
            this.BountyCheckBox.AutoSize = true;
            this.BountyCheckBox.Location = new System.Drawing.Point(6, 73);
            this.BountyCheckBox.Name = "BountyCheckBox";
            this.BountyCheckBox.Size = new System.Drawing.Size(59, 17);
            this.BountyCheckBox.TabIndex = 18;
            this.BountyCheckBox.Text = "Bounty";
            this.BountyCheckBox.UseVisualStyleBackColor = true;
            this.BountyCheckBox.CheckedChanged += new System.EventHandler(this.BountyCheckBox_CheckedChanged);
            // 
            // BountyTextBox
            // 
            this.BountyTextBox.Location = new System.Drawing.Point(98, 71);
            this.BountyTextBox.Name = "BountyTextBox";
            this.BountyTextBox.Size = new System.Drawing.Size(100, 20);
            this.BountyTextBox.TabIndex = 17;
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(6, 48);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(30, 13);
            this.RateLabel.TabIndex = 9;
            this.RateLabel.Text = "Rate";
            // 
            // RewardLabel
            // 
            this.RewardLabel.AutoSize = true;
            this.RewardLabel.Location = new System.Drawing.Point(6, 22);
            this.RewardLabel.Name = "RewardLabel";
            this.RewardLabel.Size = new System.Drawing.Size(44, 13);
            this.RewardLabel.TabIndex = 8;
            this.RewardLabel.Text = "Reward";
            // 
            // HourlyWageGroupBox
            // 
            this.HourlyWageGroupBox.Controls.Add(this.HourPriceLabel);
            this.HourlyWageGroupBox.Controls.Add(this.HourPriceTextBox);
            this.HourlyWageGroupBox.Controls.Add(this.HoursWorkedLabel);
            this.HourlyWageGroupBox.Controls.Add(this.HoursWorkedTextBox);
            this.HourlyWageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourlyWageGroupBox.Location = new System.Drawing.Point(3, 3);
            this.HourlyWageGroupBox.MinimumSize = new System.Drawing.Size(0, 70);
            this.HourlyWageGroupBox.Name = "HourlyWageGroupBox";
            this.HourlyWageGroupBox.Size = new System.Drawing.Size(223, 191);
            this.HourlyWageGroupBox.TabIndex = 19;
            this.HourlyWageGroupBox.TabStop = false;
            this.HourlyWageGroupBox.Text = "Hourly Wage";
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(91, 42);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.HoursWorkedTextBox.TabIndex = 14;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(6, 45);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(73, 13);
            this.HoursWorkedLabel.TabIndex = 7;
            this.HoursWorkedLabel.Text = "Hours worked";
            // 
            // HourPriceTextBox
            // 
            this.HourPriceTextBox.Location = new System.Drawing.Point(91, 16);
            this.HourPriceTextBox.Name = "HourPriceTextBox";
            this.HourPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.HourPriceTextBox.TabIndex = 13;
            // 
            // HourPriceLabel
            // 
            this.HourPriceLabel.AutoSize = true;
            this.HourPriceLabel.Location = new System.Drawing.Point(6, 19);
            this.HourPriceLabel.Name = "HourPriceLabel";
            this.HourPriceLabel.Size = new System.Drawing.Size(73, 13);
            this.HourPriceLabel.TabIndex = 6;
            this.HourPriceLabel.Text = "Price per hour";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MonthlyWageRadioButton);
            this.groupBox1.Controls.Add(this.HourlyWageRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 46);
            this.groupBox1.MinimumSize = new System.Drawing.Size(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 40);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wage type";
            // 
            // HourlyWageRadioButton
            // 
            this.HourlyWageRadioButton.AutoSize = true;
            this.HourlyWageRadioButton.Location = new System.Drawing.Point(9, 19);
            this.HourlyWageRadioButton.Name = "HourlyWageRadioButton";
            this.HourlyWageRadioButton.Size = new System.Drawing.Size(55, 17);
            this.HourlyWageRadioButton.TabIndex = 4;
            this.HourlyWageRadioButton.TabStop = true;
            this.HourlyWageRadioButton.Text = "Hourly";
            this.HourlyWageRadioButton.UseVisualStyleBackColor = true;
            this.HourlyWageRadioButton.CheckedChanged += new System.EventHandler(this.HourlyWageRadioButton_CheckedChanged);
            // 
            // MonthlyWageRadioButton
            // 
            this.MonthlyWageRadioButton.AutoSize = true;
            this.MonthlyWageRadioButton.Location = new System.Drawing.Point(99, 19);
            this.MonthlyWageRadioButton.Name = "MonthlyWageRadioButton";
            this.MonthlyWageRadioButton.Size = new System.Drawing.Size(62, 17);
            this.MonthlyWageRadioButton.TabIndex = 5;
            this.MonthlyWageRadioButton.TabStop = true;
            this.MonthlyWageRadioButton.Text = "Monthly";
            this.MonthlyWageRadioButton.UseVisualStyleBackColor = true;
            this.MonthlyWageRadioButton.CheckedChanged += new System.EventHandler(this.MonthlyWageRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FirstnameLabel);
            this.groupBox2.Controls.Add(this.SurnameLabel);
            this.groupBox2.Controls.Add(this.FirstnameTextBox);
            this.groupBox2.Controls.Add(this.SurnameTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.MinimumSize = new System.Drawing.Size(0, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 40);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(243, 16);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.Location = new System.Drawing.Point(64, 16);
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstnameTextBox.TabIndex = 2;
            this.FirstnameTextBox.TextChanged += new System.EventHandler(this.FirstnameTextBox_TextChanged);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(188, 19);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Surname";
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Location = new System.Drawing.Point(6, 21);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(52, 13);
            this.FirstnameLabel.TabIndex = 0;
            this.FirstnameLabel.Text = "Firstname";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 289);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(236, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(110, 25);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.Location = new System.Drawing.Point(352, 3);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(110, 25);
            this.CancelAddButton.TabIndex = 12;
            this.CancelAddButton.Text = "Cancel";
            this.CancelAddButton.UseVisualStyleBackColor = true;
            this.CancelAddButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CancelAddButton);
            this.flowLayoutPanel1.Controls.Add(this.OKButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 257);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(465, 32);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 289);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.MonthlyWageGroupBox.ResumeLayout(false);
            this.MonthlyWageGroupBox.PerformLayout();
            this.HourlyWageGroupBox.ResumeLayout(false);
            this.HourlyWageGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox HourlyWageGroupBox;
        private System.Windows.Forms.Label HourPriceLabel;
        private System.Windows.Forms.TextBox HourPriceTextBox;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.GroupBox MonthlyWageGroupBox;
        private System.Windows.Forms.Label RewardLabel;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.TextBox BountyTextBox;
        private System.Windows.Forms.CheckBox BountyCheckBox;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.TextBox RewardTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MonthlyWageRadioButton;
        private System.Windows.Forms.RadioButton HourlyWageRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label FirstnameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox FirstnameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    }
}