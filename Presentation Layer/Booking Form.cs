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
    public partial class Booking_Form : Form
    {
        public Booking_Form()
        {
            InitializeComponent();
        }
        
  

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();

            DialogResult dialogResult;

            dialogResult = MessageBox.Show("Are you sure you wish to cancel and return\n to the home page?", "Cancel", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(dialogResult==DialogResult.Yes)
            {
                this.Hide();
                homePage.Show();
            }
            
        }

        private void Booking_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Payment_Form payment_Form = new Payment_Form();
            DateTime Checkin;
            DateTime Checkout;
            decimal CostNight;
            decimal Deposit;
            int RoomNo;
            decimal Total;

            Checkin = DateTime.Parse(dtpCheckin.Text);
            Checkout = DateTime.Parse(dtpCheckout.Text);
            //CostNight = decimal.Parse(txtPerNight.Text);
            RoomNo = int.Parse(cboRoomNmbr.Text);
            //Total = decimal.Parse(txtTotal.Text);
            //Deposit = decimal.Parse(txtDeposit.Text);

          

            payment_Form.lblCheckin.Text = Checkin.ToString("f");
            payment_Form.lblCheckout.Text = Checkout.ToString("f");
            payment_Form.lblRoomNO.Text = RoomNo.ToString();
           // payment_Form.lblDeposit.Text = Deposit.ToString("c");
            //payment_Form.lblTotal.Text = Total.ToString("c");

            this.Hide();
            payment_Form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
