using ComponentFactory.Krypton.Workspace;
using Newtonsoft.Json;
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
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class TicketList : UserControl
 {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
              (
                  int nLeftRect,     // x-coordinate of upper-left corner
                  int nTopRect,      // y-coordinate of upper-left corner
                  int nRightRect,    // x-coordinate of lower-right corner
                  int nBottomRect,   // y-coordinate of lower-right corner
                  int nWidthEllipse, // height of ellipse
                  int nHeightEllipse // width of ellipse
              ); 
        public TicketList()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void TicketList_Load(object sender, EventArgs e)
        {

        }
        #region Proporties

        public int _id;
        public string _luggageAmount;
        public string _departureTime;
        public string _landingTime;
        public string _departureLocation;
        public string _landingLocation;
        public string _travelType;
        public string _travelTime;
        public bool _isTransfer;
        public string _price;


        public string flightID { get; set; }
        public Flying flying { get; set; }

        [Category("Custom Props")]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        [Category("Custom Props")]
        public string LuggageAmount
        {
            get
            {
                return _luggageAmount;
            }
            set
            {
                _luggageAmount = value;
                lblLuggageAmount.Text = value.ToString() + " Kg";
            }
        }

        [Category("Custom Props")]
        public string DepartureTime
        {
            get
            {
                return _departureTime;
            }
            set
            {
                _departureTime = value;
                lblDepartureTime.Text = value;
            }
        }

        [Category("Custom Props")]
        public string LandingTime
        {
            get
            {
                return _landingTime;
            }
            set
            {
                _landingTime = value;
                lblLandingTime.Text = value;
            }
        }

        [Category("Custom Props")]
        public string DepartureLocation
        {
            get
            {
                return _departureLocation;
            }
            set
            {
                _departureLocation = value;
                lblDepartureLocation.Text = value;
            }
        }

        [Category("Custom Props")]
        public string LandingLocation
        {
            get
            {
                return _landingLocation;
            }
            set
            {
                _landingLocation = value;
                lblLandingLocation.Text = value;
            }
        }


        [Category("Custom Props")]
        public string TravelType
        {
            get
            {
                return _travelType;
            }
            set
            {
                _travelType = value;
                lblTravelType.Text = value;
            }
        }


        [Category("Custom Props")]
        public string TravelTime
        {
            get
            {
                return _travelTime;
            }
            set
            {
                _travelTime = value;
                lblTravelTime.Text = value;
            }
        }


        [Category("Custom Props")]
        public bool IsTransfer
        {
            get
            {
                return _isTransfer;
            }
            set
            {
                _isTransfer = value;
                if (_isTransfer)
                {
                    pictureTransfer.Visible = true;
                }
                else
                {
                    pictureTransfer.Visible = false;
                }

            }
        }

        [Category("Custom Props")]
        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                lblPrice.Text = value.ToString() + " ₺";
            }
        }
        #endregion

        public static int canSelectedTicketId = -1;
        private void TicketList_MouseEnter(object sender, EventArgs e)
        {
            if (this._id != canSelectedTicketId)
            {
                this.BackColor = Color.LightGray;
            }
        }

        private void TicketList_MouseLeave(object sender, EventArgs e)
        {

            if (this._id != canSelectedTicketId)
            {
                this.BackColor = Color.White;
            }
        }

        public void InitMySelf(string _startingTime, string _endingTime, string _duration, string _departureCity, string _landingCity, string _isConnectingFlight, string _price)
        {
            lblDepartureTime.Text= _startingTime;
            lblLandingTime.Text = _endingTime;
            lblTravelTime.Text = _duration;
            lblDepartureLocation.Text = _departureCity;
            lblLandingLocation.Text = _landingCity;
            lblTravelType.Text = _isConnectingFlight;
            lblPrice.Text = _price;
        }

        private void BuyTicket_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.cost = FlightService.Read(flightID).Price.ToString() + " YTL";
            payment.myTicketList = this;
            payment.myFlying = flying;
            payment.Show();
            

        }
        public Flight updatedFlight = new Flight();
        public string createSeatNo()
        {
            var flight = FlightService.Read(flightID);
            var seatActiveObject = JsonConvert.DeserializeObject<List<SeatActive>>(flight.SeatOccupancy);
            string seatNumber = "";
            bool isActiveSeat = true;
            while (isActiveSeat)
            {
                seatNumber = new Random().Next(1, 21).ToString() + Convert.ToChar(new Random().Next(65, 71));

                isActiveSeat = seatActiveObject.Where(s => s.SeatNo == seatNumber).Select(s => s.Active).FirstOrDefault();
            }

            var a = seatActiveObject.Where(s => s.SeatNo == seatNumber).FirstOrDefault();
            seatActiveObject.ElementAt(seatActiveObject.IndexOf(a)).Active = true;
            var seatOccupancy = JsonConvert.SerializeObject(seatActiveObject);
            flight.SeatOccupancy = seatOccupancy;
            updatedFlight = flight;

            return seatNumber;
        }

        public void LastProcess()
        {
            try
            {
                ReservationService.Insert(new Context.Entities.Reservation()
                {
                    Id = Guid.NewGuid().ToString(),
                    FlightId = flightID,
                    isActive = true,
                    isCheckin = false,
                    Pnr = "PNR" + new Random().Next(10000000, 100000000).ToString(),
                    SeatNo = createSeatNo(),
                    UserId = Login.UserId
                });


                FlightService.Update(updatedFlight);


            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured!" + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }
    }
}
