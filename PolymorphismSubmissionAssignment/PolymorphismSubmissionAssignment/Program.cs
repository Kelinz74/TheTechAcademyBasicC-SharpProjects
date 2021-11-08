using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    class Program
    {   
        static void Main(string[] args)
        {
            //instantiate class employee passing in the properties firstName and lastName
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student", quit = "I quit" };            

            //call to the method SayName
            employee.SayName();


            //Call to the method Quit
            employee.Quit(employee);
            Console.ReadLine();
        }
        
    }
}
