using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoppelOrderingSystem.Order;
using System.Collections.ObjectModel;
using PoppelOrderingSystem.Database;

namespace PoppelOrderingSystem.Report
{
    public class ExpiredProductReport : Report
    {
        #region Properties
        public Collection<StockItem> expiredProducts;
        public Collection<StockItem> ExpiredProducts
        {
            get
            {
                return expiredProducts;
            }
            set
            {
                expiredProducts = value;
            }
        }
        #endregion
        public ExpiredProductReport(): base()
        {
            ExpiredProducts = new Collection<StockItem>();
        }

        public Collection<StockItem> getStock(String date)
        {

            PoppelDatabase pd = new PoppelDatabase();
            this.ExpiredProducts=pd.readStock(date);
            return expiredProducts;
        }
    }
}
