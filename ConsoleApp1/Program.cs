using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {//napisati fun koja ce kao ulazni parametar imati niz
        //vratiti razliku izmedju najmanjeg i najveceg broja
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
            int rez1 = brojevi.Max();
            int rez2 = brojevi.Min();
            int rezultat;
            rezultat = rez1 - rez2;
            Console.WriteLine("rezultat je {0} - {1} = {2}", rez1, rez2, rezultat);
        }












        
    }
      
 }

