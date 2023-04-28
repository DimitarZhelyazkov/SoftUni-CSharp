﻿/*
 ⦁	Стъпки
Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 стъпки всеки ден.
Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си.
Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път като излиза през деня 
и когато постигне целта си да се изписва "Goal reached! Good job!"  
и колко стъпки повече е извървяла "{разликата между стъпките} steps over the goal!"
Ако иска да се прибере преди това, тя ще въведе командата "Going home" и ще въведе стъпките, които е извървяла докато се прибира.
След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише: "{разликата между стъпките} more steps to reach goal."
 */

using System;


namespace _84.Walking
{
    internal class Walking
    {
        static void Main(string[] args)
        {
            int steps = 0;
            while (steps <= 10000)
            {
                string input = Console.ReadLine();
                if(input == "Going home") { input = Console.ReadLine(); steps += int.Parse(input); break; }
                steps += int.Parse(input);
            }
            if(steps >= 10000) { Console.WriteLine("Goal reached! Good job!"); Console.WriteLine($"{steps-10000} steps over the goal!"); }
            else { Console.WriteLine($"{10000-steps} more steps to reach goal."); }
        }
    }
}
