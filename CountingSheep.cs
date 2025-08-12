using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This was a really fun mini project- I really wanted to do a "Counting sheep" as an example of how to utilize a loop!
//Aug 11, 2025: New user functionality added: the user cna now pick from three types of sheep to count before they go to sleep.

namespace Multiple_New_Projects_and_Revamps.New_Projects
{
    internal class CountingSheep
    {
        static void Main()
        {
  //Added a Welcome Message.
  WriteLine("Good Evening! This is the Counting Sheep console app, you can choose your sheep to count before you go to sleep! ");
  //These sheep types are all real, and are very cute.
  WriteLine("Choose your sheep to count before you go to sleep:\n 1. Babydoll Southdown\n 2. Valais Blacknose\n 3. Ryeland Sheep");
  string sheep = ReadLine();
  string sheepType;

  //New user functionality: Switch case holds the sheep type to be chosen by the user, and their chosen type of sheep will be counted by the loop statement.
  switch (sheep)
  {
      case "1":
          sheepType = "Babydoll Southdown";
          break;
          case "2":
          sheepType = "Valais Blacknose";
          break;
          case "3":
          sheepType = "Ryeland Sheep";
          break;
  //If the user has no sheep type prefernce or choice is wrong- the default choice is a cloud dream sheep- no they don't exist... unless your sleeping in a dream.
      default:
          sheepType = "Cloud Dream Sheep";
          break;
  }
            
              WriteLine("To quickly double check: you do count sheep before you go to sleep, yes? (Type: yes/no)");
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
                    WriteLine($"{i} {sheepType}...");
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


