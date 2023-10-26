using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Quic;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
    
    //create entry
    // Entry entry = new Entry();

    //create a new journal option
    Journal journal = new Journal();
    //asks for a journal name
    // Console.WriteLine("Enter a journal name:");
    // journal.Name = Console.ReadLine();    
    // Console.WriteLine(journal.Name);



    // Create list of prompts
    List<string> prompts = new List<string>();

    prompts.Add("Did you have any \"I am... therefore:\" statements today? If so, write it down.\n");    
    prompts.Add("Did you use technology in the first 60 minutes of waking up today? If so, write down how your day went.\n");    
    prompts.Add("I want to develop a routine of pacing. Did you get up, and walk around the room today?\n");    
    prompts.Add("In this society, our brains do not have time to decompress anymore. Did you have time to think today? If not, what can you do to find time?\n");    
    prompts.Add("I want to replace some consumption with production. Did you create something today? If not, what would you like to create at the end of the day? (Ideas; write, blender)\n");    

    // randomizes a prompt
    static string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    // 1. Show menu
    bool quit = false;
    while(!quit)
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");

        string menu = Console.ReadLine();
        {
            switch (menu)
            {
                case "1":
                    string prompt = GetRandomPrompt(prompts);
                    journal.AddEntry(prompt);
                    break;

                case "2":
                    journal.Display();
                    //DisplayJournal(journal);
                    break;

                case "3":
                    journal.LoadJournal();
                    break;

                case "4":
                    journal.SaveJournal();
                    Console.WriteLine("Journal Saved.");
                    break;

                case "5":
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Oops! Try again.");
                    break;
            }
        }
    }
    }
}
