using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //////////////////Console app part one assignment////////////////////////////
            
            //A one-dimensional array of strings
            string[] stringList = { "You are awesome ", "You are amazing ", "You can do it " };
            
            //A WriteLine methode that prints to the console with a question asking for some input from the user.
            Console.WriteLine("Please write your name.");

            //Variable that saves the input from the console to memory
            string indexString = Console.ReadLine();

            //a for loop by a counter of i as long as i is less then the count of the list.  
            for (int i = 0; i < stringList.Length; i++)
            {
                stringList[i] = "\n" + stringList[i] + indexString + ".";
            }
            //a foreach loop that iterates through the newly saved array values to print out the strings from the array from each index of the array.
            foreach (string all in stringList)
            {
                Console.WriteLine(all);
            }

            //////////////////Console app part two assignment////////////////////////////
            

            //example of an infinite loop(#1. Console app part two assignment)
            //for (int infinite = 0; ; infinite++)
            //{
            //    Console.WriteLine(infinite);
            //}

            //fixed innfinite loop(#3 Fix the infinite loop so that it will execute properly to display the index number of the array (0, 1, 2))
            for (int infinite = 0; infinite < stringList.Length; infinite++) 
            {
                Console.WriteLine("\n" + infinite);            
            }
            

            //////////////////Console app part three assignment////////////////////////////

            //an array of ints
            int[] highScores = { 40, 50, 35, 75, 66, 77 };

            //changes the array to a list
            List<int> Scores = new List<int>(highScores);
            Console.WriteLine("\nScores less then 50.");
            //a for loop iterating through a list of int values from the variable scores, while J is less then the count of indexes in the list (5) 1 will be added to the variable
            //j while iterating through each value.
            for (int j = 0; j < Scores.Count; j++)
            {
                //an if statement looking for any value less than 50 through the iteration of the list.
                if (Scores[j] < 50)
                {                    
                    Console.WriteLine(Scores[j]);
                }
            }

            Console.WriteLine("\nNumber less then or equal to 10.");
            //a for loop by a counter of i as long as num is less then the count of the list.
            for (int num = 0; num <= 10; num++)
            {
                //WriteLine method to print each iteration of num starting with 0.
                Console.WriteLine(num);
            }

            //////////////////Console app part four assignment////////////////////////////

            //a list of string values
            List<string> superHeros = new List<string>
            {
                "doctor strange",
                "batman",
                "captain america",
                "iron man",
                "wolverine"
            };

            //boolean variable for the while loop condition. Starts out as false
            bool foundIt = false;
            //variable to hold the int value of the index for the for loop once a match has been found with the inputed value
            int result = 0;

            //a while loop to keep asking the WriteLine question printed to the consol after the if statement uses the else statement, the found it variable does not turn to true so it will
            //loop again.  If the input maches a value in the list, the while loop variable will turn to true and end.
            while(!foundIt)
            {
                //WriteLine method printing a question to the console asking the user for some input.
                Console.WriteLine("\nSearch a list by the name of your favorite superhero.");

                //string variable to hold the input to memory
                string answerHero = Console.ReadLine().ToLower().Trim();

                //a for loop by a counter of i as long as i is less then the count of the list.
                for (int i = 0; i < superHeros.Count; i++) 
                {
                    //an if statement taking the index of superHeros comparing it to the input from the user.  Once the condition is met, the index is saved to variable result and the variable
                    // foundIt is changed from false to true.
                    if (superHeros[i] == answerHero)
                    {
                        result = i;
                        foundIt = true;
                    }
                
                }
                //an if statement that if the variable foundIt = true the WriteLine method will print to the console with the value from the variable result.
                if (foundIt) 
                { 
                    Console.WriteLine("Your superhero is at index " + result + " of the list."); 
                }
                //if the previous if statement (if (superHeros[i] == answerHero)) condition had not been met through the entire iteration of the list through the for loop,  The else statment
                //would have ran witht eh WriteLine method for not meeting the condition and foundIt would still remain false and a result would not have been saved to the variable result
                //letting the while loop to run to start the process over again.
                else
                {  
                    Console.WriteLine("Your Superhero is not in the list."); 
                }
                result = 0;
            }

            //////////////////Console app part five assignment////////////////////////////

            //a list of string values
            List<string> toys = new List<string>
            {
                "funko pop",
                "gijoe",
                "transformers",
                "thundercats",
                "he-man",
                "transformers",
                "mask"
            };

            //boolean variable for the while loop condition. Starts out as false
            bool gotToys = false;
            //a while loop that will continue to run while gotToys = false
            while (!gotToys)
            {
                //a new list named results
                List<int> results = new List<int>();
                //a WriteLine method printing to the console a question to the user for an input that will be saved to the variable toysHobbie
                Console.WriteLine("\nWhat was your favorite toy from 1980 to present?(If you played with any.)");
                string toysHobbie = Console.ReadLine().ToLower().Trim();

                //a for loop by a counter of i as long as i is less then the count of the list.
                for (int i = 0; i < toys.Count; i++)
                {
                    //an if statement taking the index of toys comparing it to the input from the user.  Once the condition is met, the index is saved to the list results and the variable
                    // gotToys is changed from false to true.
                    if (toys[i] == toysHobbie)
                    {
                        results.Add(i);
                        gotToys = true;
                    }

                }
                //an if statement that if the variable gotToys = true the WriteLine method will print to the console with the value(s) from the variable num.
                if (gotToys)
                {
                    //a foreach loop that iterates through the list results to give the value to num of each index in the list and print the WriteLine method to the console.
                    foreach (int num in results)
                    {
                        Console.WriteLine("Your favorite toy is at index " + num + " of the list.\n");
                    }
                   
                }
                //if the previous if statement containing the variable gotToys condition had not been met through the entire iteration of the list through the for loop,  The else statment
                //would have ran with the WriteLine method for not meeting the condition letting the while loop to run to start the process over again.
                else
                {
                    Console.WriteLine("Your favorite toy is not in the list.\n");
                }
                
            }

            //////////////////Console app part six assignment////////////////////////////

            //a list of string values
            List<string> theBoys = new List<string>
            {
                "Peter",
                "Jeremiah",
                "Fred",
                "Danny",
                "George",
                "Benti",
                "Peter"
            };
            //an empty list named container
            List<string> container = new List<string>();

            //a foreach loop that iterates through the list theBoys to give the value to item of each index in the list.
            foreach (string item in theBoys)
            {
                //if statement iterating through the container list for values that are duplicate.  If there is a duplicate value the WriteLine method will run.
                if (container.Contains(item))
                {
                    Console.WriteLine(item + " is on the list more then once.");
                }
                //if the if statement condition is not met then the else statement will run.  The WriteLine method will take each value from the list and concatinate it to the remaining string.
                else
                {
                    Console.WriteLine(item + " is on the list.");
                }
                //adding each value iterated though the list theBoys to the new list container    
                container.Add(item);
            }                      
            Console.ReadLine();
        }
    }
}
