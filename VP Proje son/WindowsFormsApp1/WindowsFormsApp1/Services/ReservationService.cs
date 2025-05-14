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
    public class ReservationService
    {
        private readonly static BookFlightSystemDbContext context = new BookFlightSystemDbContext();

        public static void Delete(Reservation item)
        {
            context.Reservations.Remove(item);
            context.SaveChanges();
        }

        public static void Insert(Reservation item)
        {
            context.Reservations.Add(item);
            context.SaveChanges();
        }

        public static Reservation Read(string id)
        {
            return context.Reservations.Find(id);
        }

        public static List<Reservation> ReadAll()
        {
            return context.Reservations.ToList();
        }
        public static void Update(Reservation item)
        {
            context.Reservations.AddOrUpdate(item);
            context.SaveChanges();
        }
        public static List<Reservation> GetReservationsOfUser(string userId)
        {
            return context.Reservations.Where(r => r.UserId == userId).ToList();
        }

        public static Reservation GetReservationByPnr(string PNR)
        {
            return context.Reservations.Where(r => r.Pnr == PNR).FirstOrDefault();
        }
    }
}
