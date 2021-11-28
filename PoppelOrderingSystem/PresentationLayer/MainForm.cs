using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelOrderingSystem.PresentationLayer;
using PoppelOrderingSystem.CustomerMangement;
using PoppelOrderingSystem.Domain;
using PoppelOrderingSystem.Report;

namespace PoppelOrderingSystem
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private CreateCustomer createCustomer;
        private CustomerManagement customerMangement;
        private CustomerManangementController customerManangementController;
        private PickingList pickList;
        private ExpiredProducts expProducts;
        private bool loginClosed;

        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
           
            this.WindowState = FormWindowState.Maximized;
            customerManangementController = new CustomerManangementController();
            
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createCustomer == null)
            {
                createCustomer = new CreateCustomer(customerManangementController);
                createCustomer.MdiParent = this;
                createCustomer.StartPosition = FormStartPosition.CenterScreen;
                createCustomer.Show();
            }
            else if(createCustomer.Visible == false)
            {
                createCustomer = new CreateCustomer(customerManangementController);
                createCustomer.MdiParent = this;
                createCustomer.StartPosition = FormStartPosition.CenterScreen;
                createCustomer.Show();
            }

        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerMangement == null)
            {
                customerMangement = new CustomerManagement(customerManangementController);
                customerMangement.MdiParent = this;
                customerMangement.StartPosition = FormStartPosition.CenterScreen;
                customerMangement.Show();
            }
            else if (customerMangement.Visible == false)
            {
                customerMangement = new CustomerManagement(customerManangementController);
                customerMangement.MdiParent = this;
                customerMangement.StartPosition = FormStartPosition.CenterScreen;
                customerMangement.Show();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginClosed)
            {
                Application.Exit();
            }
        }

        private void generatePickingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pickList = new PickingList();
            pickList.MdiParent = this;
            pickList.StartPosition = FormStartPosition.CenterScreen;
            pickList.Show();
        }

        private void generateExpiredProductsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expProducts = new ExpiredProducts();
            expProducts.MdiParent = this;
            expProducts.StartPosition = FormStartPosition.CenterScreen;
            expProducts.Show();
        }
    }
}
