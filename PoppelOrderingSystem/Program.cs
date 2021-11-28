using PoppelOrderingSystem.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelOrderingSystem.CustomerMangement;
using PoppelOrderingSystem.Order;

namespace PoppelOrderingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm main = new MainForm();
            
            main.StartPosition = FormStartPosition.CenterScreen;
            main.Show();
            Application.Run();
          
        }
    }
}
