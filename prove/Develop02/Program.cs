using System;
using System.Collections.Generic;
using System.IO;



//program class

class Program
{
    //I added a try and catch that tells the user if the file is misssing or if the file is 
    //unable to load
    //i added the user to only choose between option provided if the 
    //user type any number from that which is provided
    //it will prompt them to only select 1 - 5.
    //i also addded if the user wish to quit it should display goodbye
    static void Main(string[] args)
    {
       
      Journal journal = new Journal();

      while (true) {
        Console.WriteLine("Welcome to the Journal Program. Please select one of the follwoing from option 1 to 5");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

        string choice = Console.ReadLine();

        switch (choice) {
            case "1":
                Console.WriteLine(promptGenerator.getAnotherPrompt());
                string entryText = Console.ReadLine();
                journal.writeEntry(entryText);
                break;
            case "2":
                journal.displayEntries();
                break;
            case "3":
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                journal.loadEntries(loadFile);
                break;
            case "4":
               Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                journal.saveEntries(saveFile);
                break; 
            case "5":
                Console.WriteLine("Goodbye");
                break;
            default:
                Console.WriteLine("Invalid choice! Enter option 1-5");
                break;
        }
      }
    }
}