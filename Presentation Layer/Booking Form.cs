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
        Payment_Form payment_Form = new Payment_Form();
        HomePage homePage = new HomePage();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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
            this.Hide();
            payment_Form.Show();
        }
    }
}
