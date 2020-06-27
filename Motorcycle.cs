using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_240620
{
    public class Motorcycle : Vehicle
    {
        public int _numberOfWheels;
        public string _model;
        public int _numberOfHandBreaks;
        public override int GetMaxNumOfPassengers()
        {
            return 2;
        }

        public override int GetMaxSpeed()
        {
            return 260;
        }

        public override string ToString()
        {
            return $"{ base.ToString()} NumberOfHandBreaks : {_numberOfHandBreaks}";
        }
    }
}
