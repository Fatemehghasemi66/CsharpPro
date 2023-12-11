using CsharpPro.Models;
using CsharpPro.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpPro;

public partial class ProductForm : Form
{


    public ProductForm()
    {
        InitializeComponent();
        PersianCalendar PC = new PersianCalendar();
        DateLable.Text = PC.GetYear(DateTime.Now) + "/" + PC.GetMonth(DateTime.Now) + "/" + PC.GetDayOfMonth(DateTime.Now);
        System.Timers.Timer time = new System.Timers.Timer();
        TimeLable.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        ProductRepository Productrepository = new ProductRepository();
        ProductGridView.DataSource = Productrepository.GetIAll(); ;
    }
    public void ClearControl()
    {
        foreach (Control ctrl in Controls)
        {
            if (ctrl is TextBox)
            {
                ctrl.Text = "";
            }
        }
        foreach (Control ctrl in Controls)
        {
            if (ctrl.GetType() == typeof(CheckBox))
            {
                ((CheckBox)ctrl).Checked = false;
            }
        }
    }
    private void SaveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(CountTextBox.Text) || string.IsNullOrEmpty(ProNameTextBox.Text) || string.IsNullOrEmpty(PriceTextBox.Text))
            {
                MessageLable.BackColor = Color.DarkRed;
                MessageLable.ForeColor = Color.White;
                MessageLable.Text = "Please enter Valid inputs";
                return;
            }
            MessageBox.Show($"Product {ProNameTextBox.Text} was successfully inserted");
            Product product = new Product(name: ProNameTextBox.Text, price: decimal.Parse(PriceTextBox.Text), count: int.Parse(CountTextBox.Text), brandName: BrandNameTextBox.Text);
            ProductRepository productRepository = new ProductRepository();
            productRepository.AddItem(product);
            ProductGridView.DataSource = null;
            ProductGridView.DataSource = productRepository.GetIAll(); ;
            ProductGridView.Refresh();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            ClearControl();
        }


    }
}
