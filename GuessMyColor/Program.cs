using System;

namespace GuessMyColor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A computer generates a color (a random number)
             The user tries to guess the color
            */
            Random rnd = new Random();
            int computerNumber = rnd.Next(1, 4);
            bool rightGuess = false;
            /*
             * 1 - red
             * 2 - green
             * 3 - blue
             */

            while(!rightGuess)
            {
                Console.WriteLine("What's my color? ");
                string userInput = Console.ReadLine().ToLower();

                if(computerNumber == 1 && userInput == "red")
                {
                    Console.WriteLine("You won!");
                    rightGuess = true;
                } else if (computerNumber == 2 && userInput == "green")
                {
                    Console.WriteLine("You won!");
                    rightGuess = true;
                } else if (computerNumber == 3 && userInput == "blue")
                {
                    Console.WriteLine("You won!");
                    rightGuess = true;
                } else
                {
                    Console.WriteLine("Try again!");
                }
            }

        }
    }
}
