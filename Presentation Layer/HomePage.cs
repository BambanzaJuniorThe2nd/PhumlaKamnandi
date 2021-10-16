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

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you wish to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult==DialogResult.Yes)
            {
                this.Hide();
                login.Show();
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            BookingsListView bookingsList = new BookingsListView();
            this.Hide();
            bookingsList.ShowDialog();
           
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You currently have no new Notifications", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Booking_Form booking_Form = new Booking_Form();
            this.Hide();
            booking_Form.ShowDialog();
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            GuestListView guestList = new GuestListView();
            this.Hide();
            guestList.ShowDialog();
        }
    }
}
