using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIMEmanger;
using TIMEmanger.Entity;

namespace TIMEmanager
{
    public partial class AddTestForm : Form
    {
        ScheduleService ss = new ScheduleService();
        Tasks currentCourse = new Tasks();
        public User user;
        //ScheduleInfo si;
        public AddTestForm(Tasks currentCourse/*,ScheduleInfo si*/)
        {
            InitializeComponent();
            this.currentCourse = currentCourse;
            //this.si = si;
        }

        private void txtDiscription_Click(object sender, EventArgs e)
        {
            txtDiscription.Text = "";
            txtDiscription.ForeColor = Color.Black;
        }

        private void txtPlace_Click(object sender, EventArgs e)
        {
            txtPlace.Text = "";
            txtPlace.ForeColor = Color.Black;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string discription = txtDiscription.Text;
            string place = txtPlace.Text;

            if (discription == "" || discription == "Discription")
            {
                MessageBox.Show("请输入考试描述。", "信息不足");
            }
            else if (place == "" || place == "Place")
            {
                MessageBox.Show("请输入考试地点。", "信息不足");
            }
            else
            {
                int i = (int)numHourFrom.Value;
                int j = (int)numMinuteFrom.Value;
                int k = (int)numHourTo.Value;
                int l = (int)numMinuteTo.Value;
                DateTime time = testTime.Value;

                string tailFrom = ss.ConvertTimeToString(i, j);
                string tailTo = ss.ConvertTimeToString(k, l);
                long startTime = ss.ConvertDayToLong(time, tailFrom);
                long expectTime = ss.ConvertDayToLong(time, tailTo);

                Tasks newTest = new Tasks();

                DateTime now = DateTime.Now;
                string str0 = (now.Second + now.Millisecond).ToString();
                string str1 = ss.ConvertTimeToString(now.Hour, now.Minute);
                string str2 = ss.ConvertDayToLong(now, str1).ToString();
                long id = long.Parse(user.Id + str2 + str0);

                newTest.UserId = user.Id;
                newTest.Id = id;
                newTest.Name = currentCourse.Name + "考试";
                newTest.Summary = discription;
                newTest.Place = place;
                newTest.StartTime = expectTime;
                newTest.ExpectTime = expectTime;
                //newTest.FatherCourseName = currentCourse.Name;

                ss.AddTask(newTest);
                //si.InitialPanel();
                this.Dispose();

            }

        }
    }
}
