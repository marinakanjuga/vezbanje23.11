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
            Console.WriteLine(Spejsovi("fjajf jj j"));
            Console.ReadKey();
           
        }
        static int Spejsovi(string rec)
        {
            int sum = 0;

            for (int i = 0; i < rec.Length; i++)
            {
                if (char.IsWhiteSpace(rec[i]))
                {
                    sum++;
                }
            }
            return sum;
        }

    






    











    }

}

