using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] homesklet = { 12, 8, -1, 5, 14, 7, 2 };
            int nagy = 0;
            int kicsi = 0;
            int osszeg = 0; 

            foreach (var item in homesklet)
            {
                osszeg = item;
                if (item > homesklet[0])
                {
                    nagy = item;
                }
                else if (item < homesklet[0])
                {
                    kicsi = item;
                }
                
            }
                Console.WriteLine($"A legnagyob hő: {nagy}");
                Console.WriteLine($"A lwgkisebb hő: {kicsi}");
            Console.WriteLine($"A átlaga{ osszeg/homesklet.Length}");
                Console.ReadLine();
        } 
    }
}
