/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab4B
*/

using System;

class Lab4B{
    public static void Main(string[] args){
        Console.Write("Enter the day: ");
        string day = Console.ReadLine();
        day = day.ToLower();

        if (day == "monday" || day == "wednesday")
        {
            Console.WriteLine("I have class today!");
        }
        else if (day == "friday")
        {
            Console.WriteLine("It's Friday! Friday! Gotta get down on Friday!");
        }
        else if(day == "tuesday"||day=="thursday"||day=="saturday"||day=="sunday")
        {
            Console.WriteLine("I should use this time to do my homework.");
        }
        else { Console.WriteLine("Not a day of the week.");
        }

    }
}
