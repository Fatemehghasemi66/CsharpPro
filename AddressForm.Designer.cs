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
        Label label1;
        Label label2;
        postalCodeTextBox = new TextBox();
        housenumberTextBox = new TextBox();
        streetTextBox = new TextBox();
        cityTextBox = new TextBox();
        postalocodLabel = new Label();
        CityLabel = new Label();
        StreetLabel = new Label();
        HouseNumberLable = new Label();
        considLable = new Label();
        considerationsTextBox = new TextBox();
        addressDataGridView = new DataGridView();
        saveButton = new Button();
        label1 = new Label();
        label2 = new Label();
        ((System.ComponentModel.ISupportInitialize)addressDataGridView).BeginInit();
        SuspendLayout();
        // 
        // postalCodeTextBox
        // 
        postalCodeTextBox.Location = new Point(137, 76);
        postalCodeTextBox.Name = "postalCodeTextBox";
        postalCodeTextBox.Size = new Size(148, 23);
        postalCodeTextBox.TabIndex = 0;
        // 
        // housenumberTextBox
        // 
        housenumberTextBox.Location = new Point(137, 201);
        housenumberTextBox.Name = "housenumberTextBox";
        housenumberTextBox.Size = new Size(148, 23);
        housenumberTextBox.TabIndex = 1;
        // 
        // streetTextBox
        // 
        streetTextBox.Location = new Point(137, 160);
        streetTextBox.Name = "streetTextBox";
        streetTextBox.Size = new Size(148, 23);
        streetTextBox.TabIndex = 2;
        // 
        // cityTextBox
        // 
        cityTextBox.Location = new Point(137, 119);
        cityTextBox.Name = "cityTextBox";
        cityTextBox.Size = new Size(148, 23);
        cityTextBox.TabIndex = 3;
        // 
        // postalocodLabel
        // 
        postalocodLabel.AutoSize = true;
        postalocodLabel.Location = new Point(64, 76);
        postalocodLabel.Name = "postalocodLabel";
        postalocodLabel.Size = new Size(67, 15);
        postalocodLabel.TabIndex = 4;
        postalocodLabel.Text = "PostalCode";
        // 
        // CityLabel
        // 
        CityLabel.AutoSize = true;
        CityLabel.Location = new Point(101, 122);
        CityLabel.Name = "CityLabel";
        CityLabel.Size = new Size(28, 15);
        CityLabel.TabIndex = 5;
        CityLabel.Text = "City";
        // 
        // StreetLabel
        // 
        StreetLabel.AutoSize = true;
        StreetLabel.Location = new Point(92, 168);
        StreetLabel.Name = "StreetLabel";
        StreetLabel.Size = new Size(37, 15);
        StreetLabel.TabIndex = 6;
        StreetLabel.Text = "Street";
        // 
        // HouseNumberLable
        // 
        HouseNumberLable.AutoSize = true;
        HouseNumberLable.Location = new Point(43, 201);
        HouseNumberLable.Name = "HouseNumberLable";
        HouseNumberLable.Size = new Size(86, 15);
        HouseNumberLable.TabIndex = 7;
        HouseNumberLable.Text = "House number";
        // 
        // considLable
        // 
        considLable.AutoSize = true;
        considLable.Location = new Point(45, 248);
        considLable.Name = "considLable";
        considLable.Size = new Size(84, 15);
        considLable.TabIndex = 9;
        considLable.Text = "considerations";
        // 
        // considerationsTextBox
        // 
        considerationsTextBox.Location = new Point(137, 248);
        considerationsTextBox.Multiline = true;
        considerationsTextBox.Name = "considerationsTextBox";
        considerationsTextBox.Size = new Size(148, 71);
        considerationsTextBox.TabIndex = 8;
        // 
        // addressDataGridView
        // 
        addressDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        addressDataGridView.Location = new Point(21, 393);
        addressDataGridView.Name = "addressDataGridView";
        addressDataGridView.RowTemplate.Height = 25;
        addressDataGridView.Size = new Size(383, 147);
        addressDataGridView.TabIndex = 10;
        addressDataGridView.CellContentClick += addressDataGridView_CellContentClick;
        // 
        // saveButton
        // 
        saveButton.BackColor = Color.FromArgb(255, 192, 192);
        saveButton.Location = new Point(161, 335);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(85, 28);
        saveButton.TabIndex = 11;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = false;
        saveButton.Click += saveButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(62, 39);
        label1.Name = "label1";
        label1.Size = new Size(69, 15);
        label1.TabIndex = 13;
        label1.Text = "CustomerId";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(161, 39);
        label2.Name = "label2";
        label2.Size = new Size(0, 15);
        label2.TabIndex = 14;
        // 
        // AddressForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(416, 570);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(saveButton);
        Controls.Add(addressDataGridView);
        Controls.Add(considLable);
        Controls.Add(considerationsTextBox);
        Controls.Add(HouseNumberLable);
        Controls.Add(StreetLabel);
        Controls.Add(CityLabel);
        Controls.Add(postalocodLabel);
        Controls.Add(cityTextBox);
        Controls.Add(streetTextBox);
        Controls.Add(housenumberTextBox);
        Controls.Add(postalCodeTextBox);
        Name = "AddressForm";
        Text = "AddressForm";
        Load += Address_Load;
        ((System.ComponentModel.ISupportInitialize)addressDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox postalCodeTextBox;
    private TextBox housenumberTextBox;
    private TextBox streetTextBox;
    private TextBox cityTextBox;
    private Label postalocodLabel;
    private Label CityLabel;
    private Label StreetLabel;
    private Label HouseNumberLable;
    private Label considLable;
    private TextBox considerationsTextBox;
    private DataGridView addressDataGridView;
    private Button saveButton;
}