using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry (Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll () 
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("No entries available.");
        }
        else
        {
            Console.WriteLine("");
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }
    public void SaveToFile (string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // Save each entry in "Date|Prompt|EntryText" format
                outputFile.WriteLine($"{entry._date}|{entry._prompText}|{entry._entryText}");
            }
        }
            
    }
    public void LoadFromFile (string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry newEntry = new Entry();
            
            newEntry._date = parts[0].Trim();
            newEntry._prompText = parts[1].Trim();
            newEntry._entryText = parts[2].Trim();
            _entries.Add(newEntry);
        }
    }
}