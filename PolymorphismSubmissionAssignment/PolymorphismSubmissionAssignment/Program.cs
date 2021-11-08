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
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student"};
            IQuittable insertnamehere = new Employee();

            //call to the method SayName
            employee.SayName();


            //Call to the method Quit            
            insertnamehere.Quit(employee);
            Console.ReadLine();
        }
        
    }
}
