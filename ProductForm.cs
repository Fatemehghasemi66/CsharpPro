using CsharpPro.Repository.Implementation;
using SharpPro.Models;
using SharpPro.Repository.InterFace;
using System.Globalization;


namespace CsharpPro;

public partial class ProductForm : Form
{
    Product selectedproduct = null;
    public delegate void RefreshDataDelegate();
    public event RefreshDataDelegate RefreshDataEvent;

    private readonly IProductRepository _productRepository;
    public ProductForm(IProductRepository productRepository)
    {
        _productRepository = productRepository;
        InitializeComponent();
        RefreshDataEvent += LoadFormData;
        RefreshDataEvent?.Invoke();

    }

 

    private void LoadFormData()
    {
        List<Product> products = _productRepository.GetIAll();
        ProductGridView.DataSource = null;
        ProductGridView.DataSource = products;
        ProductGridView.Refresh();
    }


    public void ClearForm()
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
            int productId = 0;
            productRepository.AddItem(product, id: out productId);
     
            RefreshDataEvent?.Invoke();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            ClearForm();
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
        if (selectedproduct is null)
        {
            MessageBox.Show("Please Select An Item");
            return;
        }
        selectedproduct.Name = ProNameTextBox.Text;
        selectedproduct.Price = decimal.Parse(PriceTextBox.Text);
        selectedproduct.Count = int.Parse(CountTextBox.Text);
        selectedproduct.BrandName = BrandNameTextBox.Text;


        _productRepository.UpdateItem(selectedproduct);
        RefreshDataEvent?.Invoke();
        ClearForm();
    }

    private void ProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (ProductGridView.SelectedCells.Count > 0)
        {
            var selectedRowindex = ProductGridView.SelectedCells[0].RowIndex;
            var row = ProductGridView.Rows[selectedRowindex];
            int id = int.Parse(row.Cells["Id"].Value.ToString());

            Product product = _productRepository.GetById(id);
            ProNameTextBox.Text = product.Name;
            PriceTextBox.Text = product.Price.ToString();
            CountTextBox.Text = product.Count.ToString();
            BrandNameTextBox.Text = product.BrandName;
            selectedproduct = product;

        }
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        if (selectedproduct is null)
        {
            MessageBox.Show("Please Select An Item");
            return;
        }

        _productRepository.DeleteItem(id: selectedproduct.Id);
        RefreshDataEvent?.Invoke();
        ClearForm();
    }

    private void ActiveProductCheckBox_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}

