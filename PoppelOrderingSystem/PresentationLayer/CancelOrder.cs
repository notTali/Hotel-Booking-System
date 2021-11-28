using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using PoppelOrderingSystem.Order;
using PoppelOrderingSystem.Database;
using PoppelOrderingSystem.CustomerMangement;

namespace PoppelOrderingSystem.PresentationLayer
{
    public partial class CancelOrder : MetroFramework.Forms.MetroForm
    {
        private RemoveOrderController removeOrderController;
        private Collection<RemoveOrderItem> products;
        public CancelOrder(CustomerManangementController customerController)
        {
            InitializeComponent();
            removeOrderController = new RemoveOrderController(customerController);
            ordersListView.View = View.Details;
            products = removeOrderController.getOrders();
            

            setUpListView();
        }

        private void ordersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersListView.SelectedItems.Count == 0)
            {
                removeButton.Enabled = false;
            }
            else
            {
                removeButton.Enabled = true;
            }
        }

        public void setUpListView()
        {
            //Clear current List View Control
            ordersListView.Clear();
            ListViewItem itemDetails;
            //Set Up Columns of List View
            ordersListView.Columns.Insert(0, "Order Number", 95, HorizontalAlignment.Left);
            ordersListView.Columns.Insert(1, "Order Date", 180, HorizontalAlignment.Left);

            try
            {
                errorLabel.Visible = false ;
                if (products != null && products.Count != 0)
                {
                    foreach (RemoveOrderItem item in products)
                    {
                        //Need a way to find out what order this is associated to
                        itemDetails = new ListViewItem();
                        itemDetails.Text = item.orderNumber;
                        itemDetails.SubItems.Add(item.orderDatePlaced);
                        ordersListView.Items.Add(itemDetails);
                    }
                    ordersListView.Refresh();
                    ordersListView.GridLines = true;
                }
                else
                {
                    errorLabel.Text = "No orders for customer!";
                    errorLabel.Visible = true;
                }

            }
            catch(Exception e){
                errorLabel.Text = "No orders for customer!";
                errorLabel.Visible = true;
            }
        
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
            string stringId = ordersListView.FocusedItem.SubItems[0].Text;
            int id;
            if(int.TryParse(stringId,out id))
            {
                 DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this order?", "Confirm Cancel Order", MessageBoxButtons.YesNo);
                 if (dialogResult == DialogResult.Yes)
                 {
                     removeOrderController.Delete(id);
                     products = removeOrderController.getOrders();
                     setUpListView();
                 }
            }

           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement(removeOrderController.CustomerManagementController);
            customerManagement.search(removeOrderController.CustomerManagementController.Customer.Id);
            customerManagement.MdiParent = this.MdiParent;
            customerManagement.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
            customerManagement.Show();
        }
    }
}
