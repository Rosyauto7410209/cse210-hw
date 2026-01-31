using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool running = true;
        while (running)
        {
        Console.WriteLine("Your Journal");
        Console.WriteLine("1. Write an Entry");
        Console.WriteLine("2. View Entries");
        Console.WriteLine("3. Save as file");
        Console.WriteLine("4. Upload a file");
        Console.WriteLine("5. Exit Your Journal");
        string choice = Console.ReadLine();

        switch (choice)
        {
        //----------separation bar-------------------
        case "1":
            string prompt = journal.prompts.Randomprompts();
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            Entry e = new Entry(DateTime.Now,prompt,response);
            journal.AddNewEntry(e);
            break;

            //----------separation bar-------------------
        case "2":
            journal.DisplayEntries();
            break;
       case "3":
            Console.Write("Please enter a name: ");
            string filename = Console.ReadLine();
            journal.SaveasFile(filename);
            break;
        case "4":
            Console.Write("Please enter a file name: ");
            string f = Console.ReadLine();
            journal.LoadaFile(f);
            break;
        case "5":
            running = false;
            break;
        }
        }










    }
    

}
