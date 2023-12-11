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
            CustomerId = new Label();
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
            CustomerIdLable = new Label();
            HomeAddrressTextBox = new TextBox();
            HomeAddressLable = new Label();
            BirthDatedateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).BeginInit();
            SuspendLayout();
            // 
            // TimeLable
            // 
            TimeLable.AutoSize = true;
            TimeLable.Location = new Point(20, 68);
            TimeLable.Name = "TimeLable";
            TimeLable.Size = new Size(0, 32);
            TimeLable.TabIndex = 15;
            // 
            // DateLable
            // 
            DateLable.AutoSize = true;
            DateLable.Location = new Point(23, 20);
            DateLable.Name = "DateLable";
            DateLable.Size = new Size(0, 32);
            DateLable.TabIndex = 14;
            // 
            // CustomerId
            // 
            CustomerId.AutoSize = true;
            CustomerId.Location = new Point(681, 24);
            CustomerId.Name = "CustomerId";
            CustomerId.Size = new Size(137, 32);
            CustomerId.TabIndex = 13;
            CustomerId.Text = "CustomerId";
            // 
            // EmailAddressLable
            // 
            EmailAddressLable.AutoSize = true;
            EmailAddressLable.Location = new Point(502, 121);
            EmailAddressLable.Name = "EmailAddressLable";
            EmailAddressLable.Size = new Size(155, 32);
            EmailAddressLable.TabIndex = 12;
            EmailAddressLable.Text = "EmailAddress";
            // 
            // BirthDateLable
            // 
            BirthDateLable.AutoSize = true;
            BirthDateLable.Location = new Point(1054, 111);
            BirthDateLable.Name = "BirthDateLable";
            BirthDateLable.Size = new Size(114, 32);
            BirthDateLable.TabIndex = 11;
            BirthDateLable.Text = "BirthDate";
            // 
            // MobilNumberLable
            // 
            MobilNumberLable.AutoSize = true;
            MobilNumberLable.Location = new Point(12, 274);
            MobilNumberLable.Name = "MobilNumberLable";
            MobilNumberLable.Size = new Size(177, 32);
            MobilNumberLable.TabIndex = 10;
            MobilNumberLable.Text = "MobileNumber";
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Location = new Point(58, 195);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(119, 32);
            LastNameLable.TabIndex = 9;
            LastNameLable.Text = "LastName";
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.Location = new Point(58, 128);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(122, 32);
            FirstNameLable.TabIndex = 8;
            FirstNameLable.Text = "FirstName";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(195, 121);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(235, 39);
            FirstNameTextBox.TabIndex = 17;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(195, 195);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(235, 39);
            LastNameTextBox.TabIndex = 18;
            // 
            // MobileNumberTextBox
            // 
            MobileNumberTextBox.Location = new Point(195, 271);
            MobileNumberTextBox.Name = "MobileNumberTextBox";
            MobileNumberTextBox.Size = new Size(235, 39);
            MobileNumberTextBox.TabIndex = 19;
            // 
            // EmailAddressTextBox
            // 
            EmailAddressTextBox.Location = new Point(681, 111);
            EmailAddressTextBox.Name = "EmailAddressTextBox";
            EmailAddressTextBox.Size = new Size(319, 39);
            EmailAddressTextBox.TabIndex = 21;
            EmailAddressTextBox.TextChanged += EmailAddressTextBox_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Aquamarine;
            SaveButton.Location = new Point(1250, 274);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(254, 74);
            SaveButton.TabIndex = 22;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // RememberCustomerheckBox
            // 
            RememberCustomerheckBox.AutoSize = true;
            RememberCustomerheckBox.Location = new Point(1284, 216);
            RememberCustomerheckBox.Name = "RememberCustomerheckBox";
            RememberCustomerheckBox.Size = new Size(162, 36);
            RememberCustomerheckBox.TabIndex = 23;
            RememberCustomerheckBox.Text = "Remember";
            RememberCustomerheckBox.UseVisualStyleBackColor = true;
            // 
            // CustomerGridView
            // 
            CustomerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerGridView.Location = new Point(23, 427);
            CustomerGridView.Name = "CustomerGridView";
            CustomerGridView.RowHeadersWidth = 82;
            CustomerGridView.RowTemplate.Height = 41;
            CustomerGridView.Size = new Size(1578, 472);
            CustomerGridView.TabIndex = 24;
            // 
            // MessageLable
            // 
            MessageLable.AutoSize = true;
            MessageLable.Location = new Point(332, 61);
            MessageLable.Name = "MessageLable";
            MessageLable.Size = new Size(0, 32);
            MessageLable.TabIndex = 25;
            // 
            // CustomerIdLable
            // 
            CustomerIdLable.AutoSize = true;
            CustomerIdLable.BackColor = Color.FromArgb(192, 255, 255);
            CustomerIdLable.Location = new Point(846, 24);
            CustomerIdLable.Name = "CustomerIdLable";
            CustomerIdLable.Size = new Size(0, 32);
            CustomerIdLable.TabIndex = 26;
            // 
            // HomeAddrressTextBox
            // 
            HomeAddrressTextBox.Location = new Point(681, 195);
            HomeAddrressTextBox.Multiline = true;
            HomeAddrressTextBox.Name = "HomeAddrressTextBox";
            HomeAddrressTextBox.Size = new Size(319, 177);
            HomeAddrressTextBox.TabIndex = 28;
            // 
            // HomeAddressLable
            // 
            HomeAddressLable.AutoSize = true;
            HomeAddressLable.Location = new Point(494, 195);
            HomeAddressLable.Name = "HomeAddressLable";
            HomeAddressLable.Size = new Size(163, 32);
            HomeAddressLable.TabIndex = 27;
            HomeAddressLable.Text = "HomeAddress";
            // 
            // BirthDatedateTimePicker
            // 
            BirthDatedateTimePicker.AccessibleRole = AccessibleRole.None;
            BirthDatedateTimePicker.Location = new Point(1189, 109);
            BirthDatedateTimePicker.Name = "BirthDatedateTimePicker";
            BirthDatedateTimePicker.Size = new Size(386, 39);
            BirthDatedateTimePicker.TabIndex = 31;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 965);
            Controls.Add(BirthDatedateTimePicker);
            Controls.Add(HomeAddrressTextBox);
            Controls.Add(HomeAddressLable);
            Controls.Add(CustomerIdLable);
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
            Controls.Add(CustomerId);
            Controls.Add(EmailAddressLable);
            Controls.Add(BirthDateLable);
            Controls.Add(MobilNumberLable);
            Controls.Add(LastNameLable);
            Controls.Add(FirstNameLable);
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
        private Label CustomerId;
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
        private Label CustomerIdLable;
        private TextBox HomeAddrressTextBox;
        private Label HomeAddressLable;
        private DateTimePicker BirthDatedateTimePicker;
    }
}