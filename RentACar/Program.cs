using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("------Welcome to our Car Rental Service------");
                Console.WriteLine();
                Console.WriteLine("Which type of vehicle would you like to rent?");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Motorcycle");
                string choice = Console.ReadLine();

                Vehicle chosenVehicle = ConsoleInterface.VehicleChoice(choice);

                //All order details
                Vehicle vehicle = chosenVehicle;
                Payment paymentMethod = Payment.Cash;
                CreditCard cardInfo = new CreditCard();
                Client client;
                Destination destination;
                Schedule schedule;
                //hardcoded because we don't have time for useless manual data entering at the presentation
                ID idCard = new ID("346578", new DateTime(2012, 1, 11), new DateTime(2013, 4, 12), "MVR Sofia");
                DriversLicence driversLicence = new DriversLicence(Categories.A, "346578", new DateTime(2012, 1, 11), new DateTime(2013, 4, 12), "MVR Sofia");

                //Clear console
                ConsoleInterface.ClearConsole();

                Console.WriteLine(chosenVehicle);

                Console.WriteLine();

                Console.Write("Would you like to take this car?(y/n): ");
                choice = Console.ReadLine();

                //Clear console
                ConsoleInterface.ClearConsole();

                if (choice == "y" || choice == "Y")
                {

                    Console.Write("Would you like to pay with a credit card?(y/n): ");
                    choice = Console.ReadLine();

                    if (choice == "y" || choice == "Y")
                    {
                        //hardcoded for the same reason
                        cardInfo = new CreditCard("John Doe", CardType.Maestro, "12112441242123456985", "432", new DateTime(2013, 1, 11), new DateTime(2013, 8, 12), "Pireus Bank");
                        //a constructor for a user with a credit card
                        //hardcoded for the same reason
                        client = new Client("John Doe", Sex.Male, new DateTime(1992, 9, 7), "08871526374", "Stuttgart", cardInfo, driversLicence, idCard);
                    }

                    else
                    {
                        paymentMethod = ConsoleInterface.PaymentMethodChoice();
                        //a constructor for a user without a credit card
                        //hardcoded for the same reason
                        client = new Client("John Doe", Sex.Male, new DateTime(1992, 9, 7), "08871526374", "Stuttgart", driversLicence, idCard);
                    }

                    //Check documents validity
                    idCard.CheckValidity(idCard);
                    cardInfo.CheckValidity(cardInfo);
                    driversLicence.CheckValidity(driversLicence);

                    //Clear console
                    ConsoleInterface.ClearConsole();

                    Console.Write("Please enter the town from which you'll pick up the vehicle: ");
                    string pickUpPlace = Console.ReadLine();

                    Console.Write("Please enter the town from which you'll drop off the vehicle: ");
                    string dropOffPlace = Console.ReadLine();

                    destination = new Destination(pickUpPlace, dropOffPlace);

                    //Clear console
                    ConsoleInterface.ClearConsole();

                    Console.Write("Please enter a pick up date in which you'll get the vehicle: ");
                    DateTime pickUpDate = DateTime.Parse(Console.ReadLine());

                    Console.Write("Please enter a drop off date in which you'll return the vehicle: ");
                    DateTime dropOffDate = DateTime.Parse(Console.ReadLine());

                    schedule = new Schedule(pickUpDate, dropOffDate);

                    //Clear console
                    ConsoleInterface.ClearConsole();

                    Order order = new Order(client, paymentMethod, vehicle, schedule, destination);

                    Console.WriteLine("------Final details for your order------");

                    Console.WriteLine();

                    order.PrintOrder();

                    order.LogOrder();
                }
                else
                {
                    ConsoleInterface.ClearConsole();

                    Console.WriteLine("Thank you have a nice day.");
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DocumentInvalidException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidAgeForRentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
