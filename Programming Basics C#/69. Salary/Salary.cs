﻿/*
 ⦁	Заплата
Шеф на компания забелязва че все повече служители прекарват  време в сайтове, които ги разсейват.  
За да предотврати това, той въвежда изненадващи проверки на отворените табове на браузъра на служителите си. 
Според отворения сайт в таба се налагат следните глоби:
⦁	"Facebook" -> 150 лв.
⦁	"Instagram" -> 100 лв.
⦁	"Reddit" -> 50 лв.
От конзолата се четат два реда:
⦁	Брой отворени табове в браузъра n - цяло число в интервала [1...10]
⦁	Заплата - число в интервала [500...1500]
След това n – на брой пъти се чете име на уебсайт – текст
Изход
⦁	Ако по време на проверката заплатата стане по-малка или равна на 0 лева, на конзолата се изписва 
"You have lost your salary." и програмата приключва. 
⦁	В противен случай след проверката на конзолата се изписва остатъкът от заплатата (да се изпише като цяло число).

 */

using System;


namespace _69.Salary
{
    internal class Salary
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            for (int i = 0; i < tabs; i++)
            {
                switch (Console.ReadLine())
                {
                    case "Facebook": salary -= 150; break;
                    case "Instagram": salary -= 100; break;
                    case "Reddit": salary -= 50; break;
                    default: break;
                }
                if (salary <= 0) { salary = 0; Console.WriteLine("You have lost your salary."); break; }
            }
            if(salary > 0) { Console.WriteLine($"{salary}"); }
        }
    }
}
