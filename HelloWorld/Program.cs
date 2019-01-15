using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int winningNum;
            int inputNum;
            string input;

            winningNum = 7;

            Console.WriteLine("Guess the winning number between 1-10:");
            input = Console.ReadLine();

            bool isNumber = int.TryParse(input, out inputNum);

            if (isNumber == false)
            {
                Console.WriteLine("You must enter a number.");
            } else if (inputNum <= 0 || inputNum >= 11)
            {
                Console.WriteLine("You must enter a number between 1 and 10.");
            } else if (inputNum == winningNum)
            {
                Console.WriteLine($"You've won! The winning number is {winningNum}.");
            } else
            {
                Console.WriteLine("Sorry, the winning number was {winningNum}.");
            }

        }
    }
}
