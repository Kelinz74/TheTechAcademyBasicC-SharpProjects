using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Using string Concatenation adding two sections of string together with the + operator.
                Console.WriteLine("I am concatenating " + "this line.\n");

                //Utilizing the .ToUpper method to change a string value into all capital letters.
                string lowercase = "This sentance went from lower case, to upper case.\n";
                Console.WriteLine(lowercase.ToUpper());

                //using the StringBuilder class from System.Text for a StringBuilder object to maintain a buffer to accommodate expansions to the string without taking up more
                //memory with multiple strings as a string in itself is not mutable( can not be changed once assined to a memory spot, it only appears changed as the new string
                //variable will show the value of the new variable.  Both variable will be taking up memory.)  StringBuilder makes strings mutable(can be edited without taking up
                //more memory)
                StringBuilder sb = new StringBuilder();

                sb.Append("My name is Peter Smith.");
                sb.Append(" I am attending The Tech Academy Online from Washington state.\n");
                sb.Append("My course of study in the Tech Academy is Software Developer.\n");
                sb.Append("My hope is to assist in or think of the next great software that will change the world.\n");
                sb.Append("My motto is \"Dream big, the only limit is your imagination and be the example that others will look up to\".");

                Console.WriteLine(sb);
                Console.ReadLine();
            }
        }
    }
}
