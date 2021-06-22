using System;
using System.Collections.Generic;
using System.Text;

namespace Joining
{
    class Customer
    {
        public string IdNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CurrentCountryIsoCode { get; set; }

        public override string ToString()
        {
            return $"{IdNumber}\t{FirstName}\t{LastName}";
        }
    }
}
