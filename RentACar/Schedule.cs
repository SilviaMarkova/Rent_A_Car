using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public struct Schedule
    {
        private DateTime pickUpDateAndHour;
        private DateTime dropOffDateAndHour;

        public Schedule(DateTime pickUpDateAndHour, DateTime dropOffDateAndHour):this()
        {
            this.PickUpDateAndHour = pickUpDateAndHour;
            this.DropOffDateAndHour = dropOffDateAndHour;
        }

        public DateTime PickUpDateAndHour
        {
            get 
            { 
                return this.pickUpDateAndHour; 
            }

            set 
            {
                this.pickUpDateAndHour = value; 
            }
        }

        public DateTime DropOffDateAndHour
        {
            get 
            { 
                return this.dropOffDateAndHour; 
            }

            set 
            { 
                this.dropOffDateAndHour = value; 
            }
        }

        public override string ToString()
        {
            return string.Format(" Pick-up date: {0}\r\n Drop-off date: {1}",this.pickUpDateAndHour, this.dropOffDateAndHour);
        }
    }
}
