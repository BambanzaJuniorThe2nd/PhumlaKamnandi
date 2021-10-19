﻿using System;
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
    public partial class Booking_Form : Form
    {
        RoomFee roomFee;
        private Reserve reserve;
        private Collection<int> rooms;
        decimal Total = 0;
        decimal PerNight = 0;
        int Days = 0;

        public Booking_Form(Reserve Reserve)
        {
            InitializeComponent();
            reserve = Reserve;

        }
       
       
        
  

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();

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
        //    RoomFee aRoomfee = new RoomFee();
        //    Reserve areserve = new Reserve();
        //    dtpCheckin.Text = DateTime.Now.ToString();
        //    dtpCheckout.Text = DateTime.Now.ToString();
        //    DateTime checkin;
        //    DateTime checkout;
        //    checkin = DateTime.Parse(dtpCheckin.Text);
        //    checkout = DateTime.Parse(dtpCheckout.Text);
        //    rooms = areserve.makeBooking(checkin, checkout);
        //    foreach(int room in rooms)
        //    {
        //        cboRoomNmbr.Items.Add(room);
        //    }
        //    PerNight = aRoomfee.TotalFee(checkin);
        //    Days = Convert.ToInt32((checkout.Date) - (checkin.Date));
        //    Total = PerNight * Days;
        //    txtPerNight.Text = PerNight.ToString("c");
        //    txtTotal.Text = Total.ToString("c");




        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Payment_Form payment_Form = new Payment_Form(reserve);
           
          
            string id = lblGuestID.Text;
            
            DateTime Checkin = DateTime.Parse(dtpCheckin.Text);
            DateTime Checkout = DateTime.Parse(dtpCheckout.Text);


            int RoomNo = int.Parse(cboRoomNmbr.SelectedItem.ToString());





            if (Checkin.Date > Checkout.Date)
            {
                MessageBox.Show("Checkin date cannot be set to after the checkout date", "Date Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                dtpCheckin.Focus();
            }
            else if (cboRoomNmbr.SelectedIndex < -1)
            {
                MessageBox.Show("Please select an availble room to continue", "Room Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cboRoomNmbr.Focus();
            }

            else
            {

                payment_Form.lblCheckin.Text = Checkin.Date.ToString("f");
                payment_Form.lblCheckout.Text = Checkout.Date.ToString("f");
                payment_Form.lblTotal.Text = Total.ToString();
                payment_Form.lblRoomNO.Text = RoomNo.ToString();
                payment_Form.lblGuestID.Text = id;
                this.Hide();
                payment_Form.ShowDialog();



            }
           
            
                   
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGuestID_Click(object sender, EventArgs e)
        {

        }

        private void cboRoomNmbr_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPerNight_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpCheckout_ValueChanged(object sender, EventArgs e)
        {
            cboRoomNmbr.Items.Clear();
            RoomFee aRoomfee = new RoomFee();
            Reserve areserve = new Reserve();
           
            DateTime checkin;
            DateTime checkout;
            checkin = DateTime.Parse(dtpCheckin.Text);
            checkout = DateTime.Parse(dtpCheckout.Text);
            rooms = areserve.makeBooking(checkin, checkout);
            foreach (int room in rooms)
            {
                cboRoomNmbr.Items.Add(room);
            }
            PerNight = aRoomfee.TotalFee(checkin);
            Days =checkout.Subtract(checkin).Days;
            Total = PerNight * Days;
            txtPerNight.Text = PerNight.ToString();
            txtTotal.Text = Total.ToString();
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            cboRoomNmbr.Items.Clear();
            Reserve areserve = new Reserve();
            RoomFee aRoomfee = new RoomFee();
            DateTime checkin;
            DateTime checkout;
            checkin = DateTime.Parse(dtpCheckin.Text);
            checkout = DateTime.Parse(dtpCheckout.Text);
            rooms = areserve.makeBooking(checkin, checkout);
            foreach (int room in rooms)
            {
                cboRoomNmbr.Items.Add(room);
            }
            PerNight = aRoomfee.TotalFee(checkin);
            Days = checkout.Subtract(checkin).Days;
            Total = PerNight * Days;
            txtPerNight.Text = PerNight.ToString("c");
            txtTotal.Text = Total.ToString("c");


        }
    }
}
