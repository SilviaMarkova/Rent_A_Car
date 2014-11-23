using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class ID : Document
    {
        public ID(string documentID, DateTime dateOfIssue, DateTime dateOfExpiry, string pubisher)
            : base(documentID, dateOfIssue, dateOfExpiry, pubisher)
        {
            
        }

        public override bool CheckValidity(Document id)
        {
            if (DateOfExpiry < DateTime.Now)
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
            return string.Format("--------Information about ID:--------- \r\n\r\n ID number: {0} \r\n Date of issue: {1}\r\n Date of expiry: {2}\r\n Publisher: {3}\r\n",
                this.DocumentID, this.DateOfIssue, this.DateOfExpiry, this.Publisher);
        }
    }
}
