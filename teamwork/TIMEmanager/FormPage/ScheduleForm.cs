using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIMEmanager;
using TIMEmanger.Entity;

namespace TIMEmanger
{
    public partial class ScheduleForm : Form
    {
        ScheduleService ss = new ScheduleService();
        List<Tasks> courses = new List<Tasks>();
        private Tasks currentCourse;   //表示当前正在操作的课程
        public User user;
        Button[] buttons = new Button[50];
        public ScheduleForm(User user)
        {
            InitializeComponent();
            this.user = user;
            ShowCourses();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            AddScheduleForm acf = new AddScheduleForm();
            acf.user = user;
            acf.Show();
        }

        ///<summary>
        ///说明：在课程表窗口中显示本周的课程
        ///作者：吴垚康
        ///</summary>
        private void ShowCourses()
        {
            //Tasks currentCourse;
            courses = ss.GetCoursesOfThisWeek(user.Id);

            //以下为测试用
            /*
            Tasks course = new Tasks();
            course.Name = "软件构造基础";
            course.TeacherName = "贾向阳";
            course.Place = "[1区]202";
            course.DairyStartTime = 1;
            course.DairyFinishTime = 3;
            course.WeekLoopDay = 1;
            PaintCourse(course);

            Tasks course1 = new Tasks();
            course1.Name = "组合数学";
            course1.TeacherName = "王老师";
            course1.Place = "[1区]202";
            course1.DairyStartTime = 6;
            course1.DairyFinishTime = 8;
            course1.WeekLoopDay = 3;
            PaintCourse(course1);

            Tasks course2 = new Tasks();
            course2.Name = "软件工程";
            course2.TeacherName = "刘老师";
            course2.Place = "[1区]202";
            course2.DairyStartTime = 3;
            course2.DairyFinishTime = 5;
            course2.WeekLoopDay = 5;
            PaintCourse(course2);

            Tasks course3 = new Tasks();
            course3.Name = "操作系统";
            course3.TeacherName = "刘老师";
            course3.Place = "[1区]202";
            course3.DairyStartTime = 3;
            course3.DairyFinishTime = 5;
            course3.WeekLoopDay = 4;
            PaintCourse(course3);

            Tasks course4 = new Tasks();
            course4.Name = "计算机网络";
            course4.TeacherName = "刘老师";
            course4.Place = "[1区]202";
            course4.DairyStartTime = 6;
            course4.DairyFinishTime = 8;
            course4.WeekLoopDay = 2;
            PaintCourse(course4);

            Tasks course5 = new Tasks();
            course5.Name = "操作系统课程设计";
            course5.TeacherName = "刘老师";
            course5.Place = "[1区]202";
            course5.DairyStartTime = 11;
            course5.DairyFinishTime = 13;
            course5.WeekLoopDay = 2;
            PaintCourse(course5);
            */
            int i = 0;
            foreach (Tasks tasks in courses)
            {
                PaintCourse(tasks,i);
                i++;
            }
            AddButtonEvent();
        }

        ///<summary>
        ///说明：对于每个课程绘制出按钮控件
        ///作者：吴垚康
        ///</summary>
        ///<param name="course"><当前要绘制的课程></param>
        private void PaintCourse(Tasks course,int i)
        {
            
            string courseName = course.Name;
            string coursePlace = course.Place;
            //int startTime = course.StartTime;
            //int endTime = course.ExpectTime;
            int classBegin = course.DairyStartTime;
            int classEnd = course.DairyFinishTime;
            int weekLoopDay = course.WeekLoopDay;

            Button btnNewCourse = new Button();
            buttons[i] = btnNewCourse;
            switch (weekLoopDay)
            {
                case 1: panelDay1.Controls.Add(btnNewCourse); break;
                case 2: panelDay2.Controls.Add(btnNewCourse); break;
                case 3: panelDay3.Controls.Add(btnNewCourse); break;
                case 4: panelDay4.Controls.Add(btnNewCourse); break;
                case 5: panelDay5.Controls.Add(btnNewCourse); break;
                case 6: panelDay6.Controls.Add(btnNewCourse); break;
                case 7: panelDay7.Controls.Add(btnNewCourse); break;
            }

            btnNewCourse.Text = courseName + "\n" + coursePlace;
            btnNewCourse.SetBounds(6, 35 + (classBegin - 1) * 22, 45, 22 * (classEnd - classBegin + 1));
            btnNewCourse.Font = new Font("微软雅黑", 9f, FontStyle.Regular);

            //currentCourse = course;
            //btnNewCourse.MouseClick += new MouseEventHandler(MouseClick);

            toolTip.SetToolTip(btnNewCourse,
                courseName + "\n" + coursePlace + "\n第" + classBegin + "节-第" + classEnd + "节");

        }

        private void AddButtonEvent()
        {
            for (int i = 0; i < courses.Count; i++)
            {
                buttons[i].MouseClick += new MouseEventHandler(MouseClick);
                //GetButton(i + 1).Click += new EventHandler(BtnUpdate);

            }
        }

        private void MouseClick(object sender, MouseEventArgs e)
        {

            //string title = "[名称]\n[地点]\n[教师]\n[时间]\n[作业]\n[考试]";
            // string info = currentCourse.Name + "\n";
            // info += currentCourse.Place + "\n";
            //info += currentCourse.TeacherName + "\n";
            //info += ss.ParseWeekLoopDay(currentCourse.WeekLoopDay) + " ";
            //info += "第" + currentCourse.DairyStartTime + "节到第" + currentCourse.DairyFinishTime + "节";
            int i = 0;
            foreach(Button btn in buttons)
            {
                if (btn == (Button)sender) break;
                i++;
            }

            ScheduleInfo sci = new ScheduleInfo(/*title,info,*/courses[i]);
            sci.user = user;
            sci.Show();
        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {
            foreach (Tasks t in courses)
            {
                ss.DeleteTask(t);
            }
        }
    }
}
