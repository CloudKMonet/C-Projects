using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* This is a Claculator App. Switch Case is a great way to make my logic processing codes mored edit friendly- just in case I'm
    looking into adding more functionality to the code at a later date. The most recent update was for functionality, and to make the 
    console app calculator more interesting to use. I had added a second switch case to deal with the four new operations: Exit, AC,
    Percent, and Toggle. In addition to the standard addition, subtraction, multiplication, and division. */

namespace Multiple_New_Projects_and_Revamps.New_Projects
{
    internal class CalculatorButMyVersion
    {
       
        static void Main()
        {
            WriteLine("This is my Calculator- but Better! :D");
            //Using the '\n' is a way to break up the prompt so when you run it the output is organized.
            WriteLine("Type a Number or one of the Operators: 1.Add\n 2.Subtract\n 3.Multiply\n 4.Divide\n 5.+/-\n 6.%\n 7.AC\n 8.Exit");

            //Mew declarations for processing user input.
            double num1 = 0;
            double num2 = 0;
            string input;

            //Operations! Processing uses the x and y variables instead of the num variables.
            static double Add(double x, double y) => x + y;
            static double Subtract(double x, double y) => x - y;
            static double Multiply(double x, double y) => x * y;
            static double Divide(double x, double y) => x / y;
            //These have a urany operation aka a single x to do the opertion is needed.
            static double Toggle(double x) => -x;
            static double Percent(double x) => x / 100;
            static double Clear() => 0;

            //I used a while loop to contain both switch cases, so the operations work as intended.
            while (true)
            {
                WriteLine($"\nCurrent Number: {num1}");
                WriteLine("Enter an operator or a number: ");
                input = ReadLine().Trim();

                //Here I use try parsing for a new number as the input.
                if (double.TryParse(input,out double parsedInput ))
                {
                    num1 = parsedInput;
                    continue;
                }

                //Switch case for the input(s). First switch case is dedicated to the new operations.
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
                    //An exit would be helpful if the user wanted to end the app.
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
                            //Here is the afformentioned 'x' and 'y' variables.
                            double x = num1;
                            double y = num2;

                            //With result declared we can clean up a little bit and instead string the results below.
                            switch (input)
                            {
                                case "+": result = Add(x, y); break;
                                    
                                case "-": result = Subtract(x, y); break;

                                case "*": result = Multiply(x, y); break;

                                //The usercannot divide by zero- that is a standard mathematical rule.
                                case "/":
                                    //we'll make use of the Divide by Zero Exception Class to instantiate the rule above.
                                    result = (y == 0) ? throw new DivideByZeroException() : Divide(x, y);
                                    break;

                            }

                            //String Result.
                            WriteLine($"Result {result}");
                            num1 = result;
                        }
                        else
                        {
                            WriteLine("Woops! Invlaid Second Number.");
                        }
                        break;
                        
                    //In case input is wrong.
                    default:
                        WriteLine("Hey! Please check your input- it needs to be a number or one of the operators listed!");
                        break;

                }
                
            }

        }
    }
}



