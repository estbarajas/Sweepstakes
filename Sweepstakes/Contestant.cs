using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAdress;
        public int registrationNumber;
        public Contestant()
        {
            registrationNumber = 0;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetEmailAdress(string emailAdress)
        {
            this.emailAdress = emailAdress;
        }
    }
}
