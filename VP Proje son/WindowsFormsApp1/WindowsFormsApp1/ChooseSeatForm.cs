using WindowsFormsApp1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WindowsFormsApp1.Context.Entities;
using WindowsFormsApp1.Services;
using Newtonsoft.Json;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class ChooseSeatForm : KryptonForm
    {
        public Reservation myReservation;

        private string SeatNo;
        public string seatNumber { get => SeatNo; set { SeatNo = value; } }
        public List<SeatActive> seatOccupancy { get; set; }
        public KryptonButton KryptonButton2 { get => kryptonButton2; }

        public ChooseSeatForm()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is PictureBox && (string)control.Tag != this.seatNumber)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings["Path"] + "/seat.png");

                    var seat = seatOccupancy.FirstOrDefault(s => s.SeatNo == (string)pictureBox.Tag);
                    if (seat.Active)
                    {
                        pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings["Path"] + "/full-seat.png");
                    }
                }
            }

            PictureBox clickedPictureBox = sender as PictureBox;

            if(clickedPictureBox != null && (string)clickedPictureBox.Tag != this.seatNumber)
            {
                clickedPictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings["Path"] +"/selectSeat.png");
                selectedSeat.Text = "Selected seat: " + (string)clickedPictureBox.Tag + "\nCost: 70 TL";
                kryptonButton2.Tag = (string)clickedPictureBox.Tag;
                kryptonButton1.Visible = false;
                kryptonButton2.Visible = true;

            }
            else
            {
                selectedSeat.Text = "";
                kryptonButton1.Visible = true;
                kryptonButton2.Visible = false;
            }
        }

        private void ChooseSeatForm_Load(object sender, EventArgs e)
        {
            var flight = FlightService.Read(myReservation.FlightId);
            var seatOccupancyJson = flight.SeatOccupancy;
            seatOccupancy = JsonConvert.DeserializeObject<List<SeatActive>>(seatOccupancyJson);
            

            this.seatNumber = myReservation.SeatNo;
            seatNo.Text = "Seat No: " + this.seatNumber;

            foreach (Control control in panel2.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;

                    
                    var seat = seatOccupancy.FirstOrDefault(s => s.SeatNo == (string)pictureBox.Tag);
                    if (seat.Active)
                    {
                        pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings["Path"] + "/full-seat.png");
                        if (seat.SeatNo == seatNumber)
                        {
                            pictureBox.Click += new System.EventHandler(this.pictureBox_Click);

                        }
                    }
                    else
                    {
                        pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
                        pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings["Path"] + "/seat.png");
                    }

                    if ((string)pictureBox.Tag == this.seatNumber)
                    {
                        pictureBox.Image = Image.FromFile(ConfigurationManager.AppSettings["Path"] + "/selected-seat.png");
                        kryptonButton1.Tag = (string)pictureBox.Tag;
                    }
                }
            }
        }

        private void completeTheCheckIn_Click(object sender, EventArgs e)
        {
            myReservation.isCheckin = true;
            myReservation.SeatNo = (string)kryptonButton1.Tag;
            ReservationService.Update(myReservation);
            MessageBox.Show("Check-in process has been completed successfully.", "Check-in completed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainPage form = new MainPage();
            form.Show();
            this.Close();

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Payment form = new Payment();
            form.myChooseSeat = this;
            form.deleteSeatNo = SeatNo;
            form.cost = "70 YTL";
            form.Show();
            this.Close();
        }

        private void ChooseSeatpictureBox_Click(object sender, EventArgs e)
        {
            CheckinForm form1 = new CheckinForm();
            form1.Show();
            this.Close();
        }

    }
}
