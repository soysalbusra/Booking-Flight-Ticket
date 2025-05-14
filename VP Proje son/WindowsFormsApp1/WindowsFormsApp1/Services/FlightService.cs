using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WindowsFormsApp1.Context;
using WindowsFormsApp1.Context.Entities;

namespace WindowsFormsApp1.Services
{
    public class FlightService
    {
        private readonly static BookFlightSystemDbContext context = new BookFlightSystemDbContext();

        public static void Delete(Flight item)
        {
            context.Flights.Remove(item);
            context.SaveChanges();
        }

        public static void Insert(Flight item)
        {
            context.Flights.Add(item);
            context.SaveChanges();
        }

        public static Flight Read(string id)
        {
            return context.Flights.FirstOrDefault(f=>f.Id==id);
        }

        public static List<Flight> ReadAll()
        {
            return context.Flights.ToList();
        }
        public static List<Flight> GetFlightsByFilters(DateTime Date, string routeId)
        {
            //Where(f => f.DepartureTime.DayOfYear == Date.DayOfYear)
            
            var flights = context.Flights.Where(f => f.RouteId == routeId).ToList();
            
            List<Flight> myFlightList = new List<Flight>();
            
            
            foreach (var flight in flights)
            {
                if (flight.DepartureTime.Date == Date.Date)
                {
                    myFlightList.Add(flight);
                }
            }

            return myFlightList;
        }

        public static void Update(Flight item)
        {
            context.Flights.AddOrUpdate(item);
            context.SaveChanges();
        }

        public static Flight GetFlightByCode(string flightCode)
        {
            return context.Flights.FirstOrDefault(f=>f.FlightCode==flightCode);
        }
    }
}
