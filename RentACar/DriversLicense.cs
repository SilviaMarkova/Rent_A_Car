using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class DriversLicence : Document
    {
        private Categories category;

        public DriversLicence(Categories category, string documentID, DateTime dateOfIssue, DateTime dateOfExpiry, string pubisher)
            : base(documentID, dateOfIssue, dateOfExpiry, pubisher)
        {
            this.Category = category;
        }

        public Categories Category
        {
            get 
            { 
                return this.category; 
            }

            set 
            { 
                this.category = value; 
            }
        }

        public override bool CheckValidity(Document driversLicense)
        {
            if (driversLicense.DateOfExpiry< DateTime.Today)
            {
                IsValid = false;
            }
            else
            {
                IsValid = true;
            }
            return IsValid;
        }

        public override string ToString()
        {
            return string.Format("--------Information about Driver's license:--------- \r\n\r\n Category: {0}\r\n Driver's license number: {1} \r\n Date of issue: {2}\r\n Date of expiry: {3}\r\n Publisher: {4}\r\n",
                this.Category, this.DocumentID, this.DateOfIssue, this.DateOfExpiry, this.Publisher);
        }
    }

}
