using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Square
    {
        /*https://learn.microsoft.com/ru-ru/dotnet/csharp/tutorials/string-interpolation
         */
        public static void PrintSquare(char simbol, int side)
        {
            for (int i = 0; i< side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write("{0,3}", simbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine(("").PadRight(24, '-'));

        }

    }
}
