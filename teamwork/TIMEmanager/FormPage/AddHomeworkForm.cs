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
    public partial class AddHomeworkForm : Form
    {
        ScheduleService ss = new ScheduleService();
        Tasks currentCourse = new Tasks();
        public User user;
        public AddHomeworkForm(Tasks currentCourse)
        {
            InitializeComponent();
            this.currentCourse = currentCourse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string discription = txtDiscription.Text;

            if (discription != "" && discription != "Discription")
            {
                DateTime expectDay = ddlDay.Value;
                int hour = (int)numHour.Value;
                int minute = (int)numMinute.Value;
                string tail = ss.ConvertTimeToString(hour, minute);
                long expectTime = ss.ConvertDayToLong(expectDay, tail);

                Tasks newHomework = new Tasks();

                DateTime now = DateTime.Now;
                string str0 = (now.Second + now.Millisecond).ToString();
                string str1 = ss.ConvertTimeToString(now.Hour, now.Minute);
                string str2 = ss.ConvertDayToLong(now, str1).ToString();
                long id = long.Parse(user.Id + str2 + str0);

                newHomework.UserId = user.Id;
                newHomework.Id = id;
                newHomework.Name = currentCourse.Name + "作业";
                newHomework.Summary = discription;
                newHomework.ExpectTime = expectTime;
                //newHomework.FatherCourseName = currentCourse.Name;

                ss.AddTask(newHomework);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("请输入课程描述。", "信息不足");
            }

        }

        private void txtDiscription_Click(object sender, EventArgs e)
        {
            txtDiscription.Text = "";
            txtDiscription.ForeColor = Color.Black;
        }
    }
}
