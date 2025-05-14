using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Context.Entities
{
    public class User
    {
        public string Id { get; set; } = null;

        public string Name { get; set; } = null;

        public string Email { get; set; }

        public string IdentificationNumber { get; set; }

        public string Password { get; set; } = null;

        public string Surname { get; set; } = null;

        public bool isPersonel { get; set; }
    }
}
