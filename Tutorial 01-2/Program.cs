using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01_2
{
    internal class Program
    {
        static void Main(string[] args)
        {for (int i = 0; i<10;  i++)
            {
                Console.WriteLine("Enter a number: ");
                int number= Convert.ToInt32(Console.ReadLine());

                if (number%2==0 )
                {
                    Console.WriteLine(number+ " is Even");
                    
                }
                else
                {
                    Console.WriteLine(number+ " is Odd");
                   
                }
            }

        }
    }
}
