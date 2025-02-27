namespace MultiWindowsForm
{
    public partial class MainForm : Form
    {
        private NewCustomerForm _customerform;
        private List<Customer> _customerList;
        private int customerCount;
        private int CurrentSelectId;
        public MainForm()
        {
            InitializeComponent();
            _customerform = new NewCustomerForm(this);
            _customerList = new List<Customer>();

            _customerList.Add(new Customer { Name = "Test", CustomerId = 0, Email = "Test", PhoneNumber = "Test" });

            ReloadDataGrid();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCustomerForm customerForm = new NewCustomerForm(this);
            _customerform.ShowDialog();
        }
        private void ReloadDataGrid()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _customerList;

        }

     
        public void AddCustomer(Customer customer)
        {
            _customerList.Add(customer);
            ReloadDataGrid();
        }

        public void EditCustomer(int id, Customer updatedCustomer)
        {
            MessageBox.Show("Mainform is editing the customer now.");

            // find the customer out of the list
            // by id
            var cust = _customerList.Find(c => c.CustomerId == id);

            // checking to see if we got a customer to edit

            if (cust != null)
            {
                // found one, process the customer

                cust.Name = updatedCustomer.Name;
                cust.PhoneNumber = updatedCustomer.PhoneNumber;
                cust.Email = updatedCustomer.Email;
                ReloadDataGrid();
            }
        }


        public void LoadCustomer(Customer customer)
        {


        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // create an empty customer
            Customer cust;

            // get the index (position) of the selected customer from the datagrid
            var index = dgvCustomers.SelectedRows[0].Index;

            // use the index to get the customer data out of the list
            cust = _customerList[index];

            // load the customer and toggle editing
            _customerform.LoadCustomer(cust);
            _customerform.ToggleEdit(true);

            // open the form
            _customerform.Show();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }




}
