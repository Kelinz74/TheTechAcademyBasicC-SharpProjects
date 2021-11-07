using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Instantiate and initialize the Class Employee
            Employee employee = new Employee();
            
            //Calling two methods from employee and from the inherited class Persons through employee.
            employee.iDentification();
            employee.SayName();
            Console.ReadLine();
        }
    }
}
