using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //When would you use a loop
            //Why would you use a loop
            //nested loops
            //infinite loops
            //keywords, break and continue
            //four types of loops {for loops, for each loops, while loops, do while loops}

            //for loop   - both counting and/or Iterating through an array or other collection
            //type
            //for(initializer; condition, updater)
            //{
            //  do something
            //}

            /*for(int i= 15; i > 0; i--)
            {
                Console.WriteLine(i);
            }*/

            /*for (int i = 50; i <= 100; i++)
            {
                Console.WriteLine(i);
            }*/

            /*string greeting = "My name is little Bill.";
            string[] wordsInGreeting = greeting.Split();
            //for loop to print the words
            for(int i = 0; i < wordsInGreeting.Length; i++)
            {
                Console.WriteLine(wordsInGreeting[i]);
            }*/

            //Create an array called days with the elements Monday, Tuesday, Wednesday.
            //Using a For Loop, print the elements of the days array.
            /*string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday" };
            for(int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine(daysOfWeek[i]);
            }*/

            //Start with the string "Once upon a time" and create an array called
            //storyWords using the Split method. Reverse the order of the elements in
            //the array and using a For Loop, print each word.

            string storyBeginning = "Once upon a time";
            string[] storyWords = storyBeginning.Split();
            /*Array.Reverse(storyWords);

            for(int i = 0; i < storyWords.Length; i++)
            {
                Console.WriteLine(storyWords[i]);
            }
            
            or
            do not
            Array.Reverse(storyWords);*/
            for (int i = storyWords.Length - 1; i <= 0; i--)
            {
                Console.WriteLine(storyBeginning[i]);
            }


            //Add the product of 1 through 10 using a For Loop
            //print the product to the screen.
            /*int product = 1;
            for (int i = 1; i < 11; i++)
            {                
                product = product * i;                
            }
            Console.WriteLine(product);*/

            //Foreach loops are used to iterate over a collection (array, or list)
            //You can think of the structure of a foreach loop as the statement:
            //For each item in the collection, do something

            //EX...    foreach(datatype variable in any collection)
            //          {  do  something  }

            /*  Example     int[] studentGrades = { 4, 4, 3, 4, 3 };
                            foreach(int grade in studentGrades)
                            {
                                Console.WriteLine(grade);
                            }*/

            /*string[] calendar = { "Jan", "Dog" ,"Feb", "Mar", "April", "May", "June" };
            foreach(string month in calendar)
            {
                Console.WriteLine(month);
            
            }*/
            //foreach loops allow the temporary variable to know to assign
            //itself to each element in the collection (like an array), one at a time

            //Foreach loop will always go from beginning to end, no matter what
            //it counts the number of elements in the collection, and runs that many times

            string[] groupOfMusicians = { "Adel", "ACDC", "U2", "REM", "21 Pilots", "Bach" };
            foreach (string musicians in groupOfMusicians)
            {
                Console.WriteLine(musicians);
            }
        }
    }
}

