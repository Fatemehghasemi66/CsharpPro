using CsharpPro.Repository.Implementation;
using SharpPro;
using SharpPro.Models;
using SharpPro.Repository.Implementation;
using SharpPro.Repository.InterFace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpPro;

public partial class MainForm : Form
{
    private ICustomerRepository _customerRepository;
    private IProductRepository _productRepository;
    private IAddressRepository _addressRepository;
    private IOrderRepository _orderRepository;
    public MainForm()
    {
        InitializeComponent();
        _customerRepository = new CustomerRepository();
        _productRepository = new ProductRepository();
        _addressRepository = new AddressRepository();
        _orderRepository = new OrderRepository();
        string logoImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content", "Images", "Logo.jpg");
        logoPictureBox.ImageLocation = logoImagePath;
        logoPictureBox.SizeMode = PictureBoxSizeMode.Normal;



    }

    private void formsToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void customerFormToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void pToolStripMenuItem_Click(object sender, EventArgs e)
    {


    }

    private void customerFormToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        CustomerForm customerForm = new(_customerRepository);
        customerForm.Show();
    }

    private void userListToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void productListToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ProductForm productForm = new ProductForm(_productRepository);
        productForm.Show();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void saveOrderToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveOrderForm saveOrderForm = new SaveOrderForm(_customerRepository,_productRepository,_orderRepository);
        saveOrderForm.Show();
    }
}
