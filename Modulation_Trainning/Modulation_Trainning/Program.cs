using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulation_Trainning
{
    class Program
    {
        public static void Main()
        {
            int a, b;
            a = 7;
            b = 15;
            Troca(a, b);

            Console.WriteLine("{0}  {1}", a, b);
            Console.ReadLine();
        }
        public static int Troca(int x, int y)
        {
            int aux = x;
            aux = x;
            x = y;
            y = aux;

            return x;
            return y;
        } 
        
    }
}
