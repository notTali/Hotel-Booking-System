using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelOrderingSystem.PresentationLayer
{
    public partial class OrderCreated : MetroFramework.Forms.MetroForm
    {
        public OrderCreated()
        {
            InitializeComponent();
        }

        private void OrderCreated_Load(object sender, EventArgs e)
        {

        }

        private void OrderCreated_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
