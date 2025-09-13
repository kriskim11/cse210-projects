using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    // adds a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    // displays all entries in the journal
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    // saves journal entries to a file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved to {file}.");
    }
    // loads journal entries from a file
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[1], parts[2], parts[0]);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Journal loaded from {file}.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}