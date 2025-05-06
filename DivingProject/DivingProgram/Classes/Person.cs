using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class Person
    {
        protected string firstName;
        protected string lastName;
        public string email {get; set;}
        protected string password;
        protected DateTime birthDate;

        public Person (string firatName, string lastName, string email, string password, DateTime birthDate)
        {
            this.firstName = firatName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.birthDate = birthDate;
        }

        public string GetFirstName() {  return firstName; }
        public string GetLasttName() { return lastName; }

        public string GetEmail() { return email; }
        public string GetPassword() { return password; }
        public DateTime GetBirthDate() { return birthDate; }

        public void SetFirstName(string firstName) { this.firstName = firstName; }
        public void SetLastName(string lastName) { this.lastName = lastName; }
        public void SetEmail(string email) { this.email = email; }
        public void SetPassword(string password) { this.password = password; }
        public void SetBirthDate(DateTime date) { this.birthDate = date; }

    }
}
