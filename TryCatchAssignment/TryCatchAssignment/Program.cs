using System;

namespace TryCatchAssignment
{
    //a class used as an exception
    public class NegativeNumberNotAllowed : Exception
    {
        public NegativeNumberNotAllowed(string message) : base(message)
        {

        }
    }

    public class Test
    {
        //a method for checking if an input number is less then then throw NegativeNumberNotAllowed error
        static void CheckForNegative(int number)
        {
            if (number < 1)
            {
                throw new NegativeNumberNotAllowed("Negative number is not allowed");
            }
        }


        static void Main(string[] args)
        {
            //bool value variable holding a false value for the while loop
            bool trueOrfalse = false;
            //a while loop to continue looping the program until trueorfalse becomes positive
            while (!trueOrfalse)
            {
                //try for a try catch error check.
                try
                {
                    //a writeline method printing to the console a request for user input.
                    Console.WriteLine("Have you had a birthday this year. (True or False)\n");
                    bool birthday = Convert.ToBoolean(Console.ReadLine().ToLower());

                    //a writeline method printing to the console a request for user input.
                    Console.WriteLine("How old are you?\n");
                    int age = Convert.ToInt32(Console.ReadLine());

                    //a call to the method checkfornegative to compare the user input age if it is less then 0.
                    CheckForNegative(age);

                    //if statement for the user input if you have or have not had a birthday this year.
                    if (birthday == true)
                    {
                        //calculation for if you have had a birthday what your birth year was from this year.
                        DateTime today = DateTime.Now;
                        int thisyear = today.Year;

                        int ageOld = thisyear - age;

                        Console.WriteLine("You were born in {0}", ageOld);
                        trueOrfalse = true;

                    }
                    else
                    {
                        //the else to the if, if you have not had a birthday this year what year you were born from the time of your last birthday calculation
                        DateTime today = DateTime.Now;
                        int thisyear = today.Year;

                        int ageOld = thisyear - age - 1;

                        Console.WriteLine("You were born in {0}", ageOld);
                        trueOrfalse = true;
                    }

                }
                //catch for the number < 0 error.  Created from a custom class.
                catch (NegativeNumberNotAllowed)
                {
                    Console.WriteLine("You are not 0 or less, be a positive person and input your age.");
                }
                //a catch if anything other then a number is inputed or if true or false is not the answer to the first question.
                catch (FormatException)
                {
                    Console.WriteLine("Please input what is being asked.  We don't want to know anything else.");
                }
                Console.ReadLine();
            }
        }

    }
}
