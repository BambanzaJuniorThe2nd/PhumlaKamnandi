
namespace PhumlaKamnandi.Presentation_Layer
{
    partial class BookingsListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingsListView));
            this.label6 = new System.Windows.Forms.Label();
            this.listViewBookings = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CityLbl = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtCheckout = new System.Windows.Forms.TextBox();
            this.txCheckin = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.RoomNolbl = new System.Windows.Forms.Label();
            this.CheckoutLBl = new System.Windows.Forms.Label();
            this.CheckinLbl = new System.Windows.Forms.Label();
            this.GuestIDlbl = new System.Windows.Forms.Label();
            this.BookingIDlbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(326, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "All Bookings";
            // 
            // listViewBookings
            // 
            this.listViewBookings.HideSelection = false;
            this.listViewBookings.Location = new System.Drawing.Point(18, 85);
            this.listViewBookings.Name = "listViewBookings";
            this.listViewBookings.Size = new System.Drawing.Size(765, 280);
            this.listViewBookings.TabIndex = 12;
            this.listViewBookings.UseCompatibleStateImageBehavior = false;
            this.listViewBookings.SelectedIndexChanged += new System.EventHandler(this.listViewBookings_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.CityLbl);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtRoomNo);
            this.groupBox1.Controls.Add(this.txtCheckout);
            this.groupBox1.Controls.Add(this.txCheckin);
            this.groupBox1.Controls.Add(this.txtBookingID);
            this.groupBox1.Controls.Add(this.txtGuestID);
            this.groupBox1.Controls.Add(this.RoomNolbl);
            this.groupBox1.Controls.Add(this.CheckoutLBl);
            this.groupBox1.Controls.Add(this.CheckinLbl);
            this.groupBox1.Controls.Add(this.GuestIDlbl);
            this.groupBox1.Controls.Add(this.BookingIDlbl);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(18, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 323);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CityLbl
            // 
            this.CityLbl.AutoSize = true;
            this.CityLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLbl.Location = new System.Drawing.Point(10, 220);
            this.CityLbl.Name = "CityLbl";
            this.CityLbl.Size = new System.Drawing.Size(42, 20);
            this.CityLbl.TabIndex = 53;
            this.CityLbl.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(123, 220);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(217, 25);
            this.txtTotal.TabIndex = 52;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(413, 39);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(45, 34);
            this.deleteButton.TabIndex = 49;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(422, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Blue;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(605, 269);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 39);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhumlaKamnandi.Properties.Resources._2cbdceb401ee446d991b1f3d0a74598d__1_;
            this.pictureBox1.Location = new System.Drawing.Point(521, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.Location = new System.Drawing.Point(123, 173);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(217, 25);
            this.txtRoomNo.TabIndex = 9;
            // 
            // txtCheckout
            // 
            this.txtCheckout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckout.Location = new System.Drawing.Point(123, 131);
            this.txtCheckout.Name = "txtCheckout";
            this.txtCheckout.Size = new System.Drawing.Size(217, 25);
            this.txtCheckout.TabIndex = 8;
            // 
            // txCheckin
            // 
            this.txCheckin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCheckin.Location = new System.Drawing.Point(123, 90);
            this.txCheckin.Name = "txCheckin";
            this.txCheckin.Size = new System.Drawing.Size(217, 25);
            this.txCheckin.TabIndex = 7;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.Location = new System.Drawing.Point(123, 48);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(72, 25);
            this.txtBookingID.TabIndex = 6;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestID.Location = new System.Drawing.Point(266, 47);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(74, 25);
            this.txtGuestID.TabIndex = 5;
            // 
            // RoomNolbl
            // 
            this.RoomNolbl.AutoSize = true;
            this.RoomNolbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNolbl.Location = new System.Drawing.Point(10, 174);
            this.RoomNolbl.Name = "RoomNolbl";
            this.RoomNolbl.Size = new System.Drawing.Size(107, 20);
            this.RoomNolbl.TabIndex = 4;
            this.RoomNolbl.Text = "Room Number";
            // 
            // CheckoutLBl
            // 
            this.CheckoutLBl.AutoSize = true;
            this.CheckoutLBl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutLBl.Location = new System.Drawing.Point(10, 132);
            this.CheckoutLBl.Name = "CheckoutLBl";
            this.CheckoutLBl.Size = new System.Drawing.Size(76, 20);
            this.CheckoutLBl.TabIndex = 3;
            this.CheckoutLBl.Text = "Check-out";
            // 
            // CheckinLbl
            // 
            this.CheckinLbl.AutoSize = true;
            this.CheckinLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckinLbl.Location = new System.Drawing.Point(10, 90);
            this.CheckinLbl.Name = "CheckinLbl";
            this.CheckinLbl.Size = new System.Drawing.Size(66, 20);
            this.CheckinLbl.TabIndex = 2;
            this.CheckinLbl.Text = "Check-in";
            // 
            // GuestIDlbl
            // 
            this.GuestIDlbl.AutoSize = true;
            this.GuestIDlbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestIDlbl.Location = new System.Drawing.Point(199, 48);
            this.GuestIDlbl.Name = "GuestIDlbl";
            this.GuestIDlbl.Size = new System.Drawing.Size(61, 20);
            this.GuestIDlbl.TabIndex = 1;
            this.GuestIDlbl.Text = "GuestID";
            // 
            // BookingIDlbl
            // 
            this.BookingIDlbl.AutoSize = true;
            this.BookingIDlbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingIDlbl.Location = new System.Drawing.Point(10, 52);
            this.BookingIDlbl.Name = "BookingIDlbl";
            this.BookingIDlbl.Size = new System.Drawing.Size(79, 20);
            this.BookingIDlbl.TabIndex = 0;
            this.BookingIDlbl.Text = "BookingID";
            // 
            // BookingsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewBookings);
            this.Controls.Add(this.label6);
            this.Name = "BookingsListView";
            this.Text = "Bookings View";
            this.Activated += new System.EventHandler(this.BookingsListView_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookingsListView_FormClosed);
            this.Load += new System.EventHandler(this.BookingsListView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewBookings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CityLbl;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtCheckout;
        private System.Windows.Forms.TextBox txCheckin;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label RoomNolbl;
        private System.Windows.Forms.Label CheckoutLBl;
        private System.Windows.Forms.Label CheckinLbl;
        private System.Windows.Forms.Label GuestIDlbl;
        private System.Windows.Forms.Label BookingIDlbl;
    }
}