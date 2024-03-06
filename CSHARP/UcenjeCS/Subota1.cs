using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Subota1
    {
        public static void Izvedi()
        {
            //for (int i = 0; i<10; i++)
            //{
            //    Console.WriteLine("\a");
            //    Thread.Sleep(1000); // usporavanje rada programa na jednu sekundu
            //}

            //Program unosi tri cijela broja i ispisuje ih jedan pored drugoga


            //Console.WriteLine("Unesi prvi broj: ");
            //int prvi = int.Parse(Console.ReadLine());
            //Console.WriteLine("Unesi drugi broj: ");
            //int drugi = int.Parse(Console.ReadLine());
            //Console.WriteLine("Unesi treći broj: ");
            //int treci = int.Parse(Console.ReadLine());

            //Console.Write(prvi + " " + drugi + " " + treci);

            // Program unosi imena triju gradova malim slovima
            // Ako svako ime grada počinje slovom o ispisuje SUPER, inače ispisuje OK


            // Rješenje 1
            //Console.WriteLine("Unesi ime prvog grada: ");
            //string g1 = Console.ReadLine();
            //Console.WriteLine("Unesi ime drugog grada: ");
            //string g2  = Console.ReadLine();
            //Console.WriteLine("Unesi ime trećeg grada: ");
            //string g3 = Console.ReadLine();

            //if(g1[0] == 'o' && g2[0] == 'o' && g3[0] == 'o')
            //{
            //    Console.WriteLine("Super");
            //}else
            //{
            //    Console.WriteLine("Ok");
            //}


            // Rješenje 2

            //string[] gradovi = new string[3];
            //for (int i = 0; i < gradovi.Length; i++)
            //{
            //    Console.Write("Unesi ime " + (i+1) + "grada: ");
            //    gradovi[i] = Console.ReadLine();
            //}
            //bool pocinju = true;
            //foreach(string grad in gradovi)
            //{
            //    if (grad[0] != 'o')
            //    {
            //        pocinju = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(pocinju ? "Super" : "Ok");


            // Rješenje 3
            //string grad;
            //bool pocinje = true;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Unesi ime " + (i + 1) + "grada: ");
            //    grad = Console.ReadLine();
            //    if (grad[0] != 'o')
            //    {
            //        pocinje = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(pocinje ? "Super" : "Ok");

            // Kreirajte kn/eur konverzija kalkulator

            Console.WriteLine("Odaberi vrstu konverzije: ");
            Console.Write("1. KN u Eur, 2.Eur u KN");
            int vrsta = int.Parse(Console.ReadLine());
            double iznos;
            if (vrsta == 1) 
                {
                Console.WriteLine("Unesi iznos u kunama:");
                iznos = double.Parse(Console.ReadLine());
                Console.WriteLine(iznos * 7.5345);
            }else
            {
                Console.WriteLine("Unesi iznos u eurima:");
                iznos = double.Parse(Console.ReadLine());
                Console.WriteLine(iznos / 7.5345);
            }
            
          


        }
    }
}
