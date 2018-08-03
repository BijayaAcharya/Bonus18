using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class CarLot
    {
        ////field
        private List<Car> lot;
        // instiating new and used car objects
        Car newcar1 = new Car("Chevy", "Impala", 2017, 4000);
        Car newcar2 = new Car("Jeep", "Compass", 2014, 5000);
        Car newcar3 = new Car("Madza", "Cx5", 2017, 9000);


        UsedCar usedCar1 = new UsedCar("ford", "Escape", 2016, 7000, 23840);
        UsedCar usedCar2 = new UsedCar("Toyota", "Highlander", 2018, 10000, 40100);
        UsedCar usedCar3 = new UsedCar("Nissan", "Altima", 2010, 8000, 57768);


        //properties
        public List<Car> Lot
        {
            get { return lot; }
            set { lot = value; }
        }


        // method that returns the list of the car
        public void ListOfCar()
        {

            Lot = new List<Car>() { newcar1, newcar2, newcar3, usedCar1, usedCar2, usedCar3 };
          
        }
        // method that adds a car to the list
        public void AddCar(string make, string model, double price, int year, double mileage )
        {
            Lot.Add(new UsedCar
            {   Make = make,
                Model = model,
                Price = price,
                Year = year,
                Mileage= mileage,
            });
        }
        // method that removes a car
            public void RemoveCar(int number)
            {
            Lot.RemoveAt(number);
            }

               // method that inserts a car
            public void InsertCar(string make, string model, double price, int year)
        {
            lot.Insert(2, new Car
            {
                Make = make,
                Model = model,
                Price = price,
                Year = year
            });
         
        }



        }
    }

