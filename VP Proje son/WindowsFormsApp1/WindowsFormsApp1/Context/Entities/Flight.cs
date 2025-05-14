using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Context.Entities
{
    public class Flight
    {
        public string Id { get; set; } = null;

        public string RouteId { get; set; } = null;    

        public string Airplane { get; set; } = null;

        public string SeatOccupancy { get; set; } = null;

        public decimal Price { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime LandingTime { get; set; }

        public string FlightCode { get; set; } = null;
    }
}
