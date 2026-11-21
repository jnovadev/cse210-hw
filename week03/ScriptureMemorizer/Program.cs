using System;
using System.Collections.Generic;

class Program
{
    // Exceeds requirements: randomly chooses a passage from a scripture library,
    // including both single verses and a verse range. Each round hides only words
    // that are still visible, so every Enter press makes progress
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, " +
                "that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me.")
        };

        Scripture scripture = scriptures[Random.Shared.Next(scriptures.Count)];

        while (true)
        {
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Great job practicing!");
                return;
            }

            Console.Write("Press Enter to hide a few words, or type quit to finish: ");
            string input = Console.ReadLine();

            while (input != null && input.Length > 0 &&
                   !input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Please press Enter or type quit: ");
                input = Console.ReadLine();
            }

            if (input == null || input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            scripture.HideRandomWords(3);
        }
    }
}
