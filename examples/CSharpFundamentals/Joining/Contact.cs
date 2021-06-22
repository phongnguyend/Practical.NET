using System;
using System.Collections.Generic;
using System.Text;

namespace Joining
{
    class Contact
    {
        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string CustomerIdNumber { get; set; }

        public string CountryIsoCode { get; set; }

        public override string ToString()
        {
            return $"{CustomerIdNumber}\t{EmailAddress}\t{PhoneNumber}";
        }
    }
}
