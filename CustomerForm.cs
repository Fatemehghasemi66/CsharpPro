using CsharpPro.Models;
using CsharpPro.Repository;
using System.Data;
using System.Globalization;

namespace CsharpPro
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            PersianCalendar PC = new PersianCalendar();
            DateLable.Text = PC.GetYear(DateTime.Now) + "/" + PC.GetMonth(DateTime.Now) + "/" + PC.GetDayOfMonth(DateTime.Now);
            System.Timers.Timer time = new System.Timers.Timer();
            TimeLable.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            //CustomerRepository customerrepository = new CustomerRepository();
            //CustomerGridView.DataSource = customerrepository.GetIAll();

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

                MessageLable.BackColor = Color.DarkGreen;
                MessageLable.ForeColor = Color.LightGreen;
                MessageLable.Text = $"Dear {FirstNameTextBox.Text} Wellcome to Stor";
                Customer customer = new Customer(firstName: FirstNameTextBox.Text, lastName: LastNameTextBox.Text, birthDate: BirthDatedateTimePicker.Value.Date,
                 mobileNumber: MobileNumberTextBox.Text, emailAddress: EmailAddressTextBox.Text);
                CustomerRepository customerRepository = new CustomerRepository();
                customerRepository.AddItem(customer);
                CustomerGridView.DataSource = null;
                CustomerGridView.DataSource = customerRepository.GetIAll();
                CustomerGridView.Refresh();
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
    }
}