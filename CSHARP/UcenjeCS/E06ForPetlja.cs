using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {
        public static void Izvedi()
        {
            for (int i = 0; i < 10; i = i + 1)     // u većini slučajeva se koristi i jer je i --> inkrement (uvećanje)
            {
                Console.WriteLine("Edunova" + i);
            }

            int[] niz = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //ispisati sve brojeve jedne ispod drugih

            for (int i = 0;i < niz.Length;i = i + 1)
            {
                Console.WriteLine(niz[i]);
            }

            // ispisati sve parne brojeve od 3 do 43
            for (int i = 3; i <= 43; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // koji je zbroj prvih 100 brojeva
            //1+2+3...98+99+100
            int suma = 0;
            for (int i = 1; i <= 100; i++)
                
            {
                suma += i;
            }
            Console.WriteLine(suma);

            // petlja može ići i unazad
            // ispiši sve brojeve od 78 do 4

            for (int i=78; i>=4; i--)
            {
                Console.WriteLine(i);
            }

            //korak može biti koji god mi želimo
            // ispiši svaki sedmi broj od 1-100
            for (int i= 1; i<=100; i += 7)
            {
                Console.WriteLine(i);
            }

            //ispiši brojeve od 1-20 jedno pokraj drugog
            

            for (int i = 1; i<=20; i++)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();

            //PETLJE SE MOGU UGNJEZDITI
            //domaća zadaća - navedeni kod formatirati na način da su brojke jedna ispod druge
            for (int i = 1; i<=10; i++ )
            {
                for (int j = 1; j <= 10; j++)
                {

                    Console.Write($"{i * j,-4}");
                }
                Console.WriteLine();
            }
        }


    }

}
