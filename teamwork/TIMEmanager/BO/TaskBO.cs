using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using TIMEmanager;
using TIMEmanger.Entity;
using System.Data.SQLite;

namespace TIMEmanger.BO
{
    public class TaskBO
    {

        public String filename = "TIMEmanager";

        public SQLiteManager SQLiteForTask;

        /// <summary>
        /// 空构造函数
        /// </summary>
        public TaskBO()
        {
            SQLiteForTask = new SQLiteManager();
        }

        
        internal void addTask(Task newTask)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 创建表
        /// </summary>
        /// <param name="filename"></param>
        public void creatTaskTable()
        {
            //打开数据库
            SQLiteForTask.OpenDB(filename);


            //sql命令
            string sql = "CREATE TABLE IF NOT EXISTS TASK (" +
                "ID               INTEGER PRIMARY KEY NOT NULL," +
                "USERID           INIEGER,"+
                "NAME             TEXT," +
                "SUMMARY          TEXT," +
                "SETTIME          INTEGER," +
                "EXCEPTTIME       INTEGER," +
                "ISFINISH         INTEGER," +
                "ISCOURSE         INTEGER," +
                "ISFESTIVAL       INTEGER," +
                "DAIRYSTARTNAME   INTEGER," +
                "DAIRYFINISHNAME  INTEGER," +
                "ISWEEKLOOP       INTEGER," +
                "WEEKLOOPDAY      INTEGER," +
                "ISDAYLOOP        INTEGER," +
                "COURSEID         INTERGER," +
                "TEACHERNAME      TEXT," +
                "PLACE            TEXT," +
                "STARTTIME        INTEGER" +
                ");";

            SQLiteForTask.CreateTable(sql);
            SQLiteForTask.CloseDB();
        }


        ///<summary>
        ///说明：<申请查找本周的所有课程>
        ///</summary>
        ///<param name="now"><要查询当前时间点></param>
        ///<returns>
        ///<返回本周的所有课程>
        ///</returns>
        public List<Entity.Tasks> SearchForCourseByWeek0(long now,int id)
        {
            SQLiteForTask.OpenDB(filename);
            //now在StartTime与ExpectTime之间 并且 isCourse为true
            SQLiteForTask.OpenDB(filename);
            List<Tasks> taskList = new List<Tasks>();

            string cmd = "SELECT * " +
                "FROM TASK " +
                "WHERE (ISCOURSE = 1 AND STARTTIME < " + Int64.Parse(now.ToString()) + " AND EXCEPTTIME > " + Int64.Parse(now.ToString()) + " AND USERID ="+id+");";
            using (var reader = SQLiteForTask.ReadTable(cmd))
            {
                while (reader.Read())
                {
                    Tasks task = new Tasks();
                    //根据读到的数据创建task
                    task.Id = reader.GetInt64(0);
                    task.UserId = reader.GetInt32(1);
                    task.Name = reader.GetString(2);
                    task.Summary = reader.GetString(3);
                    task.SetTime = reader.GetInt64(4);
                    task.ExpectTime = reader.GetInt64(5);
                    task.isFinish = Convert.ToBoolean(reader.GetInt32(6));
                    task.isCourse = Convert.ToBoolean(reader.GetInt32(7));
                    task.isFestival = Convert.ToBoolean(reader.GetInt32(8));
                    task.DairyStartTime = reader.GetInt32(9);
                    task.DairyFinishTime = reader.GetInt32(10);
                    task.isWeekLoop = Convert.ToBoolean(reader.GetInt32(11));
                    task.WeekLoopDay = reader.GetInt32(12);
                    task.isDayLoop = Convert.ToBoolean(reader.GetInt32(13));
                    task.CourseId = reader.GetInt64(14);
                    task.TeacherName = reader.GetString(15);
                    task.Place = reader.GetString(16);
                    task.StartTime = reader.GetInt64(17);

                    taskList.Add(task);
                }

            }
            SQLiteForTask.CloseDB();
            return taskList;
        }


        ///<summary>
        ///查找本周的全部课程
        ///作者：张贝琦
        /// </summary>
        ///<param name="now">要查询的周次</param>
        ///<param name="id">用户id</param>
        ///<returns>
        ///返回本周的所有课程
        ///</returns>
        public List<Entity.Tasks> SearchForCourseByWeek(long now, int id)
        {

            //now在StartTime与ExpectTime之间 并且 isCourse为true
            SQLiteForTask.OpenDB(filename);
            List<Tasks> taskList = new List<Tasks>();

            string cmd = "SELECT * " +
                "FROM TASK " +
                "WHERE (ISCOURSE = 1 AND STARTTIME < " + Int64.Parse(now.ToString()) + " AND EXCEPTTIME > " + Int64.Parse(now.ToString()) +
                " AND UserId = " + id + " AND WeekLoopDay = " + ParseTool.ParseDateToWeek(ParseTool.ParseIntToDate(now)) + ");";
            using (var reader = SQLiteForTask.ReadTable(cmd))
            {
                while (reader.Read())
                {
                    Tasks task = new Tasks();
                    //根据读到的数据创建task
                    task.Id = reader.GetInt64(0);
                    task.UserId = reader.GetInt32(1);
                    task.Name = reader.GetString(2);
                    task.Summary = reader.GetString(3);
                    task.SetTime = reader.GetInt64(4);
                    task.ExpectTime = reader.GetInt64(5);
                    task.isFinish = Convert.ToBoolean(reader.GetInt32(6));
                    task.isCourse = Convert.ToBoolean(reader.GetInt32(7));
                    task.isFestival = Convert.ToBoolean(reader.GetInt32(8));
                    task.DairyStartTime = reader.GetInt32(9);
                    task.DairyFinishTime = reader.GetInt32(10);
                    task.isWeekLoop = Convert.ToBoolean(reader.GetInt32(11));
                    task.WeekLoopDay = reader.GetInt32(12);
                    task.isDayLoop = Convert.ToBoolean(reader.GetInt32(13));
                    task.CourseId = reader.GetInt64(14);
                    task.TeacherName = reader.GetString(15);
                    task.Place = reader.GetString(16);
                    task.StartTime = reader.GetInt64(17);

                    taskList.Add(task);
                }
            }
            SQLiteForTask.CloseDB();
            return taskList;
        }


        ///<summary>
        ///查询课程
        ///作者：叶子扬
        ///</summary>
        ///<param name="year"><要查询课程的年份></param>
        ///<param name="month"><要查询课程的月份></param>
        ///<param name="day"><要查询课程的日期></param>
        ///<returns>
        ///返回查询日期当天的任务
        ///</returns>
        public List<Tasks> SearchForCourseByDate(string year,string month,string day)
        {
            SQLiteForTask.OpenDB(filename);
            List<Tasks> taskList = new List<Tasks>();
            Tasks task = new Tasks();
            string courseTime = year + month + day+"0000";
            string cmd = "SELECT * " +
                "FROM TASK "+
                "WHERE (EXCEPTTIME = " + int.Parse(courseTime)+");";
            using (var reader = SQLiteForTask.ReadTable(cmd))
            {
                while (reader.Read())
                {
                    //根据读到的数据创建task
                    task.Id = reader.GetInt64(0);
                    task.UserId = reader.GetInt32(1);
                    task.Name = reader.GetString(2);
                    task.Summary = reader.GetString(3);
                    task.SetTime = reader.GetInt64(4);
                    task.ExpectTime = reader.GetInt64(5);
                    task.isFinish = Convert.ToBoolean(reader.GetInt32(6));
                    task.isCourse = Convert.ToBoolean(reader.GetInt32(7));
                    task.isFestival = Convert.ToBoolean(reader.GetInt32(8));
                    task.DairyStartTime = reader.GetInt32(9);
                    task.DairyFinishTime = reader.GetInt32(10);
                    task.isWeekLoop = Convert.ToBoolean(reader.GetInt32(11));
                    task.WeekLoopDay = reader.GetInt32(12);
                    task.isDayLoop = Convert.ToBoolean(reader.GetInt32(13));
                    task.CourseId = reader.GetInt64(14);
                    task.TeacherName = reader.GetString(15);
                    task.Place = reader.GetString(16);
                    task.StartTime = reader.GetInt64(17);

                    taskList.Add(task);
                }

            }
            SQLiteForTask.CloseDB();
            return taskList;

        }


        ///<summary>
        ///查询课程
        ///作者：张贝琦
        ///</summary>
        ///<param name="year"><要查询课程的年份></param>
        ///<param name="month"><要查询课程的月份></param>
        ///<param name="day"><要查询课程的日期></param>
        ///<param name="id">所属用户的id</param>
        ///<returns>
        ///返回查询日期当天的任务
        ///</returns>
        public List<Tasks> SearchForCourseByDate(string year, string month, string day, int id)
        {
            SQLiteForTask.OpenDB(filename);
            List<Tasks> taskList = new List<Tasks>();

            string courseTime = year + month + day + "0000";
            string cmd = "SELECT * " +
                "FROM TASK " +
                "WHERE (EXCEPTTIME = " + Int64.Parse(courseTime) + " AND USERID = " + id +
                " AND ISCOURSE = 0 " +
                ");";
            using (var reader = SQLiteForTask.ReadTable(cmd))
            {
                while (reader.Read())
                {
                    Tasks task = new Tasks();
                    //根据读到的数据创建task
                    task.Id = reader.GetInt64(0);
                    task.UserId = reader.GetInt32(1);
                    task.Name = reader.GetString(2);
                    task.Summary = reader.GetString(3);
                    task.SetTime = reader.GetInt64(4);
                    task.ExpectTime = reader.GetInt64(5);
                    task.isFinish = Convert.ToBoolean(reader.GetInt32(6));
                    task.isCourse = Convert.ToBoolean(reader.GetInt32(7));
                    task.isFestival = Convert.ToBoolean(reader.GetInt32(8));
                    task.DairyStartTime = reader.GetInt32(9);
                    task.DairyFinishTime = reader.GetInt32(10);
                    task.isWeekLoop = Convert.ToBoolean(reader.GetInt32(11));
                    task.WeekLoopDay = reader.GetInt32(12);
                    task.isDayLoop = Convert.ToBoolean(reader.GetInt32(13));
                    task.CourseId = reader.GetInt64(14);
                    task.TeacherName = reader.GetString(15);
                    task.Place = reader.GetString(16);
                    task.StartTime = reader.GetInt64(17);

                    taskList.Add(task);
                }

            }
            SQLiteForTask.CloseDB();
            return taskList;

        }




        /// <summary>
        /// 查询全部任务
        /// </summary>
        /// <returns>
        /// 全部任务的列表
        /// </returns>
        public List<Tasks> SearchAllTask(int userId)
        {
            SQLiteForTask.OpenDB(filename);
            List<Tasks> taskList = new List<Tasks>();
 
            
            string cmd = "SELECT * " +
                "FROM TASK "+
                "WHERE USERID = "+userId+";";
            using (var reader = SQLiteForTask.ReadTable(cmd))
            {
                while (reader.Read())
                {
                    Tasks task = new Tasks();
                    //根据读到的数据创建task
                    task.Id = reader.GetInt64(0);
                    task.UserId = reader.GetInt32(1);
                    task.Name = reader.GetString(2);
                    task.Summary = reader.GetString(3);
                    task.SetTime = reader.GetInt64(4);
                    task.ExpectTime = reader.GetInt64(5);
                    task.isFinish = Convert.ToBoolean(reader.GetInt32(6));
                    task.isCourse = Convert.ToBoolean(reader.GetInt32(7));
                    task.isFestival = Convert.ToBoolean(reader.GetInt32(8));
                    task.DairyStartTime = reader.GetInt32(9);
                    task.DairyFinishTime = reader.GetInt32(10);
                    task.isWeekLoop = Convert.ToBoolean(reader.GetInt32(11));
                    task.WeekLoopDay = reader.GetInt32(12);
                    task.isDayLoop = Convert.ToBoolean(reader.GetInt32(13));
                    task.CourseId = reader.GetInt64(14);
                    task.TeacherName = reader.GetString(15);
                    task.Place = reader.GetString(16);
                    task.StartTime = reader.GetInt64(17);

                    taskList.Add(task);
                }

            }
            SQLiteForTask.CloseDB();
            return taskList;

        }



        /// <summary>
        /// 查询全部课程
        /// </summary>
        /// <returns>
        /// 全部课程的列表
        /// </returns>
        public List<Tasks> SearchAllCourse()
        {
            SQLiteForTask.OpenDB(filename);
            List<Tasks> taskList = new List<Tasks>();


            string cmd = "SELECT * " +
                "FROM TASK WHERE ISCOURSE=1 ;";
            using (var reader = SQLiteForTask.ReadTable(cmd))
            {
                while (reader.Read())
                {
                    Tasks task = new Tasks();
                    //根据读到的数据创建task
                    task.Id = reader.GetInt64(0);
                    task.UserId = reader.GetInt32(1);
                    task.Name = reader.GetString(2);
                    task.Summary = reader.GetString(3);
                    task.SetTime = reader.GetInt64(4);
                    task.ExpectTime = reader.GetInt64(5);
                    task.isFinish = Convert.ToBoolean(reader.GetInt32(6));
                    task.isCourse = Convert.ToBoolean(reader.GetInt32(7));
                    task.isFestival = Convert.ToBoolean(reader.GetInt32(8));
                    task.DairyStartTime = reader.GetInt32(9);
                    task.DairyFinishTime = reader.GetInt32(10);
                    task.isWeekLoop = Convert.ToBoolean(reader.GetInt32(11));
                    task.WeekLoopDay = reader.GetInt32(12);
                    task.isDayLoop = Convert.ToBoolean(reader.GetInt32(13));
                    task.CourseId = reader.GetInt64(14);
                    task.TeacherName = reader.GetString(15);
                    task.Place = reader.GetString(16);
                    task.StartTime = reader.GetInt64(17);

                    taskList.Add(task);
                }

            }
            SQLiteForTask.CloseDB();
            return taskList;

        }



        /// <summary>
        /// 添加task
        /// </summary>
        /// <param name="t">task</param>
        public void addTask(Tasks t)
        {
            /*lock (SQLiteForTask)
            {
                SQLiteForTask.OpenDB(filename);
                string task = ParseValueToString(t);
                SQLiteForTask.InsertIntoTable("TASK", task);
                SQLiteForTask.CloseDB();
            }*/
            int ret = -1;
            string task = ParseValueToString(t);
            SQLiteConnectionStringBuilder connectionStr = new SQLiteConnectionStringBuilder();
            connectionStr.DataSource = filename;
            string sql = "INSERT INTO " + "TASK" + " VALUES (" + task;
            sql += " )";
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = connectionStr.ToString();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Connection.Open();
                    ret = cmd.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// 删除task
        /// </summary>
        /// <param name="name">任务名</param>
        public void deleteTaskByName(string name)
        {
            /*
            SQLiteForTask.OpenDB(filename);
            string cmd = "Name='" + name+"'";
            SQLiteForTask.DeleteFromTable("TASK", cmd);
            SQLiteForTask.CloseDB();
            */
            string s = "Name='" + name + "'";
            int ret = -1;
            string sql = "DELETE FROM " + "TASK" + " WHERE " + s;
            SQLiteConnectionStringBuilder connectionStr = new SQLiteConnectionStringBuilder();
            connectionStr.DataSource = filename;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = connectionStr.ToString();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Connection.Open();
                    ret = cmd.ExecuteNonQuery();
                }
            }

        }


        /// <summary>
        /// 更新task数据库
        /// </summary>
        /// <param name="name">任务名</param>
        /// <param name="colNames">要更改的属性</param>
        /// <param name="colValues">新的值</param>
        public void updateTask(string name, string[] colNames, string[] colValues)
        {
            string cmd = "NAME = " + name;
            SQLiteForTask.UpdateTalbe("TASK", colNames, colValues, cmd);
        }



        ///<summary>
        ///更新task数据库
        ///作者：张贝琦
        /// </summary>
        /// <param name="name">任务名</param>
        /// <param name="colName">要更新的属性值</param>
        /// <param name="colValue">新的值</param>
        public void updateTask(string name, string colName, string colValue,string condition)
        {
            SQLiteForTask.UpdateTable(name, colName, colValue, condition);
        }



        /// <summary>
        /// 删除数据库
        /// </summary>
        public void deleteTable()
        {
            string cmd = "DROP TABLE TASK;";
            SQLiteForTask.OpenDB(filename);
            SQLiteForTask.ExecuteQuery(cmd);
            SQLiteForTask.CloseDB();
        }



        /// <summary>
        /// 通过任务名查询任务
        /// 修改：张贝琦
        /// </summary>
        /// <param name="name">task的名字</param>
        /// <returns>
        /// 相同任务名的list
        /// </returns>
        public List<Tasks> searchByName(string name, int id)
        {
            SQLiteForTask.OpenDB(filename);
            List<Tasks> taskList = new List<Tasks>();
            Tasks task = new Tasks();
            string cmd = "SELECT * " +
                "FROM TASK " +
                "WHERE NAME = '" + name + "' " +
                "AND UserId = " + id;
            using (var reader = SQLiteForTask.ReadTable(cmd))
            {
                while (reader.Read())
                {
                    //根据读到的数据创建task
                    task.Id = reader.GetInt64(0);
                    task.UserId = reader.GetInt32(1);
                    task.Name = reader.GetString(2);
                    task.Summary = reader.GetString(3);
                    task.SetTime = reader.GetInt64(4);
                    task.ExpectTime = reader.GetInt64(5);
                    task.isFinish = Convert.ToBoolean(reader.GetInt32(6));
                    task.isCourse = Convert.ToBoolean(reader.GetInt32(7));
                    task.isFestival = Convert.ToBoolean(reader.GetInt32(8));
                    task.DairyStartTime = reader.GetInt32(9);
                    task.DairyFinishTime = reader.GetInt32(10);
                    task.isWeekLoop = Convert.ToBoolean(reader.GetInt32(11));
                    task.WeekLoopDay = reader.GetInt32(12);
                    task.isDayLoop = Convert.ToBoolean(reader.GetInt32(13));
                    task.CourseId = reader.GetInt64(14);
                    task.TeacherName = reader.GetString(15);
                    task.Place = reader.GetString(16);
                    task.StartTime = reader.GetInt64(17);

                    taskList.Add(task);
                }
            }
            SQLiteForTask.CloseDB();
            return taskList;
        }

        /// <summary>
        /// task转string
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private String ParseValueToString(Tasks t)
        {
            string value =""+
                t.Id + "," +
                t.UserId+ "," +
                "'"+t.Name+"'" + "," +
                "'"+t.Summary+"'" + "," +
                t.SetTime + "," +
                t.ExpectTime + "," +
                t.isFinish + "," +
                t.isCourse + "," +
                t.isFestival + "," +
                t.DairyStartTime + "," +
                t.DairyFinishTime + "," +
                t.isWeekLoop + "," +
                t.WeekLoopDay + "," +
                t.isDayLoop + "," +
                t.CourseId + "," +
                "'"+t.TeacherName +"'"+ "," +
                "'"+t.Place + "'" + "," +
                t.StartTime;
            return value;

        }
 

    }
}
