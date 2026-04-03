using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Los Angeles", "CA", "USA");
        Address address3 = new Address("789 Beach Ave", "Miami", "FL", "USA");

        Lecture lecture = new Lecture(
            "Tech Conference",
            "Learn about the latest in tech.",
            "April 10, 2026",
            "10:00 AM",
            address1,
            "Dr. Brown",
            100
        );

        Reception reception = new Reception(
            "Networking Event",
            "Meet professionals and grow your network.",
            "May 5, 2026",
            "6:00 PM",
            address2,
            "rsvp@events.com"
        );

        OutdoorGathering outdoor = new OutdoorGathering(
            "Beach Party",
            "Enjoy fun activities at the beach.",
            "June 20, 2026",
            "3:00 PM",
            address3,
            "Sunny with light breeze"
        );

        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("----- STANDARD DETAILS -----");
            Console.WriteLine(ev.GetStandardDetails());

            Console.WriteLine("\n----- FULL DETAILS -----");
            Console.WriteLine(ev.GetFullDetails());

            Console.WriteLine("\n----- SHORT DESCRIPTION -----");
            Console.WriteLine(ev.GetShortDescription());

            Console.WriteLine("\n============================\n");
        }
    }
}