// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep5 World!");
//     }
// }

using System;

class Program {
  static void Main(string[] args) {
    DisplayWelcome();
    string name = PromptUserName();
    int number = PromptUserNumber();
    int squared = SquareNumber(number);
    DisplayResult(name, squared);
  }

  static void DisplayWelcome() {
    Console.WriteLine("Welcome to the Program!");
  }

  static string PromptUserName() {
    Console.Write("What is your name? ");
    return Console.ReadLine();
  }

  static int PromptUserNumber() {
    Console.Write("What is your favorite number? ");
    return Convert.ToInt32(Console.ReadLine());
  }

  static int SquareNumber(int num) {
    return num * num;
  }

  static void DisplayResult(string name, int squared) {
    Console.WriteLine("Hi " + name + ", your favorite number squared is " + squared + ".");
  }
}
