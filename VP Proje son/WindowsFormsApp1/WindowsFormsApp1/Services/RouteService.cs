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
    public class RouteService
    {
        private readonly static BookFlightSystemDbContext context = new BookFlightSystemDbContext();

        public static void Delete(Route item)
        {
            context.Routes.Remove(item);
            context.SaveChanges();
        }

        public static void Insert(Route item)
        {
            context.Routes.Add(item);
            context.SaveChanges();
        }

        public static Route Read(string id)
        {
            return context.Routes.FirstOrDefault(r=>r.Id==id);
        }

        public static List<Route> ReadAll()
        {
            return context.Routes.ToList();
        }

        public static List<Route> GetRouteByAirport(string departureAirportId, string landingAirportId)
        {
            return context.Routes.Where(r => r.DepartureAirportId == departureAirportId).Where(r => r.LandingAirportId == landingAirportId).ToList();
        }
        public static List<Route> GetRouteByAirport(string departureAirportId, string landingAirportId, string connectionAirportId)
        {
            return context.Routes.Where(r => r.DepartureAirportId == departureAirportId).Where(r => r.LandingAirportId == landingAirportId).Where(r => r.ConnectingAirportId == connectionAirportId).ToList();
        }
        public static void Update(Route item)
        {
            context.Routes.AddOrUpdate(item);
            context.SaveChanges();
        }
    }
}