using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {
            // eng Arrays - polja
            // JEDNODIMENZIONALNI NIZOVI

            int[] Temperature = new int[12]; // int
            Temperature[0] = 1; // [] - ovo je index niza, a 1 je vrijednost
            Temperature[Temperature.Length - 1] = 2; // temp.leght mi daje zadnje mjesto.

            Console.WriteLine(Temperature);
            Console.WriteLine(string.Join(",", Temperature));

            string[] gradovi = new string[3]; // string

            gradovi[0] = "Osijek";
            gradovi[1] = "Zagreb";
            gradovi[2] = "Donji Miholjac";


            Console.WriteLine(string.Join(",", gradovi));

            //SKRAĆENI NAČIN DEFINIRANJA NIZA

            int[] brojevi = { 2, 3, 3, 4, 7, 5, 5, 4 };

            // ispiši broj 7
            Console.WriteLine(brojevi[4]);

            // prvi element niza
            Console.WriteLine(brojevi[0]);

            // zadnji element niza
            Console.WriteLine(brojevi [brojevi.Length - 1]);

            // DVODIMENZIONALNI NIZ --> (matrica) TABLICA

            int[,] tablica =
            {
                {1,2,3 },
                {4,5,6},
                {7,8,9 }
            };
            Console.WriteLine(tablica [1,2]);

            // TRODIMENZIONALNI NIZ - KOCKA

            int[,,] kocka = new int[10,10,10]; //koliko se elemenata može pohranit - 1000

            //VIŠEDIMENZIONALNI NIZOVI

            int[,,,,,] ZvjezdaneStaze;

            string grad = "Osijek"; // string je niz znakova
            Console.WriteLine(grad[3]); // ispisao je char oblik podatka

            char znak = 'j';
            Console.WriteLine(znak);
            Console.WriteLine((int)znak); // dobijemo da se nalazi na 106.poziciji.

            int[] niz = { 1, 2, 3, 4, 5 };
            //ispišite sve elemente niza jedno ispod drugog

            Console.WriteLine(niz[0]);
            Console.WriteLine(niz[1]);
            Console.WriteLine(niz[2]);
            Console.WriteLine(niz[3]);
            Console.WriteLine(niz[4]);
        }
    }
}
