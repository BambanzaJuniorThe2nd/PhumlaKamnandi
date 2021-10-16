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
    public partial class Add_Guest : Form
    {
        public Add_Guest()
        {
            InitializeComponent();
        }
        private void ClearAll()
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtTelephone.Clear();
            txtSuburb.Clear();
            txtZip.Clear();
            txtCity.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you wish to cancel making a new guest?", "Cancel", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(dialogResult==DialogResult.Yes)
            {
                this.Hide();
                homePage.Show();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
