using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeck.lefadat
{
    internal class Program
    {
        private const int V = 10;

        static void Main(string[] args)
        {
            Random random = new Random();
            int[] szamok = new int[10];
            int parosdb = 0;
            int paratlandb=0;
            for (int i = 0; i < szamok.Length; i++) {
                szamok[i] = random.Next(1,100);
            Console.WriteLine(szamok);
        }
            for (int i = 0; i < szamok.Length; i++)
            {
                if (i %== 2)
                { 
                
                }
            }
            
            
            
            
            Console.ReadLine();
        }
       
       
    }
    
}
