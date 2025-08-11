using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This was a really fun mini project- I really wanted to do a "Counting sheep" as an example of how to utilize a loop!
//Possible Future addition: Would be like a switch case in the beginning that would ask the user- what type of sheep before sleep?

namespace Multiple_New_Projects_and_Revamps.New_Projects
{
    internal class CountingSheep
    {
        static void Main()
        {
            
            WriteLine("Do you count sheep before you go to sleep? (Type: yes/no)");
            /* I'll label this with string response, because with boolean variables, we cannot use ints. So no typying
            yes or no! */
            string response = ReadLine().ToLower();

            //Here is the boolean that the if statement is operating off of.
            if (response == "yes")
            {
                WriteLine("How many sheep do you count? (please input a number)");
                int sheepCount = Convert.ToInt32(Console.ReadLine());

                /*Here is our loop. The i = 1 stands for the input.
                  i <= sheepCount means the numeber is less than or equal to the sheep count.
                  i++ is a nice way to exit the loop after fulfilling the criteria inside. Which is why I used a thread.
                  The thread simulates a person pausing to count "sheep" jumping/ or galloping in and out of view. 
                 */
                for (int i = 1; i <= sheepCount; i++) 
                {
                    WriteLine($"{i} sheep...");
                    //Pause for 0.5 seconds to simulate a person counting sheep.
                    Thread.Sleep(500);
                }

                WriteLine("Zzz... zzz....");
            }
            //If you input a no, the app will just end. 
            else
            {
                WriteLine("Oh! Sorry- this app isn't for you then :(");
            }
            
        }
    }
}

