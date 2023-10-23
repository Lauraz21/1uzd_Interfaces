using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1uzd_Interfaces
{
    internal class Car : IVehicle
    {
        public string Model { get; set; }
        public int Fuel { get; set; }


        public void Drive()
        {
            Fuel -= 10; 
        }

        public int GetFuel()
        {
            return Fuel;
        }

        public void Refuel(int amount)
        {
            Fuel += amount;
        }
    }
}
