using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from the user, multiplies the input by 50, then prints the result to the console.  
            //The input will be converted from a string to and int.
            Console.WriteLine("Please pick a number, the number will be multiplied by 50.");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            int timeFifty = number1 * 50;
            Console.WriteLine(number1 + " * 50 = " + timeFifty);
            Console.ReadLine();

            //Takes an input from the user, addes 25 to it, then printes the result to the console.
            //The input will be converted from a string to an int.
            Console.WriteLine("\nPlease pick another number, 25 will be added to the number you pick.");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            int plusTwentyfive = number2 + 25;
            Console.WriteLine(number2 + " + 25 = " + plusTwentyfive);
            Console.ReadLine();

            //Takes an input from the user, divides it by 12.5, then prints the result to the console.
            //The input will be converted from a string to a float.
            Console.WriteLine("\nPlease pick another number, the number you pick will be divided by 12.5.");
            string input3 = Console.ReadLine();
            float number3 = (float)Convert.ToDecimal(input3);
            float divided = number3 / 12.5f;
            Console.WriteLine(number3 + " / 12.5 = " + divided);
            Console.ReadLine();

            //Takes an input from the user, checks if it is greater than 50, the prints the true/false result to the console.
            //The input will be converted to an int, compared to the number 50 with the result if printing to the console a bool value True or False.
            Console.WriteLine("\nPlease pick another number, your number will be compared to 50 whether greater than or less than.");
            string input4 = Console.ReadLine();
            int number4 = Convert.ToInt32(input4);
            bool trueOrfalse = (number4 > 50);
            Console.WriteLine(trueOrfalse);
            Console.ReadLine();

            //Takes an input from the user, divides it by 7, then prints the remainder to the console.
            //The input will be converted from a string to a int then divided using the modulus operator by 7 to print the remainder to the console. 
            Console.WriteLine("\nPlease pick another number, Your number will be divided by 7 and you will recieve the remainder as the answer.");
            string input5 = Console.ReadLine();
            int number5 = Convert.ToInt32(input5);
            int remainder = number5 % 7;
            Console.WriteLine("The remainder is " + remainder);
            Console.ReadLine();
        }
    }
}
