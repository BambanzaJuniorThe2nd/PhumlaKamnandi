using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Business;

namespace PhumlaKamnandi.Presentation_Layer
{
    
    public partial class Add_Guest : Form
    {
        private Reserve reserve;
        private Dictionary<int, string> comboSource = new Dictionary<int, string>();

        public Add_Guest(Reserve reserve)
        {

            InitializeComponent();
            this.reserve = reserve;
            SetUpCboCCC();
        }

        private void SetUpCombo()
        {
            comboSource = new Dictionary<int, string>();
            // Retrieve and add all credit card companies
            // to comboSource
            cboCCC.DataSource = new BindingSource(comboSource, null);
            cboCCC.DisplayMember = "Value";
            cboCCC.ValueMember = "Key";
        }

        private void ClearAll()
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtPhone.Clear();
            
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
            Debug.WriteLine("Inside btnConfirm_Click");
            Person person=new Person(Role.RoleType.Guest);
            string Name = txtName.Text;
            string Phone = txtPhone.Text;
            string email = txtEmail.Text;
            string personalID = txtPersonalID.Text;
            string address = txtAddress.Text;
            string ccNum = txtCCNum.Text;
            string ccc = cboCCC.Items[cboCCC.SelectedIndex].ToString();
            int expirationMonth = Convert.ToInt32(txtExpMonth.Text);
            int expirationYear = Convert.ToInt32(txtExpYear.Text);

            //person.Name = Name;
            //person.Phone = Phone;
            //person.Email = email;
            //person.PersonalId = personalID;

            //Guest aguest = (Guest)person.role;
            //aguest.Address = address;
            //reserve.AddGuest(person);

            //DialogResult dialogResult;
            //dialogResult= MessageBox.Show("A new Guest has successfully been Created with the details of:\n" + reserve.GetId(person) + "\n" +person.PersonalId+
            //    person.Name + "\n" + person.Phone + "\n" + person.Email + "\n" + aguest.Address + "\n", "New Guest", MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);

            //if(dialogResult==DialogResult.OK||dialogResult!=DialogResult.OK)
            //{
            //    this.Hide();
            //    new HomePage().ShowDialog();
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
