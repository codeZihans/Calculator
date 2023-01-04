using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CalCulator");
            Console.WriteLine("Operation Available");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("5.Find a remainder");
            Console.WriteLine("x. Quit");



            for (; ;)
            {

                Console.Write("Insert Your Option: ");
                string optionstring = Console.ReadLine();

                if (optionstring == "x")
                {
                    Environment.Exit(0);
                }

                int optionindex = Convert.ToInt32(optionstring);

                Console.Write("Enter Your First Number: ");
                string firststring = Console.ReadLine();
                int firstnumber = Convert.ToInt32(firststring);

                Console.Write("Enter your Second Number: ");
                string secondstring = Console.ReadLine();
                int secondnumber = Convert.ToInt32(secondstring);




                if (optionindex == 1)
                {
                    int sum = Add(firstnumber, secondnumber);

                    Console.WriteLine("The sum is : " + sum);
                }
                else if (optionindex == 2)
                {
                    int substract = Substract(firstnumber, secondnumber);
                    Console.WriteLine("The substract is : " + substract);
                }
                else if (optionindex == 3)
                {
                    int multiply = Multiply(firstnumber, secondnumber);
                    Console.WriteLine("The result is : " + multiply);
                }
                else if (optionindex == 4)
                {
                    double divide = Divide(firstnumber,secondnumber);
                    Console.WriteLine("The result is : " + divide);
                }
                else if (optionindex == 5)
                {
                    int remainder = firstnumber % secondnumber;
                    Console.WriteLine("The result is : " + remainder);
                }
                else
                {
                    Console.WriteLine("Please Insert Your Option properly");
                }
            }

            Console.ReadLine();
        }// main method ends

        static int Add(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        static int Substract(int first, int second)
        {
            int substract = first - second;
            return substract;
        }
        static int Multiply(int first, int second)
        {
            int multiply = first *second;
                
                return multiply;
        }
        static double  Divide(int first, int second)
        {
            double result = (double)first / second;

            return result;
        }


    }
}
