using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables.
            int winningNum;
            int inputNum;
            string input;

            inputNum = 0; //Had to set a value for the inputNum just so that we can run the while loop.
            winningNum = 7;

            while (inputNum != winningNum) //This will continue looping as long as the inputed number is not equal to the winning number, allowing the player to continue guessing until they are correct.
            {
                Console.WriteLine("Guess the winning number between 1-10: ", Environment.NewLine);
                input = Console.ReadLine(); 

                bool isNumber = int.TryParse(input, out inputNum); //Converts the user input into an integer so that we can compare it against the winning number.

                if (isNumber == false) //Checks to see if the user input is an integer.
                {
                    Console.WriteLine("{0}You must enter a number. Try again.", Environment.NewLine);
                }
                else if (inputNum <= 0 || inputNum >= 11) //Checks to see if the user input is a number between 1-10.
                {
                    Console.WriteLine("{0}You must enter a number between 1 and 10. Try again.", Environment.NewLine);
                }
                else if (inputNum == winningNum) //Checks to see if the user input matches the winning number. If so, the player wins!
                {
                    Console.WriteLine("{0}" + $"You've won! The winning number is {winningNum}. Thanks for playing.", Environment.NewLine);
                }
                else //If none of the above checks are true, then the input must have been a number between 1-10 that is NOT the winning number. Prompts the user to try again.
                {
                    Console.WriteLine("{0}" + $"Sorry, the winning number was {winningNum}. Try again.", Environment.NewLine);
                }
            }
        }
    }
}
