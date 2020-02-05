using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov2
{
    class CleanCar : Car
    {
        public CleanCar ()
        {
            passangers = Generator.Next(1, 3);
            contrabandAmount = 0;
        }

    }
}
