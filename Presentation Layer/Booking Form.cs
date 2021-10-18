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
    public partial class Booking_Form : Form
    {
        RoomFee roomFee;
        private Reserve reserve;
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
            Person person;
            string id = lblGuestID.Text;
            person = reserve.FindGuest(id);
            DateTime Checkin=DateTime.Now;
            DateTime Checkout=DateTime.Now;
            decimal CostNight;
            int RoomNo=0;
            int Days = 0;
            decimal Total=0;
            Room room;
            try
            {


                if (Checkin.Date > Checkout.Date)
                {
                    MessageBox.Show("Checkin date cannot be set to after the checkout date", "Date Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    dtpCheckin.Focus();
                }
                else if (RoomNo == 0)
                {
                    MessageBox.Show("Please select an availble room to continue", "Room Selection", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    cboRoomNmbr.Focus();
                }

                else
                {
                    CostNight = roomFee.TotalFee(Checkin);
                    Days = Convert.ToInt32((Checkout.Date) - (Checkin.Date));
                    Total = CostNight * Days;
                    txtPerNight.Text = CostNight.ToString("c");
                    txtTotal.Text = Total.ToString("c");
                    payment_Form.lblCheckin.Text = Checkin.Date.ToString("f");
                    payment_Form.lblCheckout.Text = Checkout.Date.ToString("f");
                    payment_Form.lblTotal.Text = Total.ToString("c");
                    payment_Form.lblRoomNO.Text = RoomNo.ToString();
                    payment_Form.lblGuestID.Text = person.ID.ToString();
                    this.Hide();
                    payment_Form.ShowDialog();



                }
            }catch(FormatException)
            {
                MessageBox.Show("Please make sure you've completed all fields with correct data", "Input error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
                   
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGuestID_Click(object sender, EventArgs e)
        {

        }
    }
}
