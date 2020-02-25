/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество дней до его следующего дня рождения. 
*/
using System;

namespace Addition_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string ddMmMyBirtdhday;
            int day, month;
            DateTime birthdayDateInAGivenYear, now = DateTime.Now;


            Console.Write("Дата рождения (dd.mm) = ");
            ddMmMyBirtdhday = Console.ReadLine();

            day = Int32.Parse(ddMmMyBirtdhday[0..2]);
            month = Int32.Parse(ddMmMyBirtdhday[3..5]);

            birthdayDateInAGivenYear = new DateTime(now.Year, month, day);

            Console.WriteLine($"До дня рождения осталось {(birthdayDateInAGivenYear-DateTime.Now).Days} дней");
            
            Console.ReadKey();
        }
    }
}
