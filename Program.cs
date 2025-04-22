using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK4_EX2_REDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of the variables
            double num1 = 0; double num2 = 0;

            Console.WriteLine("Enter the first number please: "); // ask user for the input of the first number
            double num = Convert.ToDouble(Console.ReadLine()); //user input of said number
            Console.WriteLine("Enter the second number please: "); // asks users input for the second number
            double num2input = Convert.ToDouble(Console.ReadLine()); //user input of said number

            Console.WriteLine("Select an operation : "); //select the operation choice to the user
            Console.WriteLine("1. Addition"); // addition
            Console.WriteLine("2. Subtraction");    // subtraction
            Console.WriteLine("3. Multiplication"); // multiplication
            Console.WriteLine("4. Division"); // division

            Console.WriteLine("Enter your choice (1-4): "); // ask user for the operation choice

            switch (Console.ReadLine()) // switch statement to check the user input
            {
                case "1":
                    num1 = num + num2input;
                    Console.WriteLine("The result is: " + num1); //prnts out the addition answer
                    break; 
                case "2":
                    num1 = num - num2input;
                    Console.WriteLine("The result is: " + num1); //prnts out the subtraction answer
                    break;
                case "3":
                    num1 = num * num2input;
                    Console.WriteLine("The result is: " + num1);    //prnts out the multiplication answer
                    break;
                case "4":
                    if (num2input != 0) // check if the second number is not zero to avoid division by zero 
                    {
                        num1 = num / num2input;
                        Console.WriteLine("The result is: " + num1); //prnts out the division answer
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed."); // prints out an error message if the second number is zero
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation."); // prints out an error message if the user input is not valid
                    break;
            }
        }
    }
}
