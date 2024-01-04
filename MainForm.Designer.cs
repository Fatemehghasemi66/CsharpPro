namespace CsharpPro
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            customerFormToolStripMenuItem = new ToolStripMenuItem();
            customerFormToolStripMenuItem1 = new ToolStripMenuItem();
            customerListToolStripMenuItem = new ToolStripMenuItem();
            productManagmentToolStripMenuItem = new ToolStripMenuItem();
            productListToolStripMenuItem = new ToolStripMenuItem();
            orderManagementToolStripMenuItem = new ToolStripMenuItem();
            saveOrderToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            logoPictureBox = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { customerFormToolStripMenuItem, productManagmentToolStripMenuItem, orderManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1617, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // customerFormToolStripMenuItem
            // 
            customerFormToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customerFormToolStripMenuItem1, customerListToolStripMenuItem });
            customerFormToolStripMenuItem.Name = "customerFormToolStripMenuItem";
            customerFormToolStripMenuItem.Size = new Size(287, 36);
            customerFormToolStripMenuItem.Text = "Customer Management";
            customerFormToolStripMenuItem.Click += customerFormToolStripMenuItem_Click;
            // 
            // customerFormToolStripMenuItem1
            // 
            customerFormToolStripMenuItem1.Name = "customerFormToolStripMenuItem1";
            customerFormToolStripMenuItem1.Size = new Size(312, 44);
            customerFormToolStripMenuItem1.Text = "Customer List";
            customerFormToolStripMenuItem1.Click += customerFormToolStripMenuItem1_Click;
            // 
            // customerListToolStripMenuItem
            // 
            customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            customerListToolStripMenuItem.Size = new Size(312, 44);
            customerListToolStripMenuItem.Text = "New Customer ";
            // 
            // productManagmentToolStripMenuItem
            // 
            productManagmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productListToolStripMenuItem });
            productManagmentToolStripMenuItem.Name = "productManagmentToolStripMenuItem";
            productManagmentToolStripMenuItem.Size = new Size(253, 36);
            productManagmentToolStripMenuItem.Text = "Product Managment";
            // 
            // productListToolStripMenuItem
            // 
            productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            productListToolStripMenuItem.Size = new Size(264, 44);
            productListToolStripMenuItem.Text = "ProductList";
            productListToolStripMenuItem.Click += productListToolStripMenuItem_Click;
            // 
            // orderManagementToolStripMenuItem
            // 
            orderManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveOrderToolStripMenuItem });
            orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            orderManagementToolStripMenuItem.Size = new Size(238, 36);
            orderManagementToolStripMenuItem.Text = "OrderManagement";
            // 
            // saveOrderToolStripMenuItem
            // 
            saveOrderToolStripMenuItem.Name = "saveOrderToolStripMenuItem";
            saveOrderToolStripMenuItem.Size = new Size(258, 44);
            saveOrderToolStripMenuItem.Text = "SaveOrder";
            saveOrderToolStripMenuItem.Click += saveOrderToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1617, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // logoPictureBox
            // 
            logoPictureBox.Location = new Point(308, 234);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(918, 932);
            logoPictureBox.TabIndex = 2;
            logoPictureBox.TabStop = false;
            logoPictureBox.Click += logoPictureBox_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(1617, 1231);
            Controls.Add(logoPictureBox);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem customerFormToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem customerFormToolStripMenuItem1;
        private ToolStripMenuItem productManagmentToolStripMenuItem;
        private ToolStripMenuItem customerListToolStripMenuItem;
        private ToolStripMenuItem productListToolStripMenuItem;
        private PictureBox logoPictureBox;
        private ToolStripMenuItem orderManagementToolStripMenuItem;
        private ToolStripMenuItem saveOrderToolStripMenuItem;
    }
}