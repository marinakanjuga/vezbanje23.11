using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //NovaKlasa klasa = new NovaKlasa();
            //NovaKlasa.nizovi();
            //string[] cars = new string[] {"volvo", "opel", "bmv"};

            //NizBrojeva(new int[] { 1, 2, 3, 5, 6, 8 });
            //int[] niz = { 1, 2, 3, 5, 6 };
            //onsole.WriteLine(niz.Max());
            //List<int> brojevi = new List<int>();
            //Console.WriteLine(Spejsovi(new string[] {"maja", "kakak", "ksla"}));
            string op, broj1, broj2;
            int num1, num2;           
            do
            {
                broj1 = Console.ReadLine();
                broj2 = Console.ReadLine();
                op = Console.ReadLine();
                if (op == "" || broj1 == "" || broj2 == "")
                {
                    break;
                }
                num1 = Convert.ToInt32(broj1);
                num2 = Convert.ToInt32(broj2);
                int rez = rezultat(num1, num2, op);
                Console.WriteLine("{0}, {1}, {2} = {3}", num1, num2, op, rez);
                
            } while (true);
            Console.WriteLine();
            Console.ReadKey();
        }
        
            static int rezultat(int num1, int num2, string op)
            {
                int k = 0;
                if (op == "+")
                {
                    k = num1 + num2;
                }
                else if (op == "-")
                {
                    k = num1 - num2;
                }
                else if (op == "*")
                {
                    k = num1 * num2;
                }
                else if (op == "/")
                {
                    k = num1 / num2;
                }
                return k;
            }
           























        }

}

