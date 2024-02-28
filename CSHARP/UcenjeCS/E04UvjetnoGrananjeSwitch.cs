using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04UvjetnoGrananjeSwitch
    {
        public static void Izvedi()
        {
            int i = 2;
            // ako je i=0 jednako napiši dobar, i = 1 napiši loš, i=2 napiši zao

            if (i==0)
            {
                Console.WriteLine("Dobar");
            }else if (i==1)
            {
                Console.WriteLine("Loš");
            }else if(i==2)
            {
                Console.WriteLine("Zao");
            }

            switch (i) // radi sa INT, CHAR, STRING
            {
                case 0:
                    Console.WriteLine("Dobar");
                    break;
                case 1:
                    Console.WriteLine("Loš");
                    break;
                case 2:
                    Console.WriteLine("Zao");
                    break;
                default: // ovo je else u ifu u switchu
                    Console.WriteLine("Ostalo");
                    break;
            }


            Console.Write("Unesi ime grada: ");
            string grad = Console.ReadLine();

            switch(grad)
            {
                case "Osijek":
                case "Vukovar":
                    Console.WriteLine("Slavonija");
                    break;
                case "Split":
                case "Zadar":
                    Console.WriteLine("Dalmacija");
                    break;
                case "Zagreb":
                case "Sisak":
                    Console.WriteLine("Središnja Hrvatska");
                    break;
            }

        }
    }
}
