using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMEmanger.BO;
using TIMEmanger.Entity;
using TIMEmanager;

namespace TIMEmanger
{
    public class TodoListService
    {
        public TaskBO taskBO = new TaskBO();

        ///<summary>
        ///说明：添加任务信息
        ///</summary>
        ///<param name="newTask"><需要添加的新任务></param>
        public void AddTask(Tasks newTask)
        {

            taskBO.addTask(newTask);
        }

        ///<summary>
        ///说明：删除任务信息
        ///</summary>
        ///<param name="name"><需要删除的当前任务></param>
        public void DeleteTask(string name)
        {
            taskBO.deleteTaskByName(name);
        }

        ///<summary>
        ///说明：删除任务信息
        ///</summary>
        ///<param name="currentTask"><需要删除的当前任务></param>
        public List<Tasks> GetTask(Tasks currentTask)
        {
            string name = currentTask.Name + "任务";
            
            //查询数据库中的任务
            return null;
        }
        public List<Tasks> SearchAll(int id)
        {
            return taskBO.SearchAllTask(id);
        }

        public Tasks SearchByName(string name)
        {
            return taskBO.searchByName(name,1).FirstOrDefault();
        }


        public int AllCount(int id)
        {
            return taskBO.SearchAllTask(id).Count;
        }
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
            string end = (endtime % 10000).ToString();
            end = end.Insert(2, ":");
            return timeStr + "-" + end;
        }


        /*public List<Tasks> myTask;
        public TodoListService(List<Tasks> task)
        {
            if(task == null)
            {
                task = new List<Tasks>();
            }
            else
            {
                myTask = task;
            }
        }
        public TodoListService() { myTask = new List<Tasks>(); }
        public Task GeTask(string name)
        {
            return myTask.Where(o => o.Name == name).FirstOrDefault();
        }
        public void AddTask(Task task)
        {
            myTask.Add(task);
        }

        public List<Task> Tasks { get =>myTask; }

        public void DeleteTask(string name)
        {
            Task task = GeTask(name);
            if (task != null)
            {
                myTask.Remove(task);
            }

        }

    }

    public class Task
    {
        public DateTime deadline { get; set; } //截止时间
        public string taskName { get; set; }  //任务名称
        public int urgentDegree { get; set; } //紧急程度

        //准备加 任务详情
        public Task(DateTime time, string name, int degree)
        {
            this.deadline = time;
            this.taskName = name;
            this.urgentDegree = degree;
        }//构造函数



    }*/
    }
}



