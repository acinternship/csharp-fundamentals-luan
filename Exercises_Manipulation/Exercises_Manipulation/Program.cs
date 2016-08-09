using System;
using System.Linq;

namespace Exercises_Manipulation
{
    class Program
    {/*
        public static void Main()
        {
            int a, b;
            a = 7;
            b = 15;
            Troca(ref a, ref b);
            Escreve(ref a, ref b);
            
        }
        public static void Troca(ref int x,ref int y)
        {
            int aux = x;
            x = y;
            y = aux;
        }
        public static void Escreve(ref int i, ref int j)
        {
            Console.Write("{0} {1}", i, j);
            Console.ReadLine();
        }

        public static double CalculateArea(int r)
        {
           
            double area = r * r * Math.PI;
            return area;
        }
        public static int ReadType()
        {
            Console.Write("Type radius: ");
            int radius = int.Parse(Console.ReadLine());
            return radius;
        }
        static void Main()
        {
            
            double result = CalculateArea(ReadType());
            Console.WriteLine("The area is {0:0.00}", result);

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        */
        public static void Main()
        {
            while (true)
            {
                var line = Console.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    break;
                }

                var words = line.Split(' ');

                var lengthsAndCount = words.GroupBy(w => w.Length)
                    .Select(g => new {
                        Length = g.Key,
                        Count = g.Count()
                    }).OrderByDescending(i => i.Length);

                foreach (var item in lengthsAndCount)
                {
                    Console.WriteLine(string.Format("{0} letters: {1}", item.Length, item.Count));
                }
            }
        }
    }
}
