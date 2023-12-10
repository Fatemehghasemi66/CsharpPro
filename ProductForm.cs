using CsharpPro.Models;
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
    List<Product> products = default;
    public ProductForm()
    {
        InitializeComponent();
        PersianCalendar PC = new PersianCalendar();
        DateLable.Text = PC.GetYear(DateTime.Now) + "/" + PC.GetMonth(DateTime.Now) + "/" + PC.GetDayOfMonth(DateTime.Now);
        System.Timers.Timer time = new System.Timers.Timer();
        TimeLable.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
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

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            Product product = new Product(name: ProNameTextBox.Text, price: decimal.Parse(PriceTextBox.Text), count: int.Parse(CountTextBox.Text), brandName: BrandNameTextBox.Text);
            if (string.IsNullOrEmpty(CountTextBox.Text) || string.IsNullOrEmpty(ProNameTextBox.Text) || string.IsNullOrEmpty(PriceTextBox.Text))
            {
                MessageLable.BackColor = Color.DarkRed;
                MessageLable.ForeColor = Color.White;
                MessageLable.Text = "Please enter Valid inputs";
                return;
            }
            MessageBox.Show($"Product {ProNameTextBox.Text} was successfully inserted");
            products = new List<Product>();
            Product newPro = new Product()
            {
                Name = ProNameTextBox.Text,
                BrandName = BrandNameTextBox.Text,
                Count = int.Parse(CountTextBox.Text),
                Price = decimal.Parse(PriceTextBox.Text),
            };
            products.Add(product);
            ProductGridView.DataSource = null;
            ProductGridView.DataSource = products;
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
