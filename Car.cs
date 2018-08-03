using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Car
    {

        // fields

        private string make;
        private string model;
        private int year;
        private double price;


        // properties
        public string Make
        {
           set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }


        // constructor that initialize the class with parameters
        public Car(string m, string mo, int yr, double pr)
        {
            make = m;
            model = mo;
            year = yr;
            price = pr;

        }
        // default constructor
        public Car()
        {

        }

        // method
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Make}\t{Model}\t{Year}\t{Price:c}");



        }
    }
}
