using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public struct Destination
    {
        private string pickUpPlace;
        private string dropOffPlace;

        public Destination(string pickUpPlace, string dropOffPlace):this()
        {
            this.PickUpPlace = pickUpPlace;
            this.DropOffPlace = dropOffPlace;
        }

        public string PickUpPlace
        {
            get 
            { 
                return this.pickUpPlace; 
            }

            set 
            { 
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a value for pick up place.");
                }
                this.pickUpPlace = value;
            }
        }

        public string DropOffPlace
        {
            get 
            { 
                return this.dropOffPlace;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a value for drop off place.");
                }
                this.dropOffPlace = value; 
            }
        }

        public override string ToString()
        {
            return string.Format("--------Information about destination--------- \r\n\r\n Pick-up town: {0}\r\n Drop-off town: {1}", this.PickUpPlace, this.DropOffPlace);
        }
    }
}
