﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07WhilePetlja
    {
        public static void Izvedi()
        {
            //beskonačna petlja

            while (true)
            {
                break;
            }

            //break i contiune rade jednako kao i u for
            //prekidanje vanjske petlje radi kao u for
            // ugnježđivanje radi kao u for


            //ispisati sve brojeve od 1-100

            int i = 0;
            while (++i <= 100)
            {
                Console.WriteLine(i);
            }
        }
    }
}
