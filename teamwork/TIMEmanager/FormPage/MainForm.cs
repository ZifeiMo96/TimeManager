using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TIMEmanger.BO;
using TIMEmanager;
using TIMEmanger.Entity;

namespace TIMEmanger
{
    public partial class MainForm : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public Tasks tasks = new Tasks();
        //public Task task = new Task(DateTime.Now, "testtask", 1);//测试避免为空
        public TodoListService todoListService = new TodoListService();
        public User user { get; set; }


        public AccountForm accountForm;

        public CalendarForm calendarForm;

        public ClockForm clockForm;

        public TodoListForm todoListForm;

        public ScheduleForm scheduleForm;

        public MoreItemForm moreItemForm;

        public UserCenterFrom userCenterFrom;

        public TaskBO taskBo;

        public UserBO userBo;



        public MainForm(User user)
        {
            this.user = user;
            taskBo = new TaskBO();
            //taskBo.creatTaskTable();
            userBo = new UserBO();
            //taskBo.deleteTable();
            taskBo.creatTaskTable();
            userBo.creatUserTable();

            tasks.Name = "test";
            //todoListService.AddTask(tasks);//增加任务

            InitializeComponent();
            accountForm = new AccountForm(this);
            calendarForm = new CalendarForm(this);
            clockForm = new ClockForm(user.Id);
            todoListForm = new TodoListForm(user.Id);
            //scheduleForm = new ScheduleForm();
            //moreItemForm = new MoreItemForm();
            userCenterFrom = new UserCenterFrom(this);
            accountForm.TopLevel = false;
            this.itePanel.Controls.Add(accountForm);
            accountForm.FormBorderStyle = FormBorderStyle.None;
            accountForm.BringToFront();
            accountForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            ChangePageToCalendar();
        }

        public  void ChangePageToCalendar()
        {
            this.itePanel.Controls.Clear();
            calendarForm.TopLevel = false;
            this.itePanel.Controls.Add(calendarForm);
            calendarForm.FormBorderStyle = FormBorderStyle.None;
            calendarForm.BringToFront();
            calendarForm.GetCourseTask();
            calendarForm.UpdateCourse();
            calendarForm.GetTask();
            calendarForm.taskPageNumber = 0;
            calendarForm.loadMenu();
            calendarForm.Show();
        }

        private void clockButton_Click(object sender, EventArgs e)
        {
            this.itePanel.Controls.Clear();
            clockForm.TopLevel = false;
            this.itePanel.Controls.Add(clockForm);
            clockForm.FormBorderStyle = FormBorderStyle.None;
            clockForm.BringToFront();
            clockForm.SearchAll();
            clockForm.Show();
        }

        private void todoListButton_Click(object sender, EventArgs e)
        {
            this.itePanel.Controls.Clear();
            todoListForm.TopLevel = false;
            this.itePanel.Controls.Add(todoListForm);
            todoListForm.FormBorderStyle = FormBorderStyle.None;
            todoListForm.BringToFront();
            todoListForm.setText();
            todoListForm.Show();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            scheduleForm = new ScheduleForm(user);
            this.itePanel.Controls.Clear();
            scheduleForm.TopLevel = false;
            this.itePanel.Controls.Add(scheduleForm);
            scheduleForm.FormBorderStyle = FormBorderStyle.None;
            scheduleForm.BringToFront();
            //scheduleForm.user = user;
            scheduleForm.Show();
        }

        public void AccountButton_Click(object sender, EventArgs e)
        {
            ChangePageToAccountFrom();
        }
        public void ChangePageToAccountFrom()
        {
            this.itePanel.Controls.Clear();
            accountForm.TopLevel = false;
            this.itePanel.Controls.Add(accountForm);
            accountForm.FormBorderStyle = FormBorderStyle.None;
            accountForm.BringToFront();
            accountForm.Show();
        }


        private void moreItemButton_Click(object sender, EventArgs e)
        {
            moreItemForm = new MoreItemForm(user);
            this.itePanel.Controls.Clear();
            moreItemForm.TopLevel = false;
            this.itePanel.Controls.Add(moreItemForm);
            moreItemForm.FormBorderStyle = FormBorderStyle.None;
            moreItemForm.BringToFront();
            //moreItemForm.user = user;
            moreItemForm.Show();
        }

        public void ChangePageToCenterFrom()
        {
            userCenterFrom.TopLevel = false;
            this.itePanel.Controls.Add(userCenterFrom);
            userCenterFrom.FormBorderStyle = FormBorderStyle.None;
            userCenterFrom.BringToFront();
            userCenterFrom.Show();
        }



        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0); 
        }

        private void toolStrip_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void AccountButton_BackgroundImageChanged(object sender, EventArgs e)
        {
            accountForm.pictureBox1.BackgroundImage = AccountButton.BackgroundImage;
        }
    }
}
