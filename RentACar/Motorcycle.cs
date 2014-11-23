using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(int engineCC, MotorcycleBrands modelAndBrand, int year, decimal price, int numberOfSeats, double fuelConsumtionPerHundredKm,
            string registrationNumber, EngineType engineType, GearBoxType gearboxType)

            : base(engineCC, modelAndBrand, year, price, numberOfSeats, fuelConsumtionPerHundredKm,
            registrationNumber, engineType, gearboxType)
        {
            
        }
    }
}
