using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Id = 256 };
            Employee employee2 = new Employee() { Id = 652 };
        } 
        

            



            public static Employee operator ==( Employee emp1, Employee emp2)
        {
            if (emp1 != emp2)
            {
                Console.WriteLine("They are the same.");
            }
            else
            {
                Console.WriteLine("They are different.");
            }
        






        }
    }
}
