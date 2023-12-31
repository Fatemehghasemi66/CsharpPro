﻿namespace CsharpPro
{
    partial class SaveOrderForm
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
            customerDataGridView = new DataGridView();
            productDataGridView = new DataGridView();
            SaveOrderButton = new Button();
            label1 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            SearchCustomerButton = new Button();
            searchCustomerTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customerDataGridView
            // 
            customerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.Location = new Point(12, 629);
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.RowHeadersWidth = 82;
            customerDataGridView.Size = new Size(2162, 182);
            customerDataGridView.TabIndex = 0;
            customerDataGridView.CellContentClick += customerDataGridView_CellContentClick_1;
            // 
            // productDataGridView
            // 
            productDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(180, 929);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 82;
            productDataGridView.Size = new Size(1761, 190);
            productDataGridView.TabIndex = 1;
            productDataGridView.CellContentClick += productDataGridView_CellContentClick;
            // 
            // SaveOrderButton
            // 
            SaveOrderButton.BackColor = SystemColors.ActiveCaption;
            SaveOrderButton.Location = new Point(259, 1353);
            SaveOrderButton.Name = "SaveOrderButton";
            SaveOrderButton.Size = new Size(231, 86);
            SaveOrderButton.TabIndex = 2;
            SaveOrderButton.Text = "SaveOrder";
            SaveOrderButton.UseVisualStyleBackColor = false;
            SaveOrderButton.Click += SaveOrderButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(957, 847);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 3;
            label1.Text = "ProductList";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(957, 544);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 4;
            label2.Text = "CustomerList";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(373, 873);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(403, 39);
            SearchTextBox.TabIndex = 5;
            SearchTextBox.TextChanged += textBox1_TextChanged;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(189, 869);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(150, 46);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchCustomerButton
            // 
            SearchCustomerButton.Location = new Point(34, 563);
            SearchCustomerButton.Name = "SearchCustomerButton";
            SearchCustomerButton.Size = new Size(150, 46);
            SearchCustomerButton.TabIndex = 9;
            SearchCustomerButton.Text = "Search";
            SearchCustomerButton.UseVisualStyleBackColor = true;
            SearchCustomerButton.Click += SearchCustomerButton_Click;
            // 
            // searchCustomerTextBox
            // 
            searchCustomerTextBox.Location = new Point(218, 567);
            searchCustomerTextBox.Name = "searchCustomerTextBox";
            searchCustomerTextBox.Size = new Size(403, 39);
            searchCustomerTextBox.TabIndex = 8;
            // 
            // SaveOrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2210, 1467);
            Controls.Add(SearchCustomerButton);
            Controls.Add(searchCustomerTextBox);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveOrderButton);
            Controls.Add(productDataGridView);
            Controls.Add(customerDataGridView);
            Name = "SaveOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SaveOrderForm";
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView customerDataGridView;
        private DataGridView productDataGridView;
        private Button SaveOrderButton;
        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button SearchCustomerButton;
        private TextBox searchCustomerTextBox;
    }
}