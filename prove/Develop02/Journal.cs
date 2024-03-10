using System;

public class Journal
{
    public List<Entry>_entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void SaveToFile(string file)
    {
        string filename = file;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._entryText}|{e._promptText}");
            }
        }
    }

    public void DisplayAll()
    {
    
    foreach (Entry i in _entries)
    {
        Entry thing = new Entry ();

        thing = i;

        thing.Display();
    }

 
        
    }

    public void LoadFromFile(string file)
    {
        string filename = file;

        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._entryText = parts[1];
            newEntry._promptText = parts[2];
            AddEntry(newEntry);
        }
    }

}