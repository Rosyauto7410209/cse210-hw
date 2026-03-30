using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("1514 Main st","New York City", "NY", "USA");
        Event lecture = new Lectures("The Aerodynamics of aircraft","Come listen to John talk about airplanes","12/15/2026","1:00 P.M.",lectureAddress,"John Smith",150);

        Address outdoorAddress = new Address("9573 South st","Blacksburg", "VA", "USA");
        Event outdoor = new Outdoor("The Great Outdoors","Come learn about the great outdoors with us","06/12/2026","3:30 P.M.",outdoorAddress,"Slightly Cloudy");

        Address receptionAddress = new Address("3451 Old log Road","Augusta", "ME", "USA");
        Event reception = new Reception("Mr. and Ms. Anderson Wedding Reception","Come celebrate our wedding!","05/05/2026","2:00 P.M.",receptionAddress,"Anderson123@Gmail.com");

        List<Event> events = new List<Event>();
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);

        foreach (Event currentEvent in events)
        {
            Console.WriteLine("Standard Details: ");
            Console.WriteLine(currentEvent.getstandardDetails());
            Console.WriteLine();
            Console.WriteLine("Full Details: ");
            Console.WriteLine(currentEvent.getfullDetails());
            Console.WriteLine();
            Console.WriteLine("Short Details: ");
            Console.WriteLine(currentEvent.getshortDetails());
            Console.WriteLine(new string ('-',40));
        }
    }
}
