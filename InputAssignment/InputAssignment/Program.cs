using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //a wtiteline printing the console a question asking for an input.
            Console.WriteLine("Please give a number, any number.");
            string number = Console.ReadLine();
            //a write to file saving the input string from the user.
            File.WriteAllText(@"C:\Users\Kelinz\Desktop\Basic_C#_Programs\IO test\logtest.txt", number);
            //reading a textfile and printing its content to the console with the Console.Writeline method.
            string text = System.IO.File.ReadAllText(@"C:\Users\Kelinz\Desktop\Basic_C#_Programs\IO test\logtest.txt");
            System.Console.WriteLine("Contents of file: {0}", text);

            Console.ReadLine();
        }
    }
}
