using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class Car : Vehicle
    {
        public Car(int engineCC, CarBrands modelAndBrand, int year, decimal price, int numberOfSeats, double fuelConsumtionPerHundredKm,
            string registrationNumber, EngineType engineType, GearBoxType gearboxType)

            : base(engineCC, modelAndBrand, year, price, numberOfSeats, fuelConsumtionPerHundredKm,
            registrationNumber, engineType, gearboxType)
        {

        }
    }
}
