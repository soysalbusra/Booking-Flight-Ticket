namespace WindowsFormsApp1
{
    partial class TicketList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTravelType = new System.Windows.Forms.Label();
            this.lblTravelTime = new System.Windows.Forms.Label();
            this.lblLandingLocation = new System.Windows.Forms.Label();
            this.lblLandingTime = new System.Windows.Forms.Label();
            this.lblDepartureLocation = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLuggageAmount = new System.Windows.Forms.Label();
            this.lblLuggage = new System.Windows.Forms.Label();
            this.pictureTransfer = new System.Windows.Forms.PictureBox();
            this.pictureTicketLogo = new System.Windows.Forms.PictureBox();
            this.BuyTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTicketLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoEllipsis = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.lblPrice.Location = new System.Drawing.Point(484, 24);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(105, 35);
            this.lblPrice.TabIndex = 34;
            this.lblPrice.Text = "2345,76 TL";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTravelType
            // 
            this.lblTravelType.AutoEllipsis = true;
            this.lblTravelType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTravelType.Location = new System.Drawing.Point(287, 60);
            this.lblTravelType.Name = "lblTravelType";
            this.lblTravelType.Size = new System.Drawing.Size(114, 17);
            this.lblTravelType.TabIndex = 31;
            this.lblTravelType.Text = "Direct";
            this.lblTravelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTravelTime
            // 
            this.lblTravelTime.AutoEllipsis = true;
            this.lblTravelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTravelTime.Location = new System.Drawing.Point(284, 10);
            this.lblTravelTime.Name = "lblTravelTime";
            this.lblTravelTime.Size = new System.Drawing.Size(117, 17);
            this.lblTravelTime.TabIndex = 30;
            this.lblTravelTime.Text = "5 Hour";
            this.lblTravelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLandingLocation
            // 
            this.lblLandingLocation.AutoEllipsis = true;
            this.lblLandingLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLandingLocation.Location = new System.Drawing.Point(396, 58);
            this.lblLandingLocation.Name = "lblLandingLocation";
            this.lblLandingLocation.Size = new System.Drawing.Size(79, 20);
            this.lblLandingLocation.TabIndex = 29;
            this.lblLandingLocation.Text = "ABD";
            this.lblLandingLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLandingTime
            // 
            this.lblLandingTime.AutoEllipsis = true;
            this.lblLandingTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLandingTime.Location = new System.Drawing.Point(392, 9);
            this.lblLandingTime.Name = "lblLandingTime";
            this.lblLandingTime.Size = new System.Drawing.Size(85, 20);
            this.lblLandingTime.TabIndex = 28;
            this.lblLandingTime.Text = "20:00";
            this.lblLandingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepartureLocation
            // 
            this.lblDepartureLocation.AutoEllipsis = true;
            this.lblDepartureLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartureLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDepartureLocation.Location = new System.Drawing.Point(207, 57);
            this.lblDepartureLocation.Name = "lblDepartureLocation";
            this.lblDepartureLocation.Size = new System.Drawing.Size(87, 20);
            this.lblDepartureLocation.TabIndex = 27;
            this.lblDepartureLocation.Text = "IST";
            this.lblDepartureLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoEllipsis = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartureTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDepartureTime.Location = new System.Drawing.Point(207, 9);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(87, 20);
            this.lblDepartureTime.TabIndex = 26;
            this.lblDepartureTime.Text = "15:00";
            this.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(220, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "--------------------------------------->";
            // 
            // lblLuggageAmount
            // 
            this.lblLuggageAmount.AutoEllipsis = true;
            this.lblLuggageAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.lblLuggageAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLuggageAmount.ForeColor = System.Drawing.Color.Black;
            this.lblLuggageAmount.Location = new System.Drawing.Point(156, 32);
            this.lblLuggageAmount.Name = "lblLuggageAmount";
            this.lblLuggageAmount.Size = new System.Drawing.Size(69, 17);
            this.lblLuggageAmount.TabIndex = 24;
            this.lblLuggageAmount.Text = "15 Kg";
            this.lblLuggageAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLuggage
            // 
            this.lblLuggage.AutoSize = true;
            this.lblLuggage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.lblLuggage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLuggage.ForeColor = System.Drawing.Color.Black;
            this.lblLuggage.Location = new System.Drawing.Point(92, 32);
            this.lblLuggage.Name = "lblLuggage";
            this.lblLuggage.Size = new System.Drawing.Size(63, 17);
            this.lblLuggage.TabIndex = 23;
            this.lblLuggage.Text = "Luggage:";
            this.lblLuggage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureTransfer
            // 
            this.pictureTransfer.Image = global::WindowsFormsApp1.Properties.Resources.dotIcon;
            this.pictureTransfer.Location = new System.Drawing.Point(324, 33);
            this.pictureTransfer.Name = "pictureTransfer";
            this.pictureTransfer.Size = new System.Drawing.Size(37, 20);
            this.pictureTransfer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTransfer.TabIndex = 32;
            this.pictureTransfer.TabStop = false;
            // 
            // pictureTicketLogo
            // 
            this.pictureTicketLogo.Image = global::WindowsFormsApp1.Properties.Resources.flightlogo;
            this.pictureTicketLogo.Location = new System.Drawing.Point(10, 11);
            this.pictureTicketLogo.Name = "pictureTicketLogo";
            this.pictureTicketLogo.Size = new System.Drawing.Size(82, 70);
            this.pictureTicketLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureTicketLogo.TabIndex = 22;
            this.pictureTicketLogo.TabStop = false;
            // 
            // BuyTicket
            // 
            this.BuyTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.BuyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BuyTicket.ForeColor = System.Drawing.Color.Black;
            this.BuyTicket.Location = new System.Drawing.Point(602, 10);
            this.BuyTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuyTicket.Name = "BuyTicket";
            this.BuyTicket.Size = new System.Drawing.Size(123, 71);
            this.BuyTicket.TabIndex = 35;
            this.BuyTicket.Text = "BUY";
            this.BuyTicket.UseVisualStyleBackColor = false;
            this.BuyTicket.Click += new System.EventHandler(this.BuyTicket_Click);
            // 
            // TicketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BuyTicket);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pictureTransfer);
            this.Controls.Add(this.lblTravelType);
            this.Controls.Add(this.lblTravelTime);
            this.Controls.Add(this.lblLandingLocation);
            this.Controls.Add(this.lblLandingTime);
            this.Controls.Add(this.lblDepartureLocation);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLuggageAmount);
            this.Controls.Add(this.lblLuggage);
            this.Controls.Add(this.pictureTicketLogo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TicketList";
            this.Size = new System.Drawing.Size(737, 92);
            this.Load += new System.EventHandler(this.TicketList_Load);
            this.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTicketLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureTransfer;
        private System.Windows.Forms.Label lblTravelType;
        private System.Windows.Forms.Label lblTravelTime;
        private System.Windows.Forms.Label lblLandingLocation;
        private System.Windows.Forms.Label lblLandingTime;
        private System.Windows.Forms.Label lblDepartureLocation;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLuggageAmount;
        private System.Windows.Forms.Label lblLuggage;
        private System.Windows.Forms.PictureBox pictureTicketLogo;
        private System.Windows.Forms.Button BuyTicket;
    }
}
