using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Domain
{
   public class Category
    {
        private int category_id;
        private string category_description;

           public override string ToString()
           {
               return category_description;
           }
        #region Properties
        public int Category_id
        {
            get { return category_id; }
            set { category_id = value; }
        }
       

        public string Category_description
        {
            get { return category_description; }
            set { category_description = value; }
        }
        #endregion

    }
}
