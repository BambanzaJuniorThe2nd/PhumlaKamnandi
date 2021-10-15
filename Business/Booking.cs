using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    class Booking
    {

        #region Data Members
        static int id;
        String checkIn;
        String checkout;
        int guestId;
        int roomId;
        decimal Total_Fee;
        int BookingId;

        #endregion

        #region Constructor
        public Booking(int guestId, String checkIn, String checkout, int roomId, decimal Total_Fee)
        {
            BookingId = id;
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
            set { BookingId = value; }
            get { return BookingId; }
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
    }
}
