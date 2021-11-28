using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelOrderingSystem.Report;
using PoppelOrderingSystem.Order;
using System.Collections.ObjectModel;
using PoppelOrderingSystem.Database;


namespace PoppelOrderingSystem.PresentationLayer
{
    public partial class PickingList : MetroFramework.Forms.MetroForm
    {
        public PickingListReport pickReport;
        private Collection<ReportItem> products;
        private DateTime pickDate = DateTime.Now;
        public PickingList()
        {
            InitializeComponent();
            productListView.View = View.Details;
            pickReport = new PickingListReport();
            products = new Collection<ReportItem>();


        }
        private void pickDateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            pickDate = pickDateCalendar.SelectionRange.Start;
            dateLabel.Text = pickDate.Year + "-" + pickDate.Month + "-" + pickDate.Day;
            products = pickReport.getOrderProducts(pickDate);
            pickNameLabel.Visible = true;
            pickDateLabel.Visible = true;
            pickDateCalendar.Visible = false;
            pickSignLabel.Visible = true;
            selectDateLabel.Visible = false;
            productListView.Visible = true;
            populateForm();
        }

        private void populateForm()
        {
            dateLabel.Visible = true;
            ListViewItem itemDetails;
            PoppelDatabase pd = new PoppelDatabase();
            productListView.Columns.Insert(0, "Rack Number", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(1, "Product ID", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(2, "Product Name", 150, HorizontalAlignment.Left);
            productListView.Columns.Insert(3, "Quantity", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(4, "Order Number", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(5, "Comments", 150, HorizontalAlignment.Left);
            try
            {
                errorLabel.Visible = false;
                foreach (ReportItem item in products)
                {
                    itemDetails = new ListViewItem();
                    itemDetails.Text = item.RackNumber;
                    itemDetails.SubItems.Add(item.ProductID + "");
                    itemDetails.SubItems.Add(item.Description);
                    itemDetails.SubItems.Add(item.Quantity);
                    itemDetails.SubItems.Add(item.OrderID);
                    itemDetails.SubItems.Add("");
                    productListView.Items.Add(itemDetails);
                }
                productListView.Refresh();
                productListView.GridLines = true;
            }
            catch (Exception e)
            {
                errorLabel.Text = "No products to pick on this date";
                errorLabel.Visible = true;

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            PickingList pickList = new PickingList();
            pickList.MdiParent = this.MdiParent;
            pickList.StartPosition = FormStartPosition.CenterScreen;
            pickList.Show();
            this.Close();
        }

        private void PickingList_Load(object sender, EventArgs e)
        {

        }
    }
}