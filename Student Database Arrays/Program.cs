using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Xml.Linq;


//Task: Write a program that will recognize invalid inputs when the user requests information about students in a class.


//1 Point: Prompt the user to ask about a particular student by number. Convert the input to an integer. Use the integer as the index for the arrays.
//Print the student’s name.
//1 Point: Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
//1 Point: Ask the user if they would like to learn about another student.

//Build Specifications:
//1 Point: Validate user number: Use an if statement to check if the number is out of range,
//i.e. either less than 1 or greater than the length of the arrays. If so, display a friendly message and let the user try again.

//1 Point: Validate category: Ask the user what information category to display: "Hometown" or "Favorite Food".
//Use an if statement to check that they entered either category name correctly. If they entered an incorrect category,
//display a friendly message and re-ask the question. (See hints below!)

//1 Point: Array Length: Use the first array’s Length property in your code instead of hardcoding it.

//Hints:
//Make sure the arrays are the same size.
//Let the user enter a number from 1 up to and including the length of the array. To get the index, subtract 1 from the number they entered.
//For the valid category: You might create a separate program to test out some code that uses a while loop and asks for either “Hometown” or “Favorite Food.” And only finishes the loop if either of these two is entered. Once you have it working, copy the code over to your “real” code.
//Make it easy for the user – tell them what information is available
//Try to use good grammar. Make your messages polite.

//Extra Challenges:
//1 Point: Provide an option where the user can see a list of all students.
//2 Points: Allow the user to search by student name (Good challenge but difficult!)
//1 Point: Category names: Allow uppercase and lowercase; allow portion of word such as "Food" instead of "Favorite Food"

namespace studentDatabase
{
    class program
    {
        static void Main(string[] args)
        {

            string userInput;
            int numEntered = 0;

            for (int i = 1; i < 100; i++)
            {

                string sName1 = "Brandy";
                string sName2 = "Kari";
                string sName3 = "Joan";
                string[] sName = { "Brandy ", "Joan", "Kari" };

                static void StudentPick()
                {

                    Console.WriteLine("Welcome! Which student would you like to learn more about? Enter a number 1-3");

                    Console.WriteLine("\n  (1): Brandy , (2): Kari , (3): Joan ");

                    Console.WriteLine("Enter a number:");

                    Console.ReadKey();
                }
                if (numEntered == 1)
                {
                    Console.WriteLine($"Student Chosen:{1} Brandy");
                    Console.WriteLine(sName1);
                }
                if (numEntered == 2)
                {
                    Console.WriteLine($"Student Chosen:{2} Kari");
                    Console.WriteLine(sName2);
                }
                if (numEntered == 3)
                {
                    Console.WriteLine($"Student Chosen:{3} Joan");
                    Console.WriteLine(sName3);
                }
                if (numEntered != 1 || numEntered != 2 || numEntered != 3)
                {
                    Console.WriteLine("Student does not exist. Please select again.");
                }
                else
                    Console.ReadKey();

                string[] studentinfo = { "hometown", "favorite food" ,"Age"};

                Console.WriteLine(studentinfo[1]);
                Console.WriteLine(studentinfo[2]);
                Console.WriteLine(studentinfo[3]);

                if (numEntered == 1) 
                {

                    string sHomeTown1 = "New Baltimore";
                    string sHomeTown2 = "Sterling Heights";
                    string sHomeTown3 = "Warren";
                    string[] sHomeTown = { "New Baltimore", "Sterling Heights", "Warren" };

                    Console.WriteLine($"{1} picked:");
                    if (numEntered == 1)
                    {
                        Console.WriteLine($" {sName1} Hometown : {sHomeTown1}");
                    }
                    if (numEntered == 2)
                    {
                        Console.WriteLine($" {sName2} Hometown : {sHomeTown2}");
                    }
                    if (numEntered == 3)
                    {
                        Console.WriteLine($" {sName3} Hometown : {sHomeTown3}");
                    }
                    else
                        Console.WriteLine("That category does not exist. Please try again. Enter hometown favorite food:");
                    userInput = Console.ReadLine();

                }
                if(numEntered == 2) 
                {
                    Console.WriteLine($"{2} picked:");

                    string sFavoriteFood1 = "Sushi";
                    string sFavoriteFood2 = "Burgers";
                    string sFavoriteFood3 = "Pizza";
                    string[] sUserFood = { "Sushi", "Burgers", "Pizza" };

                    Console.WriteLine($"{1} picked:");
                    if (numEntered == 1)
                    {
                        Console.WriteLine($" {sName1} Favorite Food : {sFavoriteFood1}");
                    }
                    if (numEntered == 2)
                    {
                        Console.WriteLine($" {sName2} Favorite Food : {sFavoriteFood2}");
                    }
                    if (numEntered == 3)
                    {
                        Console.WriteLine($" {sName3} Favorite Food: {sFavoriteFood3}");
                    }
                    else
                        Console.WriteLine("That category does not exist. Please try again. Enter hometown favorite food:");
                    userInput = Console.ReadLine();
                }
                if (numEntered == 3) 
                {
                    Console.WriteLine($"{2} picked:");

                    string sAge1 = "43";
                    string sAge2 = "42";
                    string sAge3 = "26";
                    string[] SuserAge = { "43", "42", "26" };

                    Console.WriteLine($"{1} picked:");
                    if (numEntered == 1)
                    {
                        Console.WriteLine($" {sName1} Favorite Food : {sAge1}");
                    }
                    if (numEntered == 2)
                    {
                        Console.WriteLine($" {sName2} Favorite Food : {sAge2}");
                    }
                    if (numEntered == 3)
                    {
                        Console.WriteLine($" {sName3} Favorite Food: {sAge3}");
                    }
                    else
                        Console.WriteLine("That category does not exist. Please try again. Enter hometown favorite food:");
                    userInput = Console.ReadLine();

                }
                else
                    Console.WriteLine("Choice does not exist: please choose again: ");
                userInput = Console.ReadLine();




            }

        }
    }
}      
            


           
            
                              
                




           

        
    
    
    






  