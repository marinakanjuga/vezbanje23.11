using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacija, broj1, broj2;
            int num1, num2;
            broj1 = Console.ReadLine();           
            broj2 = Console.ReadLine();
            
            operacija = Console.ReadLine();
            if (operacija != "" || broj1 != "" || broj2 !="")
            {
                num1 = Convert.ToInt32(broj1);
                num2 = Convert.ToInt32(broj2);
                int rez = rezultat(num1, num2, operacija);
                Console.WriteLine("{0}, {1}, {2} = {3}", num1, num2, operacija, rez);
            }
            else 
            {
                num1 = 2;
                num2 = 2;
                int rez = rezultat(num1, num2, operacija);
                Console.WriteLine("{0}, {1}, {2} = {3}", num1, num2, operacija, rez);
            }
          
            static int rezultat (int num1, int num2, string operacija)
            {
                int k = 0;
                if (operacija == "+")
                {
                    k = num1 + num2;
                }
                else if (operacija == "-")
                {
                    k = num1 - num2;
                }
                else if (operacija == "*")
                {
                    k = num1 * num2;
                }
                else if (operacija == "/")
                {
                    k = num1 / num2;
                }
                return k;
            }
            Console.ReadKey();
       
        }
    }  
 }

