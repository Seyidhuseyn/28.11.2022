using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bicycle : Vehicle, IEngine
    {
        private string pedalkind;

        public string Pedalkind
        {
            get => pedalkind;
            set { pedalkind = value; }
        }

        internal void Drivepath()
        {
        }

        internal void Drivetime()
        {
        }
    }
}
