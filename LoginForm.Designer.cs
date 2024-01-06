namespace CsharpPro
{
    partial class LoginForm
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
            button3 = new Button();
            userNameTextBox = new TextBox();
            UserName = new Label();
            Password = new Label();
            PasswordTextBox = new TextBox();
            RegisterButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 192);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(319, 326);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 2;
            button3.Text = "Enter";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(240, 143);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(340, 39);
            userNameTextBox.TabIndex = 3;
            userNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.ForeColor = Color.FromArgb(255, 192, 192);
            UserName.Location = new Point(109, 143);
            UserName.Name = "UserName";
            UserName.Size = new Size(125, 32);
            UserName.TabIndex = 4;
            UserName.Text = "UserName";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = Color.FromArgb(255, 192, 192);
            Password.Location = new Point(123, 232);
            Password.Name = "Password";
            Password.Size = new Size(111, 32);
            Password.TabIndex = 6;
            Password.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(240, 229);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(340, 39);
            PasswordTextBox.TabIndex = 5;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(255, 192, 192);
            RegisterButton.ImageAlign = ContentAlignment.MiddleLeft;
            RegisterButton.Location = new Point(320, 448);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(149, 51);
            RegisterButton.TabIndex = 7;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(259, 398);
            label1.Name = "label1";
            label1.Size = new Size(282, 32);
            label1.TabIndex = 8;
            label1.Text = "If you do not have a user";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(762, 563);
            Controls.Add(label1);
            Controls.Add(RegisterButton);
            Controls.Add(Password);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserName);
            Controls.Add(userNameTextBox);
            Controls.Add(button3);
            ForeColor = Color.Gray;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox userNameTextBox;
        private Label UserName;
        private Label Password;
        private TextBox PasswordTextBox;
        private Button RegisterButton;
        private Label label1;
    }
}