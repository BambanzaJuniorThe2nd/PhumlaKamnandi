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
    public partial class Payment_Form : Form
    {
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
            dialogResult = MessageBox.Show("Are you sure you wish to cancel this current booking?\n\n **All changes won't be saved**", "Cancel", MessageBoxButtons.YesNo);
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

        private void txtCVC_Enter(object sender, EventArgs e)
        {
            if(txtCVC.Text=="CVC")
            {
                txtCVC.Text = "";
                txtCVC.ForeColor = Color.White;

            }
        }

        private void txtCVC_Leave(object sender, EventArgs e)
        {
            if(txtCVC.Text=="")
            {
                txtCVC.Text = "CVC";
                txtCVC.ForeColor = Color.Silver;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
           
        }
    }
}
