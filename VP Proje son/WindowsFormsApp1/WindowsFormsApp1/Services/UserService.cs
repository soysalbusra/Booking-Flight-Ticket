using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Context;
using WindowsFormsApp1.Context.Entities;

namespace WindowsFormsApp1.Services
{
    public class UserService
    {
        private readonly static BookFlightSystemDbContext context = new BookFlightSystemDbContext();

        public static void Delete(User item)
        {
            context.Users.Remove(item);
            context.SaveChanges();
        }


        public static void Insert(User item)
        {
            context.Users.Add(item);
            context.SaveChanges();
        }

        public static User Read(string id)
        {
            return context.Users.Find(id);
        }

        public static List<User> ReadAll()
        {
            return context.Users.ToList();
        }

        public static string Login(string id, string password)
        {
            User user = context.Users.Where(u => u.IdentificationNumber == id).FirstOrDefault();
            if (user != null && user.Password == password)
            {
                return user.Id;
            }
            return "-1";
        }
        public static void Update(User item)
        {
            context.Users.AddOrUpdate(item);
            context.SaveChanges();
        }
        public static User GetUserBySurname(string surname)
        {
            return context.Users.FirstOrDefault(u => u.Surname.ToLower() == surname.ToLower());
        }
    }
}
