using CsharpPro.Enums;
using CsharpPro.Models;
using CsharpPro.Repository;
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

public partial class productForm : Form
{

    public productForm()
    {
        InitializeComponent();
        UserRepository userRepository = new UserRepository();
        GenderComboBox.DataSource = Enum.GetValues(typeof(Gender));
        UserDataGridView.DataSource = userRepository.GetIAll();
    }


    private void SaveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(MobileNumberTextBox.Text) || string.IsNullOrEmpty(FirstNameTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                MessageBox.Show("please enter valid input");
                return;

            }
            if ((MobileNumberTextBox.Text).Length == 11 && (MobileNumberTextBox.Text).StartsWith("09"))
            {
                MessageBox.Show("Your registration was successful");

            }
            else
            {
                MessageBox.Show("Please enter ValidMobileNamber, area code is mandatory");
                return;
            }
            User user = new User(firstName: FirstNameTextBox.Text, lastName: LastNameTextBox.Text, birthDate: BirthDatedateTimePicker.Value.Date, mobileNumber: MobileNumberTextBox.Text, gender: (Gender)GenderComboBox.SelectedValue);
            UserRepository userRepository = new UserRepository();
            userRepository.AddItem(user);
            UserDataGridView.DataSource = null; 
            UserDataGridView.DataSource = userRepository.GetIAll();
            UserDataGridView.Refresh();
           

        }
        catch
        {
        }
        finally
        {

        }

    }
}
