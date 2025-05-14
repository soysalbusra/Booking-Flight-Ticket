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
using ComponentFactory.Krypton.Toolkit;
using WindowsFormsApp1.Context.Entities;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class ReservationForm : KryptonForm
    {

        public List<Reservation> myReservations { get; set; }


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
        public ReservationForm()
        {
            InitializeComponent();
            reservationBackground.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, reservationBackground.Width, reservationBackground.Height, 40, 40));
            waitingButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, waitingButton.Width, waitingButton.Height, 40, 40));
            complatedButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, complatedButton.Width, complatedButton.Height, 40, 40));
            canceledButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, canceledButton.Width, canceledButton.Height, 40, 40));

            myReservations = ReservationService.GetReservationsOfUser(Login.UserId);
            if (myReservations != null || myReservations.Count != 0)
            {
                this.WaitingReservations();
            }
        }


        private void InstantiateReservations(List<Reservation> reservations, string isCompleted, bool isWaiting=false)
        {
            foreach (var r in reservations)
            {

                ReservationUser reservation = new ReservationUser();
                reservation.myReservation = r;
                reservationsPanel.Controls.Add(reservation);
                
                Flight f = FlightService.Read(r.FlightId);
                Route route = RouteService.Read(f.RouteId);
                Airport departureAirport = AirportService.Read(route.DepartureAirportId);
                Airport landingAirport = AirportService.Read(route.LandingAirportId);

                TimeSpan dif = f.LandingTime - f.DepartureTime;
                var totalMin = Math.Floor(dif.TotalMinutes);
                var hour = Math.Floor(totalMin / 60);
                var min = totalMin % 60;
                string duration = "";
                if (hour != 0)
                {
                    duration += hour.ToString() + " hours";
                    if (min != 0)
                    {
                        duration += " " + min.ToString() + " minutes";
                    }
                }
                else
                {
                    duration += min.ToString() + " minutes";
                }
                
                reservation.IsCompletedText = isCompleted;
                reservation.CancelButton.Visible = isWaiting;
                reservation.CheckinButton.Visible = isWaiting;
                var diff = f.DepartureTime.Subtract(DateTime.Now).TotalHours;

                if (diff > 24 || diff < 1 || r.isCheckin)
                {
                    reservation.CheckinButton.Enabled = false;

                }
                if (diff < 24 || r.isCheckin)
                {
                    reservation.CancelButton.Enabled = false;
                }
                
                InitReservations(reservation, departureAirport, landingAirport, f.Price.ToString(), r.Pnr, f.DepartureTime.Hour.ToString()+":"+ f.DepartureTime.Minute.ToString(), "Turkish Airlines", f.DepartureTime.Day+" "+ Flying.findMounth(f.DepartureTime.Month) + " " + f.DepartureTime.Year);
                
            }
        }

        public void InitReservations(ReservationUser _reservation, Airport _from, Airport _target, string _price, string _pnr, string _hour, string _company, string _flyingDate)
        {
            _reservation.FromLocationText = _from.AirportCode+"->"+ _target.AirportCode;
            _reservation.PriceText = _price + " YTL";
            _reservation.PNRText = _pnr;
            _reservation.FlayingHourText = _hour;
            _reservation.CompanyNameText = _company;
            _reservation.FlayingDateText = _flyingDate;

        }
        private void canceledButton_Click(object sender, EventArgs e)
        {
            reservationsPanel.Controls.Clear();
            var reservations = myReservations.Where(r=>r.isActive==false).ToList();
            InstantiateReservations(reservations, "CANCELED");
        }

        private void complatedButton_Click(object sender, EventArgs e)
        {
            reservationsPanel.Controls.Clear();
            var reservations = new List<Reservation>();
            foreach (var r in myReservations)
            {
                var f = FlightService.Read(r.FlightId);
                if (f.DepartureTime.CompareTo(DateTime.Now) <= 0)
                {
                    reservations.Add(r);
                }
            }
            InstantiateReservations(reservations, "COMPLETED");
        }

        private void waitingButton_Click(object sender, EventArgs e)
        {
            this.WaitingReservations();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainPage form = new MainPage();
            form.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void WaitingReservations()
        {
            reservationsPanel.Controls.Clear();
            var reservations = new List<Reservation>();
            foreach (var r in myReservations)
            {
                var f = FlightService.Read(r.FlightId);
                if (f.DepartureTime.CompareTo(DateTime.Now) > 0)
                {
                    reservations.Add(r);
                }
            }
            InstantiateReservations(reservations, "WAITING", true);
        }

        private void reservationBackground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
