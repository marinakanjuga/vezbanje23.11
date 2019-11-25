using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StringFunctions
    {
        public void CountWords () 
        {
            string a;            
            a = Console.ReadLine();
            string[] splitovano = a.Split(new char[] { ' ' }, StringSplitOptions.None);
            Console.WriteLine(splitovano.Length);
            Console.ReadKey();
        }
        public void CountSpaces()
        {
            string a;
            a = Console.ReadLine();
            string[] splitovano = a.Split(new char[] { ' ' }, StringSplitOptions.None);
            Console.WriteLine(splitovano.Length-1);
            Console.ReadKey();
        }
        public void ShortestWord()
        {
            string min = " ";
            string a;
            a = Console.ReadLine();
            string[] splitovano = a.Split(new char[] { ' ' }, StringSplitOptions.None);
            for (int i = 0; i < splitovano.Length; i++)  
            {
                int lent = splitovano[i].Length;
                if (lent < min.Length) 
                {
                    min = splitovano[i];
                }
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
        public void LongestWord()
        {
            string max = " ";
            string a;
            a = Console.ReadLine();
            string[] splitovano = a.Split(new char[] { ' ' }, StringSplitOptions.None);
            for (int i = 0; i < splitovano.Length; i++)
            {
                int lent = splitovano[i].Length;
                if (lent > max.Length)
                {
                    max = splitovano[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
