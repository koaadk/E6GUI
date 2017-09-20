using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del5
{
    class Program
    {
        static void Main()
        {
            int low = 0;
            int high = 100;
            Random rnd = new Random();
            Console.WriteLine("Enter a number between 1 and 100, for the program to guess");
            String numberToGuessInput = Console.ReadLine();
            int numberToGuess = int.Parse(numberToGuessInput);
            int numberGuessed = rnd.Next(low, high);
            char firstChar = 'a';
            int equal = 0;
            while (equal != 1) {
                Console.WriteLine("I guess " + numberGuessed);


           firstChar = getInput();
            
           switch (firstChar)
            {
                case 'h':
                case 'H':
                    high = numberGuessed;
                    numberGuessed = rnd.Next(low, high);
                    break;
                    case 'l':
                    case 'L':
                        low = numberGuessed;
                        numberGuessed = rnd.Next(low, high);
                        break;
                    case 'e':
                    case 'E':
                        Console.WriteLine("I got it!");
                        equal = 1;
                        break;

                }
            }
        }

        static char getInput(){
            char input ='\0';
            do
            {
                Console.Write("Tell me if I'm (H)igh, (L)ow, or (E)qual?");

                try
                {
                    String inputStr = Console.ReadLine();
                    
                    input = inputStr[0];
                    
                }
                catch
                {
                    Console.WriteLine("Wrong input, try again");
                }
            }
            while (input == '\0');
            return input;
            } 
    }
}
