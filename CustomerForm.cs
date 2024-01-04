using SharpPro.Enums;
using SharpPro.Models;
using SharpPro.Repository.Implementation;
using SharpPro.Repository.InterFace;
using System.Data;
using System.Globalization;

namespace SharpPro;

public partial class CustomerForm : Form
{
    Customer selectedCustomer = null;
    public delegate void RefreshDataDelegate();
    public event RefreshDataDelegate RefreshDataEvent;
    private readonly ICustomerRepository _customerRepository;

    public CustomerForm(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;

        InitializeComponent();
        RefreshDataEvent += LoadFormData;
        GenderComboBox.DataSource = Enum.GetValues(typeof(Gender));
        RefreshDataEvent?.Invoke();
    }
    private void LoadFormData()
    {

        List<Customer> customers = _customerRepository.GetIAll();
        CustomerGridView.DataSource = null;
        CustomerGridView.DataSource = customers;
        CustomerGridView.Refresh();
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

    private void CustomerForm_Load(object sender, EventArgs e)
    {
        PersianCalendar PC = new PersianCalendar();
        DateLable.Text = PC.GetYear(DateTime.Now) + "/" + PC.GetMonth(DateTime.Now) + "/" + PC.GetDayOfMonth(DateTime.Now);
        System.Timers.Timer time = new System.Timers.Timer();
        TimeLable.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {

        try
        {
            if (string.IsNullOrEmpty(MobileNumberTextBox.Text) || string.IsNullOrEmpty(FirstNameTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text) || (MobileNumberTextBox.Text).Length < 11)
            {
                MessageLable.BackColor = Color.DarkRed;
                MessageLable.ForeColor = Color.LightPink;
                MessageLable.Text = "Please enter Valid input";
                return;
            }
            if (!string.IsNullOrEmpty(MobileNumberTextBox.Text) && (MobileNumberTextBox.Text).Length == 11)
            {
                string SubMoB = (MobileNumberTextBox.Text).Substring(0, 2);
                if (SubMoB != "09")
                {
                    MessageLable.ForeColor = Color.DarkRed;
                    MessageLable.Text = "Please enter ValidMobileNumber, area code is mandatory";
                    return;
                }
            }

            Customer customer = new Customer(
            username: UserNameTextBox.Text,
            password: PasswordTextBox.Text,
            firstName: FirstNameTextBox.Text,
            lastName: LastNameTextBox.Text,
            birthDate: BirthDatedateTimePicker.Value.Date,
            mobileNumber: MobileNumberTextBox.Text,
            emailAddress: EmailAddressTextBox.Text,
            homeAddress: HomeAddressTextBox.Text,
            gender: (Gender)GenderComboBox.SelectedItem
            );
            int customerId = 0;
             _customerRepository.AddItem(item: customer, id: out customerId); ;
           if(customerId == 0 )
            {
                MessageBox.Show("No Customer Inserted !!");
            }

            MessageBox.Show($"Customer Inserted Id: {customerId} ");
               
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            RefreshDataEvent?.Invoke();
            ClearForm();
        }
    }

    private void EmailAddressTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    private void DeleteButton_Click(object sender, EventArgs e)
    {
        if (selectedCustomer is null)
        {
            MessageBox.Show("Please Select An Item");
            return;
        }

        _customerRepository.DeleteItem(id: selectedCustomer.Id);
        RefreshDataEvent?.Invoke();
        ClearForm();
    }

    private void CustomerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (CustomerGridView.SelectedCells.Count > 0)
        {
            var selectedRowindex = CustomerGridView.SelectedCells[0].RowIndex;
            var row = CustomerGridView.Rows[selectedRowindex];
            int id = int.Parse(row.Cells["Id"].Value.ToString());

            Customer customer = _customerRepository.GetById(id);
            FirstNameTextBox.Text = customer.FirstName;
            LastNameTextBox.Text = customer.LastName;
            EmailAddressTextBox.Text = customer.Email;
            MobileNumberTextBox.Text = customer.MobileNumber;
            UserNameTextBox.Text = customer.UserName;
            PasswordTextBox.Text = customer.Password;
            HomeAddressTextBox.Text = customer.HomeAddress;
            GenderComboBox.SelectedItem = (Gender)customer.Gender;
            selectedCustomer = customer;
            //challenge whith  Birthdate when it is Null....?????
        }

    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        if (selectedCustomer == null)
        {
            MessageBox.Show("Please Select An Item");
            return;
        }
        selectedCustomer.FirstName = FirstNameTextBox.Text;
        selectedCustomer.LastName = LastNameTextBox.Text;
        selectedCustomer.Email = EmailAddressTextBox.Text;
        selectedCustomer.HomeAddress = HomeAddressTextBox.Text;
        selectedCustomer.UserName = UserNameTextBox.Text;
        selectedCustomer.Password = PasswordTextBox.Text;
        selectedCustomer.MobileNumber = MobileNumberTextBox.Text;
        selectedCustomer.Gender = GenderComboBox != null ? (Gender)GenderComboBox.SelectedItem : Gender.NOTSELECTED;
        selectedCustomer.BirthDate = (DateTime)BirthDatedateTimePicker.Value.Date;

        _customerRepository.UpdateItem(selectedCustomer);
        RefreshDataEvent?.Invoke();
        ClearForm();
    }
}