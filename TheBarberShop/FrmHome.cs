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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void realTime_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lblRealTime.Text = datetime.ToString();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            realTime.Start();
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            FrmRegistration registration = new FrmRegistration();
            registration.Show();
            this.Hide();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to Logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (logout == DialogResult.OK)
            {
                this.Close();
                FrmLogin home = new FrmLogin();
                home.Show();
            }
            if (logout == DialogResult.Cancel)
            {
                this.Focus();
            }
        }

        private void btnExistCust_Click(object sender, EventArgs e)
        {
            FrmExistingCust existing = new FrmExistingCust();
            existing.Show();
            this.Hide();
        }
    }
}
