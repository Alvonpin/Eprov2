using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov2
{
    class Car
    {
        public int passangers;
        public int contrabandAmount;
        public bool alreadyChecked;

        public static Random Generator = new Random();

        //Metoden används i programmet när användaren vill underöka hurvida en bil (subject) inehåller stöldgods
        //Om bilen inehåller stöldgods ökar riken för att den blir upptäckt om den inehåller mer stöldgods
        public bool Examine(Car subject)
        {
            subject.alreadyChecked = true;

            //sucessRate bestämmer om undersökningen lyckas eller inte. 
            //Värdet beror på mängden stöldgods. Om mägden är stor ökar sannorlikheten att undersökningen lyckas.
            int sucessRate = Generator.Next(0, contrabandAmount);

            if ( sucessRate > 0 )
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
