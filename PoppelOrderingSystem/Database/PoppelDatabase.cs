using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

//namespaces
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using PoppelOrderingSystem.Domain;
using PoppelOrderingSystem.Order;
using PoppelOrderingSystem.Report;
using System.Windows.Forms;


namespace PoppelOrderingSystem.Database
{
    public class PoppelDatabase : Database
    {
        private Collection<Category> categories;
        private Collection<StockItem> items;
        public bool doesKeyExist(string id)
        {
            SqlDataReader reader;
            SqlCommand command;
            bool exists = false;
            try
            {
                command = new SqlCommand("SELECT TOP 1 customer_id FROM Customer WHERE customer_id = '" + id + "'", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    exists = true;
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return exists;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return true;
            }

        }

        public void addCustomer(Customer customer)
        {
            string sqlString = "";
            sqlString = "INSERT INTO Customer(customer_id,customer_name,customer_surname,customer_telephoneNumber,customer_email,customer_credit,customer_creditLimit,customer_street,customer_suburb,customer_town,customer_city,customer_zipCode) VALUES ('" + customer.Id.Trim() + "','" + customer.Name.Trim() + "','" + customer.Surname.Trim() + "','" + customer.PhoneNumber.Trim() + "','" + customer.Email.Trim() + "'," + customer.Credit.ToString() + "," + customer.CreditLimit.ToString() + ",'" + customer.Address[0].Trim() + "','" + customer.Address[1] + "','" + customer.Address[2] + "','" + customer.Address[3] + "','" + customer.Address[4] + "')";

            UpdateDataSource(new SqlCommand(sqlString, cnMain));
        }


        public Collection<Customer> readAllCustomers() {
            Collection<Customer> customers = new Collection<Customer>();
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                command = new SqlCommand("SELECT * FROM Customer", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        customers.Add(createCustomer(reader));             //add to the collection
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return null;
            }

        }

        /// <summary>
        /// Reads customers from database with argument telephone number.
        /// </summary>
        /// <param name="telephoneNumber">telephone number to check against</param>
        /// <returns>collection of customers with specified telephone number</returns>
        public Collection<Customer> readCustomersByTelephoneNumber(string telephoneNumber)
        {
            Collection<Customer> customers = new Collection<Customer>();
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                command = new SqlCommand("SELECT * FROM Customer WHERE customer_telephoneNumber = '" + telephoneNumber + "'", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        customers.Add(createCustomer(reader));             //add to the collection
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Reads customers from database with argument customer number.
        /// </summary>
        /// <param name="id">customer number to check against.</param>
        /// <returns>Customer with specified customer number.</returns>
        public Customer readCustomersByCustomerNumber(string id)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                Customer customer = null;
                command = new SqlCommand("SELECT * FROM Customer WHERE customer_id = '" + id + "'", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        customer = createCustomer(reader);
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return customer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return null;
            }
        }

        public Collection<OrderItem> readProducts()
        {
            Collection<OrderItem> products = new Collection<OrderItem>();
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                command = new SqlCommand("SELECT * FROM Product", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrderItem orderItem = new OrderItem();
                        orderItem.Product = createProduct(reader);
                        products.Add(orderItem);

                    }


                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                readAlternatives(products);
                readCategories(products);
                foreach (OrderItem product in products)
                {
                    setStockCount(product.Product);
                }

                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return null;
            }



        }

        public Collection<ReportItem> readOrderItem(DateTime date)
        {
            Collection<ReportItem> products = new Collection<ReportItem>();
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                command = new SqlCommand("SELECT orderItem_id FROM OrderItem", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                int orderId = -1;//Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int orderItem_id = reader.GetInt32(0);
                        int stockItem_id;
                        SqlConnection connection = newConnection();
                        SqlCommand currentCommand = new SqlCommand("SELECT stockItem_id,item_quantity FROM OrderStockItem WHERE orderItem_id = " + orderItem_id, connection);
                        connection.Open();
                        currentCommand.CommandType = CommandType.Text;
                        SqlDataReader reader2 = currentCommand.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                ReportItem orderItem = new ReportItem();
                                

                                stockItem_id = reader2.GetInt32(0);
                                int quantity = reader2.GetInt32(1);

                                SqlConnection connection2 = newConnection();
                                SqlCommand currentCommand2 = new SqlCommand("SELECT product_ref FROM StockItem WHERE stockItem_id = " + stockItem_id , connection2);
                                connection2.Open();
                                currentCommand2.CommandType = CommandType.Text;
                                SqlDataReader reader3 = currentCommand2.ExecuteReader();
                                int product_id=-1;
                                if (reader3.HasRows)
                                {
                                    if(reader3.Read())
                                    {
                                        product_id = reader3.GetInt32(0);
                                        orderItem.ProductID = product_id;
                                    }
                                }
                                reader3.Close();
                                connection2.Close();


                                orderId = this.getOrderNumber(orderItem_id);
                                orderItem.OrderID = orderId + "";
                                orderItem.Quantity = "" + quantity;
                                orderItem.Description = this.getDescription(product_id);
                                orderItem.RackNumber = this.getRackNumber(stockItem_id);

                                  if (this.getOrderDate(orderId,date))
                        {
                            products.Add(orderItem);
                        }
                            }
                        }
                        reader2.Close();
                        connection.Close();




                        

                      
                    }


                }
                reader.Close();   //close the reader
                cnMain.Close();  //close the connectio

                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return null;
            }



        }

        public int getOrderNumber(int ID)
        {
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                SqlConnection connection = newConnection();
                command = new SqlCommand("SELECT order_id FROM OrderItem WHERE orderItem_id = " + ID + ";", connection);
                connection.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                int number = 0;
                //Read from table
                if (reader.HasRows)
                {
                    reader.Read();
                    number = reader.GetInt32(0);
                }
                reader.Close();   //close the reader
                connection.Close();  //close the connection
                return number;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return 0;

        }

        public bool getOrderDate(int ID, DateTime checkDate)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                SqlConnection conn = newConnection();
                command = new SqlCommand("SELECT delivery_id FROM Delivery WHERE order_id = " + ID, conn);
                conn.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                bool found = false;
                //Read from table
                if (reader.HasRows)
                {
                    reader.Read();
                    int delivery_id =reader.GetInt32(0);
                    SqlConnection connection = newConnection();
                    SqlCommand currentCommand = new SqlCommand("SELECT delivery_date FROM DeliveryDate WHERE delivery_id = " + delivery_id, connection);
                    connection.Open();
                    currentCommand.CommandType = CommandType.Text;
                    SqlDataReader reader2 = currentCommand.ExecuteReader();
                    
                    if(reader2.HasRows)
                    {
                        while (!found && reader2.Read())
                        {
                            DateTime date = reader2.GetDateTime(0);
                            if(date.ToShortDateString().Equals(checkDate.ToShortDateString()))
                            {
                                found = true;
                            }
                        }
                    }
                    reader2.Close();
                    connection.Close();
                }
                reader.Close();   //close the reader
                conn.Close();  //close the connection
                return found;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return false;

        }
        private void readAlternatives(Collection<OrderItem> products)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                foreach (OrderItem product in products)
                {
                    command = new SqlCommand("SELECT alternative_product_id FROM Alternatives WHERE product_id=" + product.Product.Id, cnMain);
                    cnMain.Open();             //open the connection
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    //Read from table
                    if (reader.HasRows)
                    {
                        product.Product.Alternatives = new Collection<Product>();
                        while (reader.Read())
                        {
                            OrderItem alternative = OrderController.getProduct(reader.GetInt32(0), products);
                            Product alternativeProduct = alternative.Product;
                            product.Product.Alternatives.Add(alternativeProduct);
                        }
                    }
                    reader.Close();   //close the reader 
                    cnMain.Close();  //close the connection

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
        }

        private void readCategories(Collection<OrderItem> products)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                if (categories == null)
                {
                    readCategories();
                }
                foreach (OrderItem product in products)
                {
                    command = new SqlCommand("SELECT category_id FROM ProductCategory WHERE product_id=" + product.Product.Id, cnMain);
                    cnMain.Open();             //open the connection
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    //Read from table
                    if (reader.HasRows)
                    {
                        product.Product.Categories = new Collection<Category>();
                        while (reader.Read())
                        {
                            int category_id = reader.GetInt32(0);
                            Boolean added = false;
                            int index = 0;
                            while (!added && index < categories.Count)
                            {
                                if (categories[index].Category_id == category_id)
                                {
                                    product.Product.Categories.Add(categories[index]);
                                    added = true;
                                }
                                index++;
                            }
                        }
                    }
                    reader.Close();   //close the reader 
                    cnMain.Close();  //close the connection

                }
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
        }

        private Product createProduct(SqlDataReader reader)
        {
            Product product = new Product();
            product.Id = reader.GetInt32(0);
            product.Description = reader.GetString(1).Trim();
            product.Price = reader.GetDecimal(2);
            product.ProductCode = reader.GetString(3).Trim();
            return product;
        }


        private void setStockCount(Product product)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                //DateTime check = DateTime.Now.AddMonths(1);
                command = new SqlCommand("SELECT SUM(stockItem_numberInStock) AS number_in_stock FROM StockItem WHERE product_ref = " + product.Id , cnMain); //+ " AND DATEDIFF(day, '" + check.ToString() + "',stockItem_expityDate) >= 0"
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        if (reader.IsDBNull(0))
                        {
                            product.NumberInStock = 0;
                        }
                        else
                        {
                            product.NumberInStock = reader.GetInt32(0);
                        }

                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
        }

        public void editCustomer(Customer customer)
        {
            string sqlString = "";
            sqlString = "Update Customer Set customer_name = '" + customer.Name.Trim() + "',customer_surname = '" + customer.Surname.Trim() + "',customer_telephoneNumber = '" + customer.PhoneNumber.Trim() + "',customer_email = '" + customer.Email.Trim() + "',customer_credit = " + customer.Credit.ToString() + ",customer_creditLimit = " + customer.CreditLimit.ToString() + ",customer_street = '" + customer.Address[0].Trim() + "',customer_suburb = '" + customer.Address[1] + "',customer_town = '" + customer.Address[2] + "',customer_city = '" + customer.Address[3] + "',customer_zipCode = '" + customer.Address[4] + "' WHERE (customer_id = '" + customer.Id.Trim() + "')";

            UpdateDataSource(new SqlCommand(sqlString, cnMain));
        }

        /// <summary>
        /// Create customer from argument reader.
        /// </summary>
        /// <param name="reader">reads data from database</param>
        private Customer createCustomer(SqlDataReader reader)
        {

            Customer customer = new Customer();
            customer.Id = reader.GetString(0).Trim();
            customer.Name = reader.GetString(1).Trim();
            customer.Surname = reader.GetString(2).Trim();
            if (!reader.IsDBNull(3))
            {
                customer.PhoneNumber = reader.GetString(3).Trim();
            }
            if (!reader.IsDBNull(4))
            {
                customer.Email = reader.GetString(4).Trim();
            }
            customer.Credit = reader.GetDecimal(5);
            customer.CreditLimit = reader.GetDecimal(6);
            string[] address = new string[5];

            if (!reader.IsDBNull(7))
            {
                address[0] = reader.GetString(7).Trim();
            }
            if (!reader.IsDBNull(8))
            {
                address[1] = reader.GetString(8).Trim();
            }
            if (!reader.IsDBNull(9))
            {
                address[2] = reader.GetString(9).Trim();
            }
            if (!reader.IsDBNull(10))
            {
                address[3] = reader.GetString(10).Trim();
            }
            if (!reader.IsDBNull(11))
            {
                address[4] = reader.GetString(11).Trim();
            }
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == null)
                {
                    address[i] = "";
                }
            }
            customer.Address = address;
            return customer;
        }

        public Collection<Category> readCategories()
        {
            SqlDataReader reader;
            SqlCommand command;
            Collection<Category> categories;
            try
            {
                command = new SqlCommand("SELECT * FROM Category", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                categories = new Collection<Category>();
                //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category category = new Category();
                        category.Category_id = reader.GetInt32(0);
                        category.Category_description = reader.GetString(1);
                        categories.Add(category);
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                this.categories = categories;
                return categories;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return null;
        }

       

        public DateTime getOrderDate(String ID)
        {
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                command = new SqlCommand("SELECT order_datePlaced FROM Order WHERE order_id = '" + ID + "';", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                DateTime date = DateTime.Today;
                //Read from table
                if (reader.HasRows)
                {
                    date = reader.GetDateTime(1);
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return date;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return DateTime.Today;

        }

        public void removeOrder(String ID)
        {
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                command = new SqlCommand("DELETE FROM Order WHERE order_id = '" + ID + "';", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();

                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }


        }

        public String getRackNumber(int ID)
        {
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                SqlConnection connection = newConnection();
                command = new SqlCommand("SELECT stockItem_rackNumber FROM StockItem WHERE stockItem_id = " + ID + ";", connection);
                connection.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                string number = "";
                //Read from table
                if (reader.HasRows)
                {
                    reader.Read();
                    number = reader.GetString(0);
                }
                reader.Close();   //close the reader 
                connection.Close();  //close the connection
                return number + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
              //  connection.Close();
                Console.Write(ex.ToString());
            }
            return null;

        }

        public String getQuantity(int ID)
        {
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                SqlConnection connection = newConnection();
                command = new SqlCommand("SELECT product_quantity FROM OrderItem WHERE product_id = " + ID + ";", connection);
                connection.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                int number = 0;
                //Read from table
                if (reader.HasRows)
                {
                    number = reader.GetInt32(1);
                }
                reader.Close();   //close the reader 
                connection.Close();  //close the connection
                return number + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
              //  connection.Close();
                Console.Write(ex.ToString());
            }
            return null;

        }

        public String getDescription(int ID)
        {
            SqlDataReader reader;
            SqlCommand command;
            
            try
            {
                SqlConnection connection = newConnection();
                command = new SqlCommand("SELECT product_description FROM Product WHERE product_id = " + ID + ";", connection);
                connection.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                String descritpion = "";
                //Read from table
                if (reader.HasRows)
                {
                    reader.Read();
                    descritpion = reader.GetString(0);
                }
                reader.Close();   //close the reader 
                connection.Close();  //close the connection
                return descritpion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                Console.Write(ex.ToString());
            }
            return null;

        }

        public Collection<StockItem> readStock(String Date)
        {
            SqlDataReader reader;
            SqlCommand command;
            Collection<StockItem> items;
            try
            {
                DateTime input;
                DateTime.TryParse(Date, out input);
                command = new SqlCommand("SELECT * FROM StockItem WHERE DATEDIFF(day, stockItem_expityDate,'" + input.ToString() + "') >= 0 ORDER BY stockItem_rackNumber", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                items = new Collection<StockItem>();
                //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        StockItem item = new StockItem();
                        item.expiryDate = reader.GetDateTime(1).ToShortDateString();
                        item.rackNumber = reader.GetString(2);
                        item.numberInStock = reader.GetInt32(3) + "";
                        item.productRef = reader.GetInt32(4) + "";
                        SqlConnection connection = newConnection();
                        SqlCommand command2 = new SqlCommand("SELECT product_description FROM Product WHERE product_id = " + item.productRef + ";", connection);
                        connection.Open();             //open the connection
                        command2.CommandType = CommandType.Text;
                        SqlDataReader reader2 = command2.ExecuteReader();
                        String descritpion = "";
                        //Read from table
                        if (reader2.HasRows)
                        {
                            reader2.Read();
                            descritpion = reader2.GetString(0);
                        }
                        reader2.Close();   //close the reader 
                        connection.Close();  //close the connection
                        item.productRef = descritpion;
                        items.Add(item);
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                this.items = items;
                return items;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return null;
        }   

        public Collection<RemoveOrderItem> getOrders(string customerId)
        {
            SqlDataReader reader;
            SqlCommand command;
            Collection<RemoveOrderItem> oItems;
            try
            {
                command = new SqlCommand("SELECT order_id,order_datePlaced FROM [Order] WHERE customer_id = '"+customerId+"' AND order_status = 'Open'",cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                oItems = new Collection<RemoveOrderItem>();
                //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        RemoveOrderItem rm = new RemoveOrderItem();
                        rm.orderNumber = reader.GetInt32(0)+"";
                        rm.orderDatePlaced = reader.GetDateTime(1)+"";
                        oItems.Add(rm);
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return oItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return null;
        }

        public void writeOrder(PoppelOrderingSystem.Order.Order order)
        {
            string sqlString = "";
            sqlString = "INSERT INTO [Order](order_datePlaced,customer_id) OUTPUT INSERTED.order_id VALUES ('" + order.DateOrderPlaced.ToString() + "','" + order.Customer.Id.Trim() + "')";

            SqlDataReader reader;
            SqlCommand command;
            try
            {
                command = new SqlCommand(sqlString, cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                //Read from table
                int id = -1;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();

                if (id != -1)
                    for (int i = 0; i < order.Products.Count; i++)
                    {
                        sqlString = "INSERT INTO [OrderItem](order_id,product_quantity) OUTPUT INSERTED.orderItem_id VALUES (" + id + "," + order.Products[i].Quantity + ")";
                        cnMain.Open();
                        command = new SqlCommand(sqlString, cnMain);
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                        //Read from table
                        int orderItemId = -1;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                orderItemId = reader.GetInt32(0);
                            }
                        }
                        cnMain.Close();
                        reader.Close();   //close the reader 

                        DateTime check = DateTime.Now;
                        check = check.AddMonths(1);
                        sqlString = "SELECT stockItem_id,stockItem_numberInStock FROM StockItem WHERE DATEDIFF(day, '" + check.ToString() + "',stockItem_expityDate) >= 0 AND product_ref = " + order.Products[i].Product.Id + " AND stockItem_numberInStock>0 order by convert(datetime, stockItem_expityDate, 103) ASC";
                        command = new SqlCommand(sqlString, cnMain);
                        cnMain.Open();             //open the connection
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                        //Read from table
                        int stockItemID = -1;
                        bool done = false;
                        if (reader.HasRows)
                        {
                            int reduceCounter = order.Products[i].Quantity;
                            while (reader.Read() &&reduceCounter!=0)
                            {

                                stockItemID = reader.GetInt32(0);
                                int numInStock = reader.GetInt32(1);
                                int reductionAmount;
                                if (numInStock >= reduceCounter)
                                {
                                    done = true;
                                    reductionAmount = reduceCounter;
                                    reduceCounter -= reductionAmount;
                                }
                                else
                                {
                                    reductionAmount = numInStock;
                                    reduceCounter -= reductionAmount;
                                   
                                }
                                SqlConnection connection = newConnection();

                                SqlCommand currentCommand = new SqlCommand("INSERT INTO OrderStockItem(orderItem_id,stockItem_id, item_quantity) VALUES(" + orderItemId + "," + stockItemID + "," + reductionAmount + ")", connection);
                                currentCommand.CommandType = CommandType.Text;
                                connection.Open();
                                currentCommand.ExecuteNonQuery();
                                connection.Close();

                                currentCommand = new SqlCommand("Update StockItem Set stockItem_numberInStock = stockItem_numberInStock - " + reductionAmount + "WHERE stockItem_id = " + stockItemID, connection);
                                currentCommand.CommandType = CommandType.Text;
                                connection.Open();
                                currentCommand.ExecuteNonQuery();

                                connection.Close();


                            }
                        }
                        reader.Close();   //close the reader 
                        cnMain.Close();
                       

                    }
                sqlString = "INSERT INTO [Delivery](delivery_startTime,delivery_endTime,order_id) OUTPUT INSERTED.delivery_id VALUES ('" + order.DeliveryDetails.StartDeliveryTime.ToString() + "','" + order.DeliveryDetails.EndDeliveryTime.ToString() + "'," + id + ")";
                cnMain.Open();
                command = new SqlCommand(sqlString, cnMain);
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                //Read from table
                int deliveryId = -1;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        deliveryId = reader.GetInt32(0);
                    }
                }
                cnMain.Close();
                reader.Close();   //close the reader 
                for (int i = 0; i < order.DeliveryDetails.AllowedDeliveryDates.Count; i++)
                {
                    sqlString = "INSERT INTO [DeliveryDate](delivery_id,delivery_date) VALUES (" + deliveryId + ",'" + order.DeliveryDetails.AllowedDeliveryDates[i].ToString() + "')";
                    UpdateDataSource(new SqlCommand(sqlString, cnMain));
                }

                cnMain.Close();  //close the connection
                 sqlString = "UPDATE CUSTOMER SET customer_credit = customer_credit + "+ Math.Round(order.OrderPrice, 2) + " WHERE stockItem_id = " + order.Customer.Id.Trim();
                        command = new SqlCommand(sqlString, cnMain);
                        cnMain.Open();             //open the connection
                        Console.WriteLine(Math.Round(order.OrderPrice,2));
                        //command.ExecuteNonQuery();
                        cnMain.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
        }

       
        public void deleteOrder(int orderId,string customerId)
        {
            string sqlString = "";
          
            SqlDataReader reader;
            SqlCommand command;
            try
            {

                sqlString = "SELECT product_quantity,orderItem_id FROM OrderItem Where order_id = '" + orderId + "'";
                command = new SqlCommand(sqlString, cnMain);
                cnMain.Open();
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                decimal payBack = 0;
                //Read from table

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int product_quantity = reader.GetInt32(0);
                        int orderItem_id = reader.GetInt32(1);
                        SqlConnection connection = newConnection();

                        SqlCommand currentCommand = new SqlCommand("SELECT stockItem_id, item_quantity FROM OrderStockItem WHERE orderItem_id = " + orderItem_id, connection);
                        connection.Open();
                        currentCommand.CommandType = CommandType.Text;
                        SqlDataReader reader2 = currentCommand.ExecuteReader();
                        int stockItem_id=-1;
                        int item_quantity;
                        if (reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                stockItem_id = reader2.GetInt32(0);
                                item_quantity = reader2.GetInt32(1);
                                SqlConnection updateStockConnection = newConnection();

                                SqlCommand updateStockCommand = new SqlCommand("UPDATE StockItem Set stockItem_numberInStock = stockItem_numberInStock + " + item_quantity + " WHERE stockItem_id = " + stockItem_id, updateStockConnection);
                                updateStockConnection.Open();
                                updateStockCommand.CommandType = CommandType.Text;
                                updateStockCommand.ExecuteNonQuery();
                                updateStockConnection.Close();
                            }
                        }
                        connection.Close();
                        reader2.Close();
                        currentCommand = new SqlCommand("DELETE FROM OrderStockItem WHERE orderItem_id = " + orderItem_id, connection);
                        connection.Open();
                        currentCommand.CommandType = CommandType.Text;
                        currentCommand.ExecuteNonQuery();
                        connection.Close();

                        currentCommand = new SqlCommand("SELECT product_ref FROM StockItem WHERE stockItem_id = " + stockItem_id, connection);
                        connection.Open();
                        currentCommand.CommandType = CommandType.Text;
                        reader2 = currentCommand.ExecuteReader();
                        int product_ref = -1;
                        if(reader2.HasRows)
                        {
                            reader2.Read();
                            product_ref = reader2.GetInt32(0);
                        }
                        reader2.Close();
                        connection.Close();
                        currentCommand = new SqlCommand("SELECT product_price FROM Product WHERE product_id = " + product_ref, connection);
                        connection.Open();
                        currentCommand.CommandType = CommandType.Text;
                        reader2 = currentCommand.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            reader2.Read();
                            payBack = payBack + (reader2.GetDecimal(0)*product_quantity);
                        }
                        reader2.Close();
                        connection.Close();


                    }
                }

                cnMain.Close();
                reader.Close();   //close the reader 

                //Give Customer money back
                sqlString = "UPDATE CUSTOMER SET customer_credit = customer_credit - "+payBack+" Where customer_id = '"+customerId+"'";
                command = new SqlCommand(sqlString, cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                cnMain.Close();

                sqlString = "DELETE FROM OrderItem Where order_id = " + orderId;
                command = new SqlCommand(sqlString, cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                cnMain.Close();
                sqlString = "SELECT delivery_id FROM Delivery Where order_id = '" + orderId + "'";
                command = new SqlCommand(sqlString, cnMain);
                cnMain.Open();
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                //Read from table

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int deliveryId = reader.GetInt32(0);
                        SqlConnection connection = newConnection();

                        SqlCommand currentCommand = new SqlCommand("DELETE FROM DeliveryDate WHERE delivery_id = " + deliveryId, connection);
                        connection.Open();
                        currentCommand.CommandType = CommandType.Text;
                        currentCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                reader.Close();
                cnMain.Close();
                sqlString = "DELETE FROM Delivery Where order_id = " + orderId;
                command = new SqlCommand(sqlString, cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                cnMain.Close();

                sqlString = "DELETE FROM [Order] Where order_id = '" + orderId + "'";
                command = new SqlCommand(sqlString, cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                cnMain.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }

        }


    
    }

}
