using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
       // Create events
        Address address1 = new Address("123 Main St", "Cityville", "Idaho", "12345");
        Event lecture = new Lecture("Lecture Event", "A lecture event description", DateTime.Now, "10:00 AM", address1, "Pearl Mensah", 50);

        Address address2 = new Address("456 Elm St", "Townsville", "New Jersy", "67890");
        Event reception = new Reception("Reception Event", "A reception event description", DateTime.Now, "7:00 PM", address2, "pearl@gmail.com.com");

        Address address3 = new Address("789 Oak St", "Villageland", "South Carolina", "54321");
        Event outdoorGathering = new OutdoorGathering("Outdoor Gathering Event", "An outdoor gathering event description", DateTime.Now, "2:00 PM", address3, "Sunny");

        // Generate marketing messages
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}