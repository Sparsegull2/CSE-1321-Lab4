/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab4C
*/

using System;

class Lab4C{
    public static void Main(string[] args){
        Console.WriteLine("Welcome!");
        Console.Write("Please input a number: ");
        float num= float.Parse(Console.ReadLine());
        Console.WriteLine("\nWhat would you like to do to this number: \n0) Get the additive inverse of the number \n1) Get the reciprocal of the number \n2) Square the number \n3) Cube the number \n4) Exit the program\n");
        int opt = int.Parse(Console.ReadLine());

        switch (opt)
        {
            case 0:
                Console.WriteLine("\nThe additive inverse of "+ num+" is "+(num*(0-1)));
                break;
            case 1:
                Console.WriteLine("\nThe reciprocal of "+num+" is "+1/num);
                break;
            case 2:
                Console.WriteLine("\nThe square of "+num+" is "+num*num);
                break;
            case 3:
                Console.WriteLine("\nThe cube of "+num+" is "+num*num*num);
                break;
            case 4:
                Console.WriteLine("\nThank you, goodbye!");
                break;
            default: Console.WriteLine("\nInvalid input, please try again!");
                break;
        }
    }
}
