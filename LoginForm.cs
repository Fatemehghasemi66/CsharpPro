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

namespace CsharpPro
{
    public partial class LoginForm : Form
    {
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
            string tableName = "dbo.[Login]";
            int i = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"SELECT * FROM {tableName}where UserName = @UserName and Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", userNameTextBox);
            command.Parameters.AddWithValue("@Password", PasswordTextBox);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            connection.Open();
            sda.Fill(dt);
            connection.Close();
            i = (int)command.ExecuteNonQuery();
            if (i >0)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("UserName or Password is incorrect!!!");
            }


        }
    }
}
