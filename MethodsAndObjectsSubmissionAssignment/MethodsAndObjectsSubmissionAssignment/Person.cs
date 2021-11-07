using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    public class Person
    {
        //two string variable reciving a value(s) from the instantate/initalize on the Main()
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        //Public void method when called will print to the console the WriteLine statment
        public void SayName()
        {            
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
