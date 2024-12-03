using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejelentkezesKonzol
{
    public class Felhasznalo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IsAdmin { get; set; }

        public Felhasznalo(string name, string email, string password, int isAdmin)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.IsAdmin = isAdmin;
        }
    }
}
