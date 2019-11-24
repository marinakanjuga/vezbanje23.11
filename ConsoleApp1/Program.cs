using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {//fun koja ce kao ulazni par imati niz stringova. 
        //fun treba da vrati duz najduzeg stringa, u klasi strings
        static void Main(string[] args)
        {
            najduziString();
            Console.ReadKey();

        }
        static void najduziString()
        {
            List<string> stringovi = new List<string>();
            string a;
            int n;
            do
            {
                Console.WriteLine("upisi string");
                a = Console.ReadLine();             
                if (a == "")
                {
                    break;
                }               
                n = Convert.ToInt32(a);
                stringovi.Add(a);
                Console.WriteLine(suma(n));
            }
            while (true);
            //Console.WriteLine("najduzi string je {0}", stringovi.Max());
        }

        static int suma (int n) 
        {
            string m = Convert.ToString(n);
            int suma = 0;
            for (int i = 0; i < m.Length; i++)
            {
                suma = suma + Convert.ToInt32(m.Substring(i, 1));
            }
            return suma;

        }











        
    }
      
 }

