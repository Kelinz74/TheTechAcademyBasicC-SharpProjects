using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{    
    //Public class Employee inheriting from Person class
    public class Employee : Person, IQuittable
    {
        //polymorphed method from IQuittable with parameter from class person quit.
        public void Quit(Person person)
        {
            Console.WriteLine(person.quit);
        }

        //this method overrides the SayName method from Person class
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }        

    }
}
