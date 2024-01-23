using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite string:");
            string unos = Console.ReadLine();

            string rezultat = "";

            if (unos.Length < 5)
            {
                rezultat = unos;
            }
            else
            {
                rezultat = unos.Substring(2, unos.Length - 4);
            }

            Console.WriteLine("Novi string: " + rezultat);

            Console.ReadLine();
        }
    }
}
