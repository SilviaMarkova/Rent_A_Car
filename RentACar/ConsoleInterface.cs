using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public static class ConsoleInterface
    {
        public static Vehicle VehicleChoice(string choice)
        {
            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("----------Free cars in this period, sorted by price: ---------");
                Console.WriteLine("(to select a car please enter its number in the list)");

                List<Car> cars = new List<Car>();

                cars = GenerateContent.GenerateCars();

                for (int i = 0; i < cars.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i+1, cars[i]);
                }

                int carChoice = int.Parse(Console.ReadLine());

                Car chosenCar = cars[carChoice - 1];

                return chosenCar;
            }
            else if (choice == "2")
            {
                Console.WriteLine("----------Free motorcycles in this period, sorted by price: ---------");
                Console.WriteLine("(to select a motorcycle please enter its number in the list)");

                List<Motorcycle> motorcycles = new List<Motorcycle>();

                motorcycles = GenerateContent.GenerateMororcycles();

                for (int i = 0; i < motorcycles.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, motorcycles[i]);
                }

                int motorcyclesChoice = int.Parse(Console.ReadLine());

                Motorcycle chosenMotorcycle = motorcycles[motorcyclesChoice - 1];

                return chosenMotorcycle;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return null;
            }

        }

        public static Payment PaymentMethodChoice()
        {
            Console.WriteLine("Available payment methods:");
            int lineNumber = 1;

            foreach (var paymentMethod in Enum.GetNames(typeof(Payment)))
            {
                Console.WriteLine("{0}. {1}", lineNumber, paymentMethod);
            }

            Console.WriteLine();

            Console.Write("Please select a number coresponding to the payment method of your coice: ");

            string userChoice = Console.ReadLine();

            Payment payMethod = Payment.BankTransfer;

            if (userChoice == "1")
            {
                payMethod = Payment.BankTransfer;
            }
            else if (userChoice == "2")
            {
                payMethod = Payment.Cash;
            }
            else if (userChoice == "3")
            {
                payMethod = Payment.MoneyOrder;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            return payMethod;
        }

        public static void ClearConsole()
        {
            Console.Clear();

            Console.WriteLine();
        }
    }
}
