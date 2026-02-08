using System;

public class Reference
{
    static void Main(string[] args)
    {
        Console.WriteLine("2 nephi 3:4-5");

        Console.WriteLine


    }
}







{
    List<string> prompts = new List<string>
{
"Nephi 12:12",
"Alma 5:12",
"Quote",
"Quot 2",
"number",
};

public string Randomprompts()
    {
        Random rand = new Random();
        {
        int randomindex = rand.Next(0,prompts.Count() - 1);

        return prompts[randomindex];
        }


    }

}
