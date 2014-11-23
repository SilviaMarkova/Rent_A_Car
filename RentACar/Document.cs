using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public abstract class Document
    {
        private string documentID;
        private DateTime dateOfIssue;
        private DateTime dateOfExpiry;
        private bool isValid;
        private string publisher;
        private string owner;

        //if the user chooses not to pay with a credit card we need to have an empty constructor to take the empty constructor from the
        //class CrediCard
        public Document()
        {

        }

        public Document(string documentID, DateTime dateOfIssue, DateTime dateOfExpiry, string pubisher)
        {
            this.DocumentID = documentID;
            this.DateOfIssue = dateOfIssue;
            this.DateOfExpiry = dateOfExpiry;
            this.IsValid = isValid;
            this.Publisher = pubisher;
        }

        public Document(string owner, string documentID, DateTime dateOfIssue, DateTime dateOfExpiry, string pubisher)
            :this(documentID, dateOfIssue, dateOfExpiry, pubisher)
        {
            this.Owner = owner;
            
        }

        public string DocumentID
        {
            get 
            { 
                return this.documentID; 
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a value for document id.");
                }
                this.documentID = value; 
            }
        }

        public DateTime DateOfIssue
        {
            get 
            { 
                return this.dateOfIssue;
            }

            set
            { 
                this.dateOfIssue = value; 
            }
        }

        public bool IsValid
        {
            get
            {
                if (this.isValid == false)
                {
                    throw new DocumentInvalidException("Your document is not valid.");
                }
                return this.isValid;
            }

            set 
            { 
                this.isValid = value; 
            }
        }

        public string Publisher
        {
            get 
            { 
                return this.publisher; 
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a value for publisher of the document.");
                }
                this.publisher = value; 
            }
        }

        public string Owner
        {
            get 
            { 
                return this.owner;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a value for owner of the document.");
                }
                this.owner = value; 
            }
        }

        public DateTime DateOfExpiry
        {
            get 
            {
                return this.dateOfExpiry; 
            }

            set
            {
                this.dateOfExpiry = value; 
            }
        }

        public abstract bool CheckValidity(Document document);
    }
}
