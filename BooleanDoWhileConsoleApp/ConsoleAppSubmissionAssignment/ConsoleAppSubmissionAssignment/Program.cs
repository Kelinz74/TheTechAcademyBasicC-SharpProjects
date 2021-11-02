using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //a WriteLine method asking for an input of an int value 1 - 5.  The input will be saved to the variable number converted from a string to an int value.            
            Console.WriteLine("What is your favorite number from 1 - 5?");
            int number = Convert.ToInt32(Console.ReadLine());
            //a boolean variable witht he bool value false
            bool isGuessed = false;

            //a do while loop.  To do the switch to begin with before continuing onto the while.  If the default is chosen from not choosing 1 - 5 the while loop 
            //will continue.
            do
            {
                //switch statment for the variable number with different cases for the input of 1 - 5 and a final default which will not change the while loop requirment to true
                //therefore looping back through the switch option until an input of 1 - 5 is chosen.  for each of the 1 -5 options a Writeline will display to the console and 
                //then change the isGuessed to true.  The key word break will then stop the switch from proceeding through further cases of the switch statement.
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Ya, thats not bad");
                        isGuessed = true;
                        break;
                    case 2:
                        Console.WriteLine("Well thats not to bad but you didn't choose 1");
                        isGuessed = true;
                        break;
                    case 3:
                        Console.WriteLine("Always in the middle!!");
                        isGuessed = true;
                        break;
                    case 4:
                        Console.WriteLine("Over achiever obvoiusly!");
                        isGuessed = true;
                        break;
                    case 5:
                        Console.WriteLine("5!!!!  Jinx, you owe me a coke!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You really should have chose a number 1 - 5.");
                        Console.WriteLine("\nWhat is your favorite number from 1 - 5?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            //a while loop to itterate through the switch until the bool value is changed to True !isGuessed = false.  the ! represents Not True.  The loop will continue until
            //true
            while (!isGuessed);
            {


            }
            //pauses the program from closing so the output can be read.  To close the program, press the enter key one more time.
            Console.ReadLine();
        }
    }
}
