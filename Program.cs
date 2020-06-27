using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_240620
{
    class Program
    {

        static void Main(string[] args)
        {

            Car Honda = new Car
            {
                _model = "Civic",
                _numberOfDoors = 5,
                _numberOfWheels = 5
            };
            Car Mazda = new Car
            {
                _model = "MX5",
                _numberOfDoors = 5,
                _numberOfWheels = 5
            };

            Motorcycle Yamaha = new Motorcycle
            {
                _model = "T-MAX",
                _numberOfWheels = 2,
                _numberOfHandBreaks = 2
            };
            Motorcycle BMW = new Motorcycle
            {
                _model = "R1",
                _numberOfWheels = 2,
                _numberOfHandBreaks = 1
            };
            
            Console.WriteLine(Honda);
        }
        public void PrintVehicle(Car c)
        {
            Console.WriteLine(c);
        }

        Vehicle[] vehicles = {new Car
            { _model = "mazda",
            _numberOfWheels = 4,
            _numberOfDoors = 5
            } , 
            new Car {_model = "Handa",
                _numberOfWheels = 4,
                _numberOfDoors = 3
            } ,
            new Motorcycle {_model = "Yamaha",
                _numberOfHandBreaks = 2,
                _numberOfWheels = 2
            }
        };
        public void PrintVehicles()
        {
            for (int i = 0; i < vehicles.Length; i++)
            {

                Console.WriteLine(vehicles[i]);
            }
        }
        
    }
}
