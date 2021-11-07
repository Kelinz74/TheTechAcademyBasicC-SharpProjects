using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the class DoMath
            DoMath domath = new DoMath();

            //a call to the method in class domath with int values being passed as the parameters.
            domath.addition(25, 75);
            Console.ReadLine();
            //a call to the method in class domath with the parameters set by name with thier values.
            domath.addition(num1: 37, num2: 100);
            Console.ReadLine();
        }
    }
}
