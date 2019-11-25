using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

          

            StringFunctions funkcija = new StringFunctions();
            
            Console.WriteLine("uensite tekst");
            funkcija.CountWords();
            funkcija.CountSpaces();
            funkcija.LongestWord();
            funkcija.ShortestWord();


          
            
          
          
           


        }
    }
}

