using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z04
    {
        public static void Izvedi()
        {
            //program od korisnika unosi dva cijela broja
            // Program ispisuje sve neparne brojeve između dva unesena broja

            Console.WriteLine("Unesi prvi broj: ");
            int prvi=int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            int drugi =int.Parse(Console.ReadLine());
            int manji = prvi < drugi ? prvi : drugi;
            int veci = prvi > drugi ? prvi : drugi;

            for (int i = manji; i <= veci; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
