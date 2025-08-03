using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* This is a Claculator App. One that specifically uses switch case! Switch is a great way to mae the code editable
    in case I want to add more to the code at a later date- which I probably will! I've added new functionality to the calcultor!
    Feel free to take a look- I had to add another switch case to deal with the four new operations, exit, AC, Percent, and Toggle.
*/

namespace Multiple_New_Projects_and_Revamps.New_Projects
{
    internal class CalculatorButMyVersion
    {
       
        static void Main()
        {
            WriteLine("This is my Calculator- but Better! :D");
            //using the '\n' is a way to break up the prompt so when you run it the output is organized.
            WriteLine("Type a Number or one of the Operators: 1.Add\n 2.Subtract\n 3.Multiply\n 4.Divide\n 5.+/-\n 6.%\n 7.AC\n 8.Exit");

            //new declarations for processing user input
            double num1 = 0;
            double num2 = 0;
            string input;

            //Operations! Processing uses the x and y variables instead of the num variables.
            static double Add(double x, double y) => x + y;
            static double Subtract(double x, double y) => x - y;
            static double Multiply(double x, double y) => x * y;
            static double Divide(double x, double y) => x / y;
            /*These have a urany operation aka a single x to do the opertion is needed */
            static double Toggle(double x) => -x;
            static double Percent(double x) => x / 100;
            static double Clear() => 0;

            while (true)
            {
                WriteLine($"\nCurrent Number: {num1}");
                WriteLine("Enter an operator or a number: ");
                input = ReadLine().Trim();

                //here we try parsing a new number as the input
                if (double.TryParse(input,out double parsedInput ))
                {
                    num1 = parsedInput;
                    continue;
                }

                //switch case for the input(s)
                switch (input.ToLower())
                {
                    case "ac":
                        num1 = Clear();
                        WriteLine($"Result: {num1}");
                        break;
                    case "+/-":
                        num1 = Toggle(num1);
                        WriteLine($"Result: {num1}");
                        break;
                    case "%":
                        num1 = Percent(num1);
                        WriteLine($"Result: {num1}");
                        break;
                    //an exit would be helpful if the user wanted to end the app
                    case "exit":
                        WriteLine("Buh-Bye! Come back soon!");
                        return;

                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        WriteLine("Enter a second number please: ");
                        string secondinput = ReadLine();

                        if (double.TryParse(secondinput, out num2))
                        {
                            double result = 0;
                            //here is the afformentioned 'x' and 'y' variables
                            double x = num1;
                            double y = num2;

                            //with result declared we can clean up a little bit and instead of string the result...
                            switch (input)
                            {
                                case "+": result = Add(x, y); break;
                                    
                                case "-": result = Subtract(x, y); break;

                                case "*": result = Multiply(x, y); break;

                                //the usercannot divide by zero; that is a rule
                                case "/":
                                    //we'll make use of the Divide by Zero Exception Class to instantiate the rule above
                                    result = (y == 0) ? throw new DivideByZeroException() : Divide(x, y);
                                    break;

                            }

                            WriteLine($"Result {result}");
                            num1 = result;
                        }
                        else
                        {
                            WriteLine("Woops! Invlaid Second Number.");
                        }
                        break;
                    
                    default:
                        WriteLine("Hey! Please check your input- it needs to be a number or one of the operators listed!");
                        break;

                }
                
            }

        }
    }
}


