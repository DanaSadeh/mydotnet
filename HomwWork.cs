﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course3_hw
{
    class HomwWork
    {
        static void Main(string[] args)
        {
            
            //q1:
            Console.WriteLine("q1: Is there a reminder?");
            Console.WriteLine("Please Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter another number");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine(a+ "%" + b+ "=" + a%b +" There is no remainder");
            }
            else
            {
                Console.WriteLine(a + "%" + b + "=" + a % b + "  There is a remainder");
            }


            //q2:
            Console.WriteLine(" ");
            Console.WriteLine("q2: whats the Sum and whtas the Average");
            Console.WriteLine("Please Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter another number");
            int z = Convert.ToInt32(Console.ReadLine());

            int c = x + z;
            int d = c / 2;
            Console.WriteLine(c + " is the Sum of " + x + "+" + z);
            Console.WriteLine(d + " is the Average of " + x + "," + z);


            //q3:
            Console.WriteLine(" ");
            Console.WriteLine("q3: Get only positive number ");
            Console.Write("Please Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thnx :)");
            do
            {
                Console.WriteLine(num1);
                num1--;
               

            } while (num1 >= 0);
            Console.WriteLine("The counter went down with no negetiv outcome");

            //q4:
            Console.WriteLine(" ");
            Console.WriteLine("q4: Is it a prime number?");
            Console.Write("please enter a number: ");

            int prime = Convert.ToInt32(Console.ReadLine());
            int m = 2;
            if (prime % m != 0 && m < prime)
            {
               
                Console.WriteLine("Thnx " + prime + " is a prime number");
                
                
            }else
            Console.WriteLine("Thnx " + prime + " is not a prime number");




            //q5:
            Console.WriteLine(" ");
            Console.WriteLine("q5: The guessing game");
            int secret = 54;
            int Guess = 0;

            while (Guess != secret)
            {
                Console.Write("Hey please Enter your guess number: ");
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess > secret)
                {
                    Console.WriteLine("{0} is too high!", Guess);
                }
                else if (Guess < secret)
                {
                    Console.WriteLine("{0} is too low!", Guess);
                }
                else
                {
                    Console.WriteLine("{0} is right! Congratulations.", Guess);
                    
                }
            }


            //q6:
            Console.WriteLine(" ");
            Console.WriteLine("q6: Factorial calculation");
                Console.WriteLine("please enter a number:");
                int usernum;

                usernum = Convert.ToInt32(Console.ReadLine());
                // = 5;
                int result = usernum;
                int i = 0;
                for (i = 1; i < usernum; i++)
                    result *= i;

                Console.WriteLine(result + " Is the Factorial calculation of your number " + usernum);


            //q7:
            Console.WriteLine(" ");
            Console.WriteLine("q7:multipile without multipiling");
                Console.WriteLine("please enter a number:");
                int y = Convert.ToInt32(Console.ReadLine());// 4
                Console.WriteLine("please enter another number:");
                int u = Convert.ToInt32(Console.ReadLine());//5
                int f = 0;
                int total = y;
                for (f = 0; f < u; f++)

                    total += y;

                Console.WriteLine(total - y + " Is multipile without multipiling of " +y +" * "+ u + " :)" );
            Console.ReadKey();

            }

        }

    }

        
   


