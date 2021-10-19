using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Business;

namespace PhumlaKamnandi.Presentation_Layer
{
    public partial class GuestDetails : Form
        // This page is used to display the guest details when the clerk enters the guestID on the homepage
        // we have setup this page as a precautionary measure to ensure that the guest details match the guest's description
        // gathered from the clerk over the phone to avoid bookings for incorrect guestID as a result of a typo made by the clerk\
        // whilst entering the guest ID
       
    {
        Reserve reserve;
        public GuestDetails()
        {
            InitializeComponent();
            reserve = new Reserve();
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Booking_Form booking_Form = new Booking_Form(reserve);
           
            booking_Form.lblGuestID.Text = txtGuestID.Text;
            booking_Form.lblGuestName.Text = txtName.Text;
            this.Hide();
            booking_Form.Show();
            

        }

        private void GuestDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
