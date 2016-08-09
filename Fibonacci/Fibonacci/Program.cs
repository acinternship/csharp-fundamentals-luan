using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static void main()
        {
           
            int value2 = FibonacciSequence();

             Console.WriteLine(value2);
            Console.ReadLine();
        }
        /* 
         int a, fibonacci_num, i, aux, position_1, position_2, position_3;

         a = 0;
         fibonacci_num = 1;
         position_1 = 6;
         position_2 = 3;
         position_3 = 16;

         Console.WriteLine("The fibonacci number's position and its value: ");
         Console.WriteLine("");
         Console.WriteLine("Position | Fibonacci Number");

         for (i = 2; i <= position_3; i++)
         {
             aux = a;
             a = fibonacci_num;
             fibonacci_num = aux + fibonacci_num;



             if (position_1 == i)
             {
                 Console.Write(position_1);
                 Console.Write("        |    ");
                 Console.WriteLine(fibonacci_num);
             }

             else if (position_2 == i)
             {
                 Console.Write(position_2);
                 Console.Write("        |    ");
                 Console.WriteLine(fibonacci_num);
             }


             else if (position_3 == i)
             {
                 Console.Write(position_3);
                 Console.Write("       |    ");
                 Console.WriteLine(fibonacci_num);
             }
         }
         Console.ReadLine();
     */
                 
        static int ChoosePosition()

        { Console.WriteLine("Type Fibunacci position: ");

            int position = int.Parse(Console.ReadLine());
            return (position);
        }

        static int FibonacciSequence()
        {
            int value1 = ChoosePosition();

            int j, num, fibonacci_num, aux_count;

            num = 0;
            fibonacci_num = 1;

            //Fibonacci Calculus 
            for (j = 2; j <= value1; j++)
            {
                aux_count = num;
                num = fibonacci_num;
                fibonacci_num = aux_count + fibonacci_num;
            }

            if (value1 == j)
                {
                return fibonacci_num;      
                }
            
         }
         
        }
        
    } 
