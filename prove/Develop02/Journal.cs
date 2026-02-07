using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.IO;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal run = new Journal();
        run.Run();
        Console.WriteLine("Thank you for writing in your journal");
    }
}
public class Journal
{
// public string _filename = "journal.txt";
// I was having trouble getting it to show up in the file that it shares a folder with so this is how AI helped me fix it. 
//An explanation would be awesome.
public string _filename = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName,"journal.txt");

public List<Entry> entries = new List<Entry>();
public bool running = true;
List <string> journalPrompts = new List<string>
{
     "What was the best part of your day?",
    "What challenged you today?",
    "What are you grateful for?",
    "What did you learn today?",
    "How did you see personal growth today?"
};


public void Run()
    {
        while (running)
        {
              
            Random prom = new Random();
            string prompt = journalPrompts[prom.Next(journalPrompts.Count)];
            
            PrintMenu();

            Console.Write("\nSelect an option (1-5): ");
            string input = Console.ReadLine();
            
            if (input == "1")
            {
                Entry enter = new Entry();
                enter.Create(prompt);
                entries.Add(enter);
            }
            else if (input == "2")
            {
                foreach ( Entry entry in entries)
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
                foreach (Entry entry in entries)
                {
                outputFile.WriteLine($"{entry.FormattedEntry()},");
                // Console.WriteLine(entry.FormattedEntry());
                }
        }  
    }
public void ReadFile()
   {
        entries.Clear();
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

            entries.Add(entry);
        }

        Console.WriteLine($"Loaded {entries.Count} entries.");
    }

}
public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;
    

  public void Create(string prompt)
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        Console.Write("Do you have a prompt you would like to use? (yes / no): ");
        string ans = Console.ReadLine();
        if (ans == "yes")
        {
            Console.Write("Enter Prompt:> ");
            prompt = Console.ReadLine();
            _prompt=prompt;
            Console.WriteLine();
            Console.WriteLine(prompt);
            Console.Write(">");
            _entry = Console.ReadLine();
        }
        else
        {
            Console.WriteLine(prompt);
            Console.Write(">");
            _entry = Console.ReadLine();
            _prompt = prompt;
        }
        
    }
    public string FormattedEntry()
    {
        return ($"Date: {_date} - Prompt: {_prompt} \n>{_entry}");
    }


}
