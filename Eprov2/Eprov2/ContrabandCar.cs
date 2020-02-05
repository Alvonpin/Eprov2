using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov2
{
    class ContrabandCar : Car
    {
        public ContrabandCar ()
        {
            passangers = Generator.Next(1, 4);
            contrabandAmount = Generator.Next(1, 4);
        }
    }
}
