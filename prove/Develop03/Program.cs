using System;

class Program
{   
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3,16);
        string text = "Jesus answered and said unto him, Verily, verily, I say unto thee, Except a man be born again, he cannot see the kingdom of God.";
        Scripture scripture = new Scripture(reference, text);
        while (!scripture.isallhidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplaytext());
            Console.WriteLine();
            Console.Write("Press enter to hide words or type quit to end program.");
            string input = Console.ReadLine();
            if(input !=null && input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Program has ended.");
                break;
            }
            scripture.HideRandom(3);
        }
        if (scripture.isallhidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplaytext());
            Console.WriteLine();
            Console.WriteLine("All Words are hidden.");
        }
 
    }
}







