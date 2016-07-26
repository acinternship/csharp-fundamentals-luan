using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Luan's Big giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3");
            string UserValue = Console.ReadLine();
            string message = "";

            if (UserValue == "1")
                message = "You won a new car!";
            if (UserValue == "2")
                message = "You won a new boat!";
            if (UserValue == "3")
                message = " You won a new cat!";

            else
            {
                message = "Sorry, we didn`t understand.  ";
                // message = mesage + "You lose.";
                message += " You lose.";
       
            }
            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Luan's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            String userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            /*
            Console.Write("You won a ");
            Console.Write(message);
            Console.Write(".");
            */

            Console.WriteLine("You entered {0}, therefore you won a {1}.", userValue, message);

            Console.ReadLine();
           






        }
    }
}
