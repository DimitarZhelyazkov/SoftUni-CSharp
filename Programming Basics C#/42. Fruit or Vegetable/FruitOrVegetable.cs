﻿/*
 ⦁	Плод или зеленчук
Да се напише програма, която чете име на продукт, въведено от потребителя, и проверява дали е плод или зеленчук.
⦁	Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
⦁	Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot
⦁	Всички останали са "unknown"
Да се изведе "fruit”, "vegetable" или "unknown" според въведения продукт.
 */

using System;


namespace _42.Fruit_or_Vegetable
{
    internal class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            switch (fruit)
            {
                case "banana": Console.WriteLine("fruit"); break;
                case "apple": Console.WriteLine("fruit"); break;
                case "kiwi": Console.WriteLine("fruit"); break;
                case "cherry": Console.WriteLine("fruit"); break;
                case "lemon": Console.WriteLine("fruit"); break;
                case "grapes": Console.WriteLine("fruit"); break;
                case "tomato": Console.WriteLine("vegetable"); break;
                case "cucumber": Console.WriteLine("vegetable"); break;
                case "pepper": Console.WriteLine("vegetable"); break;
                case "carrot": Console.WriteLine("vegetable"); break;
                    default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
