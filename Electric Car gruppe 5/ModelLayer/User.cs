using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class User : SuperUser
    {
        public User(string fName, string lName, string address, int zipcode, string city, string phone, string email, string password) 
            : base(fName, lName, address, zipcode, city, phone, email, password)
        {

        }
    }
}
