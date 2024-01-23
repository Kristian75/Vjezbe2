using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a:");
            decimal cijenaBezPDVa = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Unesite cijenu s PDV-om:");
            decimal cijenaSPDVom = decimal.Parse(Console.ReadLine());

            decimal iznosPDVa = cijenaSPDVom - cijenaBezPDVa;

            Console.WriteLine("Iznos PDV-a: " + iznosPDVa);

            Console.ReadKey();
        }
    }
}
