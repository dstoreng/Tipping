using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lotto.Model
{
    public static class DateParser
    {
        public static string ConvertDateTimeToDate(string dateTimeString)
        {
            string dateString = SplitDate(dateTimeString);
            CultureInfo culture = System.Threading.Thread.CurrentThread.CurrentCulture;

            DateTime dt = new DateTime();

            /* @return date formatted, ex  Vinnertall Mandag dd/MM */
            try
            {
                string date = DateTime.ParseExact(dateString, "yyyy,MM,dd", culture).ToString("dddd dd/MM");
                return  "Vinnertall " + date.Substring(0, 1).ToUpper(culture) + date.Substring(1);

            }
            catch (Exception e)
            {
                dt = DateTime.MinValue;
            }

            return dt.ToShortDateString();
        }

        /*
         * @return date in "yyyy,MM,dd" format */
        private static string SplitDate(String value)
        {
            int index = value.IndexOf(',',8);
            return value.Substring(0, index);
        }
    }
}
