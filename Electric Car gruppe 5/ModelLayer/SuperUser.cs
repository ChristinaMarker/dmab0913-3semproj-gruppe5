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
        private string phone;
        private string email;
        private string password;

        /// <summary>
        /// Constructor for the SuperUser class
        /// </summary>
        /// <param name="fName">The first name of the user</param>
        /// <param name="lName">The last name of the user</param>
        /// <param name="address">The address of the user</param>
        /// <param name="zipcode">The zipcode of the user</param>
        /// <param name="city">The city of the user</param>
        /// <param name="email">The email of the user</param>
        /// <param name="password">The password of the user</param>
        public SuperUser(string fName, string lName, string address, int zipcode, string city, string phone, string email, string password)
        {
            this.fName = fName;
            this.lName = lName;
            this.address = address;
            this.zipcode = zipcode;
            this.phone = phone;
            this.city = city;
            this.email = email;
            this.password = password;
        }

        public string FName { get { return fName; } set { fName = value; } }
        public string LName { get { return lName; } set { lName = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int Zipcode { get { return zipcode; } set { zipcode = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
    }
}
