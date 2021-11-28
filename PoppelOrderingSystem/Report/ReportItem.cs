using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Report
{
    public class ReportItem
    {
        public int productID;
        public int ProductID{
            get{
                return productID;
            }
            set{
                productID=value;
            }
        }
        public String orderID;
        public String OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }
        public String rackNumber;
        public String RackNumber
        {
            get
            {
                return rackNumber;
            }
            set
            {
                rackNumber = value;
            }
        }
        public String description;
        public String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public String quantity;
        public String Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public ReportItem(){
            ProductID=0;
            Quantity = "";
            Description = "";
            RackNumber="";
            OrderID="";
        }
    }
}
