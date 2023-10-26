using System.Formats.Asn1;

public class Journal
{
    public string Name { get; set; }
    
    public List<Entry> Entries { get; set; }


    public Journal()//everytime a Journal object is created, add a new Entry to it
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(string prompts)
    {
        Console.Write(prompts + "");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("MM/dd/yyy");
        Entries.Add(new Entry(prompts, response, date));
    }

    public void Display()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void LoadJournal()
    {
        Console.Write("Enter journal name:");
        string filename = Console.ReadLine();
        Entries.Clear();
        
        using (StreamReader reader = new StreamReader(filename))
        {
            string headerLine = reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string entryLine = reader.ReadLine();
                string[] fields = entryLine.Split(',');

                string EntryDate = fields[0];
                string Prompt = fields[1].Replace(",,",",");
                string Response = fields[2].Replace(",,",",");

                Entries.Add(new Entry(Prompt, Response, EntryDate));
            }   
        
        Console.WriteLine($"Loaded from '{filename}'");

        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter journal name: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date,Prompt,Response");

            foreach (Entry entry in Entries)
            {
                writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt().Replace(",", ",,")},{entry.GetResponse().Replace(",", ",,")}");            }
        }
    }
}