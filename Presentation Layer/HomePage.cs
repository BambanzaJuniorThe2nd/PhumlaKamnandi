using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Business;

namespace PhumlaKamnandi.Presentation_Layer
{
    public partial class HomePage : Form
    {
        private Collection<Guest> guests = new Collection<Guest>();
        private Reserve guest;
        public HomePage()
        {
            InitializeComponent();
            guest = new Reserve();
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
            Add_Guest add_Guest = new Add_Guest();
            this.Hide();
            add_Guest.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Person person;
            string id = txtGuestID.Text;
            GuestDetails guestDetails = new GuestDetails();
            

            person=guest.FindGuest(id);
            Guest aguest = (Guest)person.role;
            if (person==null)
            {
                MessageBox.Show("Guest doens't exist within our system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                guestDetails.txtGuestID.Text = person.ID; 
                guestDetails.txtEmail.Text = person.Email;
                guestDetails.txtName.Text = person.Name;
                guestDetails.txtTelephone.Text = person.Phone;
                guestDetails.txtAddress.Text = aguest.Address;
                
                this.Hide();
                guestDetails.ShowDialog();
            }


            





            
            
         
            
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

        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
