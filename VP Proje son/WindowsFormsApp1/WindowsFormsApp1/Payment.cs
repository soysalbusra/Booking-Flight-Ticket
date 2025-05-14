using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;
using WindowsFormsApp1.Context.Entities;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class Payment : KryptonForm
    {
        public TicketList myTicketList { get; set; }
        public Flying myFlying { get; set; }
        public ChooseSeatForm myChooseSeat { get; set; }
        public string cost;
        public string deleteSeatNo;
        public Payment()
        {
            InitializeComponent();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (cardNumber.Text == "11")
            {

                if (cardPaswordText.Text == "1")
                {
                    var result = MessageBox.Show("Payment Successful!");
                    if (myChooseSeat != null)
                    {
                        myChooseSeat.myReservation.isCheckin = true;
                        myChooseSeat.myReservation.SeatNo = (string)myChooseSeat.KryptonButton2.Tag;



                        var flight = FlightService.Read(myChooseSeat.myReservation.FlightId);
                        var seatActiveObject = JsonConvert.DeserializeObject<List<SeatActive>>(flight.SeatOccupancy);


                        var a = seatActiveObject.Where(s => s.SeatNo == (string)myChooseSeat.KryptonButton2.Tag).FirstOrDefault();
                        var b = seatActiveObject.Where(s => s.SeatNo == deleteSeatNo).FirstOrDefault();
                        
                        seatActiveObject.ElementAt(seatActiveObject.IndexOf(a)).Active = true;
                        seatActiveObject.ElementAt(seatActiveObject.IndexOf(b)).Active = false;
                        var seatOccupancy = JsonConvert.SerializeObject(seatActiveObject);
                        flight.SeatOccupancy = seatOccupancy;

                        ReservationService.Update(myChooseSeat.myReservation);
                        FlightService.Update(flight);
                    }
                    else
                    {
                        myTicketList.LastProcess();
                    }

                    if (result == DialogResult.OK)
                    {
                        MainPage mainPage = new MainPage();
                        mainPage.Show();
                        if (myChooseSeat != null)
                        {
                            this.myChooseSeat.Hide();
                        }
                        else
                        {
                            this.myFlying.Hide();
                        }
                        
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Check your password!");

                }
            }
            else
            {
                MessageBox.Show("Check your card number!");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            Cost.Text = "Cost: " + cost;
        }

        private void infoOutput_Click(object sender, EventArgs e)
        {

        }

        private void cardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void reservationBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardNumber_Enter(object sender, EventArgs e)
        {
            if (cardNumber.Text == "Card Number")
            {
                cardNumber.Text = "";
                cardNumber.ForeColor= Color.Black;
            }
        }

        private void cardNumber_Leave(object sender, EventArgs e)
        {
            if (cardNumber.Text == "")
            {
                cardNumber.Text = "Card Number";
                cardNumber.ForeColor= Color.Silver;
            }
        }

        private void cardPaswordText_Enter(object sender, EventArgs e)
        {
            if (cardPaswordText.Text == "Password")
            {
                cardPaswordText.Text = "";
                cardPaswordText.ForeColor = Color.Silver;
            }
        }

        private void cardPaswordText_Leave(object sender, EventArgs e)
        {
            if (cardPaswordText.Text == "")
            {
                cardPaswordText.Text = "Password";
                cardPaswordText.ForeColor = Color.Black;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
    }

