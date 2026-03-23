using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Basics for you","Jimbo", 500);
        video1.AddComment(new Comment("john", "very helpful"));

        Video video2 = new Video("best snacks of 2020","slimjim", 300);
        video2.AddComment(new Comment("realman", "I prefer number 3 over 2."));

        Video video3 = new Video("what is the best color?","crayola", 400);
        video3.AddComment(new Comment("Jane", "My son prefers red over green."));

        Video video4 = new Video("how to change your oil","CarMechanics", 100);
        video4.AddComment(new Comment("Jerry", "Thanks for the video!"));                        

    foreach(Video video in videos)
        {
            video.DisplayDetails();
            video.DisplayComments();
            Console.WriteLine(new string('-',40));
        }
    }
}