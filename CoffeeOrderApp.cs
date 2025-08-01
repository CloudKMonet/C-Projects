using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This app is about ordering a coffee!... and ya know, sharing what I know about making lists. 
  This app includes, coffee types in an array, a loop, and a menu. :D */

namespace Multiple_New_Projects_and_Revamps.New_Projects
{
    internal class CoffeeOrderApp
    {
        static void Main()
        {
            //the first thing I'll establish is a menu
            string[] menu = { "Americano", "Flat White", "Latte", "Frappe", "Cappuccino" };

            //now let's greet the user, and prompt them to choose a number from the menu
            WriteLine("Hi! Welcome to the Virtual order Coffee Shop!");
            WriteLine("Please choose your drink: ");

            //thus us a loop that goes through the menu once an item is selected from the menu to make sure it was used
            for (int i = 0; i < menu.Length; i++)
            {
                WriteLine($"{i+1}. {menu[i]}");
            }

            /* now the switch case is based on the user choice- so we declare choice as an intent, and list out according
               to the menu items */

            int choice = Convert.ToInt32(ReadLine());

            switch (choice)
            {
                case 1:
                    WriteLine("You chose an Americano!");
                    WriteLine("That'll be: $2.50!");
                    break;
                case 2:
                    WriteLine("You chose a Flat White!");
                    WriteLine("That'll be: $3.50!");
                    break;
                case 3:
                    WriteLine("You chose a Latte!");
                    WriteLine("That'll be: $5.50!");
                    break;
                case 4:
                    WriteLine("You chose a Frappe!");
                    WriteLine("That'll be: $6.50!");
                    break;
                case 5:
                    WriteLine("You chose an Cappuccino!");
                    WriteLine("That'll be: $4.50!");
                    break;
                default:
                    WriteLine("Sorry we don't serve that here.");
                    break;
            }

            //Surpise!... I decide to not add another witch case for size differences- we'll do that later but for now?
            WriteLine("Don't worry- the only size coffee we serve is in a medium.... hope you like coffee!");
        }
    }
}
