using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This is a simple tip calculator- where the user is asked to input their bill, and then they can input what 
   amount that they would like to tip by (examples could be like an input of 10 or 15), the equation
   accounts for converting the percentage into a decimal- but it's a simple formula :D and something 
   fun for this mini tip calculator was the if else to allow the user to reinput without having to close and reopen
   the app. */

namespace Multiple_New_Projects_and_Revamps.New_Projects
{
    internal class SimplyATipCalculator
    {
        static void Main()
        {
            //Welcome Message
            WriteLine("Welcome to the Simple Tip Calculator! :D ");

            //Convert the bill amount and tip percentage to doubles to allow for decimal points.
            WriteLine("What was the total amount for your bill? (Please no $ sign, just a number!)");
            double billAmount = Convert.ToDouble(ReadLine());
            WriteLine("What percentage would you like to tip? (Please a input number, no % sign!)");
            double tipPercentage = Convert.ToDouble(ReadLine());

            //Calculates the tip amount and display it to the user; it is also formatted into two decimal places.
            double tipAmount = billAmount * (tipPercentage / 100);
            WriteLine($"You should leave a tip of about: ${tipAmount:F2}");
            WriteLine("Thank you for using the Simple Tip Calculator! :D");

            //Optional for the user to run the program again or exit.
            WriteLine("Press 'A' for again, and 'E' to exit.");
            string response = ReadLine().ToLower();
            if (response == "a")
            {
                Main();
            }
            else
            {
            //Environement Exit is used to close the program.
                Environment.Exit(0);
            }
        }
    }
}

