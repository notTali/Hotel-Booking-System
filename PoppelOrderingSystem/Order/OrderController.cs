using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoppelOrderingSystem.Domain;
using PoppelOrderingSystem.Database;
using System.Windows.Forms;
using PoppelOrderingSystem.PresentationLayer;
using PoppelOrderingSystem.CustomerMangement;

namespace PoppelOrderingSystem.Order
{
    public class OrderController
    {
        private Collection<OrderItem> products;
        private PoppelDatabase database;
        private decimal orderTotal;
        private Collection<OrderItemForm> displayedProducts;
        private Collection<OrderItemForm> allProducts;
        private Collection<Category> categories;
        private Order order;
        private Collection<OrderItem> orderItems;
        private Customer customer;
        private Employee employee;
        private CustomerManangementController customerManagementController;

        public CustomerManangementController CustomerManagementController
        {
            get { return customerManagementController; }
            set { customerManagementController = value; }
        }


        public Order Order
        {
            get { return order; }
            set { order = value; }
        }

        public Collection<OrderItem> OrderItems
        {
            get { return orderItems; }
            set { orderItems = value; }
        }

        public Collection<OrderItemForm> AllProducts
        {
            get { return allProducts; }
            set { allProducts = value; }
        }

        public Collection<OrderItemForm> DisplayedProducts
        {
            get { return displayedProducts; }
            set
            {

                displayedProducts = value;

            }
        }

        public Collection<Category> getCategories()
        {
            if (categories==null||categories.Count==0)
            {
                categories = database.readCategories();
            }
            return categories;
        }

        public decimal OrderTotal
        {
            get
            {
                return orderTotal;
            }
            set
            {
                orderTotal = value;
            }
        }

        public OrderController(Customer customer, Employee employee)
        {

            products = new Collection<OrderItem>();
            database = new PoppelDatabase();
            allProducts = new Collection<OrderItemForm>();
            categories = new Collection<Category>();
            order = new Order();
            orderTotal = 0;
            orderItems = new Collection<OrderItem>();
            this.employee = employee;
            this.customer = customer;
        }

        public Collection<OrderItem> getProducts()
        {
            setProducts();
            return products;
        }
        public static OrderItemForm getClickedForm(int id, Collection<OrderItemForm> orderItemForms)
        {
            OrderItemForm returnForm = null;
            bool stop = false;
            int i = 0;
            while (stop != true && i < orderItemForms.Count)
            {
                if (orderItemForms[i].Id == id)
                {
                    returnForm = orderItemForms[i];
                    stop = true;
                }
                i++;

            }
            return returnForm;
        }

        public void setAlternatives(int id)
        {

            OrderItemForm clickedForm = OrderController.getClickedForm(id, displayedProducts);

            for (int i = 0; i < allProducts.Count; i++)
            {
                if (!allProducts[i].Equals(clickedForm))
                {
                    allProducts[i].SimilarFilterCheckBox.Checked = false;
                }
            }

            Collection<OrderItemForm> alternativesForm = new Collection<OrderItemForm>();
            Collection<Product> alternatives;
            if (clickedForm.RefOrderItem.Product.Alternatives != null)
            {
                alternatives = clickedForm.RefOrderItem.Product.Alternatives;
            }
            else
            {
                alternatives = new Collection<Product>();
            }

            foreach (OrderItemForm alternative in displayedProducts)
            {
                if (alternative.Equals(clickedForm))
                {
                    alternativesForm.Add(clickedForm);
                }
                foreach (Product product in alternatives)
                {

                    if (alternative.RefOrderItem.Product.Id == product.Id)
                    {
                        alternativesForm.Add(alternative);
                    }
                }

            }

            displayedProducts = alternativesForm;


        }

        public void unSetAlternatives(int id)
        {
            OrderItemForm clickedForm = OrderController.getClickedForm(id, displayedProducts);
            displayedProducts.Clear();
            foreach (OrderItemForm orderItemForm in allProducts)
            {
                displayedProducts.Add(orderItemForm);
            }
        }

        private void setProducts()
        {
            products = database.readProducts();
            foreach (OrderItem orderItem in products)
            {
                orderItem.Quantity = 1;
            }
        }

        public static OrderItem getProduct(int id, Collection<OrderItem> products)
        {
            OrderItem returnProduct = null;
            bool stop = false;
            int i = 0;
            while (stop != true && i < products.Count)
            {
                if (products[i].Product.Id == id)
                {
                    returnProduct = products[i];
                    stop = true;
                }
                i++;
            }

            return returnProduct;

        }

        public void clearFilters()
        {
            displayedProducts.Clear();
            foreach (OrderItemForm orderItemForm in allProducts)
            {
                orderItemForm.SimilarFilterCheckBox.Checked = false;
                displayedProducts.Add(orderItemForm);
            }
        }

        public void setCategory(string category)
        {
            displayedProducts.Clear();
            foreach (OrderItemForm orderItemForm in allProducts)
            {
                displayedProducts.Add(orderItemForm);
            }
            if(!category.Equals("All")&&!category.Equals(""))
            {
                Collection<OrderItemForm> categoriesForm = new Collection<OrderItemForm>();
                Collection<Product> alternatives;

                foreach (OrderItemForm categoryForm in displayedProducts)
                {
                    int index = 0;
                    bool added = false;
                    while (!added && index < categoryForm.RefOrderItem.Product.Categories.Count)
                    {
                        if (categoryForm.RefOrderItem.Product.Categories[index].Category_description.Equals(category))
                        {
                            added = true;
                            categoriesForm.Add(categoryForm);
                        }
                        index++;
                    }


                }

                displayedProducts = categoriesForm;

            }
           


        }

        public void checkOut()
        {
           order.OrderPrice = OrderTotal;
           order.Products = OrderItems;
           order.DateOrderPlaced = DateTime.Now;
           order.CurrentOrderStatus = Order.OrderStatus.open;
           order.Customer = customer;
           //order.Employee = employee;


        }

        public void submitOrder()
        {
            database.writeOrder(order);
        }

        public Customer Customer
        {
            get => default;
            set
            {
            }
        }
    }
}
