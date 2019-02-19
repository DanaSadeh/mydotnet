using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("write a number");
            a=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("write another number");
            b = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine(a+ " is bigger than " +b);
            
            }
            else
            {
                Console.WriteLine(b + " is bigger than " + a);
            }
        }
    }
}
