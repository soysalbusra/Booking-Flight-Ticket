using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Staff : KryptonForm
    {
        private String FlightCode;
        private Airport DepartureAirport;
        private Airport LandingAirport;
        private Airport ConnectingAirport;
        private DateTime DepartureDateTime;
        private DateTime LandingDateTime;
        private String price;
        private String airplane;

        public Flight deleteFlight;

        public String searchInput { get; set; }

        public Staff()
        {
            InitializeComponent();
        }

        private void StaffFormAddFlightTitlelabel_Click(object sender, EventArgs e)
        {

        }

        private void StaffFormAddFlightAddbutton_Click(object sender, EventArgs e)
        {

        }

        private void StaffFormAddFlightResetbutton_Click(object sender, EventArgs e)
        {

        }

        private void StaffFormArrivalDatedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StaffFormDepartureDatedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StaffDepartureAirportlabel_Click(object sender, EventArgs e)
        {

        }

        private void Stafftimer_Tick(object sender, EventArgs e)
        {
            StaffFormDatelabel.Text = DateTime.Now.ToShortDateString();
            StaffFormTimelabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void StaffFormAddFlightbutton_Click(object sender, EventArgs e)
        {
            StafftabControl.SelectedTab = AddFlight;
        }


        private void ResetForm()
        {
            StaffDepartureAirportcomboBox.SelectedIndex = -1;
            StaffDestinationAirportcomboBox.SelectedIndex = -1;

            StaffDepartureDatedateTimePicker.Value = DateTime.Now;
            StaffFormArrivalDatedateTimePicker.Value = DateTime.Now;

        }
        private void StaffAddFlightResetbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void StaffDepartureDatedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DepartureDateTime = StaffDepartureDatedateTimePicker.Value;
            if (LandingDateTime != null)
            {
                TimeSpan diff = LandingDateTime - DepartureDateTime;
                label7.Text = Math.Floor(diff.TotalMinutes).ToString();
            }
        }

        private void StaffFormArrivalDatedateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            LandingDateTime = StaffFormArrivalDatedateTimePicker.Value;
            if (DepartureDateTime != null)
            {
                TimeSpan diff = LandingDateTime - DepartureDateTime;
                label7.Text = diff.TotalMinutes.ToString();
            }
        }

        private void StaffAddFlightAddbutton_Click(object sender, EventArgs e)
        {
            if (StaffDepartureAirportcomboBox.SelectedIndex == -1 || StaffDestinationAirportcomboBox.SelectedIndex == -1 || StaffDepartureDatedateTimePicker.Value <= DateTime.Now || StaffFormArrivalDatedateTimePicker.Value <= DateTime.Now || textBox3.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                DialogResult result = MessageBox.Show("Are you sure you want to add this flight?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var route = new Route();
                        if (DepartureAirport != null || LandingAirport != null)
                        {
                            if (ConnectingAirport == null)
                            {
                                route = RouteService.GetRouteByAirport(DepartureAirport.Id, LandingAirport.Id).FirstOrDefault();
                            }
                            else
                            {
                                route = RouteService.GetRouteByAirport(DepartureAirport.Id, LandingAirport.Id, ConnectingAirport.Id).FirstOrDefault();
                            }
                            if (route == null)
                            {
                                route = new Route()
                                {
                                    Id = Guid.NewGuid().ToString(),
                                    DepartureAirportId = DepartureAirport.Id,
                                    LandingAirportId = LandingAirport.Id
                                };
                                if (ConnectingAirport != null)
                                {
                                    route.ConnectingAirportId = ConnectingAirport.Id;
                                }
                                RouteService.Insert(route);
                            }
                        }
                        var flight = new Flight()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Airplane = airplane,
                            RouteId = route.Id,
                            Price = Convert.ToDecimal(price),
                            DepartureTime = DepartureDateTime,
                            LandingTime = LandingDateTime,
                            FlightCode = FlightCode
                        };
                        List<SeatActive> seatOccupancy = new List<SeatActive>();

                        for (int i = 1; i < 21; i++)
                        {
                            for (int j = 65; j < 71; j++)
                            {
                                seatOccupancy.Add(new SeatActive
                                {
                                    SeatNo = i.ToString() + (char)j,
                                    Active = false,
                                });
                            }
                        }

                        flight.SeatOccupancy = JsonConvert.SerializeObject(seatOccupancy);
                        FlightService.Insert(flight);
                        MessageBox.Show("Flight added successfully!", "Success", MessageBoxButtons.OK);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Flight adding failed. Error: " + err.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }

                }
            }
        }


        private void StaffFormUpdatebutton_Click(object sender, EventArgs e)
        {

            if (StaffDepartureAirportcomboBox.SelectedIndex == -1
     || StaffDestinationAirportcomboBox.SelectedIndex == -1

     || StaffDepartureDatedateTimePicker.Value <= DateTime.Now
     || StaffFormArrivalDatedateTimePicker.Value <= DateTime.Now)
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this flight?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Flight updated successfully!", "Success", MessageBoxButtons.OK);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to cancel this flight?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FlightService.Delete(deleteFlight);
                    MessageBox.Show("Flight has been canceled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show("An error occured while deleting flight." + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void StaffFormSearchFlightbutton_Click(object sender, EventArgs e)
        {
            //StafftabControl.SelectedTab = SearchFlight;
        }

        private void StaffFormCancelFlightbutton_Click(object sender, EventArgs e)
        {
            StafftabControl.SelectedTab = CancelFlight;
        }

        private void StaffLogoutAdd_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void StaffLogoutSearch_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void StaffLogoutCancel_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            var allFlights = FlightService.ReadAll();

            foreach (var flight in allFlights)
            {
                var routeOfFlight = RouteService.Read(flight.RouteId);
                var departureAirport = AirportService.Read(routeOfFlight.DepartureAirportId);
                var landingAirport = AirportService.Read(routeOfFlight.LandingAirportId);
                StaffCancelFlightIdcomboBox.Items.Add(flight.FlightCode + " - " + departureAirport.AirportCode + " --> " + landingAirport.AirportCode);
            }

            StaffDepartureAirportcomboBox.Items.Clear();
            StaffDestinationAirportcomboBox.Items.Clear();
            ConnectingAirportComboBox.Items.Clear();

            List<Airport> airports = AirportService.ReadAll();

            foreach (Airport airport in airports)
            {
                StaffDepartureAirportcomboBox.Items.Add(airport.AirportName + ", " + airport.CityName + ", " + airport.CountryName);
                StaffDestinationAirportcomboBox.Items.Add(airport.AirportName + ", " + airport.CityName + ", " + airport.CountryName);
                ConnectingAirportComboBox.Items.Add(airport.AirportName + ", " + airport.CityName + ", " + airport.CountryName);
            }

            StaffDepartureDatedateTimePicker.MinDate = DateTime.Now;
            StaffFormArrivalDatedateTimePicker.MinDate = DateTime.Now;
            label7.Text = "";
            ConnectingAirportComboBox.Enabled = false;
        }
        private void StaffDepartureAirportcomboBox_Click(object sender, EventArgs e)
        {

        }

        private void StaffDestinationAirportcomboBox_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            FlightCode = textBox3.Text;
        }

        private void StaffDepartureAirportcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string[] AirportParts = new string[3];
                AirportParts = StaffDepartureAirportcomboBox.Text.Split(',');
                DepartureAirport = AirportService.GetAirportByName(AirportParts[0].Trim(), AirportParts[1].Trim(), AirportParts[2].Trim());

            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured. Please try again later." + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffDestinationAirportcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string[] AirportParts = new string[3];
                AirportParts = StaffDestinationAirportcomboBox.Text.Split(',');
                LandingAirport = AirportService.GetAirportByName(AirportParts[0].Trim(), AirportParts[1].Trim(), AirportParts[2].Trim());

            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured. Please try again later." + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AirplaneComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            price = PriceTextBox.Text.Trim();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ConnectingAirportComboBox.Enabled = checkBox1.Checked;
        }

        private void ConnectingAirportComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string[] AirportParts = new string[3];
                AirportParts = ConnectingAirportComboBox.Text.Split(',');
                ConnectingAirport = AirportService.GetAirportByName(AirportParts[0].Trim(), AirportParts[1].Trim(), AirportParts[2].Trim());

            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured. Please try again later." + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffDestinationAirportcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void airplaneTextBox_TextChanged(object sender, EventArgs e)
        {
            airplane = airplaneTextBox.Text.Trim();
        }

        private void StaffCancelFlightIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var flightCode = (string)StaffCancelFlightIdcomboBox.SelectedItem;
            deleteFlight = FlightService.GetFlightByCode(flightCode.Split('-')[0].ToUpper().Trim());
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //searchInput = textBox1.Text.Trim();
        }

        private void StaffFormSearchpictureBox_Click(object sender, EventArgs e)
        {
        }
    }
}
