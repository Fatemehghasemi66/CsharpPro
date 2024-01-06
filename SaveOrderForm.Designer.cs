namespace CsharpPro
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
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customerDataGridView
            // 
            customerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.Location = new Point(12, 252);
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.RowHeadersWidth = 82;
            customerDataGridView.Size = new Size(2162, 409);
            customerDataGridView.TabIndex = 0;
            // 
            // productDataGridView
            // 
            productDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(239, 818);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 82;
            productDataGridView.Size = new Size(1761, 429);
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
            label1.Location = new Point(1035, 200);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 3;
            label1.Text = "ProductList";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(989, 766);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 4;
            label2.Text = "CustomerList";
            // 
            // SaveOrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2210, 1467);
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
    }
}