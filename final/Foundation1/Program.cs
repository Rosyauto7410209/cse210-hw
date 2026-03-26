using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Advanced math for you","Jimbo", 500);
        video1.AddComment(new Comment("john", "very helpful"));
        video1.AddComment(new Comment("Beatriz", "I have a few questions about section 3."));
        video1.AddComment(new Comment("Eric", "This video helped me pass a test."));
        videos.Add(video1);


        Video video2 = new Video("best snacks of 2020","slimjim", 300);
        video2.AddComment(new Comment("realman", "I prefer number 3 over 2."));
        video2.AddComment(new Comment("Gabby", "Healthier snacks are better in my opinion."));
        video2.AddComment(new Comment("ali", "I like how this video covered so many new snacks for me to try."));
        videos.Add(video2);

        Video video3 = new Video("what is the best color?","crayola", 400);
        video3.AddComment(new Comment("Jane", "My son prefers red over green."));
        video3.AddComment(new Comment("Dia", "I like purple."));
        video3.AddComment(new Comment("Greenman", "green is better."));
        videos.Add(video3);

        Video video4 = new Video("how to change your oil","CarMechanics", 100);
        video4.AddComment(new Comment("Jerry", "Thanks for the video!"));
        video4.AddComment(new Comment("Hanna", "Is changing the oil different depending on the vehicle?"));   
          video4.AddComment(new Comment("Bernard", "What do I do with the oil afterwards?"));                         
        videos.Add(video4);

    foreach(Video video in videos)
        {
            video.DisplayDetails();
            video.DisplayComments();
            Console.WriteLine(new string('-',40));
        }
    }
}