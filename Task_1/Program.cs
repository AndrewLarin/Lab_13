using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Петербург", 1703, 319, 170);
            MultiBuilding mb = new MultiBuilding("Москва", 1147, 875, 250, 99);
            Console.WriteLine(mb.Print());
            Console.WriteLine(building.Print());
            Console.ReadKey();
        }
    }
}
