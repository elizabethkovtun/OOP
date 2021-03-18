using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_2_1
{
    public class Car
    {
        public string name { get; set; }
        public bool station { get; set; }
        public Car()
        {

            this.name = name;
            this.station = false;
        }

        internal void Add(Car car) => throw new NotImplementedException();
        internal bool Contsins(Car car) => throw new NotImplementedException();
        internal bool Remove(Car car) => throw new NotImplementedException();

    }
}