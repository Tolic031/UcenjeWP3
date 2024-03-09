using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z07
    {
        //Program unosi ime osobe, visinu i težinu.
        // Program ispisuje crvenom bojom 
        // ako je visina > 170 i < od 190 te težina < 90.5 ---- ti si zgodan/zgodna

        public static void Izvedi()
        {
            string ime = Pomocno.UcitajString("Unesi ime ");
            int visina = Pomocno.UcitajCijeliBroj("Unesi visinu u cm");
            float tezina = Pomocno.UcitajDecimalniBroj("Unesi težinu u kg");

            Console.WriteLine("ime.EndsWith('a'): " + ime.EndsWith("a"));

            if (visina > 170 && visina< 190)
            {
                if (tezina < 90.5)
                {
                    Console.Write("Ti ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(ime);
                    Console.ResetColor();
                    Console.Write(" si zgodan");
                }
                else if (ime.EndsWith("a"))
                {
                    Console.Write("Ti ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(ime);
                    Console.ResetColor();
                    Console.Write(" si zgodna");
                }
            }
           
        }
        
    }
}
