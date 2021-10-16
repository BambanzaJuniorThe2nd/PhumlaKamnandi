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
    
    public partial class Add_Guest : Form
    {
       private Reserve reserve;

        public Add_Guest(Reserve reserve)
        {
            
            InitializeComponent();
            this.reserve = reserve;
            
            
        }
       
        private void ClearAll()
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtTelephone.Clear();
            
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
            HomePage homePage = new HomePage();
            Person person=new Person(Role.RoleType.Guest);
            Guest aguest = (Guest)person.role;
            string address = txtAddress.Text;
            string Name = txtName.Text;
            string Phone = txtTelephone.Text;
            string email = txtEmail.Text;
            string personalID = txtID.Text;
            person.Name = Name;
            person.Phone = Phone;
            person.Email = email;
            aguest.Address = address;
           // person.Address = txtAddress.Text;
            person.PersonalId = personalID;
           
            reserve.AddGuest(person);
            DialogResult dialogResult;

            dialogResult= MessageBox.Show("A new Guest has successfully been Created with the details of:\n" + reserve.GetId(person) + "\n" +person.PersonalId+
                person.Name + "\n" + person.Phone + "\n" + person.Email + "\n" + aguest.Address + "\n", "New Guest", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            if(dialogResult==DialogResult.OK||dialogResult!=DialogResult.OK)
            {
                this.Hide();
                homePage.ShowDialog();
                
            }
                   

            

            


            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
