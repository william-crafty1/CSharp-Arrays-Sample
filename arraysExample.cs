using System;

namespace arraysProgram
{
    class arraysExample
    {
        static void Main(string[] args)
        {
            string[] RECharacters = {"Chris", "Leon", "Jill", "Claire", "Ada", "Barry", "Wesker", "Ethan", "Rebecca"};
            string[] fruitArray = {};

            Console.WriteLine("Here are all the main characters from Resident Evil");
            for(int i = 0; i< RECharacters.Length; i++){
                Console.WriteLine(RECharacters[i]);
            }

            Console.WriteLine("Thanks, press any key to exit.");
            Console.ReadKey();
        }
    }
}
