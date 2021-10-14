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
        public GuestListView()
        {
            InitializeComponent();
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
    }
}
