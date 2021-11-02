using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            //a writeLine method to display a welcome message at the start of the program.
            Console.WriteLine("Welcome to Package Express.  Please folow the instructions below.");
            Console.ReadLine();

            //a writeline method to display a question with the Readling method holding until the input is given, the input is saved to variable weightPackage converted to a int
            //from a string value
            Console.WriteLine("What is the weight of your package?");
            int weightPackage = Convert.ToInt32(Console.ReadLine());

            //if statement asking if the int variable weightPackage is greater than 50. If it is greater than 50 then do what is in the first set of curly brackets, if not then 
            //continue to the else.
            if (weightPackage > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
                Console.ReadLine();
            }
            else
            {
                //if weightPackage is under 50 start with the first Console.WriteLine asking for the next value of Width.  The input will be converted to int from a string value.
                Console.WriteLine("\nWhat is the package width?");
                int wPackage = Convert.ToInt32(Console.ReadLine());

                //asking for the height input to be saved in the variable hPackage converted to an int from a string value.
                Console.WriteLine("\nWhat is the package height?");
                int hPackage = Convert.ToInt32(Console.ReadLine());

                //asking for the length input to be saved in the variable lPackage converted to an int from a string value.
                Console.WriteLine("\nWhat is the package length?");
                int lPackage = Convert.ToInt32(Console.ReadLine());

                //adding the input values saved to wPackage, hPackage and lPackage together in an if statement.  If the total sum of the three values is greater than 50, move to the first
                //Console.WriteLine in the first set of curly brackets below the if statement. If not greater than 50 move to the else statment.
                if (wPackage + hPackage + lPackage > 50)
                {
                    Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                //else statement with a WriteLine method to display a final quote for shipping
                else
                {
                    //with the weight, width, height and lenght falling under the requirements.  The else is then performed with estimating the cost from the dimensions of the 
                    //package.  wPackage * hPackage * lPackage * weightPackage / 100 is done to get the shipping cost for the package.  Utilizing the the global using System.Globalization;
                    //and CultureInfo("en-US") method converted the variable decimal Quote to a string variable us in a US currency format.
                    int totalQuote = wPackage * hPackage * lPackage * weightPackage / 100;
                    decimal Quote = totalQuote;
                    string us = Quote.ToString("C", new CultureInfo("en-US"));

                    //printed information and total cost to the console
                    Console.WriteLine("\nWelcome to Package Express. Please follow the instructions below.\nPlease enter the package " +
                        "weight:\n" + weightPackage + "\n\nPlease enter" + "the package width:\n" + wPackage + "\n\nPlease enter the package " +
                        "height\n" + hPackage + "\n\nPlease enter the package length:\n" + lPackage + "\n\nYour estimated total for " +
                        "shipping this package is: " + us + "\nThank you");
                    Console.ReadLine();
                }
                
            }
        }
    }
}
