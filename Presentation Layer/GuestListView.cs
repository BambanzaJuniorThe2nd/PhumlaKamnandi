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
    public partial class GuestListView : Form
    {
        private FormStates state;
        public GuestListView()
        {
            InitializeComponent();
        }

        public enum FormStates
        {
            View=0,
            Edit=1,
            Delete=2,
        }
        #region Utillity Methods
        private void Showall(bool value)
        {
            GuestIDlbl.Visible = value;
            Namelbl.Visible = value;
            Emaillbl.Visible = value;
            Phonelbl.Visible = value;
            Addresslbl.Visible = value;
            Suburblbl.Visible = value;
            CityLbl.Visible = value;
            ZipLbl.Visible = value;
            txtGuestID.Visible = value;
            txtName.Visible = value;
            txtPhone.Visible = value;
            txtSuburb.Visible = value;
            txtZip.Visible = value;
            txtAddress.Visible = value;
            txtCity.Visible = value;
            txtEmail.Visible = value;
            if(state==FormStates.Delete)
            {
                btnConfirm.Visible=! value;
                brnCancel.Visible = !value;
                
            }
            else
            {
                btnConfirm.Visible = value;
                brnCancel.Visible = value;
            }
            deleteButton.Visible = value;
            editButton.Visible = value;
        }
        private void EnableEntries(bool value)
        {
            if(state==FormStates.Edit)
            {
                txtGuestID.Enabled = !value;
            }
            else
            {
                txtGuestID.Enabled = value;
            }
            txtAddress.Enabled = value;
            txtCity.Enabled = value;
            txtEmail.Enabled = value;
            txtName.Enabled = value;
            txtPhone.Enabled = value;
            txtSuburb.Enabled = value;
            txtZip.Enabled = value;
            if (state == FormStates.Delete)
            {
                btnConfirm.Visible = !value;
                brnCancel.Visible = !value;
            }
            else
            {
                btnConfirm.Visible = value;
                brnCancel.Visible = value;
            }
        
    }
     

        private void brnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you wish to cancel and return to the homepage?\n\n **All changes won't be saved**",
                "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult==DialogResult.Yes)
            {
                this.Hide();
                homePage.ShowDialog();
            }
        }
        private void ClearAll()
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtGuestID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtSuburb.Text = "";
            txtZip.Text = "";
        }
        #endregion


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GuestListView_Load(object sender, EventArgs e)
        {

        }
    }
}
