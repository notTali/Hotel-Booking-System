using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelOrderingSystem.Order;
using PoppelOrderingSystem.Email;


namespace PoppelOrderingSystem.PresentationLayer
{
    public partial class OrderSummary : MetroFramework.Forms.MetroForm
    {
        private PoppelOrderingSystem.Order.OrderController orderController;
        public OrderSummary(PoppelOrderingSystem.Order.OrderController orderController)
        {
            InitializeComponent();
            this.orderController = orderController;
            setUpForm();
        }
        private void setUpForm()
        {
            orderDate.Text = orderController.Order.DateOrderPlaced.ToShortDateString();
            customer.Text = orderController.Order.Customer.nameSurnameToString();
            orderTotalTextBox.Text = "R " + string.Format("{0:0.00}", (orderController.Order.OrderPrice));
            orderTotalTextBox.ReadOnly = true;

            OrderListView.View = View.Details;
            string addressInfo = orderController.Order.Customer.addressToMulilineString();
            addressTextBox.Text = addressInfo;
            addressTextBox.ReadOnly = true;
            deliveryTimeStart.Text = orderController.Order.DeliveryDetails.StartDeliveryTime.ToShortTimeString();
            deliveryTimeEnd.Text = orderController.Order.DeliveryDetails.EndDeliveryTime.ToShortTimeString();
            setUpShoppingCartListView();
            foreach (OrderItem item in orderController.Order.Products)
            {
                addToOrder(item);
            }
            deliveryDaysTextBox.Text = ""+orderController.Order.DeliveryDetails.AllowedDeliveryDates[0].DayOfWeek;
            DateDeliveryTextBox.Text = orderController.Order.DeliveryDetails.AllowedDeliveryDates[0].ToShortDateString();
            for(int i=1;i<orderController.Order.DeliveryDetails.AllowedDeliveryDates.Count;i++)
            {
                deliveryDaysTextBox.AppendText("\r\n" + orderController.Order.DeliveryDetails.AllowedDeliveryDates[i].DayOfWeek);
                DateDeliveryTextBox.AppendText("\r\n" + orderController.Order.DeliveryDetails.AllowedDeliveryDates[i].ToShortDateString());
            }
            deliveryDaysTextBox.ReadOnly = true;
            DateDeliveryTextBox.ReadOnly = true;


        }

        public void setUpShoppingCartListView()
        {
            //Clear current List View Control
            OrderListView.Clear();
            //Set Up Columns of List View
            OrderListView.Columns.Insert(0, "Product", 130, HorizontalAlignment.Left);
            OrderListView.Columns.Insert(1, "Quantity", 55, HorizontalAlignment.Left);
            OrderListView.Columns.Insert(2, "Item Cost", 80, HorizontalAlignment.Left);
            OrderListView.Columns.Insert(3, "Item Total", 80, HorizontalAlignment.Left);
            OrderListView.Columns.Insert(4, "", 0, HorizontalAlignment.Left);
            OrderListView.Refresh();
            OrderListView.GridLines = true;
        }
        public void addToOrder(OrderItem orderItem)
        {
            ListViewItem orderItemDetails;
            orderItemDetails = new ListViewItem();
            orderItemDetails.Text = "" + orderItem.Product.Description;
            orderItemDetails.SubItems.Add("" + orderItem.Quantity);
            orderItemDetails.SubItems.Add("R " + string.Format("{0:0.00}", (orderItem.Product.Price)));
            orderItemDetails.SubItems.Add("R " + string.Format("{0:0.00}", (orderItem.Quantity * orderItem.Product.Price)));
            
            orderItemDetails.SubItems[0].Tag = orderItem.Product.Id;
            OrderListView.Items.Add(orderItemDetails);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            //EmailController.sendEmail(orderController.Order.Customer, "Poppel Order Confimation", EmailController.createEmailTemplete(orderController.Order));
            OrderCreated success = new OrderCreated();
            success.MdiParent = this.MdiParent;
            success.Show();
            orderController.submitOrder();
            this.Close();

        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this order?", "Confirm Cancel Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CreateDelivery delivery = new CreateDelivery(orderController);
            int startTime = -1;
            int endTime = -1;
            int hour=8;
            for (int i = 0; i <= orderController.Order.DeliveryDetails.EndDeliveryTime.Hour;i++,hour++ )
            {
                if(hour==orderController.Order.DeliveryDetails.StartDeliveryTime.Hour)
                {
                    startTime = i;
                }

            }
            hour = 9;
            for (int i = 0; i <= orderController.Order.DeliveryDetails.EndDeliveryTime.Hour; i++, hour++)
            {
                if (hour == orderController.Order.DeliveryDetails.EndDeliveryTime.Hour)
                {
                    endTime = i-1;
                }
            }
            
                 delivery.setDropDownlists(startTime, endTime);
                delivery.setCheckBoxes(orderController.Order.DeliveryDetails.AllowedDeliveryDates);
            delivery.MdiParent = this.MdiParent;
            delivery.StartPosition = FormStartPosition.CenterScreen;
            delivery.Show();
            this.Close();
            
        }

        private void employee_Click(object sender, EventArgs e)
        {

        }
    }
}
