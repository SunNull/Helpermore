using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpermore
{
    public class DateMore
    {
        /// <summary>
        /// 日期转换成yyyy-MM-dd HH:mm:ss格式的字符串
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DateToString(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }
        /// <summary>
        /// 日期差天数
        /// </summary>
        /// <param name="startdate"></param>
        /// <param name="enddate"></param>
        /// <param name="dttype">计算类型</param>
        /// <returns></returns>
        public static double DateToSpan(DateTime startdate, DateTime enddate, Dttype dttype)
        {
            TimeSpan span = enddate - startdate;
            if (dttype == Dttype.天数)
                return span.TotalDays;
            else if (dttype == Dttype.小时数)
                return span.TotalHours;
            else if (dttype == Dttype.分钟数)
                return span.TotalMinutes;
            else if (dttype == Dttype.秒数)
                return span.TotalSeconds;
            else 
                return span.TotalMicroseconds;
        }

        
    }

    public enum Dttype
    {
        天数 = 1,
        小时数 = 2,
        分钟数 = 3,
        秒数 = 4,
    }
}
