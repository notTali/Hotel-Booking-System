using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoppelOrderingSystem.PresentationLayer;
using PoppelOrderingSystem.Domain;
using PoppelOrderingSystem.Database;

namespace PoppelOrderingSystem.CustomerMangement
{
    public class CustomerManangementController
    {
        private PoppelDatabase database = new PoppelDatabase();
        private Customer customer;
        private Employee employee;

        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public Collection<Customer> GetAllCustomers() {
            return database.readAllCustomers();  
        }
        public Customer searchCustomerByCustomerNumber(string id)
        {
            return database.readCustomersByCustomerNumber(id);
        }

        public Collection<Customer> searchCustomerByPhoneNumber(string telephoneNumber)
        {
            return database.readCustomersByTelephoneNumber(Person.unFormatPhoneNumber(telephoneNumber));
        }

        public void editCustomer(Customer customer)
        {
            database.editCustomer(customer);
        }
        public void addCustomer(Customer customer)
        {
            database.addCustomer(customer);
        }

        public string generateId(string name, string surname)
        {
            bool generated = false;
            string customerCode="";
            Random random = new Random();
            

            if (surname.Length >= 3)
            {
                customerCode += surname.Substring(0, 3);
            }
            else
            {
                customerCode += surname.Substring(0, surname.Length);
                for (int i = 0; i < 3 - surname.Length; i++)
                {

                    int num = random.Next(0, 26); // Zero to 25
                    char character = (char)('a' + num);
                    customerCode += character;
                }
            }
            if (name.Length >= 3)
            {
                customerCode += name.Substring(0, 3);
            }
            else
            {
                customerCode += name.Substring(0, name.Length);
                for (int i = 0; i < 3 - name.Length; i++)
                {

                    int num = random.Next(0, 26); // Zero to 25
                    char character = (char)('a' + num);
                    customerCode += character;
                }
            }
            int number = 0;
            while(!generated)
            {
                number++;
                if(number==1000)
                {
                    return null;
                }
                string testCode = "" + number;
                for (int i = 0; i <= 3 - testCode.Length; i++)
                {
                    testCode = "0" + testCode;
                }
                testCode = customerCode +""+ testCode;
               testCode = testCode.ToLower();
                if(!database.doesKeyExist(testCode))
                {
                    generated = true;
                    customerCode = testCode;
                }
            }
            return customerCode;



        }


    }
}
