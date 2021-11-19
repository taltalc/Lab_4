using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            int Sum = 0;
                
           if(number>0)
            {
                for (int count = 1; count <= number; count++)
                {

                    Sum += (2 * count - 1);
                    Console.WriteLine(Sum);
                }
            }
           else
            {
                Console.WriteLine("Ошибка!");
            }
              Console.ReadKey();  
            }
            
        }
    }

