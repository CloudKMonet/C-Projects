using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This is a pretty self-explanatory title for the console app. This is in fact an app that acts as a to do list. Users can input their to-do's, and see their to-dos. 
  I assume the user looks at this daily thus the welcome message is "Your daily To-Do List". Fun Features: Multiple methods, data is stored as a string, and is recalled
  during each subsequent usage. I wanted to do this mini console app, before I worked on a bigger web app version of it. */

namespace Multiple_New_Projects_and_Revamps.New_Projects
{
    internal class ToDoListButMyVersion
    {
        //These are acessible to all methods in this program.
        static string filePathing = "todos.txt";
        static List<string> todos = new List<string>();

        static void Main()
        {
            //Load the Daily To-Do List, and while there us one, you can view, add, complete, or delete a To-Do.
            LoadDailyToDos();
            while (true)
            {
                Clear();
                WriteLine("---> Your Daily To Do List <---");
                WriteLine("Please Pick a number from the List:\n 1. View To-Do\n 2. Add To-Do\n 3. Complete To-Do\n 4. Delete To-Do\n 5. Exit");
                string choice = ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewToDo();
                        break;
                        case "2":
                        AddToDo();
                        break;
                        case "3":
                        CompleteToDo();
                        break;
                        case "4":
                        DeleteToDo();
                        break;
                        case "5":
                        SaveToDos();
                        break;
                    default:
                        WriteLine("Please type a number from the listed options.");
                        break;

                }

            }

            //This is the Load-in for the.
            static void LoadDailyToDos()
            {
                if (File.Exists(filePathing)) 
                    //Reviews all the todos fore a new list is loaded.
                    todos = new List<string>(File.ReadAllLines(filePathing)) ;
            }

            //Method Container for Viewing the To-Do List.
            static void ViewToDo()
            {
                Clear();
                WriteLine("---> Your To Do List, But Better <---");
                if (todos.Count == 0) WriteLine("No To Do's for Today!");
                else
                    for (int i = 0;  i < todos.Count; i++) 
                        WriteLine($"{i + 1}. {todos[i]}");
                        WriteLine("\nPress Enter to Return to the List...");
                        ReadLine();
            }

            //Method for Adding in a To-Do Item.
            static void AddToDo()
            {
                WriteLine("Enter your To-Do: ");
                string todo = ReadLine();
                todos.Add(todo);
                SaveToDos();
            }

            //Method for when the To-Do is marked as completed!
            static void CompleteToDo()
            {
                ViewToDo();
                WriteLine("Enter the to-do number to mark it as a completed to-do!");
                if (int.TryParse(ReadLine(), out int num) && num > 0 && num <= todos.Count)
                {
                    todos[num - 1] += " [Done] ";
                    SaveToDos();
                }
            }

            //Method Container for Deleting a To-Do Item.
            static void DeleteToDo()
            {
                ViewToDo();
                WriteLine("Enter to-do number to delete said to-do: ");
                if (int.TryParse(ReadLine(), out int num) && num > 0 && num <= todos.Count)
                {
                    todos.RemoveAt(num - 1);
                    SaveToDos();
                }

            }

            //Method Container for Saving the To-Dos.
            //This will keep the to-do's unless they are deleted!
            static void SaveToDos()
            {
                File.WriteAllLines(filePathing, todos);
            }


        }
    }
}

