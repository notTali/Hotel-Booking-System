//Brian Mc George
//MCGBRI004
//03-10-2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Domain
{
    public class Employee : Person
    {
        private decimal salary;
        private string position;

        //Constructor needed?

        #region Properties
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
        #endregion
    }
}
