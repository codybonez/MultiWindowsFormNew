using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowsForm
{
    public partial class NewCustomerForm : Form
    {
        private MainForm _mainForm;
        private int CustomerCount;
        private bool isEditing;
        private int CurrentCustomerId;
        public NewCustomerForm(MainForm form)
        {
            InitializeComponent();
            
            _mainForm = form;
            CustomerCount = 1;
            isEditing = false;
            CurrentCustomerId = -1;
            
        }

        public void ToggleEdit(bool newState) 
        {
            isEditing = newState; 
        }
        private void CreateCustomer() {
            // validtaion
            if (!CheckValidity()) { 
            
                    
            
                // show an error 
                // return and try again
            }


            // create a customer and load it with the data from the form

            Customer customer = new Customer
            {
                CustomerId = CustomerCount,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
            };
            // send that data to the AddCustomer function on the parent form
            _mainForm.AddCustomer(customer);
            CustomerCount++;

        }

        private bool CheckValidity() {
            // some logic here to validate the various inputs 


            // return if value

            bool somevalue = true;
            return somevalue;
        
            
        }


        private void EditCustomer()
        {


            MessageBox.Show("Form is being edited");
            _mainForm.EditCustomer(CurrentCustomerId, new Customer
            {
                CustomerId = CurrentCustomerId,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
            });

            CurrentCustomerId = -1;
            ToggleEdit(false);

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                EditCustomer();
            }
            else
            {
                CreateCustomer();
            }

                // validtaion

                // create a customer and load it with the data from the form

            
                // close the form if we want to

                Hide();

                // clear the new customer form

                ClearForm();
            
        }
        private void ClearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
        }
        public void LoadCustomer(Customer customer)
        {
            CurrentCustomerId = customer.CustomerId;
            txtName.Text = customer.Name;
            txtEmail.Text = customer.Email;
            txtPhoneNumber.Text = customer.PhoneNumber;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

       
    }
}
