//Grading ID: R5560
//Lab 7
//Due Date: April 4th, 2021
//Course Section: CIS 199-01
/*Description: Prompts user to input how many rows and columns of *s there will be(same number) and calls a method
to output a square of *s that size */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class Lab7
{
    static void Main(string[] args)//method that prompts user to input number and calls to the ShowSquaresOfStars method.
    {
        int stars;//number of rows/columns. user input stored here
        bool valid;//boolean value to see if input is valid or not

        Write("How many stars per side do you want << ");//user prompt

        do//do while loop to keep asking the user to input a valid number if they input an invalid number
        {
            if (valid = int.TryParse(ReadLine(), out stars) && stars > 0)//TryParse to make sure input is valid
            {
                ShowSquareOfStars(stars);//calls method with the stars argument
            }
            else//this happens if variable is invalid
            {
                WriteLine("Please input a valid number. Must be greater than 0!");
            }
        }
        while (!valid);//checks to see if valid is true or not. If it is not, the loop is played again

    }

    static void ShowSquareOfStars(int numStars)//methods with int numStars parameter. Is called to output the square of *s.
    {
        //'nested for loops are used to make the square
        for (int x = 1; x <= numStars; x++)//used to determine how many are in each row. Goes until x is > than user input
        {
            for (int y = 1; y <= numStars; y++)//determine how many rows there will be
            {
                Write("*");//outputs *
            }
            WriteLine();//Goes to next line for the loop do its next interation
        }
    }
}

