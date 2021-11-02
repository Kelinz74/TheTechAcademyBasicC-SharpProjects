using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   //using the writeline method the string What is your age is printed to the Console which will then wait for an input using the readline method saving the value
            //as a string to the sAge variable.  The sAge variable is then converted to an int saved to the variable age.
            Console.WriteLine("What is your age");
            string sAge = Console.ReadLine();
            int age = Convert.ToInt32(sAge);

            //using the writeline method the string Have you ever had a DUI is printed to the Console which will then wait for an input using the readline method saving the value
            //as a string to the sDUI variable.  The sDUI variable is then converted to an boolean value saved to the variable DUI.
            Console.WriteLine("\nHave you ever had a DUI? (true or false)");
            string sDUI = Console.ReadLine();
            bool DUI = Convert.ToBoolean(sDUI);

            //using the writeline method the string How many speeding tickets do you have is printed to the Console which will then wait for an input using the readline
            //method saving the value as a string to the sTickets variable.  The sTickets variable is then converted to an boolean value saved to the variable tickets.
            Console.WriteLine("\nHow many speeding tickets do you have?");
            string sTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(sTickets);

            //the age variable is greater than 15 and the DUI equels false and tickets are less than or equal to 3, the variable qualified will equal to true.
            bool qualified = (age > 15 && DUI == false && tickets <= 3);

            //prints true or false from the variable qualified
            Console.WriteLine("\nQualified?\n" + qualified);
            Console.ReadLine();
        }
    }
}
