using System;

namespace arraysProgram
{
    class arraysExample
    {
        static void Main(string[] args)
        {
            string[] RECharacters = {"Chris", "Leon", "Jill", "Claire", "Ada", "Barry", "Wesker", "Ethan", "Rebecca"};
            string[] fruitArray = new string[5];

            Console.WriteLine("Here are all the main characters from Resident Evil");
            for(int i = 0; i < RECharacters.Length; i++){
                Console.WriteLine(RECharacters[i]);
            }

            Console.WriteLine("Now, enter in your favorite fruits:");
            for(int i = 0; i < fruitArray.Length; i++){
                fruitArray[i] = Console.ReadLine();
            }

            Array.Sort(fruitArray);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Here are the fruits you entered:");
            for(int i = 0; i < fruitArray.LongLength; i++){
                Console.WriteLine(fruitArray[i]);
            }

            Console.WriteLine("Thanks, press any key to exit.");
            Console.ReadKey();
        }
    }
}
