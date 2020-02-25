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
            const char SEPARATION = '.';
            string dateOfBirthday;
            int counter = 0;
            int day, month, year = 0;

            Console.Write("Дата рождения (dd.mm.yyyy) = ");
            dateOfBirthday = Console.ReadLine();

            day = Int32.Parse(dateOfBirthday[0..2]);
            month = Int32.Parse(dateOfBirthday[3..5]);
            year = Int32.Parse(dateOfBirthday[6..9]);

            //for (int i = 0; i < dateOfBirthday.Length; i++)
            //{
            //    if (dateOfBirthday[i]=='.')
            //    {
            //        counter++;
            //        if (counter == 1)
            //        {
            //            day = Int32.Parse(dateOfBirthday[0..2]);
            //        }

            //        else
            //        {
            //            month = Int32.Parse(dateOfBirthday[3..5]);
            //            year = Int32.Parse(dateOfBirthday[6..9]);
            //            break;
            //        }
            //    }
            //}

            Console.ReadKey();
        }
    }
}
