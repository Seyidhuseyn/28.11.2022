using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Vehicle
    {
        private int _drivetime;

        public int Drivetime
        {
            get => _drivetime;
            set { _drivetime = value; }
        }
        private int _drivepath;

        public int Drivepath
        {
            get => _drivepath;
            set { _drivepath = value; }
        }
        public int AverageSpeed()
        {
            return Drivepath / Drivetime;
        }

    }

}
