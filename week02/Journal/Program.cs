using System;
using System.IO;
using System.Text.Json;

class Program
{
    // Exceeds requirements: entries are saved as readable JSON, preserving commas,
    // quotation marks, and other characters. Failed or invalid file loads leave
    // the current journal unchanged and show a helpful message.
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == null || choice == "5")
            {
                Console.WriteLine("Goodbye!");
                return;
            }

            try
            {
                switch (choice)
                {
                    case "1":
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine(prompt);
                        Console.Write("> ");
                        string response = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(response))
                        {
                            Console.WriteLine("The response was empty. No entry was added.");
                            break;
                        }

                        Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
                        journal.AddEntry(entry);
                        Console.WriteLine("Entry added.");
                        break;
                    case "2":
                        journal.DisplayAll();
                        break;
                    case "3":
                        Console.Write("Filename to load (for example, journal.json): ");
                        journal.LoadFromFile(Console.ReadLine());
                        Console.WriteLine("Journal loaded. Current entries have been replaced.");
                        break;
                    case "4":
                        Console.Write("Filename to save (for example, journal.json): ");
                        journal.SaveToFile(Console.ReadLine());
                        Console.WriteLine("Journal saved.");
                        break;
                    default:
                        Console.WriteLine("Please enter a number from 1 to 5.");
                        break;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Unable to access the journal file: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Permission denied: {ex.Message}");
            }
            catch (JsonException)
            {
                Console.WriteLine("The file does not contain a valid JSON journal. Current entries were kept.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid filename: {ex.Message}");
            }
        }
    }
}
