using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIMEmanger.Entity;
using TIMEmanger.BO;
using TIMEmanager;

namespace TIMEmanger.FormPage
{
    public partial class taskAdd : Form
    {
        public TodoListService todoListService;
        public int Id;
        public CalendarForm cf;
        
        public taskAdd(int id)
        {
            InitializeComponent();
            todoListService = new TodoListService();
            Id = id ;
        }

        public taskAdd(int userID,DateTime dt,CalendarForm cf)
        {
            InitializeComponent();
            todoListService = new TodoListService();
            Id = userID;
            endTime.Value = dt;
            this.cf = cf;
        }

        private void taskName_TextChanged(object sender, EventArgs e)
        {

        }

       /* private void addTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("添加成功");
            try
            {
                if(taskName.Text == "" || taskDegree.Text == "")
                {
                    MessageBox.Show("请输入任务名称");
                }
                else
                {
                    int degree = int.Parse(taskDegree.Text);
                    string name = taskName.Text;
                    long endtime = todoListService.ConvertDayToLong(endTime.Value, "0000");

                    Tasks task = new Tasks();
                    //todoListService.AddTask(task);
                    taskDegree.Clear();
                    taskName.Clear();
                    MessageBox.Show("添加成功");
                }
            }
            catch(Exception x)
            {
                Console.WriteLine("添加失败");
            }
        }*/

        private void taskAdd_Load(object sender, EventArgs e)
        {
            taskName.Text = "TaskName";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addTask_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (taskName.Text == "" )
                {
                    MessageBox.Show("请输入任务名称");
                }
                else
                {
                    string name = taskName.Text;
                    long endtime = todoListService.ConvertDayToLong(endTime.Value, "0000");

                    Tasks task = new Tasks();
                    task.Name = name;
                    task.Id = ParseTool.ParseTaskId(Id, DateTime.Now);
                    task.ExpectTime = endtime;
                    task.UserId = Id;
                    task.Summary = txtDiscription.Text;
                    todoListService.AddTask(task);                    
                    MessageBox.Show("添加成功");
                    cf.GetTask();
                    cf.loadMenu();
                    cf.Show();
                    this.Dispose();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("添加失败");
            }
        }

        private void taskName_Click(object sender, EventArgs e)
        {
            taskName.Text = "";
            taskName.ForeColor = Color.Black;
        }

        private void taskDegree_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscription_Click(object sender, EventArgs e)
        {
            txtDiscription.Text = "";
            txtDiscription.ForeColor = Color.Black;
        }
    }
}
