using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RentACar
{
    public class Order : IOrder
    {
        private Client customerInfo;
        private Payment paymentMethod;
        private Vehicle rentedVehicleInfo;
        private Schedule scheduleInfo;
        private Destination destination;

        public Order(Client customerInfo, Payment paymentInfo, Vehicle rentedVehicleInfo, Schedule scheduleInfo, Destination destination)
        {
            this.CustomerInfo = customerInfo;
            this.PaymentMethod= paymentMethod;
            this.RentedVehicleInfo = rentedVehicleInfo;
            this.ScheduleInfo = scheduleInfo;
            this.Destination = destination;
        }

        public Client CustomerInfo
        {
            set
            { 
                this.customerInfo = value;
            }

            get 
            { 
                return this.customerInfo; 
            }
        }

        public Payment PaymentMethod
        {
            set 
            { 
                this.paymentMethod = value;
            }

            get 
            { 
                return this.paymentMethod; 
            }
        }

        public Vehicle RentedVehicleInfo
        {
            set 
            { 
                this.rentedVehicleInfo = value;
            }

            get 
            {
                return this.rentedVehicleInfo; 
            }
        }

        public Schedule ScheduleInfo
        {
            set 
            { 
                this.scheduleInfo = value; 
            }

            get 
            {
                return this.scheduleInfo; 
            }
        }

        public Destination Destination
        {
            set 
            { 
                this.destination = value; 
            }

            get 
            {
                return this.destination;
            }
        }

        public void LogOrder()
        {
            string fileName = string.Format("{0:yyyy_MMM_d_HHmm_ss}.txt", DateTime.Now);
            StreamWriter writer = new StreamWriter(fileName);
            
            using (writer)
            {
                writer.Write(this);
            }
        }

        public void PrintOrder()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return string.Format("{0}\r\n\r\n{1}\r\n\r\n{2}\r\n\r\n{3}", this.CustomerInfo, this.RentedVehicleInfo, this.ScheduleInfo, this.Destination);
        }

    }
}
