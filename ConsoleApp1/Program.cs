using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            NovaKlasa klasa = new NovaKlasa();
            //Console.WriteLine(klasa.nizovi());
            nizovi();
            Console.ReadKey();
        }

        static void nizovi()
        {
            Console.WriteLine("unesite broj redova");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int b =1;
            for (int i = 1; i <= a; i++)
            {
                
                for (int j=1; j <= i; j++) 
                {
                    Console.Write("{0}", b); 
                    b++;
                    
                }
                Console.WriteLine();
            }
        }























    }

}

