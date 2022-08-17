using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class Clients
    {
        private string vClientId, vName, vStreet, vCity, vPostalCode, vPhoneNumber, vFaxNumber, vCreditLimit;

        public string ClientId 
        {
            get => vClientId;
            set => vClientId = value; 
        }

        public string Name 
        {
            get => vName;
            set => vName = value; 
        }

        public string Street 
        {
            get => vStreet;
            set => vStreet = value; 
        }

        public string City 
        {
            get => vCity;
            set => vCity = value; 
        }

        public string PostalCode 
        {
            get => vPostalCode;
            set => vPostalCode = value; 
        }

        public string PhoneNumber 
        {
            get => vPhoneNumber;
            set => vPhoneNumber = value; 
        }

        public string FaxNumber 
        {
            get => vFaxNumber;
            set => vFaxNumber = value; 
        }

        public string CreditLimit 
        {
            get => vCreditLimit;
            set => vCreditLimit = value; 
        }
    }
}
