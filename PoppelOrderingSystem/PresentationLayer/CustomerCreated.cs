using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelOrderingSystem.CustomerMangement;
using PoppelOrderingSystem.Domain;

namespace PoppelOrderingSystem.PresentationLayer
{
    public partial class CustomerCreated : MetroFramework.Forms.MetroForm
    {
        public Collection<Customer> customers;
        private MainForm form;
        public Collection<Customer> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                customers = value;
            }
        }

        private CustomerManangementController customerController;


        public CustomerCreated(CustomerManangementController controller)
        {
            this.Customers = new Collection<Customer>();
            InitializeComponent();
            customerController = controller;
            customerNumberTextBox.Text = customerController.Customer.Id;
            customersListView.View = View.Details;
        }

        private void populateCustomers()
        {
            customersListView.Clear();
            this.Customers = customerController.GetAllCustomers();
            ListViewItem itemDetails;

            customersListView.Columns.Insert(0, "CustomerID", 100, HorizontalAlignment.Left);
            customersListView.Columns.Insert(1, "First Name", 100, HorizontalAlignment.Left);
            customersListView.Columns.Insert(2, "Last Name", 150, HorizontalAlignment.Left);
            customersListView.Columns.Insert(3, "Phone Number", 100, HorizontalAlignment.Left);
            customersListView.Columns.Insert(4, "Email Address", 100, HorizontalAlignment.Left);

            if (customers != null && customers.Count != 0)
            {
                foreach (Customer customer in customers)
                {
                    itemDetails = new ListViewItem();
                    itemDetails.Text = customer.Id;
                    itemDetails.SubItems.Add(customer.Name);
                    itemDetails.SubItems.Add(customer.Surname);
                    itemDetails.SubItems.Add(customer.PhoneNumber);
                    itemDetails.SubItems.Add(customer.Email);
                    customersListView.Items.Add(itemDetails);
                }
            }

            customersListView.Refresh();
            customersListView.GridLines = true;

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerCreatedForm_Load(object sender, EventArgs e)
        {
            form = (MainForm)this.MdiParent;//Add this line ONLY to Load
            customersListView.View = View.Details;
            populateCustomers();
        }

        private void CustomerCreatedForm_Activated(object sender, EventArgs e)
        {
            customersListView.View = View.Details;
            populateCustomers();
        }
    }
}
