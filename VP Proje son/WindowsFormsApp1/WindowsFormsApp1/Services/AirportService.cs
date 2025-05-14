using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Context;
using WindowsFormsApp1.Context.Entities;

namespace WindowsFormsApp1.Services
{
    public class AirportService
    {
        private readonly static BookFlightSystemDbContext context = new BookFlightSystemDbContext();
        public void Delete(Airport item)
        {
            context.Airports.Remove(item);
            context.SaveChanges();
        }

        public static void Insert(Airport item)
        {
            context.Airports.Add(item);
            context.SaveChanges();
        }

        public static Airport Read(string id)
        {
            return context.Airports.FirstOrDefault(a=>a.Id==id);
        }

        public static List<Airport> ReadAll()
        {
            return context.Airports.ToList();
        }

        public static Airport GetAirportByName(string airportName, string airportCity, string countryName)
        {
            Airport airport = context.Airports.Where(a => a.AirportName.Equals(airportName)).Where(a => a.CityName.Equals(airportCity)).Where(a => a.CountryName.Equals(countryName)).FirstOrDefault();
            return airport;
        }

        public static Airport GetAirportByName(string airportCity, string countryName)
        {
            Airport airport = context.Airports.Where(a => a.CityName.Equals(airportCity)).Where(a => a.CountryName.Equals(countryName)).FirstOrDefault();
            return airport;
        }
        public static void Update(Airport item)
        {
            context.Airports.AddOrUpdate(item);
            context.SaveChanges();
        }
    }
}
