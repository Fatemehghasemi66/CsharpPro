namespace CsharpPro
{
    partial class ProductForm
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
            ProNameLabel = new Label();
            ProNameTextBox = new TextBox();
            MessageLable = new Label();
            TimeLable = new Label();
            DateLable = new Label();
            BrandNameTextBox = new TextBox();
            BrandLabel = new Label();
            CountTextBox = new TextBox();
            CountLabel = new Label();
            PriceTextBox = new TextBox();
            PriceLabel = new Label();
            SaveButton = new Button();
            ProIdabel = new Label();
            ProIdLable = new Label();
            checkBox1 = new CheckBox();
            ProductGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            SuspendLayout();
            // 
            // ProNameLabel
            // 
            ProNameLabel.AutoSize = true;
            ProNameLabel.Location = new Point(3, 118);
            ProNameLabel.Name = "ProNameLabel";
            ProNameLabel.Size = new Size(167, 32);
            ProNameLabel.TabIndex = 0;
            ProNameLabel.Text = "Product Name";
            // 
            // ProNameTextBox
            // 
            ProNameTextBox.Location = new Point(176, 118);
            ProNameTextBox.Name = "ProNameTextBox";
            ProNameTextBox.Size = new Size(261, 39);
            ProNameTextBox.TabIndex = 1;
            // 
            // MessageLable
            // 
            MessageLable.AutoSize = true;
            MessageLable.Location = new Point(226, 18);
            MessageLable.Name = "MessageLable";
            MessageLable.Size = new Size(0, 32);
            MessageLable.TabIndex = 28;
            // 
            // TimeLable
            // 
            TimeLable.AutoSize = true;
            TimeLable.Location = new Point(24, 62);
            TimeLable.Name = "TimeLable";
            TimeLable.Size = new Size(0, 32);
            TimeLable.TabIndex = 27;
            // 
            // DateLable
            // 
            DateLable.AutoSize = true;
            DateLable.Location = new Point(25, 14);
            DateLable.Name = "DateLable";
            DateLable.Size = new Size(0, 32);
            DateLable.TabIndex = 26;
            // 
            // BrandNameTextBox
            // 
            BrandNameTextBox.Location = new Point(176, 201);
            BrandNameTextBox.Name = "BrandNameTextBox";
            BrandNameTextBox.Size = new Size(261, 39);
            BrandNameTextBox.TabIndex = 30;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Location = new Point(24, 201);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(140, 32);
            BrandLabel.TabIndex = 29;
            BrandLabel.Text = "BrandName";
            // 
            // CountTextBox
            // 
            CountTextBox.Location = new Point(818, 118);
            CountTextBox.Name = "CountTextBox";
            CountTextBox.Size = new Size(277, 39);
            CountTextBox.TabIndex = 32;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Location = new Point(705, 118);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(79, 32);
            CountLabel.TabIndex = 31;
            CountLabel.Text = "Count";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(818, 194);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(277, 39);
            PriceTextBox.TabIndex = 34;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(719, 197);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(65, 32);
            PriceLabel.TabIndex = 33;
            PriceLabel.Text = "Price";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.ActiveCaption;
            SaveButton.Location = new Point(494, 322);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(169, 67);
            SaveButton.TabIndex = 35;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += button1_Click;
            // 
            // ProIdabel
            // 
            ProIdabel.AutoSize = true;
            ProIdabel.Location = new Point(979, 14);
            ProIdabel.Name = "ProIdabel";
            ProIdabel.Size = new Size(116, 32);
            ProIdabel.TabIndex = 36;
            ProIdabel.Text = "ProductId";
            // 
            // ProIdLable
            // 
            ProIdLable.AutoSize = true;
            ProIdLable.BackColor = Color.FromArgb(192, 255, 255);
            ProIdLable.Location = new Point(1138, 14);
            ProIdLable.Name = "ProIdLable";
            ProIdLable.Size = new Size(0, 32);
            ProIdLable.TabIndex = 37;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(494, 268);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 36);
            checkBox1.TabIndex = 38;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ProductGridView
            // 
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Location = new Point(87, 437);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersWidth = 82;
            ProductGridView.RowTemplate.Height = 41;
            ProductGridView.Size = new Size(965, 322);
            ProductGridView.TabIndex = 39;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 800);
            Controls.Add(ProductGridView);
            Controls.Add(checkBox1);
            Controls.Add(ProIdLable);
            Controls.Add(ProIdabel);
            Controls.Add(SaveButton);
            Controls.Add(PriceTextBox);
            Controls.Add(PriceLabel);
            Controls.Add(CountTextBox);
            Controls.Add(CountLabel);
            Controls.Add(BrandNameTextBox);
            Controls.Add(BrandLabel);
            Controls.Add(MessageLable);
            Controls.Add(TimeLable);
            Controls.Add(DateLable);
            Controls.Add(ProNameTextBox);
            Controls.Add(ProNameLabel);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProNameLabel;
        private TextBox ProNameTextBox;
        private Label MessageLable;
        private Label TimeLable;
        private Label DateLable;
        private TextBox BrandNameTextBox;
        private Label BrandLabel;
        private TextBox CountTextBox;
        private Label CountLabel;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private Button SaveButton;
        private Label ProIdabel;
        private Label ProIdLable;
        private CheckBox checkBox1;
        private DataGridView ProductGridView;
    }
}