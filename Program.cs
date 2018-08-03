using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carlot = new CarLot(); // creating an object of carlot class

            carlot.ListOfCar(); // invoking list of car from carlot class

            foreach (Car item in carlot.Lot)
            {
                item.PrintInfo();
            }
            while (true)
            {
                Console.WriteLine("What would you like to do: see, add, insert, or remove a car? Print the word.");
                string choice = Console.ReadLine().ToLower();

                if (choice == "see")
                {
                    Console.WriteLine("Enter a number from 0-5");
                    int num = int.Parse(Console.ReadLine());
                    carlot.Lot[num].PrintInfo();
                }
                if (choice == "add")
                {
                    Console.WriteLine("Please enter the make");
                    string make = Console.ReadLine();
                    Console.WriteLine("Please enter the model");
                    string model = Console.ReadLine();
                    Console.WriteLine("Please enter the price");
                    double price = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the year");
                    int year = int.Parse(Console.ReadLine());
                   
                    Console.WriteLine("Please enter the mileage");
                    double mileage = Double.Parse(Console.ReadLine());
                    carlot.AddCar(make, model, price, year, mileage);
                    Console.WriteLine($"The Car {make,-10}{model,-10}{year,-10}${price,-10}Ml{mileage,-10} is added to the list ");


                }
                if (choice == "insert")
                {
                    Console.WriteLine("Please enter the make");
                    string make = Console.ReadLine();
                    Console.WriteLine("Please enter the model");
                    string model = Console.ReadLine();
                    Console.WriteLine("Please enter the price");
                    double price = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the year");
                    int year = int.Parse(Console.ReadLine());
                    carlot.InsertCar(make, model, price, year);
                    Console.WriteLine($"The Car {make,-10}{model,-10}{year,-10}${price,-10} is inserted to the list ");
                }
                if (choice == "remove")
                {
                    Console.WriteLine("Enter a number from 0-5");
                    int num = int.Parse(Console.ReadLine());
                    carlot.RemoveCar(num);
                    Console.WriteLine($"{carlot.Lot[num].Make,-10}{carlot.Lot[num].Model,-10}{carlot.Lot[num].Year} is removed");

                }         
                                
                Console.WriteLine(" Would you like to continue? y/n");
                string select = Console.ReadLine().ToLower();
                if (select == "n")
                {
                    break;
                }
            }
        }
    }
}
