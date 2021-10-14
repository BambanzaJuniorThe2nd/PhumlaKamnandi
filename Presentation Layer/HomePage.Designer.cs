
namespace PhumlaKamnandi.Presentation_Layer
{
    partial class HomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnMonthlyReports = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtGuestID);
            this.panel1.Location = new System.Drawing.Point(-11, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 74);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAddGuest);
            this.panel3.Location = new System.Drawing.Point(490, -6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 80);
            this.panel3.TabIndex = 7;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.BackColor = System.Drawing.Color.Navy;
            this.btnAddGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGuest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.ForeColor = System.Drawing.Color.White;
            this.btnAddGuest.Location = new System.Drawing.Point(104, 25);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(130, 43);
            this.btnAddGuest.TabIndex = 7;
            this.btnAddGuest.Text = "New Guest";
            this.btnAddGuest.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(306, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtGuestID
            // 
            this.txtGuestID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtGuestID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGuestID.Location = new System.Drawing.Point(44, 26);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(212, 29);
            this.txtGuestID.TabIndex = 7;
            this.txtGuestID.Text = "Enter Guest ID";
            this.txtGuestID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuestID.Enter += new System.EventHandler(this.txtGuestID_Enter);
            this.txtGuestID.Leave += new System.EventHandler(this.txtGuestID_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhumlaKamnandi.Properties.Resources._2cbdceb401ee446d991b1f3d0a74598d__1_;
            this.pictureBox1.Location = new System.Drawing.Point(277, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Blue;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBooking.Location = new System.Drawing.Point(3, 77);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(140, 46);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Text = "Bookings";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.BackColor = System.Drawing.Color.Blue;
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNotification.Location = new System.Drawing.Point(3, 124);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(140, 46);
            this.btnNotification.TabIndex = 5;
            this.btnNotification.Text = "Notifications";
            this.btnNotification.UseVisualStyleBackColor = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnMonthlyReports
            // 
            this.btnMonthlyReports.BackColor = System.Drawing.Color.Blue;
            this.btnMonthlyReports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMonthlyReports.Location = new System.Drawing.Point(3, 167);
            this.btnMonthlyReports.Name = "btnMonthlyReports";
            this.btnMonthlyReports.Size = new System.Drawing.Size(140, 46);
            this.btnMonthlyReports.TabIndex = 6;
            this.btnMonthlyReports.Text = "Monthy Reports";
            this.btnMonthlyReports.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Blue;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHelp.Location = new System.Drawing.Point(3, 210);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(140, 46);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help/Support";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Blue;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogout.Location = new System.Drawing.Point(3, 253);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 46);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button3_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMonthlyReports);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.btnBooking);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnMonthlyReports;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLogout;
    }
}