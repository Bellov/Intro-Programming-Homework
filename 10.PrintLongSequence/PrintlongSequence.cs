﻿using System;

//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).

class PrintlongSequence
{
    static void Main()
    {
        Console.WriteLine("Long Sequence");
        for (int i = 2; i < 1000; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + ",");
            }

            else
            {
                Console.WriteLine(-i + ",");
            }
        }
    }
}

