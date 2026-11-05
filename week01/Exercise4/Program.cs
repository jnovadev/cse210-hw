using System;

class Program
{
    static void Main(string[] args)
    {
        /*Process a list of numbers into a list and perform various operations on them*/

        List<int> total_numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 0)
            {
                break;
            }
            else
            {
                total_numbers.Add(number);
            }
        }

        Console.WriteLine($"The sum is: {total_numbers.Sum()}");
        Console.WriteLine($"The average is: {total_numbers.Average()}");
        Console.WriteLine($"The largest number is: {total_numbers.Max()}");
        Console.WriteLine($"The smallest number is: {total_numbers.Min()}");

        total_numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in total_numbers)
        {
            Console.WriteLine(num);
        }
    }
}