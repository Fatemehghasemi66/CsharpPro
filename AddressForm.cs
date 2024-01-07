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

namespace CsharpPro;

public partial class AddressForm : Form
{
    Address selectedAddress = null;

    private IAddressRepository _addressRepository;
    public AddressForm(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
        InitializeComponent();


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

    private void Address_Load(object sender, EventArgs e)
    {


    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(postalCodeTextBox.Text) || string.IsNullOrEmpty(cityTextBox.Text) || string.IsNullOrEmpty(streetTextBox.Text) || string.IsNullOrEmpty(housenumberTextBox.Text))
            {
                MessageBox.Show("Please enter Valid input");
                return;
            }

            Address address = new Address(
                postalcode: postalCodeTextBox.Text,
                city: cityTextBox.Text,
                street: streetTextBox.Text,
                houseNumber: housenumberTextBox.Text,
                consideration: considerationsTextBox.Text

            );
            int customerId = 0;
            _addressRepository.AddItem(item: address, id: out customerId); ;
            if (customerId == 0)
            {
                MessageBox.Show("No Address Inserted !!");
            }

            MessageBox.Show($"Address Inserted Id: {customerId} ");

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

    private void addressDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (addressDataGridView.SelectedCells.Count > 0)
        {
            var selectedRowindex = addressDataGridView.SelectedCells[0].RowIndex;
            var row = addressDataGridView.Rows[selectedRowindex];
            int id = int.Parse(row.Cells["Id"].Value.ToString());

            Address address = _addressRepository.GetById(id);
            postalCodeTextBox.Text = address.PostalCode;
            cityTextBox.Text = address.City;
            streetTextBox.Text = address.Street;
            housenumberTextBox.Text = address.HouseNumber;
            considerationsTextBox.Text = address.Consideration;
            selectedAddress = address;
        }
    }
}
