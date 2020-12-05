using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMEmanager
{
    public class ParseTool
    {
        ///<summary>
        ///标准化时间输出
        ///作者：沈翱弘
        ///</summary>
        ///<param name="time"><要标准化的时间></param>
        ///<returns>
        ///返回标准输出
        ///</returns>
        public static String ParseTime(int time)
        {
            String t = (time / 100).ToString("00") + ":" + (time % 100).ToString("00");
            return t;
        }

        ///<summary>
        ///标准化时间输出
        ///作者：沈翱弘
        ///</summary>
        ///<param name="time1"><要标准化的时间段开头></param>
        ///<param name="time2"><要标准化的时间段结尾></param>
        ///<returns>
        ///返回标准输出
        ///</returns>
        public static String ParseTime(int time1, int time2)
        {
            return "[" + ParseTime(time1) + "--" + ParseTime(time2) + "]";
        }

        ///<summary>
        ///翻译TaskId
        ///作者：沈翱弘
        ///</summary>
        ///<param name="userId"><任务的用户ID></param>
        ///<param name="dt"><任务的创建时间></param>
        ///<returns>
        ///返回任务Id
        ///</returns>
        public static long ParseTaskId(int userId, DateTime dt)
        {
            string ds = dt.ToString("yyyyMMddHHmmss");
            ds = userId.ToString("0000") + ds;
            return Int64.Parse(ds);
        }

        ///<summary>
        ///把日期转换为周几
        ///作者：沈翱弘
        ///</summary>
        ///<param name="dt"><时间></param>
        ///<returns>
        ///返回周几
        ///</returns>
        public static int ParseDateToWeek(DateTime dt)
        {
            int d = Int32.Parse(dt.Day.ToString());
            int y = Int32.Parse(dt.Year.ToString());
            int m = Int32.Parse(dt.Month.ToString());
            int day;
            day = (d + 1 + 2 * m + 3 * (m + 1) / 5 + y + y / 4 - y / 100 + y / 400) % 7;
            if (day == 0) day = 7;
            return day;
        }

        public static int ParseDateToWeek(int y,int m,int d)
        {
            int day;
            day = (d + 1 + 2 * m + 3 * (m + 1) / 5 + y + y / 4 - y / 100 + y / 400) % 7;
            if (day == 0) day = 7;
            return day;
        }

        ///<summary>
        ///把日期转换成Task存储标准格式
        ///作者：沈翱弘
        ///</summary>
        ///<param name="dt"><时间></param>
        ///<returns>
        ///返回存储标准格式
        ///</returns>
        public static long ParseDateToInt(DateTime dt)
        {
            string ds = dt.ToString("yyyyMMddHHmmss");
            long number = Int64.Parse(ds);
            number /= 100;
            return number;
        }

        public static DateTime ParseIntToDate(long date)
        {
            long tdate = (long)date;
            int min = (int)(tdate % 100);
            tdate /= 100;
            int hour = (int)(tdate % 100);
            tdate /= 100;
            int day = (int)tdate % 100;
            tdate /= 100;
            int month = (int)tdate % 100;
            tdate /= 100;
            int year = (int)tdate;

            DateTime dateTime = new DateTime(year, month, day, hour, min,0,0);
            return dateTime;
        }

        public static int ParseClassStartToTime(int c){
            int time = 0;
            switch (c)
            {
                case 1:
                    time = 800;
                    break;
                case 2:
                    time = 850;
                    break;
                case 3:
                    time = 950;
                    break;
                case 4:
                    time = 1040;
                    break;
                case 5:
                    time = 1130;
                    break;
                case 6:
                    time = 1405;
                    break;
                case 7:
                    time = 1455;
                    break;
                case 8:
                    time = 1545;
                    break;
                case 9:
                    time = 1640;
                    break;
                case 10:
                    time = 1730;
                    break;
                case 11:
                    time = 1630;
                    break;
                case 12:
                    time = 1920;
                    break;
                case 13:
                    time = 2010;
                    break;
            }
            return time;
        }

        public static int ParseClassEndToTime(int c)
        {
            int time = 0;
            switch (c)
            {
                case 1:
                    time = 845;
                    break;
                case 2:
                    time = 935;
                    break;
                case 3:
                    time = 1035;
                    break;
                case 4:
                    time = 1125;
                    break;
                case 5:
                    time = 1215;
                    break;
                case 6:
                    time = 1450;
                    break;
                case 7:
                    time = 1540;
                    break;
                case 8:
                    time = 1630;
                    break;
                case 9:
                    time = 1725;
                    break;
                case 10:
                    time = 1615;
                    break;
                case 11:
                    time = 1915;
                    break;
                case 12:
                    time = 2005;
                    break;
                case 13:
                    time = 2055;
                    break;
            }
            return time;
        }

    }
}
