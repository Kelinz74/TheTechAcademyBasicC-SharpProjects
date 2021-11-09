using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    public class Employee
    {
        //public variable for the blueprint of the list
        public int _Id;
        public string _firstName;
        public string _lastName;

        //method for taking in values for creating a list returning the values from each paramater passed to the method
        public Employee(int Id, string firstName, string LastName)
        {
            _Id = Id;
            _firstName = firstName;
            _lastName = LastName;
        }




    }
}
