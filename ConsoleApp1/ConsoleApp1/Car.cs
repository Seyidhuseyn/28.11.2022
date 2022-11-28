using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car : Vehicle, IEngine
    {
        private int _doorcount;

        public int Doorcount
        {
            get { return _doorcount; }
            set { _doorcount = value; }
        }

        internal void Drivepath()
        {
        }

        internal void Drivetime()
        {
        }
    }
}
