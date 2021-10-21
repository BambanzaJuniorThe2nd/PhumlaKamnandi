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
        private BookingController bookingcontroller;
        private PersonController personController;
        GuestListView guestListView;
        BookingsListView bookingsListView;
      
        public HomePage()
        {
            InitializeComponent();
            guest = new Reserve();
            personController = new PersonController();
            bookingcontroller = new BookingController();
            
            
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

      

        
        #region Logout
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
        #endregion
        #region New Booking
        private void txtGuestID_Enter(object sender, EventArgs e)
        {
            if (txtGuestID.Text == "Enter Guest ID")
            {
                txtGuestID.Text = "";
                txtGuestID.ForeColor = Color.White;
            }
        }
        private void txtGuestID_Leave(object sender, EventArgs e)
        {
            if (txtGuestID.Text == "")
            {
                txtGuestID.Text = "Enter Guest ID";
                txtGuestID.ForeColor = Color.White;
            }
        }

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Person person;
            Guest aguest;
            
            GuestDetails guestDetails = new GuestDetails();
            try
            {
                string id = txtGuestID.Text;
                person = guest.FindGuest(id);
                 aguest = (Guest)person.role;
                if(id==null)
                {
                    MessageBox.Show("Please enter a GuestID to search", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (guest.FindGuest(id)==null||aguest==null||person==null)
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
            }catch(FormatException)
            {
                MessageBox.Show("Please make sure all fields are correctly filled in before continuing", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


            
        }
        #endregion

        private void btnNotification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You currently have no new Notifications", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #region Add Guest
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            Add_Guest add_Guest = new Add_Guest(guest);
            this.Hide();
            add_Guest.ShowDialog();
        }
        #endregion
        #region Guest Listform
        private void CreatnewGuestForm()
        {
            guestListView = new GuestListView(personController);

        }


        private void btnGuests_Click(object sender, EventArgs e)
        {
            if(guestListView==null)
            {
                CreatnewGuestForm();
            }
            if(guestListView.listformClosed)
            {
                CreatnewGuestForm();
            }
            guestListView.role = Role.RoleType.Guest;
            guestListView.setGuestListview();
            guestListView.Show();
        }
        #endregion
        #region Booking ListForm
        private void CreatenewBookingForm()
        {
            bookingsListView = new BookingsListView(guest);
        }
        private void btnBooking_Click(object sender, EventArgs e)
        {

            if(bookingsListView==null)
            {
                CreatenewBookingForm();
            }
            if(bookingsListView.listformclosed)
            {
                CreatenewBookingForm();
            }
            bookingsListView.setupBookingsListview();
            bookingsListView.Show();
        }
        #endregion


        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMonthlyReports_Click(object sender, EventArgs e)
        {
            MonthlyReports monthlyReports = new MonthlyReports(guest);
            this.Hide();
            monthlyReports.ShowDialog();
        }
    }
}
