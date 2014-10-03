using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public abstract class SuperUser
    {
        private string fName;
        private string lName;
        private string address;
        private int zipcode;
        private string city;
        private string email;
        private string password;

        public SuperUser(string fName, string lName, string address, int zipcode, string city, string email, string password)
        {
            this.fName = fName;
            this.lName = lName;
            this.address = address;
            this.zipcode = zipcode;
            this.city = city;
            this.email = email;
            this.password = password;
        }

        public string FName { get { return fName; } set { fName = value; } }
        public string LName { get { return lName; } set { lName = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int Zipcode { get { return zipcode; } set { zipcode = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
    }
}
