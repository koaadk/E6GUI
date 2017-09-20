using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            String firstNumberInput, secondNumberInput;
            Console.Write("Enter first number: ");
            //Console.WriteLine("Enter first number: ");
            firstNumberInput = Console.ReadLine();
            firstNumber = int.Parse(firstNumberInput);
            Console.Write("Enter Second number: ");
            secondNumberInput = Console.ReadLine();
            secondNumber = int.Parse(secondNumberInput);
            int result = firstNumber + secondNumber;
            String outputResult = string.Format("The sum of {0} and {1} is {2}", firstNumber, secondNumber, result);
            Console.WriteLine(outputResult);
            Console.ReadKey();
        }
        }
    }
