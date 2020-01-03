using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class User : Person
    {
        public string Email { get; private set; }

        public User(string email,string firstName, string lastName, DateTime birthDate)
            : base(firstName, lastName, birthDate)
        {
            this.Email = email;
        }
    }
}
