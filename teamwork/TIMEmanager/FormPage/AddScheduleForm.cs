using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TIMEmanger.Entity;
using TIMEmanger.BO;
using TIMEmanger;

namespace TIMEmanager
{
    public partial class AddScheduleForm : Form
    {
        public ScheduleService ss = new ScheduleService();
        public User user;
        public AddScheduleForm()
        {
            InitializeComponent();
            //设置默认值
            cmbWeek.Text = "MON";
            cmbCourseStart.Text = "1";
            cmbCourseEnd.Text = "3";
        }


        private void txtCoursePlace_Click(object sender, EventArgs e)
        {
            txtCoursePlace.Text = "";
            txtCoursePlace.ForeColor = Color.Black;
        }

        private void txtCourseTeacher_Click(object sender, EventArgs e)
        {
            txtCourseTeacher.Text = "";
            txtCourseTeacher.ForeColor = Color.Black;
        }


        private void txtCourseName_Click_1(object sender, EventArgs e)
        {
            txtCourseName.Text = "";
            txtCourseName.ForeColor = Color.Black;
        }

        private void cmbCourseEnd_Click(object sender, EventArgs e)
        {
            if (cmbCourseStart.SelectedItem != null)
            {
                int startIndex = int.Parse(cmbCourseStart.SelectedItem.ToString());
                cmbCourseEnd.Items.Clear();
                for (int i = startIndex; i <= 13; i++)
                {
                    cmbCourseEnd.Items.Add(i);
                }
            }
        }


        private void cmbCourseStart_Click(object sender, EventArgs e)
        {
            if (cmbCourseEnd.SelectedItem != null)
            {
                int endIndex = int.Parse(cmbCourseEnd.SelectedItem.ToString());
                cmbCourseStart.Items.Clear();
                for (int i = 1; i <= endIndex; i++)
                {
                    cmbCourseStart.Items.Add(i);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string courseName = txtCourseName.Text;
            string coursePlace = txtCoursePlace.Text;
            string courseTeacher = txtCourseTeacher.Text;
            long startime = ss.ConvertDayToLong(startTime.Value, "0000");
            long endtime = ss.ConvertDayToLong(endTime.Value, "2359");

            if (courseName == "" || courseName == "CourseName")
            {
                MessageBox.Show("请输入课程名。", "信息不足");
            }
            else if (coursePlace == "" || coursePlace == "CoursePlace")
            {
                MessageBox.Show("请输入上课地点。", "信息不足");
            }
            else if (courseTeacher == "" || courseTeacher == "CourseTeacher")
            {
                MessageBox.Show("请输入上课教师姓名。", "信息不足");
            }
            else if (startime > endtime)
            {
                MessageBox.Show("选择起止日期有误。", "信息有误");
            }
            else
            {
                int week = cmbWeek.SelectedIndex + 1;
                int courseStart = int.Parse(cmbCourseStart.SelectedItem.ToString());
                int courseEnd = int.Parse(cmbCourseEnd.SelectedItem.ToString());

                Tasks newCourse = new Tasks();

                DateTime now = DateTime.Now;
                string str0 = (now.Second + now.Millisecond).ToString();
                string str1 = ss.ConvertTimeToString(now.Hour, now.Minute);
                string str2 = ss.ConvertDayToLong(now, str1).ToString();
                long id = long.Parse(user.Id + str2 + str0);

                newCourse.Id = id;
                newCourse.Name = courseName;
                newCourse.UserId = user.Id;
                newCourse.Place = coursePlace;
                newCourse.TeacherName = courseTeacher;
                newCourse.DairyStartTime = courseStart;
                newCourse.DairyFinishTime = courseEnd;
                newCourse.WeekLoopDay = week;
                newCourse.isCourse = true;
                newCourse.StartTime = startime;
                newCourse.ExpectTime = endtime;

                ss.AddTask(newCourse);

                MessageBox.Show("添加课程成功。", "添加成功");
                this.Dispose();
            }

        }
    }
}
