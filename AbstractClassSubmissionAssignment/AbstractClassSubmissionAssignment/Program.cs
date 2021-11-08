using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate class employee passing in the properties firstName and lastName
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            //call to the method SayName
            employee.SayName();
            Console.ReadLine();

        }
    }
}
