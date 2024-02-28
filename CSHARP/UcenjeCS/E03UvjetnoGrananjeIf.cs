using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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


            var j = 5; 
            //DODATNI OPERATORI (&) - AND ILI NA HR. I

            if(i==7 & j== 5)
            {
                Console.WriteLine("5.Zadovoljena su oba uvjeta");
            }

            // razlika između & i && - and
            //kod & se provjeravaju oba uvjeta
            // kod && ukoliko prvi uvjet nije zadovoljen drugi uvjet se ne provjerava

            if(i==7 && j==5)
            {
                Console.WriteLine("6. Oba uvjeta su zadovoljena");
            }
            else // neobavezni dio if naredbe
            {
                Console.WriteLine("7.Jedan od uvjeta nije zadovoljen");
            }

            //LOGIČKO ILI ALTGR + W ---> | ili ||
            //  | uvijek se provjeravaju oba uvjeta
            //  || ukoliko je prvi uvjet zadovoljen drugi uvjet se ne provjerava

            if (i==7 || j==5)
            {
                Console.WriteLine("8. Jedan od uvjeta je zadovoljen ili oba");
            }else
            {
                Console.WriteLine("9. Niti jedan uvjet nije zadovoljen");
            }

            //LOGIČNO NOT ! - NE
            // jedan kompliciran izraz
            if ((i > 0 && i < 10) || !(i < 5))
            {
                Console.WriteLine("10. Zadovoljen kompliciran uvjet");
            }

            i = 5;
            if (i == 1)
            {
                Console.WriteLine("11. i je 1");
            }else if (i == 2)
            {
                Console.WriteLine("12. i je 2");
            }else if (i == 3)
            {
                Console.WriteLine("44. i je 3");
            }// else može biti nebrojeno puta
            else
            {
                Console.WriteLine("13. i nije 1 ili 2");
            }



            // inline if
            // kadaif poziva istu naredbu sa različitim parametrima
            if (i == 3)
            {
            Console.WriteLine("14: i je 3");
            }
            else
            {
                Console.WriteLine("15.i nije 3");
            }
            // primjer sa inline if gdje sve stane u jedan red umjesto kao gore u 4 reda.
            Console.WriteLine(i == 3 ? "14. i je 3" : "15. i nije 3");


            //UGNJEŽĐIVANJE

            if (i == 4)
            {
                if (j < 9)
                {
                    Console.WriteLine("16. Ugnježđeni if");
                }
            } 
        }    
     
            
    }
}
