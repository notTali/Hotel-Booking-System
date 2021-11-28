using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoppelOrderingSystem.Domain;

namespace PoppelOrderingSystem.Order
{
    public class Order
    {
        private Collection<OrderItem> products = new Collection<OrderItem>();
        private DateTime dateOrderPlaced;
        private Customer customer;
        private Employee employee;
        private int orderId;
        private OrderStatus orderStatus;
        private decimal orderPrice;
        private Delivery deliveryDetails;


        public enum OrderStatus
        {
            open = 0, awitingPayment = 1, awaitingDelivery = 2, delivered = 3, archived = 4
        };
        
        //Etc.

        #region Properties

        public Delivery DeliveryDetails
        {
            get { return deliveryDetails; }
            set { deliveryDetails = value; }
        }
        public decimal OrderPrice
        {
            get { return orderPrice; }
            set { orderPrice = value; }
        }

        public OrderStatus CurrentOrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        public Collection<OrderItem> Products
        {
            get { return products; }
            set { products = value; }
        }
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public DateTime DateOrderPlaced
        {
            get { return dateOrderPlaced; }
            set { dateOrderPlaced = value; }
        }
        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        public decimal getVat()
        {
            return decimal.Divide(OrderPrice, 0.14m);
        }
        public decimal getOrderTotal()
        {
            return decimal.Add(OrderPrice, getVat());
        }

        #endregion
    }
}
