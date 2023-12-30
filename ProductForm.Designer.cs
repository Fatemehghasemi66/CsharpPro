﻿namespace CsharpPro
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
            ActiveProductCheckBox = new CheckBox();
            ProductGridView = new DataGridView();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            SuspendLayout();
            // 
            // ProNameLabel
            // 
            ProNameLabel.AutoSize = true;
            ProNameLabel.Location = new Point(2, 55);
            ProNameLabel.Margin = new Padding(2, 0, 2, 0);
            ProNameLabel.Name = "ProNameLabel";
            ProNameLabel.Size = new Size(84, 15);
            ProNameLabel.TabIndex = 0;
            ProNameLabel.Text = "Product Name";
            // 
            // ProNameTextBox
            // 
            ProNameTextBox.Location = new Point(95, 55);
            ProNameTextBox.Margin = new Padding(2, 1, 2, 1);
            ProNameTextBox.Name = "ProNameTextBox";
            ProNameTextBox.Size = new Size(142, 23);
            ProNameTextBox.TabIndex = 1;
            // 
            // MessageLable
            // 
            MessageLable.AutoSize = true;
            MessageLable.Location = new Point(122, 8);
            MessageLable.Margin = new Padding(2, 0, 2, 0);
            MessageLable.Name = "MessageLable";
            MessageLable.Size = new Size(0, 15);
            MessageLable.TabIndex = 28;
            // 
            // TimeLable
            // 
            TimeLable.AutoSize = true;
            TimeLable.Location = new Point(13, 29);
            TimeLable.Margin = new Padding(2, 0, 2, 0);
            TimeLable.Name = "TimeLable";
            TimeLable.Size = new Size(0, 15);
            TimeLable.TabIndex = 27;
            // 
            // DateLable
            // 
            DateLable.AutoSize = true;
            DateLable.Location = new Point(13, 7);
            DateLable.Margin = new Padding(2, 0, 2, 0);
            DateLable.Name = "DateLable";
            DateLable.Size = new Size(0, 15);
            DateLable.TabIndex = 26;
            // 
            // BrandNameTextBox
            // 
            BrandNameTextBox.Location = new Point(95, 94);
            BrandNameTextBox.Margin = new Padding(2, 1, 2, 1);
            BrandNameTextBox.Name = "BrandNameTextBox";
            BrandNameTextBox.Size = new Size(142, 23);
            BrandNameTextBox.TabIndex = 30;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Location = new Point(13, 94);
            BrandLabel.Margin = new Padding(2, 0, 2, 0);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(70, 15);
            BrandLabel.TabIndex = 29;
            BrandLabel.Text = "BrandName";
            // 
            // CountTextBox
            // 
            CountTextBox.Location = new Point(323, 55);
            CountTextBox.Margin = new Padding(2, 1, 2, 1);
            CountTextBox.Name = "CountTextBox";
            CountTextBox.Size = new Size(151, 23);
            CountTextBox.TabIndex = 32;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Location = new Point(266, 58);
            CountLabel.Margin = new Padding(2, 0, 2, 0);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(40, 15);
            CountLabel.TabIndex = 31;
            CountLabel.Text = "Count";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(323, 94);
            PriceTextBox.Margin = new Padding(2, 1, 2, 1);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(151, 23);
            PriceTextBox.TabIndex = 34;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(273, 91);
            PriceLabel.Margin = new Padding(2, 0, 2, 0);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(33, 15);
            PriceLabel.TabIndex = 33;
            PriceLabel.Text = "Price";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.LightGreen;
            SaveButton.Location = new Point(528, 94);
            SaveButton.Margin = new Padding(2, 1, 2, 1);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(142, 28);
            SaveButton.TabIndex = 35;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ActiveProductCheckBox
            // 
            ActiveProductCheckBox.AutoSize = true;
            ActiveProductCheckBox.Location = new Point(548, 54);
            ActiveProductCheckBox.Margin = new Padding(2, 1, 2, 1);
            ActiveProductCheckBox.Name = "ActiveProductCheckBox";
            ActiveProductCheckBox.Size = new Size(101, 19);
            ActiveProductCheckBox.TabIndex = 38;
            ActiveProductCheckBox.Text = "ActiveProduct";
            ActiveProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductGridView
            // 
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Location = new Point(23, 155);
            ProductGridView.Margin = new Padding(2, 1, 2, 1);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersWidth = 82;
            ProductGridView.RowTemplate.Height = 41;
            ProductGridView.Size = new Size(832, 358);
            ProductGridView.TabIndex = 39;
            ProductGridView.CellClick += ProductGridView_CellClick;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.Cyan;
            UpdateButton.Location = new Point(713, 94);
            UpdateButton.Margin = new Padding(2, 1, 2, 1);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(142, 28);
            UpdateButton.TabIndex = 40;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(255, 128, 128);
            DeleteButton.Location = new Point(713, 45);
            DeleteButton.Margin = new Padding(2, 1, 2, 1);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(142, 28);
            DeleteButton.TabIndex = 41;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 523);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(ProductGridView);
            Controls.Add(ActiveProductCheckBox);
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
            Margin = new Padding(2, 1, 2, 1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
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
        private CheckBox ActiveProductCheckBox;
        private DataGridView ProductGridView;
        private Button UpdateButton;
        private Button DeleteButton;
    }
}