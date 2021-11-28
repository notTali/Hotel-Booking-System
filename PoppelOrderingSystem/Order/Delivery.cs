using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Order
{
    public class Delivery
    {
        private DateTime startDeliveryTime;
        private DateTime endDeliveryTime;
        private Collection<DateTime> allowedDeliveryDates;

        public DateTime StartDeliveryTime
        {
            get { return startDeliveryTime; }
            set { startDeliveryTime = value; }
        }
        public DateTime EndDeliveryTime
        {
            get { return endDeliveryTime; }
            set { endDeliveryTime = value; }
        }
        public Collection<DateTime> AllowedDeliveryDates
        {
            get { return allowedDeliveryDates; }
            set { allowedDeliveryDates = value; }
        }

        public Domain.Category Category
        {
            get => default;
            set
            {
            }
        }
    }
}
