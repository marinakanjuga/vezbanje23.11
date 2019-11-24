using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {  
            nizovi();         
                       
            static void nizovi () 
            {
                int[] brojevi = new int[10];
                int n;
                for (n=0; n < brojevi.Length; n++) 
                {
                    brojevi[n] = n * 10; 
                    Console.WriteLine("vrednost clanova {0} = {1}", n, brojevi[n]);
                }
                Console.WriteLine("vrednsot sume je {0}", calculate(brojevi));
            }
            static int calculate(int [] brojevi) 
            {
                int sum = 0;
            foreach (int n in brojevi) 
                {                   
                    sum = sum + n;
                }
                return sum;
                Console.WriteLine("vrednost je {0}", sum);
                Console.ReadKey();
            }
            
            
            
           
               
          
            
           
           
                
               

        }
    }
      
 }

