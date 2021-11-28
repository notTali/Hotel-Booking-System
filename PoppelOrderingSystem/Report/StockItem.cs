using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Report
{
    public class StockItem
    {
        #region Properties
        public String expiryDate;
        public String ExpiryDate
        {
            get
            {
                return expiryDate;
            }
            set
            {
                expiryDate = value;
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
        public String numberInStock;
        public String NumberInStock
        {
            get
            {
                return numberInStock;
            }
            set
            {
                numberInStock = value;
            }
        }
        public String productRef;
        public String ProductRef
           {
                get
            {
                return expiryDate;
            }
            set
            {
                expiryDate = value;
            }
        }
        #endregion
        public StockItem(String expiryDate, String rackNumber, String numberInStock, String productRef)
        {
            this.ExpiryDate = expiryDate;
            this.RackNumber = rackNumber;
            this.NumberInStock = numberInStock;
            this.ProductRef = productRef;
        }

        public StockItem()
        {
            this.ExpiryDate = "";
            this.RackNumber = "";
            this.NumberInStock = "";
            this.ProductRef = "";
        }
    }
}
