using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanStore.Domain
{
    public class Customer
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }
        public int CustomerId { get; set; }

        public Customer() { }

        public Customer(string fName, string lName, string cUsername, string cPassword)
        {
            this.CustomerFirstName = fName;
            this.CustomerLastName = lName;
            this.CustomerUsername = cUsername;
            this.CustomerPassword = cPassword;
        }
    }
}

