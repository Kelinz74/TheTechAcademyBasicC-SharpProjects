using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        { 
            //Instantiate and initialize the Class Employee
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Studant"};            
            
            //Calling method SayName from employee class which inherites the method from the Person class.            
            employee.SayName();
            Console.ReadLine();
        }
    }
}
