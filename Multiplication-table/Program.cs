using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 10; a++)  
            {
                for (int b = 1; b < 10; b++)   
                {
                    if (b <= a)
                    {
                        Console.Write("{0}*{1}={2} \t", a, b, a * b);    
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    }

