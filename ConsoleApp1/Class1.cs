using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class NovaKlasa
    {
        public string color = "red"; 
        public static string logFileName = "C:\\proba.log";

        
        public static void log(string logMessage)
        {
            using (StreamWriter file = new StreamWriter(logFileName, true))
            {
                file.WriteLine(DateTime.Now.ToString("yyyy-mm-dd HH-mm-ss K"));
                file.WriteLine(logMessage);
                file.WriteLine("********");
                file.WriteLine();
            }
        }

        public static void nizovi () 
        {
            Console.WriteLine("unesite broj redova");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= a; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
