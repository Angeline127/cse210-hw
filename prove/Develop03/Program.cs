using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this scripture game.");

        Console.WriteLine();

        Scripture scripture = new Scripture("Alma", 32, 21, 22,
            "And now as I said concerning faith  a faith is not to have a perfect knowledge of things;\n"
            +"therefore if ye have faith ye hope for things which are not seen, which are true.\n"
            +"And now, behold, I say unto you, and I would that ye should remember, that God is merciful unto all who believe on his name;\n"
            +"therefore he desireth, in the first place, that ye should believe, yea, even on his word.");

            

        while (true)
        {
            // Console.Clear();
            Console.WriteLine(scripture.GetHiddenText());
        

            if (scripture.CountHiddenWords() == scripture.GetWordCount() || scripture.GetWordCount() == 0)
            {
                Console.WriteLine();
                Console.WriteLine("All words in the scriptures are hidden. Goodbye. ");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish:");
            string input = Console.ReadLine().Trim().ToLower();

            if(input == "quit")
            {
                int HiddenWordCount = scripture.CountHiddenWords();
                Console.WriteLine($"Dear user, you hid {HiddenWordCount} words before quitting.  ");
                return;
            }

            scripture.HiddenRandomWord(2);
        }

        // In exceeding requirement, 
        // I added when the user type quit, the progrom will count all the words hidden
        // and, when all the words are hidden the program prompt the user 
        // all the words are hidden before it ends. 
    }
}