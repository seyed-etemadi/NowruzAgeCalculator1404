using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day, month, year, noroozDay, noroozMonth, noroozYear, ageYears, ageMonths, ageDays;
            
            // دریافت تاریخ تولد از کاربر
            
            Console.WriteLine("Please Enter Your Date Of Birth ");
            Console.WriteLine("Day :");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Month :");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Year :");
            year = int.Parse(Console.ReadLine());

            // تاریخ نوروز 1404
            noroozDay = 1;
            noroozMonth = 1;
            noroozYear = 1404;

            // محاسبه سال‌ها، ماه‌ها و روزها
            ageYears = noroozYear - year;
            ageMonths = noroozMonth - month;
            ageDays = noroozDay - day;

            // اصلاح محاسبات برای حالت‌های منفی
            if (ageMonths < 0)
            {
                ageYears--;
                ageMonths += 12;
            }

            if (ageDays < 0)
            {
                ageMonths--;
                ageDays += 30; // فرض ساده برای 30 روز در ماه
            }

            // نمایش نتیجه
            Console.WriteLine($" Your age in Nowruz 1404 will be : {ageYears} years , {ageMonths}  month and {ageDays} days");
            Console.ReadKey();
        }
    }
}
