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
            menuStrip1 = new MenuStrip();
            customerFormToolStripMenuItem = new ToolStripMenuItem();
            customerFormToolStripMenuItem1 = new ToolStripMenuItem();
            customerListToolStripMenuItem = new ToolStripMenuItem();
            productManagmentToolStripMenuItem = new ToolStripMenuItem();
            pToolStripMenuItem = new ToolStripMenuItem();
            newProductToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            userListToolStripMenuItem = new ToolStripMenuItem();
            newUserToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { customerFormToolStripMenuItem, productManagmentToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(961, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // customerFormToolStripMenuItem
            // 
            customerFormToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customerFormToolStripMenuItem1, customerListToolStripMenuItem });
            customerFormToolStripMenuItem.Name = "customerFormToolStripMenuItem";
            customerFormToolStripMenuItem.Size = new Size(287, 38);
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
            productManagmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pToolStripMenuItem, newProductToolStripMenuItem });
            productManagmentToolStripMenuItem.Name = "productManagmentToolStripMenuItem";
            productManagmentToolStripMenuItem.Size = new Size(253, 38);
            productManagmentToolStripMenuItem.Text = "Product Managment";
            // 
            // pToolStripMenuItem
            // 
            pToolStripMenuItem.Name = "pToolStripMenuItem";
            pToolStripMenuItem.Size = new Size(284, 44);
            pToolStripMenuItem.Text = "Product List";
            pToolStripMenuItem.Click += pToolStripMenuItem_Click;
            // 
            // newProductToolStripMenuItem
            // 
            newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            newProductToolStripMenuItem.Size = new Size(284, 44);
            newProductToolStripMenuItem.Text = "New Product";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userListToolStripMenuItem, newUserToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(91, 38);
            usersToolStripMenuItem.Text = "Users";
            // 
            // userListToolStripMenuItem
            // 
            userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            userListToolStripMenuItem.Size = new Size(359, 44);
            userListToolStripMenuItem.Text = "User List";
            userListToolStripMenuItem.Click += userListToolStripMenuItem_Click;
            // 
            // newUserToolStripMenuItem
            // 
            newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            newUserToolStripMenuItem.Size = new Size(359, 44);
            newUserToolStripMenuItem.Text = "New User";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(961, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 688);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem customerFormToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem customerFormToolStripMenuItem1;
        private ToolStripMenuItem productManagmentToolStripMenuItem;
        private ToolStripMenuItem pToolStripMenuItem;
        private ToolStripMenuItem customerListToolStripMenuItem;
        private ToolStripMenuItem newProductToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem userListToolStripMenuItem;
        private ToolStripMenuItem newUserToolStripMenuItem;
    }
}