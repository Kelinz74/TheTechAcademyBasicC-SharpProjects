using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{

    public class ConstructMe
    {
        //3. Chain two constructors together.//

        //variable string "name" and int "id"
        public string name;
        public int id;
        //constructor chained to another constructor method ConstructMe
        public ConstructMe(string name) : this(name, 46)
        {

        }
        //origin constructor of constructor chain.
        public ConstructMe(string Name, int id)
        {
            this.name = Name;
            this.id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a const variable//

            //consto variable with a value that will never be changed
            const int birthyear = 1974;

            //2. Create a variable using the keyword "var".//

            //a var variable containing a boolean value. var is the multi use tool for variables as it can equal many different data types.
            var number = true;

            //an if statement to show the variable being used
            if (number == true)
            {
                Console.WriteLine("My birthyear is " + birthyear + ".");
            }
            Console.ReadLine();

            //instantiation of ConstructMe with a parameter passing in of string "Peter"
            ConstructMe a = new ConstructMe("Peter");
            //A writeline method printing to the console a statement using the values from the Chained constructors.
            Console.WriteLine($"The instance with name: {nameof(a)}, has property name: {a.name} and id: {a.id}");
            Console.ReadLine();
        }
    }


}
