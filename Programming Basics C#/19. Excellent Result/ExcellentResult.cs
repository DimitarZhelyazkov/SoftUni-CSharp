﻿/*
 ⦁	Oтлична оценка
Първата задача от тази тема е да се напише конзолна програма, която чете оценка (дробно число), 
въведена от потребителя и отпечатва "Excellent!", ако оценката е 5.50 или по-висока.

 */

using System;


namespace _19.Excellent_Result
{
    internal class ExcellentResult
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50 ) { Console.WriteLine("Excellent!"); }
        }
    }
}
