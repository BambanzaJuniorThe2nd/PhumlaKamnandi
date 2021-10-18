using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Booking
    {

        #region Data Members
        int bookingId;
        int count = 0;
        String checkIn;
        String checkout;
        int guestId;
        int roomId;
        decimal Total_Fee;

        #endregion

        #region Constructor
        public Booking(int bookingId, int guestId, int roomId, String checkIn, String checkout, decimal Total_Fee)
        {
            count = count + 1;
            this.bookingId = count;
            this.checkIn = checkIn;
            this.checkout = checkout;
            
            this.roomId = roomId;
            this.Total_Fee = Total_Fee;
            this.guestId = guestId;
        }

        #endregion

        #region Property Methods
        public String Checkin
        {
            set { checkIn = value; }
            get { return checkIn; }
        }

        public String CheckOut
        {
            set { checkout = value; }
            get { return checkout; }
        } 

        public int BookingID
        {
            set { bookingId = value; }
            get { return bookingId; }
        }

        public decimal TOTALFee
        {
            set { Total_Fee = value; }
            get { return Total_Fee ; }
        }

        public int RoomId
        {
            set {  roomId = value; }
            get { return roomId; }
        }

        public int GuestId
        {
            set { guestId = value; }
            get { return guestId; }
        }

        #endregion
        #region generate BookingID
        public int GetBookingID()
        {
            return this.bookingId;
        }
        #endregion
    }
}
