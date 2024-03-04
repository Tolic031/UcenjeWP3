using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E08DoWhile
    {
        public static void Izvedi()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // u while se ne mora ući - PROVJERA UVJETA JE NA POČETKU PETLJE
            int t = 0;
            while (t > 0)
            {
                Console.WriteLine(t);
            }

            // U do while - provjera uvjeta je na kraju petlje
            // osigurava minimalno jedno izvođenje


            do
            {
                Console.WriteLine(t);
            } while (t > 0);


        }
    }
}
