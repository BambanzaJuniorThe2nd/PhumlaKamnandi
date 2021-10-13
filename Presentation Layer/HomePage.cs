using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandi.Presentation_Layer
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        private void existingBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exsitingBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtGuestID_Enter(object sender, EventArgs e)
        {
            if(txtGuestID.Text=="Enter Guest ID")
            {
                txtGuestID.Text = "";
                txtGuestID.ForeColor = Color.White;
            }
        }

        private void txtGuestID_Leave(object sender, EventArgs e)
        {
            if(txtGuestID.Text=="")
            {
                txtGuestID.Text = "Enter Guest ID";
                txtGuestID.ForeColor = Color.White;
            }
        }
    }
}
