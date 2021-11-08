using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    public abstract class Person
    {

        //two properties that will get and set the values passed to them for the instantiation of the Employee class from the Main().
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string quit { get; set; }

        //abstract method that is required to be used in another class
        public abstract void SayName();

    }
}