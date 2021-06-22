using System;

namespace Switching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDiscount(DateTime.Now));
            Console.WriteLine(GetDiscount1(DateTime.Now));
            Console.WriteLine(GetDiscount2(DateTime.Now));
            Console.WriteLine(GetDiscount3(DateTime.Now));
        }

        public static decimal GetDiscount(DateTime dateTime)
        {
            if (dateTime.DayOfWeek == DayOfWeek.Monday)
            {
                return 10;
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Tuesday)
            {
                return 20;
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Wednesday)
            {
                return 30;
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Thursday)
            {
                return 40;
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Friday && dateTime.Day == 13)
            {
                return 500;
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Friday)
            {
                return 50;
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                return 60;
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return 70;
            }

            return 0;
        }

        public static decimal GetDiscount1(DateTime dateTime)
        {
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return 10;
                case DayOfWeek.Tuesday:
                    return 20;
                case DayOfWeek.Wednesday:
                    return 30;
                case DayOfWeek.Thursday:
                    return 40;
                case DayOfWeek.Friday when dateTime.Day == 13:
                    return 500;
                case DayOfWeek.Friday:
                    return 50;
                case DayOfWeek.Saturday:
                    return 60;
                case DayOfWeek.Sunday:
                    return 70;
                default:
                    break;
            }

            return 0;
        }

        public static decimal GetDiscount2(DateTime dateTime)
        {
            return dateTime.DayOfWeek switch
            {
                DayOfWeek.Monday => 10,
                DayOfWeek.Tuesday => 20,
                DayOfWeek.Wednesday => 30,
                DayOfWeek.Thursday => 40,
                DayOfWeek.Friday when dateTime.Day is 13 => 500,
                DayOfWeek.Friday => 50,
                DayOfWeek.Saturday => 60,
                DayOfWeek.Sunday => 70,
                _ => 0,
            };
        }

        public static decimal GetDiscount3(DateTime dateTime)
        {
            return dateTime switch
            {
                { DayOfWeek: DayOfWeek.Monday } => 10,
                { DayOfWeek: DayOfWeek.Tuesday } => 20,
                { DayOfWeek: DayOfWeek.Wednesday } => 30,
                { DayOfWeek: DayOfWeek.Thursday } => 40,
                { DayOfWeek: DayOfWeek.Friday, Day: 13 } => 500,
                { DayOfWeek: DayOfWeek.Friday } => 50,
                { DayOfWeek: DayOfWeek.Saturday } => 60,
                { DayOfWeek: DayOfWeek.Sunday } => 70,
                _ => 0,
            };
        }
    }
}
