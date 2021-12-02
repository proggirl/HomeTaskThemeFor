using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskAll
{
    public class HTask3
    {
        public string TaskText3 = @" Writing methods and applying scope
        1 Write a method named isEven that accepts an int argument. 
        The method should return true if the argument is even,
        or false otherwise.Also write a program to test your method.
        2.A person is elligible to vote if his / her age is greater than or equal to 18.
        Define a method to find out if he / she is elligible to vote.
        3.Write a program to print the sum of two numbers entered by user by defining your own method.";


        public void start()
        {
            Console.WriteLine(TaskText3);
            while (true)
            {
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        int i = int.Parse(Console.ReadLine());

                        if (isEven(i))
                        {
                            Console.WriteLine(i + " is even");
                        }
                        else
                        {
                            Console.WriteLine(i + " is odd");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter your age: ");

                        int c = int.Parse(Console.ReadLine());
                        if (voteAge(c))
                        {
                            Console.WriteLine("You elligible to vote");
                        }
                        else
                        {
                            Console.WriteLine("You're not elligible to vote");
                        }
                        break;

                    case "3":
                        Console.Write("a = ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: " + Sum(a, b));

                        Console.ReadLine();
                        break;
                    default:
                        return;
                }
            }
        }
        

         bool isEven(int i)
        {
            return (i % 2) == 0;
        }

         bool voteAge(int c)
        {
            return c >= 18;
        }

         int Sum(int a, int b)
        {
            return a + b;
        }
    }

    
}
