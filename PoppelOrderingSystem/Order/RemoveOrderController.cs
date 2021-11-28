using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using PoppelOrderingSystem.Report;
using PoppelOrderingSystem.Database;
using PoppelOrderingSystem.CustomerMangement;

namespace PoppelOrderingSystem.Order
{
    public class RemoveOrderController
    {
        public Collection<RemoveOrderItem> products;
        PoppelDatabase pd = new PoppelDatabase();
        private CustomerManangementController customerManagementController;

        public CustomerManangementController CustomerManagementController
        {
            get { return customerManagementController; }
            set { customerManagementController = value; }
        }
        public RemoveOrderController(CustomerManangementController customerManagementController)
        {
            this.customerManagementController = customerManagementController;
            products = new Collection<RemoveOrderItem>();
        }

        public Collection<RemoveOrderItem> getOrders()
        {
            products = pd.getOrders(CustomerManagementController.Customer.Id);
            return products;
        }

        public void Delete(int orderID)
        {
            
            pd.deleteOrder(orderID, CustomerManagementController.Customer.Id);
        }
    }
}
