using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Go(5));
            Console.ReadKey();
        }
        public static string Go(int num)
        {
            string dash = "";
            for (int i = 0; i < num; i++)
            {
                dash = dash + "-";
            }
            return dash;
        }
    }
}
