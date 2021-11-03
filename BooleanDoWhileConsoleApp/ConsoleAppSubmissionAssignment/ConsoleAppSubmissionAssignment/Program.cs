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
            //a bool variable that starts out with the boolean value false
            bool answer = false;
            //a while statement that as long as answer equals false, the quest from Console.WriteLine("Do you like guessing games? (true or false)"); printing to the console until
            //you type true to change the variable answer to the boolean value of true.
            while (!answer)
            {

                Console.WriteLine("Do you like guessing games? (true or false)");
                bool trueOrfalse = Convert.ToBoolean(Console.ReadLine());
                answer = trueOrfalse;

            }

            //a WriteLine method asking for an input of an int value 1 - 40.  The input will be saved to the variable number converted from a string to an int value.            
            Console.WriteLine("Guess what number I am thinking of between 1 - 40?");
            int number = Convert.ToInt32(Console.ReadLine());
            //a boolean variable witht he bool value false
            bool isGuessed = false;

            //a do while loop.  To do the switch to begin with before continuing onto the while.  If the default is chosen from not choosing 1 - 5 the while loop 
            //will continue.
            do
            {
                //switch statment for the variable number with different cases for the input of 1 - 40 and a default that is the extra option if none of the cases are met.  Only one case will 
                //
                switch (number)
                {
                    case 13:
                        Console.WriteLine("Further");
                        Console.WriteLine("Guess what number I am thinking of between 1 - 40?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 17:
                        Console.WriteLine("Closer");
                        Console.WriteLine("Guess what number I am thinking of between 1 - 40?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("You got it!!!");
                        isGuessed = true;
                        break;
                    case 25:
                        Console.WriteLine("Closer!");
                        Console.WriteLine("Guess what number I am thinking of between 1 - 40?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 37:
                        Console.WriteLine("Further");
                        Console.WriteLine("Guess what number I am thinking of between 1 - 40?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Wrong, try again!");
                        Console.WriteLine("Guess what number I am thinking of between 1 - 40?");
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
