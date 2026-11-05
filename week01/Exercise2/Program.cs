using System;

class Program
{
    static void Main(string[] args)
    {
        /*Grades evaluation exercise*/
        Console.WriteLine("What is your grade percentage?");
        string inputgrade = Console.ReadLine();
        int grade = int.Parse(inputgrade);

        if (grade >= 90)
        {
            Console.WriteLine("You have an A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You have a B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You have a C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You have a D.");
        }
        else
        {
            Console.WriteLine("You have an F.");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }   
    }
}