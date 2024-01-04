namespace SharpPro
{
    partial class OrderForm
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
            FirstNameLable = new Label();
            LastNameLable = new Label();
            MobilNumber = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.Location = new Point(42, 222);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(122, 32);
            FirstNameLable.TabIndex = 0;
            FirstNameLable.Text = "FirstName";
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Location = new Point(42, 283);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(119, 32);
            LastNameLable.TabIndex = 1;
            LastNameLable.Text = "LastName";
            // 
            // MobilNumber
            // 
            MobilNumber.AutoSize = true;
            MobilNumber.Location = new Point(42, 356);
            MobilNumber.Name = "MobilNumber";
            MobilNumber.Size = new Size(78, 32);
            MobilNumber.TabIndex = 2;
            MobilNumber.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 222);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 296);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 372);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 22);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 64);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 763);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(MobilNumber);
            Controls.Add(LastNameLable);
            Controls.Add(FirstNameLable);
            Name = "OrderForm";
            Text = "OrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLable;
        private Label LastNameLable;
        private Label MobilNumber;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}