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
using PoppelOrderingSystem.Report;

namespace PoppelOrderingSystem.Report
{
    public partial class ExpiredProducts : MetroFramework.Forms.MetroForm
    {
        public Collection<StockItem> products;
        public String date;
        public Collection<StockItem> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }
        ExpiredProductReport expiredController = new ExpiredProductReport();
        public ExpiredProducts()
        {
            this.Products = new Collection<StockItem>();
            InitializeComponent(); 
            productListView.View = View.Details;
            
            dateLabel.Text = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
        }

        private void populateReport(String date)
        {

            productListView.Clear();
            this.Products = expiredController.getStock(date);
            ListViewItem itemDetails;
            dateLabel.Visible = true;
            productListView.Columns.Insert(0, "Rack Number", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(1, "Number In Stock", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(2, "Expiry Date", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(3, "Product Description", 150, HorizontalAlignment.Left);
            productListView.Columns.Insert(4, "Comments", 100, HorizontalAlignment.Left);
            if(products!=null&&products.Count!=0)
            {
                foreach (StockItem item in products)
                {
                    itemDetails = new ListViewItem();
                    itemDetails.Text = item.rackNumber;
                    itemDetails.SubItems.Add(item.numberInStock);
                    itemDetails.SubItems.Add(item.expiryDate);
                    itemDetails.SubItems.Add(item.productRef);
                    itemDetails.SubItems.Add("");
                    productListView.Items.Add(itemDetails);
                }
            }


            productListView.Refresh();
            productListView.GridLines = true;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pickDateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime Date = pickDateCalendar.SelectionRange.Start;
            dateLabel.Text = Date.Year + "-" + Date.Month + "-" + Date.Day;
            pickDateCalendar.Visible = false;
            date = Date.Year + "-" + Date.Month + "-" + Date.Day; 
            Console.WriteLine(date);
            productListView.Visible = true;
            populateReport(date);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ExpiredProducts expiredList = new ExpiredProducts();
            expiredList.MdiParent = this.MdiParent;
            expiredList.StartPosition = FormStartPosition.CenterScreen;
            expiredList.Show();
            this.Close();
        }
        
    }
}
