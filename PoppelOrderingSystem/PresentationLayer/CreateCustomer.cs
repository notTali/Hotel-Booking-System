
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelOrderingSystem.Domain;
using PoppelOrderingSystem.CustomerMangement;

namespace PoppelOrderingSystem.PresentationLayer
{
    public partial class CreateCustomer : MetroFramework.Forms.MetroForm
    {
        private CustomerManangementController customerManagementController;

        public CreateCustomer(CustomerManangementController custController)
        {
            InitializeComponent();
            customerManagementController = custController;
            firstNameTextBox.Focus();
        }

        private void modifyCreditLimitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(modifyCreditLimitCheckBox.Checked)
            {
                creditLimitTextBox.ReadOnly = false;
            }
            else
            {
                creditLimitTextBox.ReadOnly = true;
            }
        }

        private bool isCustomerDetailsValid()
        {
            if (firstNameErrorMessageLabel.Visible || lastNameErrorMessageLabel.Visible || phoneErrorLabel.Visible || emailErrorMessageLabel.Visible || creditLimitErrorLabel.Visible || zipCodeErrorMessageLabel.Visible || streetErrorMessageLabel.Visible || suburbErrorMessageLabel.Visible || townErrorMessageLabel.Visible)
            {
                return false;
            }
            return true;

        }

        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            
            if (isCustomerDetailsValid())
            {
                Customer customer = new Customer();
                if (createCustomer(customer))
                {
                    customerManagementController.addCustomer(customer);
                    customerManagementController.Customer = customer;
                    CustomerCreated created = new CustomerCreated(customerManagementController);
                    created.MdiParent = this.MdiParent;
                    created.StartPosition = FormStartPosition.CenterParent;
                    this.Hide();
                    created.Show();
                    this.Close();
                }

            }
            else
            {
                createCustomerErrorLabel.Text = "Customer Details count not be saved.\nFormat errors in customer details found.";
                createCustomerErrorLabel.Visible = true;
            }
             
        }
        
        private bool createCustomer(Customer customer)
        {
            Boolean correct = true;
            customer.Name = firstNameTextBox.Text.Trim();
            customer.Surname = lastNameTextBox.Text.Trim();
            customer.Id = customerManagementController.generateId(customer.Name, customer.Surname);
            if (Person.unFormatPhoneNumber(phoneNumberMaskBox.Text)==null)
            {
                customer.PhoneNumber = "";
            }
            else
            {
                customer.PhoneNumber = Person.unFormatPhoneNumber(phoneNumberMaskBox.Text);
            }
            customer.Email = emailAddressTextBox.Text;
            if((phoneNumberMaskBox.Text==null ||phoneNumberMaskBox.Text=="") &&(emailAddressTextBox.Text==null ||emailAddressTextBox.Text==""))
            {
                correct = false;
            }

            decimal temp = -1;
                customer.Credit = 0;
            Decimal.TryParse(creditLimitTextBox.Text.Trim(), out temp);
            if (temp == -1)
            {
                createCustomerErrorLabel.Text = "An error occured converting credit limit.\nCheck credit limit format is correct.";
                createCustomerErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                customer.CreditLimit = temp;
            }

            string[] address = new string[Person.ADDRESS_LENGTH];
            address[0] = streetAddressTextBox.Text.Trim();
            address[1] = suburbTextBox.Text.Trim();
            address[2] = townTextBox.Text.Trim();
            address[3] = cityTextBox.Text.Trim();
            address[4] = zipCodeTextBox.Text.Trim();

            customer.Address = address;
            return correct;
        }
        
        #region Validation
        private void firstNameTestBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                firstNameErrorMessageLabel.Text = "Numbers are not allowed in a name.";
                firstNameErrorMessageLabel.Visible = true;
            }
            else if (firstNameTextBox.Text.Length >= 60 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                firstNameErrorMessageLabel.Text = "Name length has been exceeded.\nNames can only be up to 60 characters.";
                firstNameErrorMessageLabel.Visible = true;
            }
            else
            {
                firstNameErrorMessageLabel.Visible = false;
            }
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                lastNameErrorMessageLabel.Text = "Numbers are not allowed in a name.";
                lastNameErrorMessageLabel.Visible = true;
            }
            else if (lastNameTextBox.Text.Length >= 60 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lastNameErrorMessageLabel.Text = "Name length has been exceeded.\nNames can only be up to 60 characters.";
                lastNameErrorMessageLabel.Visible = true;
            }
            else
            {
                lastNameErrorMessageLabel.Visible = false;
            }
        }


        private void phoneNumberMaskBox_Leave(object sender, EventArgs e)
        {

            if (!phoneNumberMaskBox.Text.Equals("(   )    -") && Person.unFormatPhoneNumber(phoneNumberMaskBox.Text) == null)
            {
                Console.WriteLine(phoneNumberMaskBox.Text);
                phoneErrorLabel.Text = "Phone number must contain 10 digits.";
                phoneErrorLabel.Visible = true;
            }
            else if (phoneNumberMaskBox.Text.Equals("(   )    -") && emailAddressTextBox.Text.Length == 0)
            {
                phoneErrorLabel.Text = "Phone number or email address is required";
                phoneErrorLabel.Visible = true;
            }
            else
            {
                phoneErrorLabel.Visible = false;
            }
        }

        private void emailAddressTextBox_Leave(object sender, EventArgs e)
        {
            //http://www.codeproject.com/Questions/447172/Email-Mask-for-csharp-masktextbox
            //Checks if email address is in correct format.
            if (!System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$") && emailAddressTextBox.Text.Length!=0)
            {
                emailErrorMessageLabel.Text = "Email address should be in the format:\nxyz@abc.com";
                emailErrorMessageLabel.Visible = true;
            }
            else if (phoneNumberMaskBox.Text.Equals("(   )    -") && emailAddressTextBox.Text.Length == 0)
            {
                phoneErrorLabel.Text = "Phone number or email address is required";
                phoneErrorLabel.Visible = true;
            }
            else if (emailAddressTextBox.Text.Length >= 60)
            {
                emailErrorMessageLabel.Text = "Email length has been exceeded.\nEmails can only be up to 60 characters.";
                emailErrorMessageLabel.Visible = true;
            }
            else
            {
                emailErrorMessageLabel.Visible = false;
            }

        }

        private void firstNameTestBox_Leave(object sender, EventArgs e)
        {
            int i = 0;
            bool stop = false;

            if (firstNameTextBox.Text.Length >= 60)
            {
                firstNameErrorMessageLabel.Text = "Name length has been exceeded.\nNames can only be up to 60 characters.";
                firstNameErrorMessageLabel.Visible = true;
                stop = true;
            }
            else if (firstNameTextBox.Text.Length ==0)
            {

                firstNameErrorMessageLabel.Text = "Name is a required field.";
                firstNameErrorMessageLabel.Visible = true;
                stop = true;
            }
            while (i < firstNameTextBox.Text.Length && !stop)
            {
                if (char.IsNumber(firstNameTextBox.Text[i]))
                {
                    firstNameErrorMessageLabel.Text = "Numbers are not allowed in a name.";
                    firstNameErrorMessageLabel.Visible = true;
                    stop = true;
                }
                i++;
            }
            if (!stop)
            {
                firstNameErrorMessageLabel.Visible = false;
            }
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            int i = 0;
            bool stop = false;

            if (lastNameTextBox.Text.Length >= 60)
            {
                lastNameErrorMessageLabel.Text = "Name length has been exceeded.\nNames can only be up to 60 characters.";
                lastNameErrorMessageLabel.Visible = true;
                stop = true;
            }
            else if (lastNameTextBox.Text.Length == 0)
            {

                lastNameErrorMessageLabel.Text = "Last Name is a required field.";
                lastNameErrorMessageLabel.Visible = true;
                stop = true;
            }
            while (i < lastNameTextBox.Text.Length && !stop)
            {
                if (char.IsNumber(lastNameTextBox.Text[i]))
                {
                    lastNameErrorMessageLabel.Text = "Numbers are not allowed in a name.";
                    lastNameErrorMessageLabel.Visible = true;
                    stop = true;
                }
                i++;
            }
            if (!stop)
            {
                lastNameErrorMessageLabel.Visible = false;
            }
        }

        private void creditLimitTextBox_Leave(object sender, EventArgs e)
        {
            int i = 0;
            bool stop = false;
            int dotIndex = creditLimitTextBox.Text.IndexOf(".");
            if (dotIndex == -1 && creditLimitTextBox.Text.Length > 8)
            {
                creditLimitErrorLabel.Text = "Credit limit can only be up to 8 digits.";
                creditLimitErrorLabel.Visible = true;
                stop = true;
            }
            else if (dotIndex != -1 && creditLimitTextBox.Text.Length > 10)
            {
                creditLimitErrorLabel.Text = "Credit limit can only be up to 8 digits.";
                creditLimitErrorLabel.Visible = true;
                stop = true;
            }
            while (i < creditLimitTextBox.Text.Length && !stop)
            {
                if (!char.IsControl(creditLimitTextBox.Text[i]) && !char.IsDigit(creditLimitTextBox.Text[i]) && creditLimitTextBox.Text[i] != '.')
                {
                    creditLimitErrorLabel.Text = "Only numbers and a '.' allowed.";
                    creditLimitErrorLabel.Visible = true;
                    stop = true;
                }


                i++;
            }

            if (creditLimitTextBox.Text.IndexOf(".") != creditLimitTextBox.Text.LastIndexOf(".") && !stop)
            {
                creditLimitErrorLabel.Text = "Only one '.' allowed.";
                creditLimitErrorLabel.Visible = true;
                stop = true;
            }
            else if (dotIndex != -1 && creditLimitTextBox.Text.Substring(dotIndex).Length > 3 && !stop)
            {
                creditLimitErrorLabel.Text = "Only two decimal places allowed.";
                creditLimitErrorLabel.Visible = true;
                stop = true;
            }
            if (!stop)
            {
                creditLimitErrorLabel.Visible = false;
            }
        }

        private void creditLimitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            int index = (sender as TextBox).Text.IndexOf('.');
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                creditLimitErrorLabel.Text = "Only numbers and a '.' allowed.";
                creditLimitErrorLabel.Visible = true;
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && index > -1)
            {
                creditLimitErrorLabel.Text = "Only one '.' allowed.";
                creditLimitErrorLabel.Visible = true;
                e.Handled = true;
            }
            else if (index != -1 && creditLimitTextBox.SelectionStart > index && creditLimitTextBox.Text.Substring(index).Length >= 3 && !char.IsControl(e.KeyChar))
            {

                int test = creditLimitTextBox.Text.Substring(index).Length;
                string test2 = creditLimitTextBox.Text.Substring(index);
                creditLimitErrorLabel.Text = "Only two decimal places allowed.";
                creditLimitErrorLabel.Visible = true;
                e.Handled = true;
            }
            else if (index == -1 && creditLimitTextBox.Text.Length > 8 && !char.IsControl(e.KeyChar))
            {
                creditLimitErrorLabel.Text = "Name length has been exceeded.\nCredit limit can only be up to 8 digits.";
                creditLimitErrorLabel.Visible = true;
                e.Handled = true;
            }
            else if (index != -1 && creditLimitTextBox.Text.Length > 10 && !char.IsControl(e.KeyChar))
            {
                creditLimitErrorLabel.Text = "Name length has been exceeded.\nCredit limit can only be up to 8 digits.";
                creditLimitErrorLabel.Visible = true;
                e.Handled = true;
            }
            else
            {
                creditLimitErrorLabel.Visible = false;
            }

        }
        private void zipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (zipCodeTextBox.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                zipCodeErrorMessageLabel.Text = "Zip code can only be up to 5 digits.";
                zipCodeErrorMessageLabel.Visible = true;
                e.Handled = true;
            }

            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                zipCodeErrorMessageLabel.Text = "Only numbers allowed.";
                zipCodeErrorMessageLabel.Visible = true;
                e.Handled = true;
            }
            else
            {
                zipCodeErrorMessageLabel.Visible = false;
            }

        }

        private void zipCodeTextBox_Leave(object sender, EventArgs e)
        {
            bool stop = false;
            int i = 0;
            if (zipCodeTextBox.Text.Length > 5)
            {
                zipCodeErrorMessageLabel.Text = "Zip code can only be up to 5 digits.";
                zipCodeErrorMessageLabel.Visible = true;
                stop = true;
            }
            while (i < zipCodeTextBox.Text.Length && !stop)
            {
                if (!char.IsDigit(zipCodeTextBox.Text[i]))
                {

                    zipCodeErrorMessageLabel.Text = "Only numbers allowed.";
                    zipCodeErrorMessageLabel.Visible = true;
                    stop = true;
                }
                i++;
            }

            if (!stop)
            {
                zipCodeErrorMessageLabel.Visible = false;
            }


        }

        private void streetAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (streetAddressTextBox.Text.Length >= 60)
            {
                streetErrorMessageLabel.Text = "Street length has been exceeded.\nStreets can only be up to 60 characters.";
                streetErrorMessageLabel.Visible = true;
            }
            else
            {
                streetErrorMessageLabel.Visible = false;
            }
        }

        private void suburbTextBox_Leave(object sender, EventArgs e)
        {
            if (suburbTextBox.Text.Length >= 60)
            {
                suburbErrorMessageLabel.Text = "Suburb length has been exceeded.\nSuburbs can only be up to 60 characters.";
                suburbErrorMessageLabel.Visible = true;
            }
            else
            {
                suburbErrorMessageLabel.Visible = false;
            }
        }

        private void townTextBox_Leave(object sender, EventArgs e)
        {
            if (townTextBox.Text.Length >= 60)
            {
                townErrorMessageLabel.Text = "Town length has been exceeded.\nTown name can only be up to 60 characters.";
                townErrorMessageLabel.Visible = true;
            }
            else
            {
                townErrorMessageLabel.Visible = false;
            }
        }

        private void cityTextBox_Leave(object sender, EventArgs e)
        {
            if (cityTextBox.Text.Length >= 60)
            {
                cityErrorMessageLabel.Text = "City length has been exceeded.\nCity can only be up to 60 characters.";
                cityErrorMessageLabel.Visible = true;
            }
            else
            {
                cityErrorMessageLabel.Visible = false;
            }
        }
        #endregion

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to stop adding a customer?", "Confirm Stop Adding Customer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
