using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArraySubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)

        {   
            //an single line array of strings
            string[] stringArray = { "You chose index 0", "You chose index 1", "You chose index 2", "You chose index 3", "You chose index 4" };
            //a interger place holder for a while loop condition
            int indexNum = 5;
            // a while loop for the WriteLine method printing to the console a question to choose a number between 0 - 4 representing the index of an array.  If you choose a number
            //greater then the index of the array, the message will display again to please choos a number of the index for the array 0 - 4.  It will loop until the condition is
            //satisfied.
            while (indexNum > 4)
            {   
                //a WriteLine method printing to the console a question for in input of an int value to be saved in the variable indexNum
                Console.WriteLine("Please choose a number that represents an index of an array of strings (0 - 4)");
                indexNum = Convert.ToInt32(Console.ReadLine());
            }
            //a WriteLine method to print to the console the value from the array variable "stringArray" the index from the input variable "indexNum"
            //Example: indexNum = 3, looking to stringArray would print to the console "You Chose index 3".
            Console.WriteLine(stringArray[indexNum]);
            Console.ReadLine();

            //an single line array of ints
            int[] intArray = { 10, 50, 150, 700, 5760 };

            //a interger place holder for a while loop condition
            int indexNum2 = 5;

            // a while loop for the WriteLine method printing to the console a question to choose a number between 0 - 4 representing the index of an array.  If you choose a number
            //greater then the index of the array, the message will display again to please choos a number of the index for the array 0 - 4.  It will loop until the condition is
            //satisfied.
            while (indexNum2 > 4)
            {
                //a WriteLine method printing to the console a question for in input of an int value to be saved in the variable indexNum2
                Console.WriteLine("Please choose a number that represents an index of an array of integers (0 - 4)");
                indexNum2 = Convert.ToInt32(Console.ReadLine());
            }
            //a WriteLine method to print to the console the value from the array variable "intArray" the index from the input variable "indexNum2"
            //Example: indexNum2 = 3, looking to intArray would print to the console "700".
            Console.WriteLine(intArray[indexNum2]);
            Console.ReadLine();

            //a list of strings
            List<string> stringList = new List<string>();
            stringList.Add("Dormammu, I've Come To Bargain.");
            stringList.Add("Forget Everything You Think You Know.");
            stringList.Add("We Don't Get To Choose Our Time.");
            stringList.Add("You're just another tiny, momentary speck within an indifferent universe.");

            //a interger place holder for a while loop condition
            int indexNum3 = 4;

            // a while loop for the WriteLine method printing to the console a question to choose a number between 0 - 3 representing the index of a list.  If you choose a number
            //greater then the index of the array, the message will display again to please choos a number of the index for the list 0 - 3.  It will loop until the condition is
            //satisfied.
            while (indexNum3 > 3)
            {
                //a WriteLine method printing to the console a question for in input of an int value to be saved in the variable indexNum3
                Console.WriteLine("Please choose a number that represents an index of an array of integers (0 - 3) for a Doctor Strange quote");
                indexNum3 = Convert.ToInt32(Console.ReadLine());
            }
            //a WriteLine method to print to the console the value from the list variable "stringList" the index from the input variable "indexNum3"
            //Example: indexNum3 = 1, looking to stringList would print to the console "Dormammu, I've Come To Bargain.".
            Console.WriteLine(stringList[indexNum3]);
            Console.ReadLine();
        }
    }    
}
