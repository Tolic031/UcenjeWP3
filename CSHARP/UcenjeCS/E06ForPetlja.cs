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

            // petlja se može preskočiti tj. nastaviti

            for (int i = 0; i<10; i++)
            {
                if (i == 3) // preskače se broj 3
                {
                    continue; // shortcuircuiting
                }
               
                    Console.WriteLine(i);
               
            }

            // petlja se može nasilno prekinuti
            for (int i = 0; i< 10; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i< 10; i++)
            {
                for (int j= 0; j< 10; j++)
                {
                    //kako prekinuti vanjsku petlju (varijabla i)
                    goto labela;
                   // break; // prekida se unutarnja petlja, varijabla j
                }
            }

            labela:
            Console.WriteLine("Nastavljam nakon vanjske petlje");


            // BESKONAČNA PETLJA
            for (; ; )
            {
                Console.WriteLine(new Random().NextInt64(1-100));
                break;
            }

            // 9 različitih načina zbrajanja prvih 100 brojeva

            // int i, s=0; for(i=1;i<=100;i++) s+=i;

            // int i, s; for(i=1, s=0;i<=100; s+=i, i++);
            //
            // int i=1, s=0; for( ; i<=100; i++){ s+=i; }
            //
            // int i, s=0; for(i=1; ; i++){ if(i<=100) s+=i; else break;}
            //
            // int i, s=0; for(i=1;i<=100; ){ s+=i; i++;}
            //
            //int i, s=0; for(i=1; ; ){ if(i<=100) {s+=i; i++;} else break;}
            //
            // int i=1, s=0; for( ; i<=100 ; ){ s+=i; i++;}
            //
            // int i=1, s=0; for( ; ; i++){if(i<=100)  s+=i; else break;}
            //
            // int i=1, s=0; for( ;  ; ){if(i<=100) {s+=i; i++;} else break;} 
            //		
        }


    }

}
