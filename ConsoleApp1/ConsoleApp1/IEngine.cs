using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IEngine
    {
        public int OilCapacity
        {
            get => OilCapacity; 
            set { OilCapacity = value; }
        }
        public int Currentoil
        {
            get => Currentoil; 
            set { Currentoil = value; }
        }
        public int Fueltype
        {
            get => Fueltype;
            set { Fueltype = value; }
        }
        public int Remainoilamont()
        {
            return OilCapacity - Currentoil;
        }


    }
}
