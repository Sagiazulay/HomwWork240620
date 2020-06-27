using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_240620
{
    public abstract class Vehicle
    {
        int _numberOfWHeels;
        string _model;

        public abstract int GetMaxNumOfPassengers();

        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            return $"Model : {_model} NumberOfWHeels : {_numberOfWHeels} Number Of Passengers: {GetMaxNumOfPassengers()} Max Speed : {GetMaxSpeed()}";
        }
    }


}
