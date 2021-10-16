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
    public partial class BookingsListView : Form
    {
        private Formstates state;
        
        public BookingsListView()
        {
            InitializeComponent();
        }

        private void BookingsListView_Load(object sender, EventArgs e)
        {

        }
        public enum Formstates
        {
            View=0,
            Edit=1,
            Delete=2,
        }
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
            editButton.Visible = value;
            deleteButton.Visible = value;

        }
        private void EnableEntries(bool value)
        {
            if(state==Formstates.Edit)
            {
                txtGuestID.Enabled = !value;
                txtBookingID.Enabled = !value;
            }
            else
            {
                txtGuestID.Enabled = value;
                txtBookingID.Enabled = value;
            }
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
        #endregion
    }
}
