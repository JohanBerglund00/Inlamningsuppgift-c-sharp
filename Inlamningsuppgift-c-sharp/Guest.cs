using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift_c_sharp
{
    class Guest
    {
        public Guest(string aFirstName, string aLastName, string aEmail)
        {
            firstName = aFirstName;
            lastName = aLastName;
            email = aEmail;
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
        }

        private string email;
        public string Email
        {
            get { return email; }
        }
    }
}
