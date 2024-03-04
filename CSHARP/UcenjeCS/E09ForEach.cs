using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09ForEach
    {
        public static void Izvedi()
        {
            string grad = "Osijek";

            // Ispiši svaki znak u novom redu

            for (int i = 0; i< grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }


            foreach (var c in grad)
            {
                Console.WriteLine(c);
            }

            // OGRANIČENJA
            //Uvijek se ide od prvog do zadnjeg elementa niza
            // ne znaš na kojem si indeksu, znaš samo vrijednost na tom indeksu
            // ne možeš utjecat na elemente niza

            // unazad slova
            for (int i = grad.Length - 1; i>=0; i--)
            {
                Console.WriteLine(grad[i]);
            }

            int[] niz = new int[] {1,2,3,4,5,6,7,8,9};
            foreach (var i in niz)
            {
                Console.WriteLine(i);
            }
        }
    }
}
