using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class DuLieu
    {
        public static string DayOfWeek(DateTime day)
        {
            switch (day.DayOfWeek)
            {
                case System.DayOfWeek.Monday:
                    return "Thứ Hai";
                case System.DayOfWeek.Tuesday:
                    return "Thứ Ba";
                case System.DayOfWeek.Wednesday:
                    return "Thứ Tư";
                case System.DayOfWeek.Thursday:
                    return "Thứ Năm";
                case System.DayOfWeek.Friday:
                    return "Thứ Sáu";
                case System.DayOfWeek.Saturday:
                    return "Thứ Bảy";
                case System.DayOfWeek.Sunday:
                    return "Chủ Nhật";
                default:
                    return "";
            }
        }
        public static string GetDay()
        {
            string s = "";
            DateTime day = DateTime.Now;
            s = "Hôm nay " + DayOfWeek(day) + ", ngày " + day.Day + " tháng " + day.Month + " năm " + day.Year;
            return s;
        }
        public static bool CheckContain(string a, string b)
        {
            if (a == "" || b == "")
                return false;
            List<string> a1 = new List<string>(a.Split(';'));
            List<string> b2 = new List<string>(b.Split(';'));
            foreach (string st in a1)
                if (b2.Contains(st))
                    return true;
            return false;
        }
    }
}
