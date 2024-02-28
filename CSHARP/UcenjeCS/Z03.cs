using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z03
    {
        public static void Izvedi()
        {
            // Program unosi tri cijela broja
            // program ispisuje najmanji

            Console.Write("Unesi prvi broj: ");
            int prvi = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int drugi = int.Parse(Console.ReadLine());

            Console.Write("Unesi treći broj: ");
            int treci = int.Parse(Console.ReadLine());

            if (prvi < drugi && prvi < treci)
            {
                Console.WriteLine(prvi);
            }else if (drugi < prvi && drugi < treci)
            {
                Console.WriteLine(drugi);
            }else
            {
                Console.WriteLine(treci);
            }
           
            
        }
    }
}
