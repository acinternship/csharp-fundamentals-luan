using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For__iteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
