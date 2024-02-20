using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {

        public static void Izvedi()
        {
            // pitati profa - Šta nam znači \r, kako staviti hrvatske dijakritičke znakove.

            string Ime;
            Console.Write("Unesi ime: ");

            Ime = Console.ReadLine();
            Console.WriteLine(Ime);


            string Grad;
            Console.Write("Unesi ime grada: ");
            Grad = Console.ReadLine();
            Console.WriteLine(Grad + " " + Grad + " " + Grad);

            Console.Write("Edunova\n"); // - \n mi daje novi red ako nema consolewrite line
            Console.WriteLine("\tOsijek");  // - \t mi daje tab - odvoji novu riječ za tab udaljenost.


            Console.WriteLine("|\\---/|");
            Console.WriteLine("| o_o |");
            Console.WriteLine(" \\_^_/");


            Console.WriteLine("      |\\      _,,,---,,_\r");
            Console.WriteLine("ZZZzz /,`.-'`'    -.  ;-;;,_\r");
            Console.WriteLine("     |,4-  ) )-,_. ,\\ (  `'-'\r");
            Console.WriteLine("    '---''(_/--'  `-'\\_)  Felix Lee \r");
    


        }
    }
}
