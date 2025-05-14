using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Context.Entities
{
    public class Airport
    {
        public string Id { get; set; } = null;
        public string AirportName { get; set; } = null;
        public string AirportCode { get; set; } = null;
        public string CityName { get; set; } = null;
        public string CountryName { get; set; } = null;
    }
}
