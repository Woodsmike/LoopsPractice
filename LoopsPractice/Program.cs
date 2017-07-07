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

            /*string storyBeginning = "Once upon a time";
            string[] storyWords = storyBeginning.Split();
            for (int i = storyWords.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(storyWords[i]);
            }*/

            //or
            /*
            string storyBeginning = "Once upon a time";
            string[] storyWords = storyBeginning.Split();
            Array.Reverse(storyWords);

            for(int i = 0; i < storyWords.Length; i++)
            {
                Console.WriteLine(storyWords[i]);
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

            /*string[] groupOfMusicians = { "Adel", "ACDC", "U2", "REM", "21 Pilots", "Bach" };
            foreach (string musicians in groupOfMusicians)
            {
                Console.WriteLine(musicians);
            }*/

            //While loop is run only if a condition is met, while something is true.
            //EX.  while(condition,

            /*Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            while(firstName.ToUpper() == "MIKE")
            {
                Console.WriteLine("Dude, you are amazing.");
                break;
            }*/

            //second 
            /*Console.WriteLine("Do you want to play the game? YES/NO");
            string playAgain = Console.ReadLine().ToUpper();

            while (playAgain == "YES")
            {
                Console.WriteLine("It's a rematch!");
                Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine();
            }*/

            //Do-while loops are similar to while loops, however a do-while loop
            //is used when you want a chunk of code to run at LEAST ONCE, but repeat
            //only if the while condition is met

            //The structure of a do-while loop is:
            //do
            //{
            //  Do something;
            //}
            //while(condition);

            /*string playAgain;
            do
            {
                Console.WriteLine("Welcome to my game? YES/NO");
                //game code here
                Console.WriteLine("Great game!!");
                Console.WriteLine("Do you want to play again? YES/NO");
                playAgain = Console.ReadLine().ToUpper();
            } while (playAgain == "YES");*/

            //Ask the user for the class in school that they would like to add to
            //their GPA calculation.
            //Ask them for the letter grade for the class (no or -)
            //Ask them if they have another class they would like to add 
            //to their GPA calculation.
            //Using a Do-While loop, repeat the code if the user says "YES"
            /*string userAnswer;
            string userClass;
            string userGrade;

            Console.WriteLine("Would you like to add a grade to your GPA calculation?  YES/NO");
            userAnswer = Console.ReadLine().ToUpper();
            if (userAnswer == "YES")
            {
                do
                {
                    Console.WriteLine("What is the name of your class?");
                    userClass = Console.ReadLine().ToUpper();
                    Console.WriteLine("What is your letter grade for the class?  Please do not enter a '+' or '-'.");
                    userGrade = Console.ReadLine().ToUpper();
                    if (userGrade != "A" && userGrade != "B" && userGrade != "C" && userGrade != "D" && userGrade != "F")
                    {

                        Console.WriteLine("Please enter a grade A, B, C, D or F");
                        userGrade = Console.ReadLine().ToUpper();
                  
                    }
                    Console.WriteLine("Would you like to add a grade to your GPA calculation?  YES/NO");
                    userAnswer = Console.ReadLine().ToUpper();
                } while (userAnswer == "YES");
            }*/

            //Nested Loops
            //Create a nested loop structure that prints:
            //1234
            //1234
            //i is rows   and    j is columns

            /*for(int i = 1; i <= 2; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }*/

            //Print a Triangle
            //Outer loop will go line by line
            //Inner loop will go over different elements in the line.
            //Result:
            //1
            //1 2 
            //1 2 3
            //1 2 3 4

            /*int n = int.Parse(Console.ReadLine());
            for (int a = 1; a <= n; a++)
            {
              
                for (int b = 1; b <= a; b++)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }*/

            //practice problem

            //Write an app that prints hello world 10X

            /*for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World.");
            }*/

            //Write an app that prints 1-100

            /*for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }*/

            /*string words = "I love food";
            
            foreach(char word in words)
            {
                Console.WriteLine(word);
                Console.WriteLine();
            }*/
            /*int vowelCount = 0;
            Console.WriteLine("Enter a word or phrase");
            string phrase = Console.ReadLine().ToLower();
            foreach(char letters in phrase)
            { 
                if(letters == 'a' || letters == 'e'|| letters == 'i'|| letters == 'o'|| letters == 'u')
                    vowelCount += 1;
            }
            Console.WriteLine(vowelCount);*/

            /*Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times should it be repeated?");
            int r = int.Parse(Console.ReadLine());

            for(int i = 0; i < r; i ++)
            {
                Console.WriteLine(n);
            }*/
            /*int multiplicationNum = 1;
            for(int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    Console.Write(multiplicationNum * j + " ");
                }
                multiplicationNum += 1;
                Console.WriteLine();
            }*/

            /*string[] moviesList = { "MI3", "Shrek", "Avatar", "King Kong", "ET" , "Star Trek" };
            
            foreach(string movies in moviesList)
            {
                if(movies.StartsWith("A"))
                {
                    continue;
                }
                else if (movies.StartsWith("E"))
                {
                    continue;
                }
                else if (movies.StartsWith("I"))
                {
                    continue;
                }
                else if (movies.StartsWith("O"))
                {
                    continue;
                }
                if (movies.StartsWith("U"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(movies);
                }

            }*/

            /*Console.WriteLine("Please enter a number (whole number).");
            int userNumb = int.Parse(Console.ReadLine());
            while(userNumb % 3 != 0)
            {
                Console.WriteLine("You lost!");
                Console.WriteLine("Please enter another number.");
                userNumb = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You WON!");*/

            //Write a console app that asks the user for a word or phrase.
            //then print the number of each vowel in that word/phrase to the console.
            //Ouput: "Your phrase has ________ A's" etc

            /*Console.WriteLine("Please enter a word or phrase.");
            string phrase = Console.ReadLine().ToLower();
            int letterA = 0;
            int letterE = 0;
            int letterO = 0;
            int letterI = 0;
            int letterU = 0;

            foreach (char letters in phrase)
            {
                if (letters == 'a')
                {
                    letterA += 1;
                }
                if (letters == 'e')
                {
                    letterE += 1;
                }
                if (letters == 'i')
                {
                    letterI += 1;
                }
                if (letters == 'o')
                {
                    letterO += 1;
                }
                if (letters == 'u')
                {
                    letterU += 1;
                }
                Console.WriteLine("Your phrase has " + letterA + "'s");
            }*/

            //Ramdom object
            Random randomNumber = new Random();
            //int randy = randomNumber.Next(0, 9);
            //or
            //Console.WriteLine(randomNumber.Next(0, 12));

            string[] word = { "Rock", "Paper", "Scissors" };
            Console.WriteLine(word[randomNumber.Next(0, 3)]);
            int[] numbers = { 1, 2, 3, 4, 5, 78, 73, 5 };
            Console.WriteLine(numbers[randomNumber.Next(0, 9)]);
        }
    }
}

