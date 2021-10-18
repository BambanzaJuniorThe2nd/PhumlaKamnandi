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
    
    public partial class Payment_Form : Form
    {
        Booking Booking;
        public Payment_Form()
        {
            InitializeComponent();
        }
       
      
        Booking_Form booking_Form = new Booking_Form();
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you wish to cancel this current booking?\n\n **All changes won't be saved**", "Cancel", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                homePage.Show();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking_Form.Show();
        }

        private void txtCCnumber_Enter(object sender, EventArgs e)
        {
            if(txtCCnumber.Text=="Credit Card Number")
            {
                txtCCnumber.Text = "";
                txtCCnumber.ForeColor = Color.White;

            }
        }

        private void txtCCnumber_Leave(object sender, EventArgs e)
        {
            if(txtCCnumber.Text=="")
            {
                txtCCnumber.Text = "Credit Card Number";
                txtCCnumber.ForeColor = Color.Silver;
            }
        }

        private void txtExpireDate_Enter(object sender, EventArgs e)
        {
            if(txtExpireDate.Text=="Expiry Date")
            {
                txtExpireDate.Text = "";
                txtExpireDate.ForeColor = Color.White;
            }
        }

        private void txtExpireDate_Leave(object sender, EventArgs e)
        {
            if(txtExpireDate.Text=="")
            {
                txtExpireDate.Text = "Expiry Date";
                txtExpireDate.ForeColor = Color.Silver;
            }
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
           

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int bookingid;
            string checkin;
            string checkout;
            int guestid;
            int roomno;
            decimal total;
            DialogResult dialogResult;
            HomePage home = new HomePage();
            if(txtCCnumber.Text==""||txtExpireDate.Text==""||cboCCC.SelectedIndex<-1)
            {
                MessageBox.Show("Please make sure all fields in the Credit card details box\n is correctly completed before creating a booking.","Input Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bookingid = Booking.GetBookingID();
                checkin = lblCheckin.Text;
                checkout = lblCheckout.Text;
                guestid = Convert.ToInt32(lblGuestID.Text);
                roomno = Convert.ToInt32(lblRoomNO.Text);
                total = Convert.ToDecimal(lblTotal.Text);

                Booking = new Booking(bookingid, guestid, roomno, checkin, checkout, total);
                dialogResult = MessageBox.Show("New booking has been created for " + " " + guestid.ToString() + "\n" + "for " + " " +
                    checkin + " " + "\n with the BookingID of: " + bookingid.ToString(), "Booking Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(dialogResult==DialogResult.OK||dialogResult!=DialogResult.OK)//makes sure all possibillities are attended too
                {
                    this.Hide();
                    home.ShowDialog();
                }
                
                
            }
        }
    }
}
