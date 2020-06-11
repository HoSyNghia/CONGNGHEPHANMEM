using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class TimeEntity: Color
    {
        public TimeEntity()
        { }
        public string Date, Time;
        public TimeEntity(string Date, string Time)
        {
            this.Date = Date;
            this.Time = Time;
        }
        public static List<Color> GetAll
        {
            get
            {
                return XuLyXml.GetAllTimes();
            }
        }

    }
}
