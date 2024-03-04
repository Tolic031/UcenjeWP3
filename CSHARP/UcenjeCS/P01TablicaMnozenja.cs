using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class P01TablicaMnozenja
    {
        public static void Izvedi()
        {
            ////Projekt 01 - navedeni kod formatirati na način da su brojke jedna ispod druge
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {

                    Console.Write($"{i * j,-4}"); // KORIŠTENJE INTERPOLACIJE --> $"{}"
                }
                Console.WriteLine();
            }
        }
    }
}
