using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class DivingClub
    {
        private string name;
        private string license;
        private string contact;
        private string address;
        private string phoneNumber;
        private string email;
        private string webSite;
        private Country country;


        public DivingClub(string name)
        {
            this.name = name;
        }

        public DivingClub( string name, string license, string contact, string address, string phoneNumber, Country country, string email)
        {
            this.name = name;
            this.license = license;
            this.contact = contact;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.country = country;
        }
        public DivingClub(string name, string license, string contact, string address, string phoneNumber, Country country, string email, string webSite)
        {
            this.name = name;
            this.license = license;
            this.contact = contact;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.webSite = webSite;
            this.country = country;
        }

        public string GetName() { return name; }
        public string GetLicense() { return license; }
        public string GetContact() { return contact; }
        public string GetAddress() { return address; }
        public string GetPhoneNumber() { return phoneNumber; }
        public string GetEmail() { return email; }
        public string GetWebsite() { return webSite; }

        public Country GetCountry() { return country; }

    }
}
