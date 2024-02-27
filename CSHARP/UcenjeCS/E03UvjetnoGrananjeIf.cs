using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {
        public static void Izvedi()
        {

            int i = 7; //sa ovim korakom se preksače nekoliko linija koda kako bi se bilo brži
                       // školski princip je Console.Readline("Unesi cijeli broj")
                       // int i = int.Parse(console.readline)

            
            bool uvjet = i == 7;        // prvo se gleda desna strana, ovdje je desna strana i=7 sto znaci da ce cw izbacit true.

            
            
            //minimalni if izraz DOBRA PRAKSA
            if(uvjet)
            {
                Console.WriteLine("1.Ušao sam u If granu");
            }

            // ako se If odnosi na jednu liniju i ne trebaju {}
            if(uvjet)
                Console.WriteLine("2.Bez {} zagrada");
                Console.WriteLine("3.Ovo će se uvijek ispisati"); // neovisno jel i 7 ili bilo koji drugi broj.

            
            
            // primjer kako se inače piše if

            if (i > 0)
            {
                Console.WriteLine("4. i je veće od 0");
            }






        }
    }
}
