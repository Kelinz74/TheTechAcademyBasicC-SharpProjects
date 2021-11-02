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
            String Title = "Anonymous Income Comparison Program";
            Console.WriteLine(Title);
            Console.ReadLine();

            Console.WriteLine("\nPerson 1\nWhat is your hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("\nHours worked per week?");
            string hoursWorked1 = Console.ReadLine();
            int hourlyPay1 = Convert.ToInt32(hourlyRate1);
            int weekHours1 = Convert.ToInt32(hoursWorked1);
            int annualSalary1 = hourlyPay1 * weekHours1 * 52;

            Console.WriteLine("\nPerson 2\nWhat is your hourly rate");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("\nHours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            int hourlyPay2 = Convert.ToInt32(hourlyRate2);
            int weekHours2 = Convert.ToInt32(hoursWorked2);
            int annualSalary2 = hourlyPay2 * weekHours2 * 52;


            Console.WriteLine("\nAnnual salary of Person 1:\n" + annualSalary1);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:\n" + annualSalary2);
            Console.ReadLine();

            bool compareSalary = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + compareSalary);
            Console.ReadLine();


        }
    }
}
