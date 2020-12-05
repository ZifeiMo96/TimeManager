using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMEmanager;
using System.Data.SQLite;

namespace TIMEmanger.Entity
{


    /// <summary>
    /// 模块名：Task
    /// 作用：创建Task数据库
    /// 作者：叶子扬
    /// </summary>
    public class Tasks

    {

        /// <summary>
        /// 任务的编号ID，生成规则为用户ID+确定生成时间+本次软件启动后的任务设定数所形成的数字串
        /// 例如用户ID为1123，设定时间为2020年6月4日22点13分22秒，则ID为112320200604221322
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 用户Id;
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 任务的名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 任务的简介
        /// </summary>
        public string Summary { get; set; }
        /// <summary>
        /// 任务的权重，大小在1-10之间
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// 任务的设定时间，记录格式例为202006042157，即为2020年6月4日21点57分
        /// </summary>
        public long SetTime { get; set; }
        /// <summary>
        /// 任务的开始时间，记录格式例为202006042157，即为2020年6月4日21点57分
        /// </summary>

        public long StartTime { get; set; }

        /// <summary>
        /// 任务的预期完成时间，记录格式例为202006042157，即为2020年6月4日21点57分
        /// </summary>
        public long ExpectTime { get; set; }
        /// <summary>
        /// 任务是否完成
        /// </summary>
        public bool isFinish { get; set; }
        /// <summary>
        /// 任务是否是一个课程
        /// </summary>
        public bool isCourse;
        /// <summary>
        /// 任务是否是一个节日
        /// </summary>
        public bool isFestival;
        /// <summary>
        /// 周期任务的开始时间,格式为2250，即22:50
        /// </summary>

        public int DairyStartTime { get; set; }

        /// <summary>
        /// 周期任务的结束时间，格式为2250，即22:50
        /// </summary>
        public int DairyFinishTime { get; set; }
        /// <summary>
        /// 是否是每周循环
        /// </summary>
        public bool isWeekLoop;

        /// <summary>
        /// 每周循环的周几，周一计为1，周日计为7
        /// </summary>
        public int WeekLoopDay;

        /// <summary>
        /// 是否是每日循环
        /// </summary>
        public bool isDayLoop;
        /// <summary>
        /// 课程的课程号
        /// </summary>
        public long CourseId { get; set; }
        /// <summary>
        /// 课程教师的名字
        /// </summary>
        public String TeacherName { get; set; }
        /// <summary>
        /// 课程的上课地点
        /// </summary>
        public string Place { get; set; }

    }
}
