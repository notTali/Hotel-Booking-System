using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Domain
{
    public class Customer : Person
    {
        private decimal credit;
        private decimal creditLimit;

        #region Constructors
        public Customer()
        {
            credit = 0;
        }
        #endregion

        #region Properties
        public decimal Credit
        {
            get
            {
                return credit;
            }
            set
            {
                credit = value;
            }
        }
        public decimal CreditLimit
        {
            get
            {
                return creditLimit;
            }
            set
            {
                creditLimit = value;
            }
        }
        #endregion


    }
}
