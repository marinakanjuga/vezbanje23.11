using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //1.zadatak

            Console.WriteLine("unesite dva broja");
            double a;
            double b;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (a%2==0 && b%2==0) 
            {
                double rezultat = a * b;
                Console.WriteLine("rezultat je {0}", rezultat);
            }
            else if (!(a % 2 == 0) && !(b % 2 == 0)) 
            {
                double rezultat = a + b;
                Console.WriteLine("rezultat je {0}", rezultat);
            }
            else if ((!(a % 2 == 0) && b % 2 == 0) || (a % 2 == 0 && !(b % 2 == 0)))
            {
                double rezultat;
                if (a>b)
                {
                    rezultat = a / b;
                }
                else 
                {
                    rezultat = b / a;
                }
                Console.WriteLine("rezultat je {0}", rezultat);
            }
        }
    }
}

