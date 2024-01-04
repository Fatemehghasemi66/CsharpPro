using SharpPro.Enums;
using SharpPro.Models;
using SharpPro.Repository.Implementation;
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

    public UserForm()
    {
        InitializeComponent();
        UserRepository userRepository = new UserRepository();
        GenderComboBox.DataSource = Enum.GetValues(typeof(Gender));
        UserDataGridView.DataSource = userRepository.GetIAll();
    }


    private void SaveButton_Click(object sender, EventArgs e)
    {
      

    }

    private void UserForm_Load(object sender, EventArgs e)
    {

    }
}
