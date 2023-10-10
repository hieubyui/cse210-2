using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        
    //create an entry object//
    static void GetEntry()
    {
        Entry entry = new Entry();
        
        // get attributes for Entry object//
        entry.EntryDate = DateTime.Now.ToShortDateString();
        entry.Prompt = ""; // value of prompt displayed to user
        entry.Response=""; // value user entered

        // create a new journal option
        Journal journal = new Journal();
        //journal.Name =""; // user entered name
        journal.Entries.Add(entry);
    }

    // Create list of prompts
    List<string> prompts = new List<string>();

    prompts.Add("Did you have any \"I am... therefore:\" statements today? If so, write it down.");    
    prompts.Add("Did you use technology in the first 60 minutes of waking up today? If so, write down how your day went.");    
    prompts.Add("I want to develop a routine of pacing. Did you get up, and walk around the room today?");    
    prompts.Add("In this society, our brains do not have time to decompress anymore. Did you have time to think today? If not, what can you do to find time?");    
    prompts.Add("I want to replace some consumption with production. Did you create something today? If not, what would you like to create at the end of the day? (Ideas; write, blender)");    

    //Create journal//
    Journal journal = new Journal();

    // 1. Show menu
    while(true)
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    Random random = new Random();
                    int index = random.Next(prompts.Count);
                    ShowRandomPrompt(prompts);
                    GetEntry();
                    break;

                case 2:
                    DisplayJournal(journal);
                    break;

                case 3:
                    LoadJournal(ref journal);
                    break;

                case 4:
                    SaveJournal(journal);
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

//----------------   menu output   -------------------//

    //1. Randomize a prompt then show it. Then, get input from user.
    static void ShowRandomPrompt(List<string> prompts)
    {
        Entry entry = new Entry();
        Random random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
        entry.Response = Console.ReadLine();
    }


    //2. Display all contents of Journal
    static void DisplayJournal(Journal journal) 
    {
        //Console.WriteLine($"Journal for: {journal.Name}");
            foreach (var entry in journal.Entries)
            {
                Console.WriteLine($"Date: {entry.EntryDate}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}\n");
            }
    }
    
    //3. Load Journal from existing file
     static void LoadJournal(ref Journal journal)
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            Console.WriteLine("Journal loaded from " + filename);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    //4. Save journal as .txt file
    static void SaveJournal(Journal journal) 
    {
        Console.Write("Enter a filename: ");
        string filename = Console.ReadLine();
        File.ReadAllLines(filename);

        Console.WriteLine("Journal saved to " + filename);
    }

    }
}