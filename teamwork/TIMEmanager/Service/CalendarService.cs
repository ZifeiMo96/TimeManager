using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMEmanager;

namespace TIMEmanger
{
    ///<summary>
    ///模块名：<日历类>
    ///作用：<用于实现日历的相关功能>
    ///作者：MR.Mo
    ///编写日期：<2020-06-01>
    ///</summary>
    public class CalendarService
    {
        private BO.TaskBO taskBO;

        public CalendarService() 
        {
            taskBO = new BO.TaskBO();
        }

        public Entity.Tasks[] getCourse(int year,int month,int day,int userid)
        {
            long s = ParseTool.ParseDateToInt(new DateTime(year, month, day, 0, 0, 0));
            List<Entity.Tasks> list = taskBO.SearchForCourseByWeek(s,userid);
            if (list == null)
            {
                return new Entity.Tasks[5];
            }
            Entity.Tasks[] t = list.ToArray();
            Entity.Tasks[] nTask = new Entity.Tasks[5];
            for(int i = 0; i< 5; i++)
            {
                if (i < t.Length)
                {
                    nTask[i] = t[i];
                }
                else
                {
                    nTask[i] = null;
                }

            }
            return nTask;
        }

        public Entity.Tasks[] getTask(int year, int month, int day, int userid)
        {
            long s = ParseTool.ParseDateToInt(new DateTime(year, month, day, 0, 0, 0));
            List<Entity.Tasks> list = taskBO.SearchForCourseByDate(year.ToString("00"), month.ToString("00"), day.ToString("00"),userid);
            if (list == null)
            {
                return new Entity.Tasks[100];
            }
            Entity.Tasks[] t = list.ToArray();
            Entity.Tasks[] nTask = new Entity.Tasks[100];
            for (int i = 0; i < 100; i++)
            {
                if (i < t.Length)
                {
                    nTask[i] = t[i];
                }
                else
                {
                    nTask[i] = null;
                }

            }
            return nTask;
        }

    }
}
