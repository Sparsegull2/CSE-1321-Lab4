/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab4A
*/

using System;

class Lab4A{
    public static void Main(string[] args){
        Console.Write("Enter the score of your exam: ");
        float grade = float.Parse(Console.ReadLine());
        grade = (float)Math.Round(grade);
        string letter ="";
        if (grade <= 100 && grade >= 98)
        {
            letter = "A+";
        }
        else if(grade <=97 && grade >= 95)
        {
            letter = "A";
        }
        else if(grade<=94 && grade >= 92)
        {
            letter = "A-";
        }
        else if (grade <= 91 && grade >= 89)
        {
            letter = "B+";
        }
        else if (grade <= 91 && grade >= 89)
        {
            letter = "B";
        }
        else if (grade <= 88 && grade >= 86)
        {
            letter = "B-";
        }
        else if (grade <= 85 && grade >= 83)
        {
            letter = "C+";
        }
        else if (grade <= 79 && grade >= 77)
        {
            letter = "C";
        }
        else if (grade <= 76 && grade >= 74)
        {
            letter = "C-";
        }
        else if (grade <= 73 && grade >= 71)
        {
            letter = "D+";
        }
        else if (grade <= 70 && grade >= 68)
        {
            letter = "D";
        }
        else if (grade <= 67 && grade >= 65)
        {
            letter = "D-";
        }
        else if (grade <= 64 && grade >= 0)
        {
            letter = "F";
        }
        else {
            letter = "INVALID";
                }
        Console.WriteLine("Letter grade is: "+letter);

    }
}
