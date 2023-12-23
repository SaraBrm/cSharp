using System.Globalization;

namespace ExtensionMethod
{
    public static class Tools
    {
        public static string GetPersianDate(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);

            return $"{year}/{month}/{day}";
        }
    }
}
