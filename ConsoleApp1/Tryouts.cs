using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tryouts
    {
        public struct Cow
        {
            public int numOfSteaks;
            public int milk1;
            public int milk2;
            public int milk3;
            public int milk4;
            public Cow(int numOfSteaks)
            {    // Because we cannot make a parameterless Constructor for Struct
                this = new Cow();    // To Zero out all other properties /// Doesn't work for Classes :P
                this.numOfSteaks = numOfSteaks;   // Only give value which you want to give
            }
        }
        public struct Fraction
        {
            public int numerator;
            public int denominator;
            public void Reduce() { }
        }
        public void Main()
        {
            Fraction frac = new Fraction();
            // Can use without new.... Class we cannot use without New. If we use New then no need to initialize again
            Console.Write(frac.numerator);   //Throws error as not initialized.
            //frac.denominator = 2;
            Console.Write(frac.denominator);   // Works fine
            frac.Reduce();   // Throws Error as not all value types initialized in Struct before use.
        }


        class Scooter
        {
            public int Mileage { get; set; }
            public Scooter(int mileage)
            {
                this.Mileage = mileage;
            }
            public static explicit operator Car(Scooter v)
            {
                return new Car { Mileage = v.Mileage };
            }
        }
        class Car
        {
            public int Mileage { get; set; }
        }
        void Main2()
        {
            Scooter scoot = new Scooter(10);
            Car car = (Car)scoot;
        }
    }
}
