using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class Client
    {
        private string firstLastName;
        private Sex sex;
        private DateTime dateOfBirth;

        private CreditCard creditCard;
        private DriversLicence driversLicence;
        private string phoneNumber;
        private string address;
        private ID iDCard;

        public Client(string firstLastName, Sex sex, DateTime dateOfBirth, string phoneNumber, string address,
            CreditCard creditCard, DriversLicence driversLicence, ID iDCard)
        {
            this.FirstLastName = firstLastName;
            this.Sex = sex;
            this.DateOfBirth = dateOfBirth;

            this.CreditCard = creditCard;
            this.DriversLicence= driversLicence;
            this.IDCard= iDCard;
            this.PhoneNumber= phoneNumber;
            this.Address = address;
        }

        //a constructor in case the user chooses not to pay with a credit card
        public Client(string firstLastName, Sex sex, DateTime dateOfBirth, string phoneNumber, string address,
            DriversLicence driversLicence, ID iDCard) 
            :this (firstLastName,  sex,  dateOfBirth,  phoneNumber,  address,
             new CreditCard(),  driversLicence,  iDCard)
        {

        }

        public string FirstLastName
        {
            get
            {
                return this.firstLastName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a value for first and last name.");
                }
                this.firstLastName = value;
            }
        }

        public int Age
        {
            get
            {
                TimeSpan age = DateTime.Now - this.DateOfBirth;

                if (age.Days / 365 < 18)
                {
                    throw new InvalidAgeForRentException("You must be 18 years or older to rent a car.");
                }

                return age.Days / 365;
            }
        }

        public Sex Sex
        {
            get
            {
                return this.sex;
            }

            set
            {
                this.sex = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                this.dateOfBirth = value;
            }
        }

        public CreditCard CreditCard
        {
            get
            {
                return this.creditCard;
            }

            set
            {
                this.creditCard = value;
            }
        }

        public DriversLicence DriversLicence
        {
            get
            {
                return this.driversLicence;
            }

            set
            {
                this.driversLicence = value;
            }
        }

        public ID IDCard
        {
            get
            {
                return this.iDCard;
            }

            set
            {
                this.iDCard = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a value for phone number.");
                }
                this.phoneNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a value for address.");
                }
                this.address = value;
            }
        }

        public override string ToString()
        {

            StringBuilder toString = new StringBuilder();

            toString.AppendLine("--------Information about client:---------");
            toString.AppendLine();
            toString.AppendFormat(" Client name - {0}", this.FirstLastName);
            toString.AppendLine();
            toString.AppendFormat(" Client gender - {0}", this.Sex);
            toString.AppendLine();
            toString.AppendFormat(" Client date of birth - {0}", this.DateOfBirth);
            toString.AppendLine();
            toString.AppendFormat(" Client age - {0}", this.Age);
            toString.AppendLine();
            toString.AppendFormat(" Client phone number - {0}", this.PhoneNumber);
            toString.AppendLine();
            toString.AppendFormat(" Client address - {0}", this.Address);
            toString.AppendLine();
            toString.AppendLine(this.IDCard.ToString());
            toString.AppendLine(this.DriversLicence.ToString());
            toString.AppendLine(this.CreditCard.ToString());
            return toString.ToString();
        }
    }
}
