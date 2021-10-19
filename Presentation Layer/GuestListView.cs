using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class GuestListView : Form
    {
        public bool listformClosed;
        private FormStates state;
        private Collection<Person> persons;
        private Person person;
        private PersonController personController;
        private Role.RoleType rolevalue;
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
        public Role.RoleType role
        {
            set { rolevalue = value; }
        }
        #region Utillity Methods
        private void Showall(bool value)
        {
            GuestIDlbl.Visible = value;
            Namelbl.Visible = value;
            Emaillbl.Visible = value;
            Phonelbl.Visible = value;
            Addresslbl.Visible = value;
            CCnoLbl.Visible = value;
                   
            txtGuestID.Visible = value;
            txtName.Visible = value;
            txtPhone.Visible = value;
            txtCCNumber.Visible = value;
            txtAddress.Visible = value;
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
            txtEmail.Enabled = value;
            txtName.Enabled = value;
            txtPhone.Enabled = value;
            txtCCNumber.Enabled = value;
            
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

        private void Populatetextboxes(Person person)
        {
            person.ID = txtGuestID.Text;
            person.Name = txtName.Text;
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
           
            txtEmail.Text = "";
            txtGuestID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtCCNumber.Text = "";
           
        }
        #endregion


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GuestListView_Load(object sender, EventArgs e)
        {
            listViewGuests.View = View.Details;
        }

        private void GuestListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            listformClosed = true;
        }

        private void GuestListView_Activated(object sender, EventArgs e)
        {
            listViewGuests.View = View.Details;
            Showall(false);
        }
    }
}
