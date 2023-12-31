using CsharpPro.Enums;
using CsharpPro.Models;
using CsharpPro.Repository;
using System.Globalization;
using System.Windows.Forms;


namespace CsharpPro;

public partial class ProductForm : Form
{
    Product selectproduct = null;
    public delegate void RefreshDataDeligate();
    public event RefreshDataDeligate RefreshDataEvent;

    public ProductForm()
    {
        InitializeComponent();
        RefreshDataEvent += LoadFormData;
        RefreshDataEvent?.Invoke();
      
    }
    private void LoadFormData()
    {
        ProductRepository productRepository = new ProductRepository();
        ProductGridView.DataSource = productRepository.GetIAll();
        ProductGridView.DataSource = null;
        ProductGridView.DataSource = productRepository;
        ProductGridView.Refresh();
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
            Product product = new Product(
                name: ProNameTextBox.Text,
                price: decimal.Parse(PriceTextBox.Text),
                count: int.Parse(CountTextBox.Text),
                brandName: BrandNameTextBox.Text
                );
            ProductRepository productRepository = new ProductRepository();
            productRepository.AddItem(product);
            RefreshDataEvent?.Invoke();
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

    private void ProductForm_Load(object sender, EventArgs e)
    {
        PersianCalendar PC = new PersianCalendar();
        DateLable.Text = PC.GetYear(DateTime.Now) + "/" + PC.GetMonth(DateTime.Now) + "/" + PC.GetDayOfMonth(DateTime.Now);
        System.Timers.Timer time = new System.Timers.Timer();
        TimeLable.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        if (selectproduct == null)
        {
            MessageBox.Show("Please Select An Item");
            return;
        }
        ProductRepository productRepository = new ProductRepository();
        selectproduct.Name = ProNameTextBox.Text;
        selectproduct.Price = decimal.Parse(PriceTextBox.Text);
        selectproduct.Count = int.Parse(CountTextBox.Text);
        selectproduct.BrandName = BrandNameTextBox.Text;


        productRepository.UpdateItem(selectproduct);
        RefreshDataEvent?.Invoke();
        ClearControl();
    }

    private void ProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (ProductGridView.SelectedCells.Count > 0)
        {
            var selectedRowindex = ProductGridView.SelectedCells[0].RowIndex;
            var row = ProductGridView.Rows[selectedRowindex];
            int id = int.Parse(row.Cells["Id"].Value.ToString());

            ProductRepository productRepository = new ProductRepository();
            Product product = productRepository.GetById(id);
            ProNameTextBox.Text = product.Name;
            PriceTextBox.Text = product.Price.ToString();
            CountTextBox.Text = product.Count.ToString();
            BrandNameTextBox.Text = product.BrandName;

        }
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        if (selectproduct is null)
        {
            MessageBox.Show("Please Select An Item");
            return;
        }

        CustomerRepository customerRepository = new CustomerRepository();
        customerRepository.DeleteItem(id: selectproduct.Id);
        RefreshDataEvent?.Invoke();
        ClearControl();
    }
}

