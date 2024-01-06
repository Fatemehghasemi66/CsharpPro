using CsharpPro.Repository.InterFace;
using SharpPro;
using SharpPro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CsharpPro
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["FirstDB"].ToString();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tableName = "dbo.[Users]";
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"SELECT * FROM {tableName}where UserName = @UserName and Password = @Password";
            SqlCommand command = new SqlCommand(query, connection: con);
            command.Parameters.AddWithValue("@UserName", userNameTextBox.Text);
            command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Successfully logged in");
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(_userRepository);
            userForm.Show();

        }
    }
}

