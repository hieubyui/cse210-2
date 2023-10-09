using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
    // Create list of prompts
    List<string> prompts = new List<string>();

    prompts.Add("Did you have any \"I am... therefore:\" statements today? If so, write it down.");    
    prompts.Add("Did you use technology in the first 60 minutes of waking up today? If so, write down how your day went.");    
    prompts.Add("I want to develop a routine of pacing. Did you get up, and walk around the room today?");    
    prompts.Add("In this society, our brains do not have time to decompress anymore. Did you have time to think today? If not, what can you do to find time?");    
    prompts.Add("I want to replace some consumption with production. Did you create something today? If not, what would you like to create at the end of the day? (Ideas; write, blender)");    

    // Randomize a prompt
    Random rnd = new Random();
    int prompt = rnd.Next(prompts.Count);

    Console.WriteLine(prompts[prompt]);

    // 1. Show menu
    // 2. Get menu input from user
    // 3. Decide what to do

    // ...

    // Create a new Entry object
    Entry entry = new Entry();

    entry.EntryDate = DateTime.Today.ToShortDateString();
    entry.Prompt = prompts[prompt];
    Console.WriteLine(entry.Prompt);
    entry.Response = ""; 

    // Create new Journal
    Journal journal1 = new Journal();

    journal1.Name = "";
    journal1.Entries.Add(entry);




    }
}