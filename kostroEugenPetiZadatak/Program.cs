using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenPetiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("\nPogodite brojeve ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            Random Broj = new Random();
            int broj1;
            int broj2;
            int broj3;
            broj1 = Broj.Next(1, 4);
            broj2 = Broj.Next(1, 4);
            broj3 = Broj.Next(1, 4);

            Console.WriteLine("\nDobitni brojevi: ");
            Console.WriteLine("{1}, {2}, {3} ", broj1, broj2, broj3);
            Console.ReadKey();

        }
    }
}
