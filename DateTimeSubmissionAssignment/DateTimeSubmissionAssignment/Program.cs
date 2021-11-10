using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.Writeline method displaying the time right now. utilizing the datetime.now method
            Console.WriteLine(DateTime.Now);

            //Console.Wtiteline printing to the console a request for user input.
            Console.WriteLine("\nPlease provide a number");
            int number = Convert.ToInt32(Console.ReadLine());

            //a variable saving the value of todays date and time from when the program was ran.
            DateTime today = DateTime.Now;

            //a variable saving the date from todays date variable using the .addhours method to figure what time it will be from now to the future using the inputed number from the user
            //as the number of hours from now.
            DateTime answer = today.AddHours(number);

            //a writeline method displaying the number from the user input and the variable answer from the days in the future calculation.
            Console.WriteLine("\n{0} from today: {1}", number, answer);

            Console.ReadLine();
        }
    }
}
