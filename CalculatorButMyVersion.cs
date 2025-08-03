using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* This is a Claculator App. One that specifically uses switch case! Switch is a great way to mae the code editable
    in case I want to add more to the code at a later date- which I probably will! 
*/

namespace Multiple_New_Projects_and_Revamps.New_Projects
{
    internal class CalculatorButMyVersion
    {
        static void Main()
        {
            WriteLine("This is my Calculator- but Better! :D");
            WriteLine("Please choose an operation by entering 1,2,3, or 4: ");

            //using the '\n' is a way to break up the prompt so when you run it the output is organized.
            WriteLine(" 1.Add\n 2.Subtract\n 3.Multiply\n 4.Divide 5.+/-\n 6.%\n 7.AC");

            int op = Convert.ToInt32(Console.ReadLine());

            WriteLine("Enter the First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            WriteLine("Enter the Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Operations!
            static double Add(double x, double y) => x + y;
            static double Subtract(double x, double y) => x - y;
            static double Multiply(double x, double y) => x * y;
            static double Divide(double x, double y) => x / y;
            static double Toggle(double x) => -x;
            static double Percentage(double x) => x / 100;
            static clear() => 0;
            

            /*So why didn't we do it num1 + num2 and so on? The above code declared Add, Subtract, Multiply, and
             * Divide. The way I decided to do this created methods out of the operations, now they can be called by name
             * and perform the operation based upon the previously input num1 and num2. In math we typically use x and y 
             * when discussing variables- the inputs are variables hence the why we would structure with x and y. 
             * Should we want, we can continue to add more operators while keeping our code organized neatly. The Lambda 
             * or Rocket, is how we can funnel the operators to work as intended. 
            */

            //I also decided switch case was a fun way to keep things organized as well as structured- in case I add more
            switch (op)
            {
                case 1:
                    WriteLine($"Result: {Add(num1, num2)}");
                    break;
                case 2:
                    WriteLine($"Result: {Subtract(num1, num2)}");
                    break;
                case 3:
                    WriteLine($"Result: {Multiply(num1, num2)}");
                    break;
                case 4:
                    if (num2 != 0)
                        WriteLine($"Result: {Divide(num1, num2)}");
                    else
                        WriteLine("Cannot Divide by Zero! :(");
                    break;
                case 5:
                    WriteLine($"Result: {Toggle(num1, num2)}");
                    break;
                case 6:
                    WriteLine($"Result: {MPercentage(num1, num2)}");
                    break;
                case 7:
                    WriteLine($"Result: {Multiply(num1, num2)}");
                    break;
                default:
                    WriteLine("Invalid Option- please input correctly, for the calcultaor to work as intended!");
                    break;
            }

        }
    }
}

