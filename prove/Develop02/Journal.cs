public class Journal
{
// public string _filename = "journal.txt";
// I was having trouble getting it to show up in the file that it shares a folder with so this is how AI helped me fix it. 
//An explanation would be awesome.
public string _filename = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName,"journal.txt");

public List<Entry> _entries = new List<Entry>();
public bool running = true;

public void Run()
    {
        while (running)
        {
              
            
            
            PrintMenu();

            Console.Write("\nSelect an option (1-5): ");
            string input = Console.ReadLine();
            
            if (input == "1")
            {
                Entry enter = new Entry();
                enter.Create();
                _entries.Add(enter);
            }
            else if (input == "2")
            {
                foreach ( Entry entry in _entries)
                {
                    Console.WriteLine("####################");
                    Console.WriteLine(entry.FormattedEntry());
                    Console.WriteLine();
                }
            }
            else if (input == "3")
            {
                ReadFile();
            }
            
            else if (input == "4")SaveToFile();
            
        
            else if (input == "5") running = false;

            else Console.WriteLine("You can't do that please :( try again");
            
        }
    }

 static void PrintMenu()
    {
       Console.WriteLine("\nPlease select one of the following choices:"); 
       Console.WriteLine("1. Write Entry");
       Console.WriteLine("2. Display Entries");
       Console.WriteLine("3. Load from file");
       Console.WriteLine("4. Save to file");
       Console.WriteLine("5. Quit"); 
    }
public void SaveToFile()
    {
        Console.WriteLine($"Saved to: {Path.GetFullPath(_filename)}");
        
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
                foreach (Entry entry in _entries)
                {
                outputFile.WriteLine($"{entry.FormattedEntry()},");
                // Console.WriteLine(entry.FormattedEntry());
                }
        }  
    }
public void ReadFile()
   {
        _entries.Clear();
        string[] lines = File.ReadAllLines(_filename);

        for (int i = 0; i < lines.Length; i += 2)
        {
            string header = lines[i];
            string body = lines[i + 1];

            string[] parts = header.Split(" - Prompt: ");

            string date = parts[0].Replace("Date: ", "");
            string prompt = parts[1];

            Entry entry = new Entry();
            entry._date = date;
            entry._prompt = prompt;
            entry._entry = body;

            _entries.Add(entry);
        }
        Console.WriteLine($"Loaded {_entries.Count} entries.");
    }
}

