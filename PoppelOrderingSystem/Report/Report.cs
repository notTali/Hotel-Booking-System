using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Report
{
    public class Report
    {
        #region Properties
        public String id;


        public String createdBy;


        public DateTime date;


        public String title;
        
        #endregion
        public Report(String createdBy, DateTime date, String title, String ID)
        {
            this.id = ID;
            this.date = date;
            this.createdBy = createdBy;
            this.title = title;
        }

        public Report()
        {
            this.id = "";
            this.date = DateTime.Now;// The current date
            this.createdBy = "";
            this.title = "";
        }
       
    }
}
