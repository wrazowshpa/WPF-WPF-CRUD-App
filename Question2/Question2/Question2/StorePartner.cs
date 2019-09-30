using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class StorePartner
    {
        public int IndexNumber { get; set; }
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        

        public StorePartner(int indexNumber, string id, string companyName, string contactName, string contactTitle, string address, string city, string country)
        {
            IndexNumber = indexNumber;
            Id = id;
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return string.Format("Company: "+CompanyName + "\nContact: " + ContactName+"\n");
        }
    }
}
