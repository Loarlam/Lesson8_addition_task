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
            string enterMyBirtdhday;
            int dayOfBirth, monthOfBirth;
            DateTime birthdayDateInAGivenYear, nowDate;

            Console.Write("Дата рождения (dd.mm) = ");
            enterMyBirtdhday = Console.ReadLine();

            dayOfBirth = Int32.Parse(enterMyBirtdhday[0..2]);
            monthOfBirth = Int32.Parse(enterMyBirtdhday[3..5]);

            nowDate = DateTime.Now;

            birthdayDateInAGivenYear = new DateTime(nowDate.Year, monthOfBirth, dayOfBirth);

            Console.WriteLine($"До дня рождения осталось {(birthdayDateInAGivenYear-DateTime.Now).Days} дней");
            
            Console.ReadKey();
        }
    }
}
