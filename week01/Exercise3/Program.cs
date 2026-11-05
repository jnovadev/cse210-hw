using System;

class Program
{
    static void Main(string[] args)
    {
       /*Random Number Guessing Game*/

       int pcNumber = new Random().Next(1, 100);
       Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");

         int userGuess = 0;
         while (userGuess != pcNumber)
         {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            userGuess = int.Parse(input);

            if (userGuess < pcNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userGuess > pcNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the number {pcNumber} correctly!");
            }
         }
    }
}