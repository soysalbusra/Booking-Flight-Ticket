using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Context.Entities
{
    public class Route
    {
        public string Id { get; set; } = null;
        public string DepartureAirportId { get; set; } = null;
        public string LandingAirportId { get; set; } = null;
        public string ConnectingAirportId { get; set; }
        public bool ConnectingFlight { get; set; }
    }
}
