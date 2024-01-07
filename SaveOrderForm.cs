using CsharpPro.Dtos;
using CsharpPro.Repository.Implementation;
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


public partial class SaveOrderForm : Form

{
    private readonly ICustomerRepository _customerRepository;
    private readonly IProductRepository _productRepository;
    private readonly IOrderRepository _orderRepository;
    public SaveOrderForm(ICustomerRepository customerRepository,
    IProductRepository productRepository,
        IOrderRepository orderRepository)
    {
        _productRepository = productRepository;
        _customerRepository = customerRepository;
        _orderRepository = orderRepository;

        InitializeComponent();
        LoadCustomerFormData();
        LoadProductFormData();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private void LoadCustomerFormData()
    {
        List<Customer> customers = _customerRepository.GetIAll();
        customerDataGridView.DataSource = null;
        customerDataGridView.DataSource = customers;
        customerDataGridView.Refresh();
    }
    private void LoadProductFormData()
    {
        List<Product> products = _productRepository.GetIAll();
        productDataGridView.DataSource = null;

        products = products.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
        productDataGridView.DataSource = products;
        productDataGridView.Refresh();
    }
    private bool SaveOrder(SaveOrderDto saveOrderDto)
    {
        if (saveOrderDto is null)
            throw new Exception(message: "Please Pass saveOrderDto Object");

        if (saveOrderDto.Products is null && saveOrderDto.Products.Count == 0)
            throw new Exception(message: "Please Pass products in saveOrderDto Object");

        if (saveOrderDto.Customer is null)
            throw new Exception(message: "Please Pass customer in saveOrderDto Object");

        if (saveOrderDto.Address is null)
            throw new Exception(message: "Please Pass Address in saveOrderDto Object");
        Order order = new()
        {
            CreationDate = DateTime.Now,
            OrderDate = DateTime.Now,
            AddressId = saveOrderDto.Address.Id,
            CustomerId = saveOrderDto.Customer.Id,
            Code = new Guid().ToString().Substring(1, 10)
        };
        int orderId = 0;
        _orderRepository.AddItem(order, out orderId);
        if (orderId > 0)
        {
            for (int i = 0; i < saveOrderDto.Products.Count; i++)
            {
                OrderItem orderItem = new()
                {
                    OrderId = orderId,
                    Count = 1,
                    CurrentPrice = saveOrderDto.Products[i].Price,
                    CreationDate = DateTime.Now
                };
                _orderRepository.AddSubItem(item: orderItem);
            }
            return true;
        }
        else
        {
            return false;
        }
    }

    private void SaveOrderButton_Click(object sender, EventArgs e)
    {
        Customer customer = new Customer();
        Address address = new Address();
        List<Product> products = new List<Product>();
        SaveOrderDto saveOrderDto = new SaveOrderDto(Customer: customer, Products: products, Address: address);
        bool flag = SaveOrder(saveOrderDto);
        if (flag)
            MessageBox.Show("Order Saved");
        else
            MessageBox.Show("Order failed");

    }

    private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
    private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void customerDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        List<Product> products = _productRepository.GetIAll();
        productDataGridView.DataSource = null;
        products = products.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
        productDataGridView.DataSource = products;
        productDataGridView.Refresh();
    }

    private void SearchCustomerButton_Click(object sender, EventArgs e)
    {
        List<Customer> customer = _customerRepository.GetIAll();
        customerDataGridView.DataSource = null;
        customer = customer.Where(x => x.MobileNumber.Contains(searchCustomerTextBox.Text)).ToList();
        customerDataGridView.DataSource = customer;
        customerDataGridView.Refresh();
    }
}
