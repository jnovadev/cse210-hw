using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty. Choose Write to add an entry.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(_entries, options);
        File.WriteAllText(filename, json);
    }

    public void LoadFromFile(string filename)
    {
        string json = File.ReadAllText(filename);
        List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(json);

        if (loadedEntries == null)
        {
            throw new JsonException("The journal must be a list of entries.");
        }

        foreach (Entry entry in loadedEntries)
        {
            if (entry == null || string.IsNullOrWhiteSpace(entry.Date)
                || string.IsNullOrWhiteSpace(entry.Prompt) || string.IsNullOrWhiteSpace(entry.Response))
            {
                throw new JsonException("Each entry must contain a date, prompt, and response.");
            }
        }

        _entries = loadedEntries;
    }
}
