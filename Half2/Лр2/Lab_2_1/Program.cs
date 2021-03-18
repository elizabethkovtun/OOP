using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_2_1
{
    class MainClass
    {
        delegate void CarWash(Car car);
        public static void Main(string[] args)
        {
            Garage garage = new Garage();
            foreach (var car in garage)
            {
                CarWash wash = Washer.Wash;
                wash(car);
                Console.WriteLine("Car " + car.name + " is " + car.station);
            }

        }
    }
}
