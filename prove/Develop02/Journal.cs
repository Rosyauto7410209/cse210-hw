using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Promptgenerator prompts = new Promptgenerator();


//----------separation bar-------------------
    public void AddNewEntry(Entry entry)
    {
        _entries.Add(entry);      
    }
//----------separation bar-------------------
    public void DisplayEntries()
    {

        foreach (Entry entry in _entries)
        {           
        entry.display();
        Console.WriteLine();            
        }
   

    }

 public void SaveasFile(string filename)
{      
       using (StreamWriter outputfile = new StreamWriter(filename))
    {
        foreach (Entry e in _entries)
        {
            outputfile.WriteLine($"{e._currentTime}-{e.Prompt}-{e.Response}");
        }
     }

}
//----------separation bar-------------------loading file

   public void LoadaFile(string filename)
{
    _entries.Clear();
    string[] lines = File.ReadAllLines(filename);
    foreach (string line in lines)
    {
        string[] parts = line.Split("-");
        if (parts.Length == 3)
        {
        DateTime date = DateTime.Parse(parts[0]);
        string prompt = parts[1];
        string response = parts[2];

        _entries.Add(new Entry (date, prompt, response));
        }

    }
}


}






