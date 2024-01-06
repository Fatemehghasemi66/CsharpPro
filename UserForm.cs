using CsharpPro;
using CsharpPro.Repository.InterFace;
using SharpPro.Enums;
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

namespace SharpPro;

public partial class UserForm : Form
{
    private readonly IUserRepository _userRepository;

    public UserForm(IUserRepository uerRepository)
    {
        _userRepository = uerRepository;
        InitializeComponent();
        UserRepository userRepository = new UserRepository();
        GenderComboBox.DataSource = Enum.GetValues(typeof(Gender));

    }


    private void SaveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(MobileNumberTextBox.Text) || string.IsNullOrEmpty(FirstNameTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text) || (MobileNumberTextBox.Text).Length < 11)
            {
             MessageBox.Show( "Please enter Valid input");
                return;
            }
            if (!string.IsNullOrEmpty(MobileNumberTextBox.Text) && (MobileNumberTextBox.Text).Length == 11)
            {
                string SubMoB = (MobileNumberTextBox.Text).Substring(0, 2);
                if (SubMoB != "09")
                {
                    MessageBox.Show("Please enter ValidMobileNumber, area code is mandatory");
                    
                    return;
                }
            }

            Users user = new Users(
            username: UserNameTextBox.Text,
            password: PasswordTextBox.Text,
            firstName: FirstNameTextBox.Text,
            lastName: LastNameTextBox.Text,
            birthDate: BirthDatedateTimePicker.Value.Date,
            mobileNumber: MobileNumberTextBox.Text,
            gender: (Gender)GenderComboBox.SelectedItem
            );
            int userId = 0;
            _userRepository.AddItem(item:user , out userId);
            if (userId == 0)
            {
                MessageBox.Show("No User Inserted !!");
            }

            MessageBox.Show($"User Inserted Id: {userId} ");

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
       finally
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

    }

    private void UserForm_Load(object sender, EventArgs e)
    {

    }

 
}
