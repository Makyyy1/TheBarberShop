using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBarberShop
{
    public partial class FrmBooking : Form
    {
        public FrmBooking()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmHome back = new FrmHome();
            back.Show();
        }
    }
}
