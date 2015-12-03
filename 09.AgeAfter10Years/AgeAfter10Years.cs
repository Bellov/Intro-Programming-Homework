using System;

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class AgeAfter10Years
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Your birthday is (please follow the format yyyy,mm,dd); ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        int age = today.Year - date.Year;
        if (today < date.AddYears(age)) age--;
        Console.WriteLine("You are now {0} years old.",age);
        Console.WriteLine("In 10 years you will be {0} years old.",age+10);

    }
}

