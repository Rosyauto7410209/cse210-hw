using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Basics for you","Jimbo", 500);
        video1.AddComment(new Comment("john", "very helpful"));

        Video video2 = new Video("Basics for you","Jimbo", 300);
        video2.AddComment(new Comment("john", "very helpful"));

        Video video3 = new Video("Basics for you","Jimbo", 400);
        video3.AddComment(new Comment("Jane", "very helpful"));

        Video video4 = new Video("Basics for you","Jimbo", 100);
        video4.AddComment(new Comment("Jerry", "very helpful"));                        

    foreach(Video video in videos)
        {
            video.DisplayDetails();
            video.DisplayComments();
            Console.WriteLine(new string('-',40));
        }
    }
}