using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write(" What is your grade percentage? ");
        string Input = Console.ReadLine();
        int number = int.Parse(Input);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "E";
        }

        Console.WriteLine($"Your grade percentage  {Input}% ");
        Console.WriteLine($"Your grade is: {letter} ");

        if (number >= 70)
        {
            Console.WriteLine("Congratulation! You have passed your exams.. ");
        }
        else
        {
            Console.WriteLine("Better luck next time... ");
        }
        

        //stretch challenge
        string sign;
        int lastDigit = number % 10;
        if (lastDigit >= 7 && letter != "F") {
            sign = "+";
        } else if (lastDigit < 3 && letter != "F") {
            sign = "-";
        } else {
            sign = "";
        }

        if (letter == "A" && number == 100) {
            sign = "+";
        } else if (letter == "F") {
            sign = "";
        }

        Console.WriteLine("Your final grade is: " + letter + sign);

    }
}