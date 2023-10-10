public class Journal
{
    //public string Name { get; set; }
    
    public List<Entry> Entries { get; set; }


    public Journal()//everytime a Journal object is created, add a new Entry to it
    {
        Entries = new List<Entry>();
    }

}