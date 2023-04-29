﻿/*
 ⦁	Преместване
На осемнадесетия си рожден ден на Хосе взел решение, че ще се изнесе да живее на квартира.
Опаковал багажа си в кашони и намерил подходяща обява за апартамент под наем.
Той започва да пренася своя багаж на части, защото не може да пренесе целия наведнъж.
Има ограничено свободно пространство в новото си жилище, където може да разположи вещите, така че мястото да бъде подходящо за живеене.
Напишете програма, която изчислява свободния обем от жилището на Хосе, който остава след като пренесе багажа си. 
Бележка: Един кашон е с точни размери:  1m. x 1m. x 1m.
Вход
Потребителят въвежда следните данни на отделни редове:
⦁	Широчина на свободното пространство - цяло число в интервала [1...1000]
⦁	Дължина на свободното пространство - цяло число в интервала [1...1000]
⦁	Височина на свободното пространство - цяло число в интервала [1...1000]
⦁	На следващите редове (до получаване на команда "Done") - брой кашони, които се пренасят в квартирата - цяло число в интервала [1...10000]
Програмата трябва да приключи прочитането на данни при команда "Done" или ако свободното място свърши.
Изход
Да се отпечата на конзолата един от следните редове:
⦁	Ако стигнете до командата "Done" и има още свободно място:
"{брой свободни куб. метри} Cubic meters left."
⦁	Ако свободното място свърши преди да е дошла команда "Done":
"No more free space! You need {брой недостигащи куб. метри} Cubic meters more."

 */


using System;


namespace _87.Moving
{
    internal class Moving
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            bool loop = true;
            int volume = width * height * lenght;
            while (loop)
            {
                string take = Console.ReadLine();
                switch (take)
                {
                    case "Done": loop = false; Console.WriteLine($"{volume} Cubic meters left."); break;
                    default:
                        if (volume - int.Parse(take) > 0) { volume -= int.Parse(take); }
                        else { Console.WriteLine($"No more free space! You need {Math.Abs(volume - int.Parse(take))} Cubic meters more."); loop = false; }
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
