using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentACar
{
    public class Vehicle : IVehicle
    {
        private int engineCC;
        private List<string> extras;
        private Enum modelAndBrand;
        private int year;
        private decimal price;
        private int numberOfSeats;
        private double fuelConsumtionPerHundredKm;
        private string registrationNumber;
        private EngineType engineType;
        private GearBoxType gearboxType;

        public Vehicle(int engineCC, Enum modelAndBrand, int year, decimal price, int numberOfSeats, double fuelConsumtionPerHundredKm,
            string registrationNumber, EngineType engineType, GearBoxType gearboxType)
        {
            this.EngineCC = engineCC;
            this.ModelAndBrand = modelAndBrand;
            this.Year = year;
            this.Price = price;
            this.NumberOfSeats = numberOfSeats;
            this.FuelConsumtionPerHundredKm = fuelConsumtionPerHundredKm;
            this.RegistrationNumber = registrationNumber;
            this.EngineType = engineType;
            this.GearboxType = gearboxType;
        }

        public double FuelConsumtionPerHundredKm
        {
            get
            {
                return this.fuelConsumtionPerHundredKm;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Fuel consumption can't be less than or equal to 0.");
                }
                this.fuelConsumtionPerHundredKm = value;
            }
        }

        public string RegistrationNumber
        {
            get 
            { 
                return this.registrationNumber; 
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a value for vehicle registration number.");
                }
                this.registrationNumber = value;
            }
        }

        public GearBoxType GearboxType
        {
            get 
            {
                return this.gearboxType; 
            }

            set 
            {
                this.gearboxType = value;
            }
        }

        public EngineType EngineType
        {
            get 
            {
                return this.engineType;
            }

            set 
            {
                this.engineType = value; 
            }
        }

        public int NumberOfSeats
        {
            get
            {
                return this.numberOfSeats;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Number of seats in the vehicle must be at least 1.");
                }
                this.numberOfSeats = value;
            }
        }

        public int EngineCC
        {
            get
            {
                return this.engineCC; 
            }

            set 
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Engine CC must be bigger than 0.");
                }
                this.engineCC = value; 
            }
        }

        public IReadOnlyCollection<string> Extras
        {
            get
            {
                return this.extras; 
            }
        }

        public Enum ModelAndBrand
        {
            get 
            { 
                return this.modelAndBrand; 
            }

            set
            { 
                this.modelAndBrand = value; 
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }

            set
            {
                if (value <= 1990)
                {
                    throw new ArgumentOutOfRangeException("Year of the car must be bigger than 1990.");
                }
                this.year = value; 
            }
        }

        public decimal Price
        {
            get 
            { 
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price of the car must be a positive number to 0.");
                }
                this.price = value;
            }
        }

        /// <summary>
        /// Add an extra to the vehicle
        /// </summary>
        /// <param name="extra"></param>
        public void AddExtra(string extra)
        {
            extras.Add(extra);
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.AppendLine("--------Information about vehicle:---------");
            toString.AppendLine();
            toString.AppendFormat(" Car brand - {0}", this.ModelAndBrand);
            toString.AppendLine();
            toString.AppendFormat(" Year of manifacture - {0}", this.Year);
            toString.AppendLine();
            toString.AppendFormat(" Engine type - {0}", this.EngineType);
            toString.AppendLine();
            toString.AppendFormat(" Gearbox type - {0}", this.GearboxType);
            toString.AppendLine();
            toString.AppendFormat(" Number of seats - {0}", this.NumberOfSeats);
            toString.AppendLine();
            toString.AppendFormat(" Fuel consumption per 100km - {0}", this.FuelConsumtionPerHundredKm);
            toString.AppendLine();
            toString.AppendFormat(" Registration number - {0}", this.RegistrationNumber);
            toString.AppendLine();
            toString.AppendFormat(" Price - {0:C}", this.Price);

            return toString.ToString();
        }
    }
}
