using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov2
{
    class Program
    {

        static void Main(string[] args)
        {
            int input = 0;
            List<Car> Cars = new List<Car>();

            Console.WriteLine("How many cars would you like to create? You can create a minumum of 1 car and a maximum of 20 cars.");

            //Användaren tvingas svara på frågan till hon har angivit ett godtagbart svar.
            //Om användarens input inte är godtagbar får hon ett felmeddelande 
            bool sucess = false;
            while (sucess == false)

            {
                input = InputManager.GetInputNumber(out sucess, out string error, 1, 20);
                if (sucess == false) {Console.WriteLine(error);}

            }

            //Beroende på hur många bilar användaren angav att hon ville skapa läggs dessa in i en lista över bilar
            for (int i = 0; i < input; i++)
            {
                int chance = Car.Generator.Next(2);//Hurvida bilen som läggs till är en CleanCar eller ContrabandCar slumpas fram.

                if (chance == 1)
                {
                    Cars.Add(new CleanCar());
                }

                else
                {
                    Cars.Add(new ContrabandCar());
                }
            }


            Console.ReadLine();

        }
    }
}
