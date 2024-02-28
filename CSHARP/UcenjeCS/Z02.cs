using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z02
    {
        public static void Izvedi()
        {
            // Program unosi dva broja
            // Ispisuje veći

            Console.Write("Unesi prvi broj: ");
            int prvi = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int drugi = int.Parse(Console.ReadLine());

            if(prvi > drugi)
            {
                Console.WriteLine(prvi);
            }
            else 
            {
                Console.WriteLine(drugi);
            }
        }
    }
}
