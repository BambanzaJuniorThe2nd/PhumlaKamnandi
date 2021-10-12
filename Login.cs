using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Presentation_Layer;

namespace PhumlaKamnandi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        HomePage homePage = new HomePage();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void UserNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
               if((UserNametxt.Text!="")&&(Passwordtxt.Text!=""))
                {
                    this.Hide();
                    homePage.ShowDialog();
                  
                }
                else
                {
                MessageBox.Show("Please complete all fields before proceeding", "Incomplete Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            
           
        }
    }
}
