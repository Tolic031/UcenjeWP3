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
            Console.WriteLine(Broj); // kad napišemo ovu komandu, dobijamo broj koji korisnik unosi
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
            Console.WriteLine(i / (float)j); // (float) -> u ovom slučaju prebacuje cijeli broj u decimalni broj.

            // Iz dvoznamenkastog broja ispiši prvi broj

            Console.Write("Unesi dvoznamenkasti broj: ");
            int dbroj = int.Parse(Console.ReadLine());
            Console.WriteLine(dbroj / 10);

            // Iz dvoznamenkastog broja ispiši drugi broj
            Console.WriteLine(dbroj % 10); // % - modulo je ostatak nakon cjelobrojnog djeljenja

            bool uvjet = true; // vrijednost može biti true ili false

            //operator jednokosti == - provjerava se da li je nešto jednako
            // jedno = dodjeljuje vrijednost 
            int k = 2, l = 2;
            Console.WriteLine(k==l);

            //različito !=
            Console.WriteLine(k!=l); // da je k bilo koji drugi broj osim isto kao l dalo bi true

            //formatiranje rada konzolnog ispisa
            Console.WriteLine("{0} {1} {2} {3}", k>l, k>=l, k<l, k<=l );


            // uvećanje za 1
            int v = 1;
            Console.WriteLine(v);
            v = v + 1; // kao u matematici, prvo se riješava desna strana pa onda lijeva.
            v += 1;            // skraćena sintaksa 1.
            v++;            //skraćena sintaksa 2.
            Console.WriteLine(v);

            // INKREMENT I DEKREMENT
            v = 1;
            
            //skraćena sintaksa

            // ispisati i uvećati
            Console.WriteLine(v++);

            //uvećati i ispisati
            Console.WriteLine(++v);

            //isto vrijedi i za dekrement npr --v i v--

            int x = 2, y = 1;
            x = x + ++y; //x = 4, y = 2
            y = --x;    // x = 3, y = 3
            Console.WriteLine(x+y);


        }
    }
}
