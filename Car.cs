using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_240620
{
    public class Car : Vehicle
    {
        public int _numberOfWheels;
        public string _model;
        public int _numberOfDoors;

        public override int GetMaxNumOfPassengers()
        {
            return 5;
        }

        public override int GetMaxSpeed()
        {
            return 220;
        }

        public override string ToString()
        {
            return $"{base.ToString()} NumberOfDoors : {_numberOfDoors}";
        }
    }
}
