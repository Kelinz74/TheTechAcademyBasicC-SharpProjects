using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    //Public class Employee inheriting from Public class Person
    public class Employee : Person
    {
        //int variable reciving a value from the instantate/initalize on the Main()
        public int Id { get; set; }

        //a public voide method to display to the console the WriteLine Method .
        public void iDentification()
        {
            Console.WriteLine("Employee ID: " + Id);
        }
    }
}
