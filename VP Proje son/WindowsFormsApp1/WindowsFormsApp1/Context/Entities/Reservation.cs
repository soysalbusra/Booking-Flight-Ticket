using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Context.Entities
{
    public class Reservation
    {
        public string Id { get; set; } = null;

        public string UserId { get; set; } = null;

        public string FlightId { get; set; } = null;

        public string SeatNo { get; set; } = null;

        public string Pnr { get; set; } = null;

        public bool isActive { get; set; }

        public bool isCheckin { get; set; }

    }
}
