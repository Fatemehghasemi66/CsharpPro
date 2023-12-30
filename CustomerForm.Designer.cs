namespace CsharpPro
{
    partial class CustomerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TimeLable = new Label();
            DateLable = new Label();
            EmailAddressLable = new Label();
            BirthDateLable = new Label();
            MobilNumberLable = new Label();
            LastNameLable = new Label();
            FirstNameLable = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            MobileNumberTextBox = new TextBox();
            EmailAddressTextBox = new TextBox();
            SaveButton = new Button();
            RememberCustomerheckBox = new CheckBox();
            CustomerGridView = new DataGridView();
            MessageLable = new Label();
            HomeAddressTextBox = new TextBox();
            HomeAddressLable = new Label();
            BirthDatedateTimePicker = new DateTimePicker();
            GenderLable = new Label();
            GenderComboBox = new ComboBox();
            UserNameTextBox = new TextBox();
            UserNameLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            DeleteButton = new Button();
            UpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).BeginInit();
            SuspendLayout();
            // 
            // TimeLable
            // 
            TimeLable.AutoSize = true;
            TimeLable.Location = new Point(11, 32);
            TimeLable.Margin = new Padding(2, 0, 2, 0);
            TimeLable.Name = "TimeLable";
            TimeLable.Size = new Size(0, 15);
            TimeLable.TabIndex = 15;
            // 
            // DateLable
            // 
            DateLable.AutoSize = true;
            DateLable.Location = new Point(12, 9);
            DateLable.Margin = new Padding(2, 0, 2, 0);
            DateLable.Name = "DateLable";
            DateLable.Size = new Size(0, 15);
            DateLable.TabIndex = 14;
            // 
            // EmailAddressLable
            // 
            EmailAddressLable.AutoSize = true;
            EmailAddressLable.Location = new Point(19, 200);
            EmailAddressLable.Margin = new Padding(2, 0, 2, 0);
            EmailAddressLable.Name = "EmailAddressLable";
            EmailAddressLable.Size = new Size(78, 15);
            EmailAddressLable.TabIndex = 12;
            EmailAddressLable.Text = "EmailAddress";
            // 
            // BirthDateLable
            // 
            BirthDateLable.AutoSize = true;
            BirthDateLable.Location = new Point(36, 176);
            BirthDateLable.Margin = new Padding(2, 0, 2, 0);
            BirthDateLable.Name = "BirthDateLable";
            BirthDateLable.Size = new Size(56, 15);
            BirthDateLable.TabIndex = 11;
            BirthDateLable.Text = "BirthDate";
            // 
            // MobilNumberLable
            // 
            MobilNumberLable.AutoSize = true;
            MobilNumberLable.Location = new Point(7, 117);
            MobilNumberLable.Margin = new Padding(2, 0, 2, 0);
            MobilNumberLable.Name = "MobilNumberLable";
            MobilNumberLable.Size = new Size(88, 15);
            MobilNumberLable.TabIndex = 10;
            MobilNumberLable.Text = "MobileNumber";
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Location = new Point(32, 89);
            LastNameLable.Margin = new Padding(2, 0, 2, 0);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(60, 15);
            LastNameLable.TabIndex = 9;
            LastNameLable.Text = "LastName";
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.Location = new Point(32, 66);
            FirstNameLable.Margin = new Padding(2, 0, 2, 0);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(61, 15);
            FirstNameLable.TabIndex = 8;
            FirstNameLable.Text = "FirstName";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(107, 62);
            FirstNameTextBox.Margin = new Padding(2, 1, 2, 1);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(150, 23);
            FirstNameTextBox.TabIndex = 17;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(107, 86);
            LastNameTextBox.Margin = new Padding(2, 1, 2, 1);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(150, 23);
            LastNameTextBox.TabIndex = 18;
            // 
            // MobileNumberTextBox
            // 
            MobileNumberTextBox.Location = new Point(107, 113);
            MobileNumberTextBox.Margin = new Padding(2, 1, 2, 1);
            MobileNumberTextBox.Name = "MobileNumberTextBox";
            MobileNumberTextBox.Size = new Size(155, 23);
            MobileNumberTextBox.TabIndex = 19;
            // 
            // EmailAddressTextBox
            // 
            EmailAddressTextBox.Location = new Point(107, 198);
            EmailAddressTextBox.Margin = new Padding(2, 1, 2, 1);
            EmailAddressTextBox.Name = "EmailAddressTextBox";
            EmailAddressTextBox.Size = new Size(155, 23);
            EmailAddressTextBox.TabIndex = 21;
            EmailAddressTextBox.TextChanged += EmailAddressTextBox_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.MediumSeaGreen;
            SaveButton.Location = new Point(397, 213);
            SaveButton.Margin = new Padding(2, 1, 2, 1);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(132, 27);
            SaveButton.TabIndex = 22;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // RememberCustomerheckBox
            // 
            RememberCustomerheckBox.AutoSize = true;
            RememberCustomerheckBox.Location = new Point(423, 192);
            RememberCustomerheckBox.Margin = new Padding(2, 1, 2, 1);
            RememberCustomerheckBox.Name = "RememberCustomerheckBox";
            RememberCustomerheckBox.Size = new Size(84, 19);
            RememberCustomerheckBox.TabIndex = 23;
            RememberCustomerheckBox.Text = "Remember";
            RememberCustomerheckBox.UseVisualStyleBackColor = true;
            // 
            // CustomerGridView
            // 
            CustomerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerGridView.Location = new Point(19, 256);
            CustomerGridView.Margin = new Padding(2, 1, 2, 1);
            CustomerGridView.Name = "CustomerGridView";
            CustomerGridView.RowHeadersWidth = 82;
            CustomerGridView.RowTemplate.Height = 41;
            CustomerGridView.Size = new Size(876, 323);
            CustomerGridView.TabIndex = 24;
            CustomerGridView.CellClick += CustomerGridView_CellClick;
            // 
            // MessageLable
            // 
            MessageLable.AutoSize = true;
            MessageLable.Location = new Point(272, 22);
            MessageLable.Margin = new Padding(2, 0, 2, 0);
            MessageLable.Name = "MessageLable";
            MessageLable.Size = new Size(0, 15);
            MessageLable.TabIndex = 25;
            // 
            // HomeAddressTextBox
            // 
            HomeAddressTextBox.Location = new Point(381, 66);
            HomeAddressTextBox.Margin = new Padding(2, 1, 2, 1);
            HomeAddressTextBox.Multiline = true;
            HomeAddressTextBox.Name = "HomeAddressTextBox";
            HomeAddressTextBox.Size = new Size(167, 51);
            HomeAddressTextBox.TabIndex = 28;
            // 
            // HomeAddressLable
            // 
            HomeAddressLable.AutoSize = true;
            HomeAddressLable.Location = new Point(289, 96);
            HomeAddressLable.Margin = new Padding(2, 0, 2, 0);
            HomeAddressLable.Name = "HomeAddressLable";
            HomeAddressLable.Size = new Size(82, 15);
            HomeAddressLable.TabIndex = 27;
            HomeAddressLable.Text = "HomeAddress";
            // 
            // BirthDatedateTimePicker
            // 
            BirthDatedateTimePicker.AccessibleRole = AccessibleRole.None;
            BirthDatedateTimePicker.Location = new Point(107, 172);
            BirthDatedateTimePicker.Margin = new Padding(2, 1, 2, 1);
            BirthDatedateTimePicker.Name = "BirthDatedateTimePicker";
            BirthDatedateTimePicker.Size = new Size(155, 23);
            BirthDatedateTimePicker.TabIndex = 31;
            // 
            // GenderLable
            // 
            GenderLable.AutoSize = true;
            GenderLable.Location = new Point(48, 150);
            GenderLable.Margin = new Padding(2, 0, 2, 0);
            GenderLable.Name = "GenderLable";
            GenderLable.Size = new Size(45, 15);
            GenderLable.TabIndex = 32;
            GenderLable.Text = "Gender";
            GenderLable.Click += label1_Click;
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Location = new Point(107, 145);
            GenderComboBox.Margin = new Padding(2, 1, 2, 1);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(155, 23);
            GenderComboBox.TabIndex = 33;
            GenderComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(381, 127);
            UserNameTextBox.Margin = new Padding(2, 1, 2, 1);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(167, 23);
            UserNameTextBox.TabIndex = 35;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(310, 128);
            UserNameLabel.Margin = new Padding(2, 0, 2, 0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(62, 15);
            UserNameLabel.TabIndex = 34;
            UserNameLabel.Text = "UserName";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(381, 155);
            PasswordTextBox.Margin = new Padding(2, 1, 2, 1);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(167, 23);
            PasswordTextBox.TabIndex = 37;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(310, 154);
            PasswordLabel.Margin = new Padding(2, 0, 2, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 36;
            PasswordLabel.Text = "Password";
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(255, 128, 128);
            DeleteButton.Location = new Point(771, 213);
            DeleteButton.Margin = new Padding(2, 1, 2, 1);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(124, 27);
            DeleteButton.TabIndex = 38;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.MediumTurquoise;
            UpdateButton.Location = new Point(626, 213);
            UpdateButton.Margin = new Padding(2, 1, 2, 1);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(125, 27);
            UpdateButton.TabIndex = 39;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 589);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(UserNameLabel);
            Controls.Add(GenderComboBox);
            Controls.Add(GenderLable);
            Controls.Add(BirthDatedateTimePicker);
            Controls.Add(HomeAddressTextBox);
            Controls.Add(HomeAddressLable);
            Controls.Add(MessageLable);
            Controls.Add(CustomerGridView);
            Controls.Add(RememberCustomerheckBox);
            Controls.Add(SaveButton);
            Controls.Add(EmailAddressTextBox);
            Controls.Add(MobileNumberTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(TimeLable);
            Controls.Add(DateLable);
            Controls.Add(EmailAddressLable);
            Controls.Add(BirthDateLable);
            Controls.Add(MobilNumberLable);
            Controls.Add(LastNameLable);
            Controls.Add(FirstNameLable);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimeLable;
        private Label DateLable;
        private Label EmailAddressLable;
        private Label BirthDateLable;
        private Label MobilNumberLable;
        private Label LastNameLable;
        private Label FirstNameLable;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox MobileNumberTextBox;
        private TextBox EmailAddressTextBox;
        private Button SaveButton;
        private CheckBox RememberCustomerheckBox;
        private DataGridView CustomerGridView;
        private Label MessageLable;
        private TextBox HomeAddressTextBox;
        private Label HomeAddressLable;
        private DateTimePicker BirthDatedateTimePicker;
        private Label GenderLable;
        private ComboBox GenderComboBox;
        private TextBox UserNameTextBox;
        private Label UserNameLabel;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Button DeleteButton;
        private Button UpdateButton;
    }
}