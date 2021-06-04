using System;
using System.Collections.Generic;

namespace arraysProgram
{
    class arraysExample
    {
        static void Main(string[] args)
        {
            string[] RECharacters = {"Chris", "Leon", "Jill", "Claire", "Ada", "Barry", "Wesker", "Ethan", "Rebecca"};
            string[] fruitArray = new string[5];
            List<string> shoppingList = new List<string>();

            Console.WriteLine("Here are all the main characters from Resident Evil");
            for(int i = 0; i < RECharacters.Length; i++){
                Console.WriteLine(RECharacters[i]);
            }

            Console.WriteLine("Now, enter in your favorite fruits:");
            for(int i = 0; i < fruitArray.Length; i++){
                fruitArray[i] = Console.ReadLine();
            }

            Array.Sort(fruitArray);
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nHere are the fruits you entered sorted alphabetically:");
            for(int i = 0; i < fruitArray.LongLength; i++){
                Console.WriteLine(fruitArray[i]);
            }

            Console.ResetColor();
            Console.WriteLine("\nHere u=is your shopping list sorted alphabetically, press any key to continue:");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            shoppingList.Add("Game");
            shoppingList.Add("Book");
            shoppingList.Add("Rocks");
            shoppingList.Add("Apples");
            shoppingList.Add("Arrows");
            shoppingList.Add("Mead");
            shoppingList.Add("SweetRoll");
            shoppingList.Add("MudCrabs");

            shoppingList.Sort();

            for(int i = 0; i < shoppingList.Count; i++){
                Console.WriteLine(shoppingList[i]);
            }


            Console.ResetColor();
            Console.WriteLine("\nThanks, press any key to exit.");
            Console.ReadKey();
        }
    }
}
