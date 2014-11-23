using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public static class GenerateContent
    {
        public static List<Car> GenerateCars()
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car(120, CarBrands.AlfaRomeo, 2000, 56, 4, 6.3, "SA5434K", EngineType.Petrol, GearBoxType.Manual));
            cars.Add(new Car(110, CarBrands.Audi, 1999, 48, 4, 5.2, "M4323MN", EngineType.Diesel, GearBoxType.Automatic));
            cars.Add(new Car(100, CarBrands.BMW, 2004, 66, 4, 7.3, "SA3812M", EngineType.Petrol, GearBoxType.Manual));
            cars.Add(new Car(120, CarBrands.Chevrolet, 2006, 70, 6, 7, "SA3432K", EngineType.Petrol, GearBoxType.Automatic));
            cars.Add(new Car(100, CarBrands.Kia, 2000, 56, 4, 5.3, "SA1234K", EngineType.Diesel, GearBoxType.Manual));
            cars.Add(new Car(104, CarBrands.Mercedes, 2000, 56, 4, 5.3, "M4323MN", EngineType.Petrol, GearBoxType.Automatic));
            cars.Add(new Car(100, CarBrands.Mercedes, 2000, 56, 4, 5.3, "SA9487K", EngineType.Petrol, GearBoxType.Automatic));
            cars.Add(new Car(100, CarBrands.Toyota, 2000, 70.50m, 2, 6.3, "SA3432K", EngineType.Diesel, GearBoxType.Automatic));

            return cars;
        }

        public static List<Motorcycle> GenerateMororcycles()
        {
            List<Motorcycle> motorcycle = new List<Motorcycle>();

            motorcycle.Add(new Motorcycle(200, MotorcycleBrands.BMW, 2006, 90, 2, 8, "K4232G", EngineType.Diesel, GearBoxType.Manual));
            motorcycle.Add(new Motorcycle(180, MotorcycleBrands.Ducatti, 2009, 120, 2, 7, "M6232G", EngineType.Petrol, GearBoxType.Manual));
            motorcycle.Add(new Motorcycle(190, MotorcycleBrands.KTM, 2010, 150, 2, 6.5, "SA2349B", EngineType.Diesel, GearBoxType.Manual));
            motorcycle.Add(new Motorcycle(500, MotorcycleBrands.Honda, 2012, 190, 2, 8, "P2105AS", EngineType.Petrol, GearBoxType.Automatic));

            return motorcycle;
        }
    }
}
