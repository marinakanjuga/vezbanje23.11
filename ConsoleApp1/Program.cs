using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            radSaKlasom();
            Console.ReadKey();
        }
       
        static void radSaKlasom () 
        {
            List<int> numbers = new List<int>();
            numbers.Add(24);
            numbers.Add(20);

            NovaKlasa.logFileName = "C:\\proba.log";
            foreach (int i in numbers) 
            {
                NovaKlasa.log("uneti broj je" + Convert.ToString(i));
            }

        }      
         

    






    











    }

}

