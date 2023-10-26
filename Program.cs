using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth year: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth month (1-12): ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            if (birthMonth < 1 || birthMonth > 12)
            {
                Console.WriteLine("Invalid month entered.");
                return;
            }

            Console.Write("Enter your birth day (1-31): ");
            int birthDay = Convert.ToInt32(Console.ReadLine());

            if (birthDay < 1 || birthDay > 31)
            {
                Console.WriteLine("Invalid day entered.");
                return;
            }

            DateTime birthdate = new DateTime(birthYear, birthMonth, birthDay);
            TimeSpan age = DateTime.Now - birthdate;

            int totalDays = (int)age.TotalDays;
            int totalHours = (int)age.TotalHours;
            int totalMinutes = (int)age.TotalMinutes;
            int totalSeconds = (int)age.TotalSeconds;

            int years = totalDays / 365;
            int months = (totalDays % 365) / 30;
            int days = (totalDays % 365) % 30;
            int hours = (totalHours % 24);
            int minutes = (totalMinutes % 60);
            int seconds = (totalSeconds % 60);

            Console.WriteLine($"You are {years} years, {months} months, and {days} days old.");
            Console.WriteLine($"You are {totalDays} days old.");

            int remainingYears = 2023 - birthYear;
            Console.WriteLine($"You have {remainingYears} years until 2023.");
        }
    }
}; 

//man bu code ni qilishda 80 uzim va qolgan 20% NI youtube va google dan oldim 