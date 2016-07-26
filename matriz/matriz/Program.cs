using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz();
        }

        private static void Matriz()
        {
            /*
             9 0  1
             0 11 1
             1 1  4
             1 0  1
             
            9 0  1 1
            0 11 1 0
            1 1  4 1
             */

            int[,] matriz = { { 9, 0, 1}, { 0, 11, 1 }, { 1, 1, 4 },
            {1, 0, 1 } };
            int[,] transposta = new int[3,4];

            for (int linha = 0; linha < 3; linha++ )
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    transposta[linha, coluna] = matriz[coluna, linha];
                }
            }
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write(transposta[linha, coluna] + "  ");
                }
                Console.WriteLine();
            }

            
                Console.ReadLine();
            
        }
           


    }
}
