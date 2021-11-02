using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //upon starting the program the first thing that will print to the console is "Anonymous Income Comparison Program" from the variable Title with the string value.
            String Title = "Anonymous Income Comparison Program";
            Console.WriteLine(Title);
            Console.ReadLine();

            //WriteLine() method to take inputs for a Person 1 to save the values in the variable hourlyRate1 and hoursWorked1.  Then multiplying them together and then by 52
            //to get the annual annualSalary1. "int annualSalary1 = hourlyPay1 * weekHours1 * 52;"
            Console.WriteLine("\nPerson 1\nWhat is your hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("\nHours worked per week?");
            string hoursWorked1 = Console.ReadLine();
            int hourlyPay1 = Convert.ToInt32(hourlyRate1);
            int weekHours1 = Convert.ToInt32(hoursWorked1);
            int annualSalary1 = hourlyPay1 * weekHours1 * 52;

            //WriteLine() method to take inputs for a Person 2 to save the values in the variable hourlyRate2 and hoursWorked2.  Then multiplying them together and then by 52
            //to get the annual annualSalary2. "int annualSalary2 = hourlyPay2 * weekHours2 * 52;"
            Console.WriteLine("\nPerson 2\nWhat is your hourly rate");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("\nHours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            int hourlyPay2 = Convert.ToInt32(hourlyRate2);
            int weekHours2 = Convert.ToInt32(hoursWorked2);
            int annualSalary2 = hourlyPay2 * weekHours2 * 52;

            //using the writeLine method to print to the console a string starting the Person 1 annual salary.
            Console.WriteLine("\nAnnual salary of Person 1:\n" + annualSalary1);
            Console.ReadLine();

            //using the writeLine method to print to the console a string staiting the Person 2 annual salary.
            Console.WriteLine("Annual salary of Person 2:\n" + annualSalary2);
            Console.ReadLine();

            //utilizing a bool comparison between annualSalary1 and annualSalary2 for see if Person 1 makes more than Person 2.
            bool compareSalary = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + compareSalary);
            Console.ReadLine();


        }
    }
}
