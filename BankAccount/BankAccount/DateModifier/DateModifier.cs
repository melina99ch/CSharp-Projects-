using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DateModifier
{
    public static class DateModifier
    {
        public static double GetDaysBetweenDates(string date1, string date2)
        {
            DateTime dateOne = DateTime.ParseExact(date1, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime dateTwo = DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (dateOne > dateTwo)
            {
                return GetDaysBetweenDates(date2, date1);
            }

            return (dateTwo - dateOne).Days;
        }
    }

}
