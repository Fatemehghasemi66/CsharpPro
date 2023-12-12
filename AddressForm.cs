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

namespace CsharpPro
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();

            
        }
       

        private void Address_Load(object sender, EventArgs e)
        {
            Address address = new Address();
            AddressRepository addressRepository = new AddressRepository();
            addressRepository.AddItem(address);
            AddressGridView.DataSource = null;
            AddressGridView.DataSource = addressRepository.GetIAll;
            AddressGridView.Refresh();

        }
    }
}
