using System;
using System.ComponentModel.Design;
using System.Data;
using System.Linq.Expressions;

namespace Num2
{
    class NextBirthday
    {
        static void Main(string[] args)
        {
            //start:
            do
            {
                try
                {

                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    DateTime currentday = DateTime.Now;

                    DateTime nextBir = new DateTime(currentday.Year, data.Month, data.Day);

                    if (currentday > nextBir)
                    {
                        nextBir = currentday.AddYears(1);
                    }

                    TimeSpan dif = nextBir - currentday;

                    Console.WriteLine($"днів до наступного день народження  :{Math.Round(dif.TotalDays)}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("помилка ");
                    //goto start;
                }
            } while (true);
        }
    }
}