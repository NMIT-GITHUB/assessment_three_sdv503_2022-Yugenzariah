using System;
namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number here: "); //Enter the first number
            double num1 = Convert.ToDouble(Console.ReadLine()); //Converts the number to a double (meaning it accepts decimals)
            Console.WriteLine("Enter another number: "); //Number two entry
            double num2 = Convert.ToDouble(Console.ReadLine()); //Converting number 2 to a double
            Console.WriteLine("Choose an operator from the following list:"); //Choosing an operator
            Console.WriteLine("\ta - Add"); // Putting the input string "a" will add the numbers
            Console.WriteLine("\ts - Subtract"); // Putting the input string "s" will subract the numbers
            Console.WriteLine("\tm - Multiply"); // Putting the input string "m" will multiply the numbers
            Console.WriteLine("\td - Divide"); // Putting the input string "d" will multiply the numbers
            Console.WriteLine("\tp - Power"); // Putting the input string "p" will find you the result of a power of a number
            Console.WriteLine("\tr - Remainder"); // Putting the input string "r" will subtract the whole number then multiply the decimal value
            Console.WriteLine("Enter your operator: "); 
            string op = Console.ReadLine(); //Reads the string entered and saves it as a string 
            double result = 0; //Sets a double of result to 0 to be further modified
            switch (op) //Switch statement for the previously entered string
            {
                case "a":
                    result = num1 + num2;
                    Console.ForegroundColor = ConsoleColor.DarkGray
                    Console.BackgroundColor = ConsoleColor.Cyan
                    Console.Clear(); // When an output is finished it will clear the console and change to a new color
                    break;
                case "s":
                    result = num1 - num2;
                    Console.ForegroundColor = ConsoleColor.Black
                    Console.BackgroundColor = ConsoleColor.Red
                    Console.Clear();
                    break;
                case "m":
                    result = num1 * num2;
                    Console.ForegroundColor = ConsoleColor.DarkBlue
                    Console.BackgroundColor = ConsoleColor.Yellow
                    Console.Clear();
                    break;
                case "d":
                    result = num1 / num2;
                    Console.ForegroundColor = ConsoleColor.DarkCyan
                    Console.BackgroundColor = ConsoleColor.DarkMagenta
                    Console.Clear();
                    break;
                case "p":
                    result = Math.Pow(num1, num2);
                    Console.ForegroundColor = ConsoleColor.White
                    Console.BackgroundColor = ConsoleColor.DarkRed
                    Console.Clear();
                    break;
                case "r":
                    result = num1 % num2;
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.BackgroundColor = ConsoleColor.Gray
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid operator input"); // If the inout is different from the inputs privided it will prompt you an erroroperator input"
                    break;
            }
            Console.WriteLine("Your result is: "); // It now prints the answer and shows the output
            Console.WriteLine(result);
        }
    }
}