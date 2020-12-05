using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TIMEmanger.Entity;
using TIMEmanger;

namespace TIMEmanager
{
    public partial class ScheduleInfo : Form
    {
        ScheduleService ss = new ScheduleService();
        Tasks currentCourse = new Tasks();
        List<Tasks> homeworks = new List<Tasks>();
        List<Tasks> tests = new List<Tasks>();
        public User user;
        public ScheduleInfo(Tasks currentCourse)
        {
            InitializeComponent();
            this.currentCourse = currentCourse;
            this.homeworks = ss.GetHomework(currentCourse);
            this.tests = ss.GetTests(currentCourse);
            InitialPanel();
        }

        public void InitialPanel()
        {

            lblName.Text = currentCourse.Name;
            lblPlace.Text = currentCourse.Place;
            lblTeacher.Text = currentCourse.TeacherName;
            lblTime.Text = ss.ParseWeekLoopDay(currentCourse.WeekLoopDay) + " ";
            lblTime.Text += "第" + currentCourse.DairyStartTime +
                "节-第" + currentCourse.DairyFinishTime + "节";


            //以下数据为测试用
            /*
            Tasks homework = new Tasks();
            homework.ExpectTime = 202009181200;
            homework.Summary = "课后习题182页1、2";
            homeworks.Add(homework);
            Tasks test = new Tasks();
            test.StartTime = 202009181100;
            test.ExpectTime = 202009181200;
            test.Summary = "期末考试";
            test.Place = "[2区]1-202";
            tests.Add(test);
            */

            lblHomework.Text = string.Empty;
            lblTest.Text = string.Empty;

            //homeworks.Clear();
            //tests.Clear();
            if (homeworks != null)
            {
                foreach (Tasks h in homeworks)
                {
                    lblHomework.Text += h.Summary + "\nDDL:"
                        + ss.ConvetLongToDayStr(h.ExpectTime) + "\n";
                }
            }

            if (tests != null)
            {
                foreach (Tasks t in tests)
                {
                    lblTest.Text += t.Summary + " | " + t.Place + "\n"
                        + ss.ConvetLongToDayStr(t.StartTime, t.ExpectTime) + "\n";
                }
            }

            if (lblTest.Text == "")
            {
                btnDelTest.ForeColor = Color.LightGray;
                btnDelTest.Enabled = false;
            }

            if (lblHomework.Text == "")
            {
                btnDelHomework.ForeColor = Color.LightGray;
                btnDelHomework.Enabled = false;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定该课程吗?", "删除课程", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                ss.DeleteTask(currentCourse);
                MessageBox.Show("删除成功。", "删除课程");
                this.Dispose();
            }


        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            AddTestForm at = new AddTestForm(currentCourse);
            at.user = user;
            at.Show();
            InitialPanel();
        }

        private void btnAddHomework_Click(object sender, EventArgs e)
        {
            AddHomeworkForm ah = new AddHomeworkForm(currentCourse);
            ah.user = user;
            ah.Show();
            InitialPanel();
        }

        private void btnDelTest_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定所有考试吗?", "删除考试", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                if (tests != null)
                {
                    foreach (Tasks t in tests)
                    {
                        ss.DeleteTask(t);

                        MessageBox.Show("删除成功。", "删除考试");
                    }
                    InitialPanel();
                }
            }
        }

        private void btnDelHomework_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定所有作业吗?", "删除作业", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                if (homeworks != null)
                {
                    foreach (Tasks h in homeworks)
                    {
                        ss.DeleteTask(h);
                        MessageBox.Show("删除成功。", "删除作业");
                    }
                    InitialPanel();
                }
            }
        }
    }
}
