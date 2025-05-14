using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Context.Entities;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{


    public partial class ReservationUser : UserControl
    {



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
                (
                int nLeftRect,
                int nRigtRect,
                int nBottomRect,
                int nTopRect,
                int nWidthEllipse,
                int nHeightEllipse
                );
        public ReservationUser()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 40, 40));
            flayingHourText.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flayingHourText.Width, flayingHourText.Height, 25, 25));
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public Reservation myReservation = new Reservation();
        public string IsCompletedText
        {
            get { return IsComplatedText.Text; }
            set { IsComplatedText.Text = value; }
        }
        public Button CancelButton
        {
            get { return cancelButton; }
            set { }
        }
        public Button CheckinButton
        {
            get { return checkinButton; }
            set { }
        }
        public string CompanyNameText
        {
            get { return companyNameText.Text; }
            set { companyNameText.Text = value; }
        }

        public string FromLocationText
        {
            get { return FromToLabel.Text; }
            set { FromToLabel.Text = value; }
        }
        public string PNRText
        {
            get { return PNRNumber.Text; }
            set { PNRNumber.Text = value; }
        }

        public string PriceText
        {
            get { return priceText.Text; }
            set { priceText.Text = value; }
        }

        public string FlayingHourText
        {
            get { return flayingHourText.Text; }
            set { flayingHourText.Text = value; }
        }

        public string FlayingDateText
        {
            get { return flyingDateText.Text; }
            set { flyingDateText.Text = value; }
        }
        
        public string SituationText
        {
            get { return IsComplatedText.Text; }
            set { IsComplatedText.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passangerCountText_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Are you sure to cancel the flight?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                myReservation.isActive = false;
                ReservationService.Update(myReservation);
                this.IsComplatedText.Text = "CANCELED";
                this.Enabled = false;
            }
        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            ChooseSeatForm chooseSeatForm = new ChooseSeatForm();
            chooseSeatForm.myReservation = this.myReservation;
            chooseSeatForm.Show();
            this.Hide();
        }
    }
}
