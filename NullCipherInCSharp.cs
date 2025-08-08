using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_New_Projects_and_Revamps.New_Projects
{
    //I actually tried to make this in python as well. Better luck in the C# right now, 
    //The Program does encode the message, but decoding needs some fixing.
    internal class NullCipherInCSharp
    {
        static Random random = new Random();
        static void Main()
        {
            //Welcome message into the program.
            WriteLine("Hi! This program is a Null Cipher Encoder/Decoder!");
            //User input for what they would like do: either encode, or decode!
            WriteLine("1. Encode the message.");
            WriteLine("2. Decode the message.");
            string userChoice = ReadLine();

            //If and else statments for the decision tree.
            if (userChoice == "1")
            {
                Encode();
            }
            else if (userChoice == "2")
            {
                Decode();
            }
            else
            {
                WriteLine("Please follow the prompted choice for either choose 1 (for encoding), or 2 (for decodng).");
            }

        }

        //First method will take the user's inputed mesage and encode it with the word bank.
        static void Encode()
        {

            WriteLine("Please enter the message your encoding... secretly of course: ");
            string secretMssg = ReadLine().ToUpper();

            WriteLine("Enter a number (for example, entering the number 4 means every 4th number is part of the secret message): ");
            int numPattern = int.Parse(ReadLine());

            //i made a word bank of fruits and vegetables- so the encoded message can be printed like a grocery list of sorts.
            string[] wordBank = {"apple", "apricot", "avocado" , "banana", "brocoli", "beetroot", "cucumber", "carrot", "cabbage", "cherry",
            "dates", "durian", "elderberry", "eggplant", "fig", "fennel", "ginger", "garlic", "galangal", "gherkins", "habanero", "horseradish",
            "huckleberry", "hazelnut", "iceberg lettuce", "idaho potato", "jackfruit", "jalapeno", "jackfruit", "jujube",
            "kale", "kelp", "kidney beans", "komatsuna", "leeks", "lettuce", "lentils", "Lime", "lemon", "mushroom", "mulberry", "naval orange",
            "napa cabbage", "okra", "olive", "papaya", "passionfruit", "peach", "pear", "parsnips", "peas", "peppers", "quince", "quiona", "raddish",
            "raisins", "rasberries", "raddichio", "radish", "rutabaga", "salmonberry", "seaweed", "shallots", "totmato", "turnip", "tarro", "tangerine",
            "ube", "umbrella squash", "vine spinach", "vidalia onion", "velevet beans", "victoria plum", "vanilla", "wheatgrass", "watermelon", "watercress",
            "winter melon", "wild leak", "ximenia", "xigua", "zuchinni", "zuchetta", "zuni bean", "zucca melon"};

            StringBuilder encodedMssg = new StringBuilder();
            int index = 0;

            //Foreach loop is the best for this as we're going through each list item of the word bank string.
            foreach (char letter in secretMssg)
            {
                //Inserts random words before the secret letter
                for (int i = 0; i < numPattern - 1; i++)
                {
                    encodedMssg.Append(wordBank[random.Next(wordBank.Length)] + " ");
                }
                //Insert words starting with the secret letter.
                encodedMssg.Append(letter + wordBank[random.Next(wordBank.Length)] + " ");
                index++;

            }

            //Output message.
            WriteLine("\nHere is your 'Grocery List' message: ");
            WriteLine(encodedMssg.ToString().Trim());

        }

        //Method Container for 'Decode' (needs some work).
        static void Decode()
        {
            WriteLine("Please paste the 'Grocery List' here for more information:  ");
            string list = ReadLine();

            WriteLine("Similarly, please enter the number pattern you used previously: ");
            int numPattern = int.Parse(ReadLine());

            string[] words = list.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder decodedMssg = new StringBuilder();

            //Grabbing the first letter from every nth word previously.
            for (int i = numPattern - 1; i < words.Length; i += numPattern)
            {
                decodedMssg.Append(words[1][0]);
            }

            //Output message.
            WriteLine("\nDecoded 'Grocery List': ");
            WriteLine(decodedMssg.ToString());

        }


    }
}
