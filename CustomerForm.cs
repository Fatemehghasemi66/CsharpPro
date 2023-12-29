using CsharpPro.Enums;
using CsharpPro.Models;
using CsharpPro.Repository;
using System.Data;
using System.Globalization;

namespace CsharpPro
{
    public partial class CustomerForm : Form
    {
        Customer selectedCustomer = null;
        public delegate void RefreshDataDelegate();
        public event RefreshDataDelegate RefreshDataEvent;
        public CustomerForm()
        {
            InitializeComponent();
            RefreshDataEvent += LoadFormData;
            GenderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            RefreshDataEvent?.Invoke();
        }
        private void LoadFormData()
        {
            CustomerRepository customerrepository = new CustomerRepository();
            List<Customer> customers = customerrepository.GetIAll();
            CustomerGridView.DataSource = null;
            CustomerGridView.DataSource = customers;
            CustomerGridView.Refresh();
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
                        MessageLable.Text = "Please enter ValidMobileNamber, area code is mandatory";
                        return;
                    }
                }


                MessageLable.ForeColor = Color.DarkGreen;
                MessageLable.Text = $"User {FirstNameTextBox.Text} was added to the list";
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
                CustomerRepository customerRepository = new CustomerRepository();
                customerRepository.AddItem(item: customer);
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

        private void EmailAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedCustomer is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }

            CustomerRepository customerRepository = new CustomerRepository();
            customerRepository.DeleteItem(id: selectedCustomer.Id);
            RefreshDataEvent?.Invoke();
            ClearControl();
        }

        private void CustomerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerGridView.SelectedCells.Count > 0)
            {
                var selectedRowindex = CustomerGridView.SelectedCells[0].RowIndex;
                var row = CustomerGridView.Rows[selectedRowindex];
                int id = int.Parse(row.Cells["Id"].Value.ToString());

                CustomerRepository customerRepository = new CustomerRepository();
                Customer customer = customerRepository.GetById(id);
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
            if(selectedCustomer == null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            CustomerRepository customerRepository = new CustomerRepository();
            selectedCustomer.FirstName = FirstNameTextBox.Text;
            selectedCustomer.LastName = LastNameTextBox.Text;
            selectedCustomer.Email = EmailAddressTextBox.Text;
            selectedCustomer.HomeAddress = HomeAddressTextBox.Text;
            selectedCustomer.UserName = UserNameTextBox.Text;
            selectedCustomer.Password = PasswordTextBox.Text;
            selectedCustomer.MobileNumber = MobileNumberTextBox.Text;
            selectedCustomer.Gender = GenderComboBox != null ? (Gender)GenderComboBox.SelectedItem: Gender.NOTSELECTED;
            selectedCustomer.BirthDate = (DateTime)BirthDatedateTimePicker.Value.Date;
            
            customerRepository.UpdateItem(selectedCustomer);
            RefreshDataEvent?.Invoke();
            ClearControl();
        }
    }
}