namespace CsharpPro;

partial class AddressForm
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
        AddressGridView = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)AddressGridView).BeginInit();
        SuspendLayout();
        // 
        // AddressGridView
        // 
        AddressGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        AddressGridView.Location = new Point(3, 0);
        AddressGridView.Name = "AddressGridView";
        AddressGridView.RowTemplate.Height = 25;
        AddressGridView.Size = new Size(800, 438);
        AddressGridView.TabIndex = 0;
        // 
        // AddressForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(AddressGridView);
        Name = "AddressForm";
        Text = "AddressForm";
        Load += Address_Load;
        ((System.ComponentModel.ISupportInitialize)AddressGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView AddressGridView;
}