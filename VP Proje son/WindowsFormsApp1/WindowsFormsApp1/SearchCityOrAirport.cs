using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SearchCityOrAirport : UserControl
    {

        public bool _isSelected = false;
        public SearchCityOrAirport()
        {
            InitializeComponent();
        }

        public Flying Flying { get; set; }

        #region Proporties

        private string _cityAndCountryName { get; set; }
        private string _airportName { get; set; }
        private string _airportCode;
        private string _airportId;

        [Category("Custom Props")]
        public string AirportCode
        {
            get
            {
                return _airportCode;
            }
            set
            {
                _airportCode = value;
            }
        }

        [Category("Custom Props")]
        public string AirportId
        {
            get
            {
                return _airportId;
            }
            set
            {
                _airportId = value;
            }
        }

        [Category("Custom Props")]
        public string CityAndCountryName
        {
            get
            {
                return _cityAndCountryName;
            }
            set
            {
                _cityAndCountryName = value;
                lblCityCountry.Text = value.ToString();
            }
        }

        [Category("Custom Props")]
        public string AirportName
        {
            get
            {
                return _airportName;
            }
            set
            {
                _airportName = value;
                lblAirportName.Text = value;
            }
        }

        #endregion

        private void btnAirportSelect_Click(object sender, EventArgs e)
        {
            
            this.Flying.ChangeCity(AirportName, CityAndCountryName, AirportCode);
            Flying.placeTransitionTimer.Start();
        }

        private void SearchCityOrAirport_MouseEnter(object sender, EventArgs e)
        {
            _isSelected = true;
        }

        public void TurnOnOf(bool turn)
        {
            this.cityBg.Visible = turn;
        }

        private void lblAirportName_Click(object sender, EventArgs e)
        {
            this.Flying.ChangeCity(AirportName, CityAndCountryName, AirportCode);
            Flying.placeTransitionTimer.Start();
        }
    }
}
