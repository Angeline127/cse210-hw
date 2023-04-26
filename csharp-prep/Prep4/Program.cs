// using System.Collections.Generic;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep4 World!");
//         Console.WriteLine("Enter a list of numbers, type 0 when finished.");


//         List<int> numbers = new List<int>();
//         List<string> words = new List<string>();

        
//         numbers = [];
//         int num = -1;
//         while (num != 0){
//             Console.WriteLine("Enter a number: ");

//             if (num != 0){
//                 numbers.Append(num);
//             }
//         }


//     }
// }

using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  static void Main(string[] args) {
    List<int> numbers = new List<int>();
    
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");

    while (true) {
      Console.Write("Enter number: ");
      int num = Convert.ToInt32(Console.ReadLine());
      if (num == 0) {
        break;
      }
      numbers.Add(num);
    }

    Console.WriteLine("The sum is: " + numbers.Sum());
    Console.WriteLine("The average is: " + numbers.Average());
    Console.WriteLine("The largest number is: " + numbers.Max());

    // Stretch Challenge: find smallest positive number
    int smallestPositive = numbers.Where(x => x > 0).DefaultIfEmpty(0).Min();
    Console.WriteLine("The smallest positive number is: " + smallestPositive);

    // Stretch Challenge: sort the list
    numbers.Sort();
    Console.WriteLine("The sorted list is:");
    foreach (int num in numbers) {
      Console.WriteLine(num);
    }
  }
}
