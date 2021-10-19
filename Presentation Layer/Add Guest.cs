﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            InitializeComponentsWithDefaultValues();
        }

        private void InitializeComponentsWithDefaultValues()
        {
            SetUpTxtID();
            SetUpCboCCC();
        }

        private void SetUpTxtID()
        {
            txtID.Text = Convert.ToString(reserve.GetLargestGuestID() + 1);
        }

        private void SetUpCboCCC()
        {
            Debug.WriteLine("Setting up cboccc...");
            comboSource = new Dictionary<int, string>();

            // Retrieve and add all credit card companies
            // to comboSource
            Collection<CreditCardCompany> companies = reserve.AllCreditCardCompanies();
            foreach (CreditCardCompany company in companies)
            {
                comboSource.Add(company.CCCID, company.CCCName);
            }

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
            if (isValidInput())
            {
                Debug.WriteLine("Inside btnConfirm_Click");
                Person person = new Person(Role.RoleType.Guest);
                string id = txtID.Text;
                string Name = txtName.Text;
                string Phone = txtPhone.Text;
                string email = txtEmail.Text;
                string personalID = txtPersonalID.Text;
                string address = txtAddress.Text;
                string ccNum = txtCCNum.Text;
                int cccId = ((KeyValuePair<int, string>)cboCCC.SelectedItem).Key;
                int expirationMonth = Convert.ToInt32(txtExpMonth.Text);
                int expirationYear = Convert.ToInt32(txtExpYear.Text);

                Debug.WriteLine("cccId: " + cccId);

                person.ID = id;
                person.Name = Name;
                person.Phone = Phone;
                person.Email = email;
                person.PersonalId = personalID;

                Guest aguest = (Guest)person.role;
                aguest.Address = address;
                aguest.CreditCardNu = ccNum;
                aguest.CCCID = cccId;
                aguest.ExpirationMonth = expirationMonth;
                aguest.ExpirationYear = expirationYear;
                reserve.AddGuest(person);

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

        }

        private bool isValidInput()
        {
            if (!isValidName())
            {
                return false;
            }
            else if (!isValidEmail())
            {
                return false;
            }
            else if (!isValidPhone())
            {
                return false;
            }

            else if (!isValidPersonalID())
            {
                return false;
            }

            else if (!isValidAddress()) {
                return false;
            }

            else if (!isValidCreditCardNumber())
            {
                return false;
            }

            else if (!isValidExpirationDate())
            {
                return false;
            }

            return true;
        }

        private bool isValidName()
        {
            string name = txtName.Text.TrimEnd();
            if (name.Length == 0)
            {
                DialogResult dialogResult;
                dialogResult= MessageBox.Show("Full name required\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidEmail()
        {
            string email = txtEmail.Text.TrimEnd();
            if (!IsValidEmail(email))
            {
                DialogResult dialogResult = MessageBox.Show("Email must be valid\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidPhone()
        {
            string phone = txtPhone.Text.TrimEnd();

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone must contain digits only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (phone.Length != 10) 
            {
                MessageBox.Show("Phone must be 10 digits in length", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidPersonalID()
        {
            string personalID = txtPersonalID.Text.TrimEnd();

            if (string.IsNullOrEmpty(personalID))
            {
                MessageBox.Show("Personal ID required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!personalID.All(char.IsDigit))
            {
                MessageBox.Show("Personal ID must contain digits only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (personalID.Length != 13)
            {
                MessageBox.Show("Personal ID must be 13 digits in length", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidAddress()
        {
            string address = txtAddress.Text.TrimEnd();

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidCreditCardNumber()
        {
            string ccNum = txtCCNum.Text.TrimEnd();

            if (string.IsNullOrEmpty(ccNum))
            {
                MessageBox.Show("Credit card number required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!ccNum.All(char.IsDigit))
            {
                MessageBox.Show("Credit card number must contain digits only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (ccNum.Length != 16)
            {
                MessageBox.Show("Credit card number  must be 13 digits in length", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidExpirationDate()
        {
            string expirationMonth = txtExpMonth.Text.TrimEnd();
            string expirationYear = txtExpYear.Text.TrimEnd();

            if (string.IsNullOrEmpty(expirationMonth))
            {
                MessageBox.Show("Expiration month required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!expirationMonth.All(char.IsDigit))
            {
                MessageBox.Show("Expiration month must contain digits only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (string.IsNullOrEmpty(expirationYear))
            {
                MessageBox.Show("Expiration year required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!expirationYear.All(char.IsDigit))
            {
                MessageBox.Show("Expiration year must contain digits only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!isNotExpired(expirationMonth, expirationYear))
            {
                MessageBox.Show("Credit card must not have expired", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isNotExpired(String expirationMonth, String expirationYear)
        {
            if (Convert.ToInt32(expirationMonth) <= DateTime.Now.Month && Convert.ToInt32(expirationYear) <= DateTime.Now.Year)
            {
                return false;
            }

            return true;
        }

        private bool IsDigitsOnly(string str)
        {
            return !string.IsNullOrEmpty(str) && str.All(char.IsDigit);
        }

        private bool IsValidEmail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
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
