using System;

namespace ParsingEnumsSubmissionAssignment
{
    class Program : Days
    {
        static void Main(string[] args)
        {

            //try for a try catch for error catching to print to the console a more user friendly statment.
            try
            {
                //writeline statment printing to the console a request for input from the user
                Console.WriteLine("What day of the week is it today?");
                string dayChoice = Console.ReadLine().ToLower();

                //applying the enum value to a variable
                daysOfTheWeek days1 = daysOfTheWeek.Monday;
                daysOfTheWeek days2 = daysOfTheWeek.Tuesday;
                daysOfTheWeek days3 = daysOfTheWeek.Wednesday;
                daysOfTheWeek days4 = daysOfTheWeek.Thursday;
                daysOfTheWeek days5 = daysOfTheWeek.Friday;
                daysOfTheWeek days6 = daysOfTheWeek.Saturday;
                daysOfTheWeek days7 = daysOfTheWeek.Sunday;

                //comparing the enum value to the input value from the user to print a writeline statement
                if (dayChoice == "monday")
                {
                    Console.WriteLine("\n" + days1 + ", That is today, good guess.");
                }
                else if (dayChoice == "tuesday")
                {
                    Console.WriteLine("\n" + days2 + ", That is today, good guess.");
                }
                else if (dayChoice == "wednesday")
                {
                    Console.WriteLine("\n" + days3 + ", That is today, good guess.");
                }
                else if (dayChoice == "thursday")
                {
                    Console.WriteLine("\n" + days4 + ", That is today, good guess.");
                }
                else if (dayChoice == "friday")
                {
                    Console.WriteLine("\n" + days5 + ", That is today, good guess.");
                }
                else if (dayChoice == "saturday")
                {
                    Console.WriteLine("\n" + days6 + ", That is today, good guess.");
                }
                else if (dayChoice == "sunday")
                {
                    Console.WriteLine("\n" + days7 + ", That is today, good guess.");
                }
                else
                {

                }
                Console.ReadLine();
            }
            //catch for the try catch statement catching FormatExceptions
            catch (FormatException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
                
}







