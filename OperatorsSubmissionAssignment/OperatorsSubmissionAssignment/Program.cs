using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            //instanciating Emplpoyee as employee1 and employee2 passing in two int values for the Id object to compare the Id property
            Employee employee1 = new Employee() { Id = 256 };
            Employee employee2 = new Employee() { Id = 652 };

            //calling the compare of empolyee1 and employee2 in a if statment to display to the console if they are equal or not.
            if (employee1 == employee2)
            {
                Console.WriteLine("The Id's are equal.");
            }
            else
            {
                Console.WriteLine("The Id's are not equal.");
            }
            Console.ReadLine();

        } 


          
    }
}
