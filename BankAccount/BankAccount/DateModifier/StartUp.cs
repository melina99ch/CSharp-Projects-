using System;

namespace DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            Console.WriteLine(DateModifier.GetDaysBetweenDates(date1, date2));
        }
    }
}
