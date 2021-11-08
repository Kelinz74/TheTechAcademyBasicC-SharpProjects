using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    //Public class Employee inheriting from Person class
    public class Employee : Person
    {
        //this method overrides the SayName method from Person class
        public override void SayName()
        {            
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
    