namespace CsharpPro
{
    partial class productForm
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
            UserDataGridView = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            SuspendLayout();
            // 
            // UserDataGridView
            // 
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Location = new Point(12, 319);
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.RowHeadersWidth = 82;
            UserDataGridView.RowTemplate.Height = 41;
            UserDataGridView.Size = new Size(1372, 550);
            UserDataGridView.TabIndex = 0;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(271, 40);
            FirstNameTextBox.Margin = new Padding(4, 2, 4, 2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(234, 39);
            FirstNameTextBox.TabIndex = 19;
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.Location = new Point(134, 46);
            FirstNameLable.Margin = new Padding(4, 0, 4, 0);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(122, 32);
            FirstNameLable.TabIndex = 18;
            FirstNameLable.Text = "FirstName";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(271, 121);
            LastNameTextBox.Margin = new Padding(4, 2, 4, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(234, 39);
            LastNameTextBox.TabIndex = 21;
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Location = new Point(134, 121);
            LastNameLable.Margin = new Padding(4, 0, 4, 0);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(119, 32);
            LastNameLable.TabIndex = 20;
            LastNameLable.Text = "LastName";
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Location = new Point(271, 206);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(234, 40);
            GenderComboBox.TabIndex = 37;
            // 
            // BirthDatedateTimePicker
            // 
            BirthDatedateTimePicker.AccessibleRole = AccessibleRole.None;
            BirthDatedateTimePicker.Location = new Point(797, 116);
            BirthDatedateTimePicker.Margin = new Padding(4, 2, 4, 2);
            BirthDatedateTimePicker.Name = "BirthDatedateTimePicker";
            BirthDatedateTimePicker.Size = new Size(387, 39);
            BirthDatedateTimePicker.TabIndex = 36;
            // 
            // MobileNumberTextBox
            // 
            MobileNumberTextBox.Location = new Point(797, 39);
            MobileNumberTextBox.Margin = new Padding(4, 2, 4, 2);
            MobileNumberTextBox.Name = "MobileNumberTextBox";
            MobileNumberTextBox.Size = new Size(387, 39);
            MobileNumberTextBox.TabIndex = 35;
            // 
            // BirthDateLable
            // 
            BirthDateLable.AutoSize = true;
            BirthDateLable.Location = new Point(644, 128);
            BirthDateLable.Margin = new Padding(4, 0, 4, 0);
            BirthDateLable.Name = "BirthDateLable";
            BirthDateLable.Size = new Size(114, 32);
            BirthDateLable.TabIndex = 34;
            BirthDateLable.Text = "BirthDate";
            // 
            // GenderLable
            // 
            GenderLable.AutoSize = true;
            GenderLable.Location = new Point(149, 196);
            GenderLable.Margin = new Padding(4, 0, 4, 0);
            GenderLable.Name = "GenderLable";
            GenderLable.Size = new Size(92, 32);
            GenderLable.TabIndex = 39;
            GenderLable.Text = "Gender";
            // 
            // MobilNumberLable
            // 
            MobilNumberLable.AutoSize = true;
            MobilNumberLable.Location = new Point(595, 39);
            MobilNumberLable.Margin = new Padding(4, 0, 4, 0);
            MobilNumberLable.Name = "MobilNumberLable";
            MobilNumberLable.Size = new Size(177, 32);
            MobilNumberLable.TabIndex = 38;
            MobilNumberLable.Text = "MobileNumber";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.CornflowerBlue;
            SaveButton.Location = new Point(797, 196);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(387, 58);
            SaveButton.TabIndex = 40;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 907);
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
            Controls.Add(UserDataGridView);
            Name = "UserForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

       

        #endregion

        private DataGridView UserDataGridView;
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
    }
}