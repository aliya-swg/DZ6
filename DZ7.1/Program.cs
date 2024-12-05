using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Building building1 = new Building(25, 5, 50, 2);
            building1.PrintBuildingInfo();

            Console.WriteLine("\n--- Next Building ---\n");

            Building building2 = new Building(30, 6, 72, 3);
            building2.PrintBuildingInfo();
        }
    }
}
