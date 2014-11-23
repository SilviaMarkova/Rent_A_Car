using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class CreditCard : Document
    {
        private string securityNumber;
        private CardType type;

        //if the user chooses not to pay with a credit card
        public CreditCard()
            : base()
        {

        }

        public CreditCard(string owner, CardType type, string documentID, string securityNumber, DateTime dateOfIssue, DateTime dateOfExpiry, string pubisher) :
            base(owner, documentID, dateOfIssue, dateOfExpiry, pubisher)
        {
            this.Type = type;
            this.SecurityNumber = securityNumber;
        }

        public string SecurityNumber
        {
            get 
            { 
                return this.securityNumber; 
            }

            set 
            { 
                this.securityNumber = value; 
            }
        }

        public CardType Type
        {
            get 
            { 
                return this.type;
            }

            set 
            { 
                this.type = value; 
            }
        }

        public override bool CheckValidity(Document creditcard)
        {
            if (creditcard.DateOfExpiry < DateTime.Now || creditcard.DocumentID.Length < 16)
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
            //if the user chooses not to pay with a credit card
            if (this.Type == null && this.DocumentID == null && this.DateOfIssue == null && this.DateOfExpiry == null && this.Publisher == null
                && this.Owner == null)
            {
                return string.Format("");
            }
            return string.Format("--------Information about credit card:--------- \r\n\r\n Card type: {0}\n ID: {1} \r\n Date of issue: {2}\r\n Date of expiry: {3}\r\n Publisher: {4}\r\n Owner: {5}\r\n",
                this.Type, this.DocumentID, this.DateOfIssue, this.DateOfExpiry, this.Publisher, this.Owner);
        }
    }
}
