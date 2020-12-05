using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMEmanger.BO;
using TIMEmanger.Entity;

namespace TIMEmanger
{
    public class ScheduleService
    {

        TaskBO taskBO = new TaskBO();

        ///<summary>
        ///说明：添加课程信息或者作业与考试
        ///</summary>
        ///<param name="newTask"><需要添加的新课程、作业或考试></param>
        public void AddTask(Tasks newTask)
        {
            taskBO.addTask(newTask);
        }

        ///<summary>
        ///说明：删除课程信息
        ///</summary>
        ///<param name="currentTask"><需要删除的当前课程、作业或考试></param>
        public void DeleteTask(Tasks currentTask)
        {
            taskBO.deleteTaskByName(currentTask.Name);
        }

        ///<summary>
        ///说明：获取本周的所有课程列表
        ///</summary>
        ///<returns>
        ///返回链表类型的本周所有课程
        ///</returns>
        public List<Tasks> GetCoursesOfThisWeek(int id)
        {



            long now = ConvertDayToLong(DateTime.Now, "0001");

            //用now去数据库查询
            //其中now的值介于StartTime和ExpectTime

            return taskBO.SearchForCourseByWeek0(now,id);
        }

        ///<summary>
        ///说明：获取某一课程的所有作业
        ///</summary>
        ///<param name="currentCourse"><需要查找的当前课程></param>
        ///<returns>
        ///返回链表类型的该课程的所有作业
        ///</returns>
        public List<Tasks> GetHomework(Tasks currentCourse)
        {
            string name = currentCourse.Name + "作业";

            //查询数据库中Name=name的记录
            return taskBO.searchByName(name,currentCourse.UserId);
            //return null;
        }

        ///<summary>
        ///说明：获取某一课程的所有考试
        ///</summary>
        ///<param name="currentCourse"><需要查找的当前课程></param>
        ///<returns>
        ///返回链表类型的该课程的所有考试
        ///</returns>
        public List<Tasks> GetTests(Tasks currentCourse)
        {
            string name = currentCourse.Name + "考试";

            //查询数据库中Name=name的记录
            return taskBO.searchByName(name, currentCourse.UserId);
            //return null;
        }


        ///<summary>
        ///说明：课程所在每周的周几
        ///作者：吴垚康
        ///</summary>
        ///<param name="weekLoopDay"><从实体类取出的周几参数></param>
        ///<returns>
        ///返回周几
        ///</returns>
        public string ParseWeekLoopDay(int weekLoopDay)
        {
            string week = "";
            switch (weekLoopDay)
            {
                case 1: week = "周一"; break;
                case 2: week = "周二"; break;
                case 3: week = "周三"; break;
                case 4: week = "周四"; break;
                case 5: week = "周五"; break;
                case 6: week = "周六"; break;
                case 7: week = "周日"; break;
            }
            return week;
        }

        public int ParseWeekLoopDay(string weekLoopDay)
        {
            //string week = "";
            int i=0;
            switch (weekLoopDay)
            {
                case "Mon": i = 1; break;
                case "Tue": i = 2; break;
                case "Wed": i = 3; break;
                case "Thu": i = 4; break;
                case "Fir": i = 5; break;
                case "Sat": i = 6; break;
                case "Sun": i = 7; break;

            }
            return i;
        }


        ///<summary>
        ///说明：将几时几分转换为四位数的字符串，例如9：00转化为0900
        ///作者：吴垚康
        ///</summary>
        ///<param name="hour"><整型的小时></param>
        ///<param name="minute"><整型的分钟></param>
        ///<returns>
        ///返回转换后的四位字符串
        ///</returns>
        public string ConvertTimeToString(int hour, int minute)
        {
            string str = "";
            str += hour >= 10 ? hour.ToString() : "0" + hour;
            str += minute >= 10 ? minute.ToString() : "0" + minute;
            return str;
        }


        ///<summary>
        ///说明：将日历的控件获取的日期转换为实体类所需要的long类型，
        ///作者：吴垚康
        ///</summary>
        ///<param name="time"><日历控件获得的日期></param>
        ///<param name="tail"><具体日期的时间点，例如00：00设置为0000></param>
        ///<returns>
        ///返回转换后的long类型时间保存数据
        ///</returns>
        public long ConvertDayToLong(DateTime time, string tail)
        {
            string timeStr = time.Year.ToString();
            timeStr += time.Month >= 10 ?
                time.Month.ToString() : "0" + time.Month.ToString();
            timeStr += time.Day >= 10 ?
                time.Day.ToString() : "0" + time.Day.ToString();
            timeStr += tail;

            long timeLong = long.Parse(timeStr);

            return timeLong;
        }

        ///<summary>
        ///说明：将long类型的时间转换为具体日期描述
        ///作者：吴垚康
        ///</summary>
        ///<param name="time"><long类型的时间></param>
        ///<returns>
        ///返回转换后的string类型的日期描述
        ///</returns>
        public string ConvetLongToDayStr(long time)
        {
            string timeStr = time.ToString();
            timeStr = timeStr.Insert(4, "/");
            timeStr = timeStr.Insert(7, "/");
            timeStr = timeStr.Insert(10, " ");
            timeStr = timeStr.Insert(13, ":");
            return timeStr;
        }

        ///<summary>
        ///说明：将long类型的时间区间转换为具体日期描述
        ///作者：吴垚康
        ///</summary>
        ///<param name="starttime"><long类型的时间起点></param>
        ///<param name="endtime"><long类型的时间终点></param>
        ///<returns>
        ///返回转换后的string类型的日期描述
        ///</returns>
        public string ConvetLongToDayStr(long starttime, long endtime)
        {
            string timeStr = ConvetLongToDayStr(starttime);
            string end = endtime.ToString().Substring(8,4);
            end = end.Insert(2, ":");
            return timeStr + "-" + end;
        }

    }
}
