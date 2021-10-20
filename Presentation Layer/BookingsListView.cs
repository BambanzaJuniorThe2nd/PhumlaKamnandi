using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class BookingsListView : Form
    {
        public bool listformclosed;
        private Formstates state;
        private Collection<Booking> bookings;
        private BookingController bookingController;
        private Booking Booking;
        public enum Formstates
        {
            View = 0,

            Delete = 1,
        }

        public BookingsListView(BookingController bookingcontroller)
        {
            InitializeComponent();
            bookingController = bookingcontroller;
            this.Load += BookingsListView_Load;
            this.FormClosed += BookingsListView_FormClosed;
            this.Activated += BookingsListView_Activated;
            state = Formstates.View;
        }
        #region Form Events
        private void BookingsListView_Load(object sender, EventArgs e)
        {
            listViewBookings.View = View.Details;
        }
        private void BookingsListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            listformclosed = true;
        }
        private void BookingsListView_Activated(object sender, EventArgs e)
        {
            listViewBookings.View = View.Details;
            setupBookingsListview();
            Showall(false);
        }
        #endregion

        #region Utility Methods
        private void Showall(bool value)
        {
            GuestIDlbl.Visible = value;
            BookingIDlbl.Visible = value;
            CheckinLbl.Visible = value;
            CheckoutLBl.Visible = value;
            RoomNolbl.Visible = value;
            txtGuestID.Visible = value;
            txtRoomNo.Visible = value;
            txtBookingID.Visible = value;
            txtCheckout.Visible = value;
            txCheckin.Visible = value;
            if(state==Formstates.Delete)
            {
                btnConfirm.Visible = !value;
                btnCancel.Visible = !value;
            }
            else
            {
                btnConfirm.Visible = value;
                btnCancel.Visible = value;
            }
           
            deleteButton.Visible = value;

        }
        private void EnableEntries(bool value)
        {
            txtGuestID.Enabled = value;
            txtBookingID.Enabled = value;           
            txtCheckout.Enabled = value;
            txCheckin.Enabled = value;
            txtRoomNo.Enabled = value;
            if (state == Formstates.Delete)
            {
                btnConfirm.Visible = !value;
                btnCancel.Visible = !value;
            }
            else
            {
                btnConfirm.Visible = value;
                btnCancel.Visible = value;
            }
        }
        private void ClearAll()
        {
            txtBookingID.Text = "";
            txtCheckout.Text = "";
            txCheckin.Text = "";
            txtGuestID.Text = "";
            txtRoomNo.Text = "";
            txtTotal.Text = "";
        }

        #endregion
        #region Listview Setup
        public void setupBookingsListview()
        {
            ListViewItem bookingdetails;
            
            listViewBookings.Clear();
            listViewBookings.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            listViewBookings.Columns.Insert(1, "GuestID", 120, HorizontalAlignment.Left);
            listViewBookings.Columns.Insert(2, "Room Number", 120, HorizontalAlignment.Left);
            listViewBookings.Columns.Insert(3, "Checkin", 120, HorizontalAlignment.Left);
            listViewBookings.Columns.Insert(4, "Checkout", 120, HorizontalAlignment.Left);
            listViewBookings.Columns.Insert(5, "Total", 120, HorizontalAlignment.Left);
            bookings = bookingController.AllBookings;

            foreach(Booking booking in bookings)
            {
                bookingdetails = new ListViewItem();
                bookingdetails.Text = booking.BookingID.ToString();
                bookingdetails.SubItems.Add(booking.GuestId.ToString());
                bookingdetails.SubItems.Add(booking.RoomId.ToString());
                bookingdetails.SubItems.Add(booking.Checkin.ToString());
                bookingdetails.SubItems.Add(booking.CheckOut.ToString());
                bookingdetails.SubItems.Add(booking.TOTALFee.ToString());

                listViewBookings.Items.Add(bookingdetails);
            }

            listViewBookings.Refresh();
            listViewBookings.GridLines = true;



        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listViewBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Showall(true);
            state = Formstates.View;
            EnableEntries(false);
            if(listViewBookings.SelectedItems.Count>0)
            {
                Booking = bookingController.Find(listViewBookings.SelectedItems[0].Text);
                Populatetextboxes(Booking);
                
            }


        }

     

       

        private void deleteButton_Click(object sender, EventArgs e)
        {
            state = Formstates.Delete;
            EnableEntries(false);
        }
        private void PopulateObject()
        {
            int Bookingid = int.Parse(txtBookingID.Text);
            int guestid = int.Parse(txtGuestID.Text);
            int Roomno = int.Parse(txtRoomNo.Text);
            string checkin = txCheckin.Text;
            string checkout = txtCheckout.Text;
            decimal total = decimal.Parse(txtTotal.Text);
            Booking = new Booking( guestid, Roomno, checkin, checkout, total);

            

        }
        private void Populatetextboxes(Booking anBooking)
        {
            txtBookingID.Text = Convert.ToString(anBooking.BookingID);
            txtGuestID.Text = Convert.ToString(anBooking.GuestId);
            txtRoomNo.Text = Convert.ToString(anBooking.RoomId);
            txCheckin.Text = Convert.ToString(anBooking.Checkin);
            txtCheckout.Text = Convert.ToString(anBooking.CheckOut);
            txtTotal.Text = Convert.ToString(anBooking.CheckOut);

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PopulateObject();
            if(state==Formstates.Delete)
            {
                bookingController.DataMaintenance(Booking, Data.DB.DBOperation.Delete);
                    
            }
       
        }
    }
}
