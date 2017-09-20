using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNo = rnd.Next(0, 100);
            Console.WriteLine("Guess a number between 0 and 100");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
            while (guess != randomNo)
            {
                if(guess < randomNo)
                {
                    Console.WriteLine("Your number is to low");
                    Console.WriteLine("Guess again");
                    guessInput = Console.ReadLine();
                    guess = int.Parse(guessInput);
                }else if (guess > randomNo)
                {
                    Console.WriteLine("Your number is to high");
                    Console.WriteLine("Guess again");
                    guessInput = Console.ReadLine();
                    guess = int.Parse(guessInput);
                }

            }
            Console.WriteLine("You guesses the right number " + randomNo);
            Console.ReadKey();

        }
    }
}
