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
            nizovi();

            static void nizovi()
            {
                najveciBroj();
                Console.ReadKey();

            }

            static void najveciBroj()
            {
                int[] myNumbers = { 1, 2, 3, 5, 6, 8 };
               
                //Console.WriteLine("najveci broj je {0}", myNumbers.Max());
                int rez1 = myNumbers.Max();
                int rez2 = myNumbers.Min();
                int rezultat;
                rezultat = rez1 - rez2;
                Console.WriteLine("rezultat je {0} - {1} = {2}", rez1, rez2, rezultat);
            }



        }






    











    }

}

