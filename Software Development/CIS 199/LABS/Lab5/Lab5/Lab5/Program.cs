//ID: M2564
//Lab: 5
//Class: CIS 199
//Course Section: 1
//Due Date: 03-03-19
//This program checks how many times a temperature is entered valid and gives you the mean of the temperature inputed. The program loop ends when the sentinel value is inputed. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //So we don't have to keep typing console. The system is using the console.

namespace Lab5
{
    class Program
    {
        //The main event for the console
        static void Main(string[] args)
        {
           const int highTemp = 130; //the highest temperature that can be inputed
           const int lowTemp = -20; // the lowest temperature that can be inputed
           double mean; // variable that will be used to display the mean calculation
           int tempInput; //the user input is stored in the tempInput variable for validation of the requirements. 
           int valid = 0; //the number of how much the temperature is valid then its stored in here.
           int temp = 0; //Add all the temp inputed to this variable.
           int sentinel = 999; //This string has the sentinel value that ends the loop and displays the output.
            bool validInt; //Checks if the input is numbers only (true or false).

            WriteLine($"Enter temperatures from {lowTemp} to {highTemp} (999 to stop)"); //displays the requirements 
            Write("Enter temperature: "); //The write command lets them enter the value in the same line.

            validInt = int.TryParse(ReadLine(), out tempInput); //Checks if the input is number only

            while (tempInput != sentinel) //checks if the value enter is not 999 which is to quite the program.
            {
                while ((!validInt) || (tempInput < -20 || tempInput > 130) && (tempInput != sentinel)) //this is used to check when the input is invalid or not true and not enter the sentinel.
                {
                    WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature."); //displays the reason why they inputed the wrong value.
                    Write("Enter temperature: ");
                    validInt = int.TryParse(ReadLine(), out tempInput);//value variable is reassign the input that the user gives to be checked.
                }

                while (validInt && (tempInput >= -20 && tempInput <= 130) && (tempInput != sentinel)) //Make sure all the value are within range and is valid data.
                {
                    valid++; //add 1 to valid
                    temp += tempInput; //add the user input to the temp variable everytime the input is within the range
                    Write("Enter temperature: ");
                    validInt = int.TryParse(ReadLine(), out tempInput); //value variable is reassign the input that the user gives to be checked.
                }
            }
            
                mean = (double)temp / valid; //mean calculation that divided by all the temp intered and divided by how many valid. Also casting the temp variable so it can be converted to double for calculation. 
                WriteLine(""); //Just an empty space to make it look better.
                WriteLine($"You enterend {valid} valid temperatures."); //output how many valid input.
                WriteLine($"The mean temperatures is {mean:F1} degrees."); //output the mean when the program is closed.

        }
    }
}
