using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov2
{
    class InputManager
    {
        //Metoden används för att hämnta och kontrollera användarinput som utgörs av nummer.
        //Metoden returnerar 0 om den misslyckas och resultatet om den lyckas samt en bool som indikerar om den lyckats eller misslyckats
        static public int GetInputNumber(out bool sucess)
        {
            string input = Console.ReadLine();
            sucess = int.TryParse(input, out int result);

            if (!sucess) { return 0; }
            else { return result; }
        }

        //Metoden används när det finns ett min och maxvärde för nummret användaren uppger.
        //Den returnerar även en string som utgörs av ett errormeddelande när den misslyckas. Stringen är tom om metoden lyckas.
        static public int GetInputNumber(out bool sucess, out string error, int min, int max)
        {
            string input = Console.ReadLine();
            sucess = int.TryParse(input, out int result);

            if (!sucess) { error = "Please enter a NUMBER"; sucess = false; return 0; }
            if (result < min) { error = "Please enter a number greater than 1"; sucess = false; return 0; }
            if (result > max) { error = "Please enter a number below or equal to 20"; sucess = false; return 0; }

            else { error = ""; sucess = true; return result; }
        }


    }
}
