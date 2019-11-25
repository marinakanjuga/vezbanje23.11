using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            


            Console.WriteLine("unesite brojeve");
            List<int> brojevi = new List<int>();
            int a;
            string b;
            do
            {
                b = Console.ReadLine();
                a = Convert.ToInt32(b);
                if (a < 0)
                {
                    break;
                }
                brojevi.Add(a);
            } while (true);

            Console.WriteLine(SumaUnetihBrojeva(brojevi));
            Console.WriteLine(AritmetickaSredina(brojevi));
            SortiranaLista(brojevi);
            Console.ReadKey();
        }

        static int SumaUnetihBrojeva (List<int> brojevi) 
        {
            int sum = 0;
            foreach (int i in brojevi) 
            {
                sum += i;
            }
            return sum;
        }
        static int AritmetickaSredina (List<int> brojevi)
        {
            //double r;
            int rez = 0;
            double rez1 = Convert.ToDouble(rez);
            rez1 = brojevi.Average();
            return rez;          
        }

        static void SortiranaLista(List<int> brojevi)
        {                       
            brojevi.Sort();
            foreach (int broj in brojevi) 
            {
                Console.WriteLine(broj);
            }
            

        }
    }
}

