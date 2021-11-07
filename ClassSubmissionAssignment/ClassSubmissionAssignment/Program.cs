using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiation of the class DoMath
            DoMath doMath = new DoMath();

            //Two variable holding an int value and a string value
            int number;
            string superHero;
            
            //A writeline method to print to the console a request for a number greater then 2 converting the input string to an int saved in the variable mathDone
            Console.WriteLine("Please pick a number greater then 2.");
            int mathDone = Convert.ToInt32(Console.ReadLine());

            //a call to the class DoMath for the method division passing in the value from the variable mathDone
            doMath.division(mathDone);

            //a call to the class DoMath for the method moreMath with an out parameter to bring the value saved in the method variable number saving to the local variable number.
            doMath.moreMath(out number);
            //a WriteLine method displaying the saved value from the variable number to the console.
            Console.WriteLine(number);

            //a call to the class DoMath for the method division as an overload with a sting parameter passing in the value "hard"
            doMath.division("hard");

            //a WriteLine method displaying to the console a request from the user an input.
            Console.WriteLine("\nWho is your favorite super hero.");
            //a variable saving the input string value from the user input
            superHero = Console.ReadLine();

            //a WriteLine method displaying to the console a concatinated line including the result returned from the static class StaticClass method favoriteSuperhero
            //with the input from the user being passed in as the parameter.
            Console.WriteLine("\nYour super hero is " + StaticClass.favoriteSuperhero(superHero) + ". Good guess.");

            Console.ReadLine();            
        }
    }
}
