using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This app is about ordering a coffee!... and ya know, sharing what I know about making lists. 
  This app includes, coffee types in an array, a loop, and a menu. :D
  As of 8/05/2025 I added in more functionality in the prices, added a switch for coffee size choice,
  and added a new end statement for the user to see the new Total Price after coffee choice, and coffee size
  choice and then commented out the previous codes.*/

namespace Multiple_New_Projects_and_Revamps.New_Projects
{
    internal class CoffeeOrderApp
    {
        static void Main()
        {
            //the first thing I'll establish is a menu
            //string[] menu = { "Americano", "Flat White", "Latte", "Frappe", "Cappuccino" };
              string[] menu = { "Americano - $2:50", "Flat White - $3.50", "Latte - $5.50", "Frappe - $6.50", "Cappuccino - $4.50" };

            //now let's greet the user, and prompt them to choose a number from the menu
            WriteLine("Hi! Welcome to the Virtual order Coffee Shop!");
            WriteLine("Please choose your drink: ");

            //thus us a loop that goes through the menu once an item is selected from the menu to make sure it was used
            for (int i = 0; i < menu.Length; i++)
            {
                WriteLine($"{i+1}. {menu[i]}");
            }

            //This what the price is without any choices!
            decimal totalPrice = 0.00m;

            /* now the switch case is based on the user choice- so we declare choice as an intent, and list out according
               to the menu items */

            int choice = Convert.ToInt32(ReadLine());

           /* switch (choice)
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
           } */

//depending on the user's choice, this will add the the totalPrice!
switch (choice)
{
    case 1:
        WriteLine("You chose an Americano!");
        totalPrice += 2.50m;
        break;
    case 2:
        WriteLine("You chose a Flat White!");
        totalPrice += 3.50m;
        break;
    case 3:
        WriteLine("You chose a Latte!");
        totalPrice += 5.50m;
        break;
    case 4:
        WriteLine("You chose a Frappe!");
        totalPrice += 6.50m;
       
        break;
    case 5:
        WriteLine("You chose an Cappuccino!");
        totalPrice += 4.50m;
        
        break;
    default:
        WriteLine("Sorry we don't serve that here.");
        break;
}
           //I Have Added Here a section where the user can now also additionally choose a size for their drink- it will change the price a lil bit
 WriteLine("You've made your choice in drink order- this is the size menu for your drink of choice:\n 1.Small - $0.00\n 2.Medium - $0.10\n 3.Large - $0.12\n");
 WriteLine("Please Note: we don't offer x-large do to the dangerously high caffeine... No; we don't except bribes for... The 'forbidden size'...");

 //Here is for the user's chocie in coffee cup size! 
 WriteLine("Now! Please enter your choice (either 1, 2, or 3): ");
 string sizeChoice = ReadLine();

 //again this will add to the total price :D
 switch (sizeChoice)
 {
     case "1":
         WriteLine("You have selected a small- that adds nothing to your order.");
             totalPrice += 0.00m;
         break;
     case "2":
         WriteLine("You have chosen a medium- that adds 0.10 cents to your order.");
         totalPrice += 0.10m;
         break;
     case "3":
         WriteLine("You have chosen a large- that adds 0.12 cents to your order.");
         totalPrice += 0.12m;
         break;
     default:
         WriteLine("By default we assume it's a small- so please make sure you choose either small, medium, or large. ");
             break;
  }

          //New Response total the price and shows the user the final amount due!
            WriteLine($"\nYour Price Total comes out to: ${totalPrice:F2}");

            //Surpise!... I decide to not add another witch case for size differences- we'll do that later but for now?
            //WriteLine("Don't worry- the only size coffee we serve is in a medium.... hope you like coffee!");
        }
    }
}

