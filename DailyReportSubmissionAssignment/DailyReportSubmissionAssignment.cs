using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Two string variables containting string values.
            string techAcademy = "The Tech Acedemy.";
            string studentDailyReport = "Student Daily Report.";

            //The first Console.Writeline with take the value from the variable techAcademy and print to the console.
            Console.WriteLine(techAcademy);
            Console.ReadLine();

            //This .WriteLine and .ReadLine with print the second variable studentDailyReport to the console.
            Console.WriteLine(studentDailyReport);
            Console.ReadLine();

            //What is your name? will printed to the console and then wait for input by the user answering the question.  The data will be saved as a string value
            //to the variable yourName.
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            //What course are you on? will be printed to the console and then wait for input by the user answering the question.  The inputed data will be saved
            //as a string value to the variable yourCourse.
            Console.WriteLine("\nWhat course are you on?");
            string yourCourse = Console.ReadLine();

            //What page number? will be printed to the console and then wait for input by the user answering the question.  The inputed data will be saved as a string
            //to the variable pageNumber and then converted to an int value with the Convert.ToInt32 method.  The int will be saved to the variable pNumber.
            Console.WriteLine("\nWhat page number?");
            string pageNumber = Console.ReadLine();
            int pNumber = Convert.ToInt32(pageNumber);

            //Do you need Help with anything? will be printed to the console and then wait for input by the user answering the question.  The inputed data will be saved as 
            //a string and saved to the variable yesOrno.  With the Convert.ToBoolean method the value from yesOrno will be converted to a Boolean value and saved to the 
            //variable trueOrfalse
            Console.WriteLine("\nDo you need help with anything? Please answer \"True\" or \"False\".");
            string yesOrno = Console.ReadLine();
            bool trueOrfalse = Convert.ToBoolean(yesOrno);

            //Were there any positive experiences you'd like to share? will be printed to the console and then wait for input by the user answering the question.
            //The inputed data will be saved as a string value to the variable positiveExperiences.
            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            //Is there any other feedback you'd like to provide?? will be printed to the console and then wait for input by the user answering the question.
            //The inputed data will be saved as a string value to the variable otherFeedback.
            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            //How many hours did you study today? will be printed to the console and then wait for input by the user answering the question.  The inputed data will be saved
            //as a string to the variable hoursStudy and then converted to an int value with the Convert.ToInt32 method.  The int will be saved to the variable study.
            Console.WriteLine("\nHow many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            int study = Convert.ToInt32(hoursStudy);

            //This C# instruction will just print the string using the WriteLine and ReadLine methods not saving any data to a variable.
            Console.WriteLine("\nThank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
