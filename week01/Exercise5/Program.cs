using System;

class Program
{
    static void Main(string[] args)
    {
        /*Function vs Method Exercise*/   
        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, number, squaredNumber);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to my Program");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    } 

    static void DisplayResult(string name, int number, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your favorite number {number} is {squaredNumber}.");
    }  
}