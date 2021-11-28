using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using PoppelOrderingSystem.Domain;
using PoppelOrderingSystem.Order;

namespace PoppelOrderingSystem.Email
{
    public class EmailController
    {
        public static void sendEmail(Customer cust, string header, string sendMessage)
        {
            if (cust.Name != null)
            {
                var fromAddress = new MailAddress("talifhani.mulaudzi54@gmail.com", "Poppel");
                var toAddress = new MailAddress(cust.Email, cust.Name);
                string fromPassword = "tali@10111";
                string subject = header;
                string body = sendMessage;

                var smtp = new SmtpClient
                {
                    Host = "talifhani.mulaudzi54.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = header,
                    Body = sendMessage
                })

                    smtp.Send(message);
            }
        }

        public static string createEmailTemplete(PoppelOrderingSystem.Order.Order order)
        {
            string templete = "Dear " + order.Customer.Name + "\n\nPlease find a summary of your order placed on: " + order.DateOrderPlaced.ToString() + "\nYour order consist of the following:";
            foreach(OrderItem item in order.Products)
            {
                templete += "\n" + item.Quantity + " x " + item.Product.Description + " - " + Product.getFormattedPrice(Decimal.Multiply(item.Quantity, item.Product.Price));
            }
            templete += "\n-------------------------------------------------------------";
            templete += "\nOrder Total: " + Product.getFormattedPrice(order.OrderPrice);
            templete += "\n\nYour order will be delivered between " + order.DeliveryDetails.StartDeliveryTime.ToShortTimeString() + " and " + order.DeliveryDetails.EndDeliveryTime.ToShortTimeString();
            if(order.DeliveryDetails.AllowedDeliveryDates.Count==1)
            {
                templete += " on " +order.DeliveryDetails.AllowedDeliveryDates[0].DayOfWeek +" "+ order.DeliveryDetails.AllowedDeliveryDates[0].ToShortDateString();
            }
            else
            {
                templete += " on any of the following days:\n" + order.DeliveryDetails.AllowedDeliveryDates[0].DayOfWeek + " " + order.DeliveryDetails.AllowedDeliveryDates[0].ToShortDateString();
                for(int i=1;i<order.DeliveryDetails.AllowedDeliveryDates.Count;i++)
                {
                    templete += "\n" + order.DeliveryDetails.AllowedDeliveryDates[i].DayOfWeek + " " + order.DeliveryDetails.AllowedDeliveryDates[i].ToShortDateString();
                }
            }
            templete += "\n\nYour order will be delivered to:\n" + order.Customer.addressToMulilineString();
            templete += "\n\nThe Poppel Team";
            return templete;
        }
         
    }
}

