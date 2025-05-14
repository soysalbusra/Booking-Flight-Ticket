using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WindowsFormsApp1.Context.Entities;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class Flying : KryptonForm
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

        public List<SearchCityOrAirport> ItemList = new List<SearchCityOrAirport>();
        public string From { get; set; }
        public string To { get; set; }

        public DateTime departureTime { get; set; }
        public DateTime landingTime { get; set; }

        private bool fromBool = true;
        private bool departureTimeBool = true;

        public static Timer placeTransitionTimer;
        
        
        
        public void VisibleControlAirport(string input)
        {
            
            if (input == null || input == "" || input == "Enter Your City")
            {
                foreach (var item in this.ItemList)
                {
                    searchingCountainer.Controls.Add(item);
                    item.Flying = this;
                }
            }
            else
            {
                searchingCountainer.Controls.Clear();

                foreach (var item in this.ItemList)
                {
                    if (item != null)
                    {
                        string[] inputItems = item.CityAndCountryName.Split(',');
                        string first = inputItems[0].Trim();
                        string second = inputItems[1].Trim();

                        string lowerFirst = first.ToLower();
                        string lowerSecond = second.ToLower();
                        string lowerInput = input.ToLower();

                        if (lowerFirst.StartsWith(lowerInput) || lowerSecond.StartsWith(lowerInput))
                        {
                            searchingCountainer.Controls.Add(item);
                            item.Flying = this;
                        }
                    }
                }
            }
        }
        
        public Flying()
        {
            InitializeComponent();

            //bottomPanelBackground.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, bottomPanelBackground.Width, bottomPanelBackground.Height, 40, 40));
            //FlightContainer.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, FlightContainer.Width, FlightContainer.Height, 40, 40));
            //FlightsPanelBG.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, FlightsPanelBG.Width, FlightsPanelBG.Height, 40, 40));

            //FlightsPanelBG.Visible = false;
            //LoadAirports();
            //isOneWay.Checked= true;
            //isRoundTrip.Checked= false;
            //LandingButton.Enabled= false;
            //LandingDateLabel.Enabled= false;

            sidebarContainer.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, sidebarContainer.Width, sidebarContainer.Height, 20, 20));
            nonSidebarView.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, nonSidebarView.Width, nonSidebarView.Height, 30, 30));
            nonSidebarViewTop.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, nonSidebarViewTop.Width, nonSidebarViewTop.Height, 20, 20));
            lblReturnDay.Text = "";
            lblDepatureDay.Text = "";
            placeTransitionTimer = placeTransition;

        }
        
        public void LoadAirports()
        {
            List<Airport> airports = AirportService.ReadAll();
            foreach (var airport in airports)
            {
                var item = new SearchCityOrAirport();
                item.CityAndCountryName = airport.CityName + ", " + airport.CountryName;
                item.AirportName = airport.AirportName;
                item.AirportCode = airport.AirportCode;
                item.AirportId = airport.Id;
                this.ItemList.Add(item);
                searchingCountainer.Controls.Add(item);
                item.Flying = this;
            }
        }
        private void InputBox_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Your City")
            {
                kryptonTextBox1.Text = "";
                kryptonTextBox1.ForeColor = Color.Black;
            }
        }

        private void InputBox_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text = "Enter Your City";
                kryptonTextBox1.ForeColor = Color.Silver;
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toAirportButton_Click(object sender, EventArgs e)
        {
            fromBool = false;
            placeTransition.Start();
        }


        private void SearchTicketButton_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();

            List<Flight> flights = new List<Flight>();
            //FlightsPanelBG.Visible = true;
            string departureAirportName = From.Split(',')[0].Trim();
            string departureCity = From.Split(',')[1].Trim();
            string departureCountry = From.Split(',')[2].Trim();

            string landingAirportName = To.Split(',')[0].Trim();
            string landingCity = To.Split(',')[1].Trim();
            string landingCountry = To.Split(',')[2].Trim();

            Airport departureAirport = AirportService.GetAirportByName(departureAirportName, departureCity, departureCountry);
            Airport landingAirport = AirportService.GetAirportByName(landingAirportName, landingCity, landingCountry);
            List<Route> routes = RouteService.GetRouteByAirport(departureAirport.Id, landingAirport.Id);
            foreach (var route in routes)
            {

                List<Flight> flightsOfRoute = FlightService.GetFlightsByFilters(departureTime, route.Id);
                foreach (var flight in flightsOfRoute)
                {
                    TimeSpan dif = flight.LandingTime - flight.DepartureTime;
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

                    var item = new TicketList();
                    getTicketContainer.Controls.Add(item);
                    item.flightID = flight.Id;
                    item.flying = this;
                    item.InitMySelf(flight.DepartureTime.Hour.ToString() + ":" + flight.DepartureTime.Minute.ToString(),
                        flight.LandingTime.Hour.ToString() + ":" + flight.DepartureTime.Minute.ToString(),
                        duration,
                        departureAirport.AirportCode,
                        landingAirport.AirportCode,
                        !route.ConnectingFlight ? "Direct" : "Connecting Flight",
                        flight.Price.ToString() + " YTL");
                }
                
            }
            //FlightsPanelBG.Controls.Add();
        }

        private void fromButton_Click(object sender, EventArgs e)
        {
            fromBool = true;
            placeTransition.Start();
        }

        private void InputBox_KeyUp(object sender, KeyEventArgs e)
        {
            VisibleControlAirport(kryptonTextBox1.Text);
        }
        public void ChangeCity(string airportName, string cityAndCountryName, string airportCode)
        {
            if (fromBool)
            {
                From = airportName + ", " + cityAndCountryName;
                int index = cityAndCountryName.IndexOf(",");
                var result = cityAndCountryName.Substring(0, index).Trim();
                fromButton.Text = result;
                fromAirportCode.Text = airportCode;
            }
            else
            {
                To = airportName + ", " + cityAndCountryName;
                int index = cityAndCountryName.IndexOf(",");
                var result = cityAndCountryName.Substring(0, index).Trim();
                toButton.Text = result;
                toAirportCode.Text = airportCode;
            }
        }

        string departureDay;
        string departureMounth;
        string departureYear;
        string landingDay;
        string landingMounth;
        string landingYear;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        public static string findMounth(int _mounth)
        {
            if (_mounth == 1)
                return "Jenuary";
            else if (_mounth == 2)
                return "February";
            else if (_mounth == 3)
                return "March";
            else if (_mounth == 4)
                return "April";
            else if (_mounth == 5)
                return "May";
            else if (_mounth == 6)
                return "June";
            else if (_mounth == 7)
                return "July";
            else if (_mounth == 8)
                return "August";
            else if (_mounth == 9)
                return "Spetember";
            else if (_mounth == 10)
                return "October";
            else if (_mounth == 11)
                return "November";
            else
                return "December";
        }

        string findDay(int _day)
        {
            if (_day == 1)
                return "Monday";
            else if (_day == 2)
                return "Tuesday";
            else if (_day == 3)
                return "Wednesday";
            else if (_day == 4)
                return "Thursday";
            else if (_day == 5)
                return "Friday";
            else if (_day == 6)
                return "Saturday";
            else
                return "Sunday";
        }
        private void departureDateButton_Click(object sender, EventArgs e)
        {
            dateTransition.Start();
            if (!departureTimeBool)
            {
                departureTimeBool = true;
            }
        }

        private void DepartureDateLabel_Click(object sender, EventArgs e)
        {
            if (!departureTimeBool)
            {
                departureTimeBool = true;
            }
        }
        private void LandingButton_Click(object sender, EventArgs e)
        {
            dateTransition.Start();
            if (departureTimeBool)
            {
                departureTimeBool = false;
            }
        }

        private void LandingDateLabel_Click(object sender, EventArgs e)
        {
            if (departureTimeBool)
            {
                departureTimeBool = false;
            }
        }

        private void isOneWay_CheckedChanged(object sender, EventArgs e)
        {
            if (OneWayradio.Checked)
            {
                returnDateButton.Visible = false;
                label9.Visible = false;
                lblReturnDay.Visible = false;
                departureTimeBool = true;
            }
            else
            {
                returnDateButton.Visible = true;
                label9.Visible = true;
                lblReturnDay.Visible = true;
            }
        }

        private void isRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainPage mainPage= new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void FlightContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Flying_Load(object sender, EventArgs e)
        {
            //PopulateSearchItems();
            LoadAirports();
            sidebarContainer.AutoScroll = true;
            nonSidebarView.Visible = false;
            nonSidebarViewTop.Visible = false;

            ElementsCountainer.Visible = false;
        }
        bool placeExpand = false;
        private void placeTransition_Tick(object sender, EventArgs e)
        {
            if (placeExpand == false)
            {
                placeContainer.Height += 10;
                if (placeContainer.Height >= 288)
                {
                    placeTransition.Stop();
                    placeExpand = true;
                }
            }
            else
            {
                placeContainer.Height -= 10;
                if (placeContainer.Height <= 98)
                {
                    placeTransition.Stop();
                    placeExpand = false;
                }
            }
        }
        bool dateExpand = false;
        private void dateTransition_Tick(object sender, EventArgs e)
        {
            if (dateExpand == false)
            {
                dateContainer.Height += 10;
                if (dateContainer.Height >= 274)
                {
                    dateTransition.Stop();
                    dateExpand = true;
                }
            }
            else
            {
                dateContainer.Height -= 10;
                if (dateContainer.Height <= 100)
                {
                    dateTransition.Stop();
                    dateExpand = false;
                }
            }
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {

                if (sidebarContainer.Width <= 0)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    sidebarContainer.AutoScroll = false;


                }
                else
                {
                    sidebarContainer.Width -= 10;
                    sidebarContainer.AutoScroll = false;
                    //ElementsCountainer.Location = new Point(ElementsCountainer.Location.X - 5, ElementsCountainer.Location.Y);
                }
            }
            else
            {

                if (sidebarContainer.Width >= 290)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    sidebarContainer.AutoScroll = true;
                }
                else
                {
                    sidebarContainer.Width += 10;
                    //ElementsCountainer.Location = new Point(ElementsCountainer.Location.X + 5, ElementsCountainer.Location.Y);

                }
            }

            if (sidebarContainer.Width <= 0)
            {
                nonSidebarView.Visible = true;
                nonSidebarViewTop.Visible = true;
                ElementsCountainer.Visible = true;
                lbltimer.BackColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
                lblDate.BackColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
                lbltimer.ForeColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                lblDate.ForeColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                backPicture.BackColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));

            }
            else
            {
                nonSidebarView.Visible = false;
                nonSidebarViewTop.Visible = false;
                ElementsCountainer.Visible = false;
                lblDate.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                lbltimer.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                lbltimer.ForeColor = Color.Black;
                lblDate.ForeColor = Color.Black;
                backPicture.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            }
            AdjustPictureBoxPosition();
        }

        private void AdjustPictureBoxPosition()
        {
            int sidebarWidth = sidebarContainer.Width;
            int pictureboxX = sidebarWidth - pictureBox1.Width / 3;
            pictureBox1.Location = new Point(pictureboxX, pictureBox1.Location.Y);
            backPicture.Location = new Point(sidebarWidth, backPicture.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            this.lbltimer.Text = ((DateTime.Now.Hour <= 9) ? ("0" + DateTime.Now.Hour.ToString()) : DateTime.Now.Hour.ToString()) + ":" + ((DateTime.Now.Minute <= 9) ? ("0" + DateTime.Now.Minute.ToString()) : DateTime.Now.Minute.ToString()) + ":" + ((DateTime.Now.Second <= 9) ? ("0" + DateTime.Now.Second.ToString()) : DateTime.Now.Second.ToString());

            this.lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateTransition.Start();
            if (departureTimeBool)
            {
                departureTime = monthCalendar1.SelectionStart;
                departureDateButton.Text = monthCalendar1.SelectionStart.ToString("dd MMMM", new CultureInfo("en-US"));
                lblDepatureDay.Text = monthCalendar1.SelectionStart.ToString("dddd", new CultureInfo("en-US"));
            }
            else
            {
                landingTime = monthCalendar1.SelectionStart;
                returnDateButton.Text = monthCalendar1.SelectionStart.ToString("dd MMMM", new CultureInfo("en-US"));
                lblReturnDay.Text = monthCalendar1.SelectionStart.ToString("dddd", new CultureInfo("en-US"));
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void selectTicketButton_Click(object sender, EventArgs e)
        {

        }

        private void getTicketContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }
    }
        
}
