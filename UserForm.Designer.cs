namespace SharpPro
{
    partial class UserForm
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
            FirstNameTextBox = new TextBox();
            FirstNameLable = new Label();
            LastNameTextBox = new TextBox();
            LastNameLable = new Label();
            GenderComboBox = new ComboBox();
            BirthDatedateTimePicker = new DateTimePicker();
            MobileNumberTextBox = new TextBox();
            BirthDateLable = new Label();
            GenderLable = new Label();
            MobilNumberLable = new Label();
            SaveButton = new Button();
            label1 = new Label();
            PasswordTextBox = new TextBox();
            label2 = new Label();
            UserNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(211, 39);
            FirstNameTextBox.Margin = new Padding(4, 2, 4, 2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(387, 39);
            FirstNameTextBox.TabIndex = 19;
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.Location = new Point(39, 39);
            FirstNameLable.Margin = new Padding(4, 0, 4, 0);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(122, 32);
            FirstNameLable.TabIndex = 18;
            FirstNameLable.Text = "FirstName";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(211, 107);
            LastNameTextBox.Margin = new Padding(4, 2, 4, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(387, 39);
            LastNameTextBox.TabIndex = 21;
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Location = new Point(47, 107);
            LastNameLable.Margin = new Padding(4, 0, 4, 0);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(119, 32);
            LastNameLable.TabIndex = 20;
            LastNameLable.Text = "LastName";
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Location = new Point(211, 170);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(387, 40);
            GenderComboBox.TabIndex = 37;
            // 
            // BirthDatedateTimePicker
            // 
            BirthDatedateTimePicker.AccessibleRole = AccessibleRole.None;
            BirthDatedateTimePicker.Location = new Point(211, 250);
            BirthDatedateTimePicker.Margin = new Padding(4, 2, 4, 2);
            BirthDatedateTimePicker.Name = "BirthDatedateTimePicker";
            BirthDatedateTimePicker.Size = new Size(387, 39);
            BirthDatedateTimePicker.TabIndex = 36;
            // 
            // MobileNumberTextBox
            // 
            MobileNumberTextBox.Location = new Point(888, 42);
            MobileNumberTextBox.Margin = new Padding(4, 2, 4, 2);
            MobileNumberTextBox.Name = "MobileNumberTextBox";
            MobileNumberTextBox.Size = new Size(387, 39);
            MobileNumberTextBox.TabIndex = 35;
            // 
            // BirthDateLable
            // 
            BirthDateLable.AutoSize = true;
            BirthDateLable.Location = new Point(47, 257);
            BirthDateLable.Margin = new Padding(4, 0, 4, 0);
            BirthDateLable.Name = "BirthDateLable";
            BirthDateLable.Size = new Size(114, 32);
            BirthDateLable.TabIndex = 34;
            BirthDateLable.Text = "BirthDate";
            // 
            // GenderLable
            // 
            GenderLable.AutoSize = true;
            GenderLable.Location = new Point(69, 178);
            GenderLable.Margin = new Padding(4, 0, 4, 0);
            GenderLable.Name = "GenderLable";
            GenderLable.Size = new Size(92, 32);
            GenderLable.TabIndex = 39;
            GenderLable.Text = "Gender";
            // 
            // MobilNumberLable
            // 
            MobilNumberLable.AutoSize = true;
            MobilNumberLable.Location = new Point(649, 39);
            MobilNumberLable.Margin = new Padding(4, 0, 4, 0);
            MobilNumberLable.Name = "MobilNumberLable";
            MobilNumberLable.Size = new Size(177, 32);
            MobilNumberLable.TabIndex = 38;
            MobilNumberLable.Text = "MobileNumber";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DarkTurquoise;
            SaveButton.Location = new Point(888, 231);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(387, 58);
            SaveButton.TabIndex = 40;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(715, 170);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 42;
            label1.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(888, 163);
            PasswordTextBox.Margin = new Padding(4, 2, 4, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(387, 39);
            PasswordTextBox.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 44;
            label2.Text = "UserName";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(888, 107);
            UserNameTextBox.Margin = new Padding(4, 2, 4, 2);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(387, 39);
            UserNameTextBox.TabIndex = 43;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 520);
            Controls.Add(label2);
            Controls.Add(UserNameTextBox);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(SaveButton);
            Controls.Add(GenderLable);
            Controls.Add(MobilNumberLable);
            Controls.Add(GenderComboBox);
            Controls.Add(BirthDatedateTimePicker);
            Controls.Add(MobileNumberTextBox);
            Controls.Add(BirthDateLable);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastNameLable);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLable);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox FirstNameTextBox;
        private Label FirstNameLable;
        private TextBox LastNameTextBox;
        private Label LastNameLable;
        private ComboBox GenderComboBox;
        private DateTimePicker BirthDatedateTimePicker;
        private TextBox MobileNumberTextBox;
        private Label BirthDateLable;
        private Label GenderLable;
        private Label MobilNumberLable;
        private Button SaveButton;
        private Label label1;
        private TextBox PasswordTextBox;
        private Label label2;
        private TextBox UserNameTextBox;
    }
}