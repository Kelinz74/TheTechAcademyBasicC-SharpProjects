using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    public class Person
    {
        string FirstName = "Sample";
        string LastName = "Studant";
        
        //Public void method when called will print to the console the WriteLine statment
        public void SayName()
        {
            
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
