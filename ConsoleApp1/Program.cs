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
        //static string najduziString()
        //{
            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazdaaa" };
            string i = cars.Max();
            int b = Convert.ToInt32(i);
            
            Console.WriteLine(Convert.ToInt32(i));
        //}
        static int suma(int[] b)
        {
            int max = b[0]; 
            for (int i = 1; i < b.Length; i++)
            {

            }
        }










    }

}

