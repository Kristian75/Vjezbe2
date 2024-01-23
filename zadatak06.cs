using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int z = 5;

            if (x > 0 && y > 0 && z > 0)
            {
                if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
                {
                    Console.WriteLine("Vrijednosti x, y i z predstavljaju stranice pravokutnog trokuta.");
                }
                else
                {
                    Console.WriteLine("Vrijednosti x, y i z ne predstavljaju stranice pravokutnog trokuta.");
                }
            }
            else
            {
                Console.WriteLine("Vrijednosti x, y i z moraju biti veće od 0.");

                Console.ReadLine();
            }
        }
    }
}
