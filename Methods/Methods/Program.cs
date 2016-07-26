using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld("luan" );
            HelloWorld("lucas");
            Console.ReadLine();
        }

        private static void HelloWorld(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        
    }
}