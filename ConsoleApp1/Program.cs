using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {//pronaci najveci broj u nizy , napisati fun koja ce kao ulazni parametar imati niz
        static void Main(string[] args)
        {
            najveciBroj();
            Console.ReadKey();

        }
        static void najveciBroj()
        {
            List<int> brojevi = new List<int>();
            string a;
            int n;
            do
            {
                Console.WriteLine("upisi broj");
                a = Console.ReadLine();
                if (a == "")
                {
                    break;                  
                }
                n = Convert.ToInt32(a);
                brojevi.Add(n);
            }
            while (true);
            Console.WriteLine("najveci broj je {0}", brojevi.Max());
        }












        
    }
      
 }

