﻿/*
 ⦁	Train the Trainers
Курсът "Train the trainers" е към края си и финалното оценяване наближава.
Вашата задача е да помогнете на журито което ще оценява презентациите, като напишете програма
в която да изчислява средната оценка от представянето на всяка една презентация от даден студент, а накрая средният успех от всички тях.
От конзолата на първият ред се прочита броят на хората в журито n - цяло число в интервала [1…20]
След това на отделен ред се прочита името на презентацията - текст
За всяка една презентация на нов ред се четат n - на брой оценки - реално число в интервала [2.00…6.00]
След изчисляване на средната оценка за конкретна презентация, на конзолата се печата
 "{името на презентацията} - {средна оценка}."
След получаване на команда "Finish" на конзолата се печата "Student's final assessment is {среден успех от всички презентации}." и програмата приключва.
Всички оценки трябва да бъдат форматирани до втория знак след десетичната запетая.

 */

using System;


namespace _97.Train_the_Trainers
{
    internal class TrainTheTrainers
    {
        static void Main(string[] args)
        {
            int ppl = int.Parse(Console.ReadLine());
            double finalAss = 0;
            int countAss = 0;
            while(true)
            {
                
                string pres = Console.ReadLine();
                if (pres == "Finish") { Console.WriteLine($"Student's final assessment is {finalAss/countAss:f2}."); break; }
                double grade = 0.00;
                countAss++;
                for (int i = 1; i <= ppl; i++) 
                {
                    grade += double.Parse(Console.ReadLine());
                    if (i == ppl) { finalAss += grade / ppl; Console.WriteLine($"{pres} - {grade / ppl:f2}."); break; }
                } 
            }
        }
    }
}
