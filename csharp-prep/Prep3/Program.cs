// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep3 World!");
//         Console.Write("What is the magic number? ");
//         int magicNo = int.Parse(Console.ReadLine());

//         Random randomGenerator = new Random();
//         int magic = randomGenerator.Next(1, 11);

//         int guess = -1;

//         while (guess != magicNo) {
//             Console.Write("What is your guess? ");
//             guess = int.Parse(Console.ReadLine());
//         }
//         if(magicNo > guess){
//             Console.WriteLine("Higer");
//         }
//         else if(magicNo < guess){
//             Console.WriteLine("Lower");
//         }
//         else{
//             Console.WriteLine("You guessed right!");
//         }


//         //stretch
        
//         bool continuePlaying = true;

//         while (continuePlaying) {
//         guess++;
//         // code to play the game goes here
//         Console.WriteLine("You have played " + guess + " times.");
//         Console.Write("Do you want to play again? (y/n) ");
//         string response = Console.ReadLine();
//         continuePlaying = (response == "y");
//         }

//         Console.WriteLine("Thanks for playing " + guess + " times!");

//     }
// }


using System;

class Program {
    static void Main(string[] args) {
        bool playAgain = true;

        while (playAgain) {
            Random rand = new Random();
            int magicNumber = rand.Next(1, 101);

            int guessCount = 0;
            int guess = 0;

            Console.WriteLine("Guess the magic number between 1 and 100!");

            while (guess != magicNumber) {
                Console.Write("Guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber) {
                    Console.WriteLine("Too low, guess higher.");
                } else if (guess > magicNumber) {
                    Console.WriteLine("Too high, guess lower.");
                } else {
                    Console.WriteLine("Congratulations, you guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses to find the magic number.");

            Console.Write("Play again? (yes/no): ");
            string playAgainInput = Console.ReadLine();

            if (playAgainInput.ToLower() != "yes") {
                playAgain = false;
            }
        }
    }
}
