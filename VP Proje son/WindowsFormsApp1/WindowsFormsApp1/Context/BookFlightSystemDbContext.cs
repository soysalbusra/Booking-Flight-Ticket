using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Reflection.Emit;
using WindowsFormsApp1.Context.Entities;

namespace WindowsFormsApp1.Context
{
    public partial class BookFlightSystemDbContext : DbContext
    {
        public BookFlightSystemDbContext() : base("workstation id=BookFlightSystemDB.mssql.somee.com;packet size=4096;user id=berkeyildirim_SQLLogin_1;pwd=shfcqlsg72;data source=BookFlightSystemDB.mssql.somee.com;persist security info=False;initial catalog=BookFlightSystemDB;TrustServerCertificate=True")
        {
        }


        public virtual DbSet<Airport> Airports { get; set; }

        public virtual DbSet<Flight> Flights { get; set; }

        public virtual DbSet<Reservation> Reservations { get; set; }

        public virtual DbSet<Route> Routes { get; set; }

        public virtual DbSet<User> Users { get; set; }

    }
}