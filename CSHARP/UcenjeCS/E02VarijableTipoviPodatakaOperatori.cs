using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {
        public static void Izvedi()
        {
            // Deklaracija varijable tipa int (cijeli broj)
            int CijeliBroj;
            CijeliBroj = 7;  // Dodijeljivanje vrijednosti varijable, pomoću operatora =

            Console.WriteLine(CijeliBroj); // korištenje varijable

            Console.WriteLine("Unesi cijeli broj: ");
            int Broj = int.Parse(Console.ReadLine()); // Parse - interpretiraj broj(int) u string u ovom slučaju.
            Console.WriteLine( Broj); // kad napišemo ovu komandu, dobijamo broj koji korisnik unosi
            Console.WriteLine(CijeliBroj + Broj); // operator zbrajanja



            
            //Deklaracija i dodijeljivanje vrijednsti u jednoj liniji
            string v1 = "Osijek";
            var v2 = "Edunova";// Ključna riječ var uzima tip podatka s desne strane

            Console.WriteLine(v1 + " " + v2); // + je operator nadoljepljivanja


            float db = 3.14f; //db predstavlja decimalni broj
            double vdb = 0.4343289248432; //vdb predstavlja veliki decimalni broj


            Console.WriteLine("Unesi visinu u metrima: ");
            float Visina = float.Parse(Console.ReadLine());
            Console.WriteLine(Visina);


            int NajveciBroj = int.MaxValue;

            int i = 2, j = 3;
            Console.WriteLine(i + j);
            Console.WriteLine(i - j);
            Console.WriteLine(i * j);
            Console.WriteLine(i / (float) j); // (float) -> u ovom slučaju prebacuje cijeli broj u decimalni broj.

            // Iz dvoznamenkastog broja ispiši prvi broj

            Console.Write("Unesi dvoznamenkasti broj: ");
            int dbroj = int.Parse(Console.ReadLine());
            Console.WriteLine(dbroj/10);

            // Iz dvoznamenkastog broja ispiši drugi broj
            Console.WriteLine(dbroj/10);
        }
    }
}
