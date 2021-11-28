using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoppelOrderingSystem.Domain;
using System.Collections.ObjectModel;
using PoppelOrderingSystem.Order;
using PoppelOrderingSystem.Database;

namespace PoppelOrderingSystem.Report
{
    public class PickingListReport
    {
        #region Properties
        public Collection<ReportItem> productToBePicked;
        public Collection<ReportItem> ProductToBePicked
        {
            get
            {
                return productToBePicked;
            }
            set
            {
                productToBePicked = value;
            }
        }
        #endregion
        private PoppelDatabase pd;
        public PickingListReport()
            : base()
        {
            this.ProductToBePicked = new Collection<ReportItem>();
            pd = new PoppelDatabase();
        }


        public Collection<ReportItem> getOrderProducts(DateTime date)
        {
            ProductToBePicked = pd.readOrderItem(date);
            return ProductToBePicked;
        }
    }
}