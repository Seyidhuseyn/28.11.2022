using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Plane : Vehicle, IEngine
    {
        private int _winglength;

        public int Winglength
        {
            get => _winglength;
            set { _winglength = value; }
        }

    }
}
