using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMEmanger.FormPage;
using System.Windows.Forms;
using TIMEmanger.Entity;
using TIMEmanger.BO;
using System.Security.Cryptography.X509Certificates;
using TIMEmanager.FormPage;

namespace TIMEmanger
{
    public partial class TodoListForm : Form
    {
        public TodoListService todoListService = new TodoListService();//传入
        public taskAdd taskAdd;
        public ModifyTask modifyTask;
        public Tasks task = new Tasks();
        public TaskBO taskBO = new TaskBO();
        public List<Tasks> allTask;
        public Button[] myTaskButton = new Button[5];
        public int Id;



        public TodoListForm(int id)
        {
            InitializeComponent();

            Id = id;
            myTaskButton[0] = task1;
            myTaskButton[1] = task2;
            myTaskButton[2] = task3;
            myTaskButton[3] = task4;
            myTaskButton[4] = task5;
            allTask = taskBO.SearchAllTask(Id);
            //taskSource1.DataSource =todoListService.Tasks ;
            //Console.WriteLine(todoListService.myTask.First().taskName);
            //taskSource1.DataSource =todoListService.Tasks ;
            //taskName1.Text = todoListService.myTask.First().taskName;
            //Console.WriteLine(allTask.FirstOrDefault().Name);
            //Console.WriteLine(allTask.FirstOrDefault().UserId);

           setText();




            //第一个任务

            //task1.Text = allTask.FirstOrDefault().Name;
            //第二个任务
            /*task2.Text = allTask[1].Name + allTask[1].ExpectTime;
            task3.Text = allTask[2].Name + allTask[2].ExpectTime;
            task4.Text = allTask[3].Name + allTask[3].ExpectTime;
            task5.Text = allTask[4].Name + allTask[4].ExpectTime;*/




        }


        private void TodoList_Load(object sender, EventArgs e)
        {
            setText();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void delete1_Click(object sender, EventArgs e)
        {
            if (task1.Text == null)
            {
                MessageBox.Show("任务为空");


                return;
            }
            else
            {
                todoListService.DeleteTask(task1.Text);
                MessageBox.Show("删除任务："+task1.Text);
                task1.Text = "";

            }
            //todoListService.DeleteTask(task.taskName);
            setText();
            /* try
             {

                 if (taskName1.Text != null)
                 {

                     todoListService.DeleteTask(taskName1.Text);
                     taskName1.Text = null;
                 }
             }
             catch (Exception x)
             {
                 MessageBox.Show("任务不存在");
             }*/
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (taskAdd == null || taskAdd.IsDisposed)
            {
                taskAdd = new taskAdd(Id);
            }
            taskAdd.ShowDialog();
            /*List<Tasks> alltask1 = taskBO.SearchAllTask();
            task2.Text = alltask1[1].Name + alltask1[1].ExpectTime;
            MessageBox.Show(alltask1.Count().ToString());*/
            setText();
        }



        private void taskGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void task1_Click(object sender, EventArgs e)
        {

            modifyTask = new ModifyTask(task1.Text,Id);
            modifyTask.ShowDialog();

        }

        public void setText()
        {
            int num = todoListService.AllCount(Id);
            Console.WriteLine(num);
            allTask = taskBO.SearchAllTask(Id);
            Tasks[] taskList = new Tasks[100];
            for(int i = 0; i < 100; i++)
            {
                if (i < allTask.Count)
                {
                    taskList[i] = allTask[i];
                }
                else{
                    taskList[i] = null;
                }
            }
            int index = int.Parse(label1.Text);
            int rem = -1;
            if ((index - 1) * 5 >= allTask.Count && index > 1)
            {
                index--;
                label1.Text = index.ToString();
            }
            for (int i = 0, j = 0; i < num && j < 5; ++i, ++j)
            {
                if (taskList[i + (index - 1) * 5] == null) continue;
                myTaskButton[j].Text = taskList[i + (index - 1) * 5].Name;
                rem = j + 1;
            }
            while (rem != -1 && rem != 5)
            {
                myTaskButton[rem].Text = null;
                rem++;
            }


        }


        private void next_Click(object sender, EventArgs e)
        {
            int num = todoListService.AllCount(Id);
            int index = int.Parse(label1.Text);
            index++;
            int rem = -1;
            try
            {
                if (num - (index - 1) * 5 > 0)
                {
                    for (int i = 0, j = 0; i < num - (index - 1) * 5 && j < 5; ++i, ++j)
                    {
                        myTaskButton[j].Text = allTask[i + (index - 1) * 5].Name;
                        rem = j + 1;
                    }
                    while (rem != -1 && rem != 5)
                    {
                        myTaskButton[rem].Text = null;
                        rem++;
                    }
                    label1.Text = index.ToString();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("已到达最后一页");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = todoListService.AllCount(Id);
            int index = int.Parse(label1.Text);
            index--;

            try
            {
                for (int i = 0, j = 0; i < num && j < 5; ++i, ++j)
                {
                    myTaskButton[j].Text = allTask[i + (index - 1) * 5].Name;
                }
                label1.Text = index.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("已到达最后一页");
                index--;
            }
        }

        private void task2_Click(object sender, EventArgs e)
        {
            modifyTask = new ModifyTask(task2.Text, Id);
            modifyTask.ShowDialog();
        }

        private void task3_Click(object sender, EventArgs e)
        {
            modifyTask = new ModifyTask(task3.Text, Id);
            modifyTask.ShowDialog();
        }

        private void task4_Click(object sender, EventArgs e)
        {
            modifyTask = new ModifyTask(task4.Text,Id);
            modifyTask.ShowDialog();
        }

        private void task5_Click(object sender, EventArgs e)
        {
            modifyTask = new ModifyTask(task5.Text, Id);
            modifyTask.ShowDialog();
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            if (task2.Text == null)
            {
                MessageBox.Show("任务为空");


                return;
            }
            else
            {
                todoListService.DeleteTask(task2.Text);
                MessageBox.Show("删除任务：" + task2.Text);
                task2.Text = "";
                setText();
            }
        }

        private void delete3_Click(object sender, EventArgs e)
        {
            if (task3.Text == null)
            {
                MessageBox.Show("任务为空");


                return;
            }
            else
            {
                todoListService.DeleteTask(task3.Text);
                MessageBox.Show("删除任务：" + task3.Text);
                task3.Text = "";
                setText();

            }
        }

        private void delete4_Click(object sender, EventArgs e)
        {
            if (task4.Text == null)
            {
                MessageBox.Show("任务为空");


                return;
            }
            else
            {
                todoListService.DeleteTask(task4.Text);
                MessageBox.Show("删除任务：" + task4.Text);
                task4.Text = "";
                setText();
            }
        }

        private void delete5_Click(object sender, EventArgs e)
        {
            if (task5.Text == null)
            {
                MessageBox.Show("任务为空");


                return;
            }
            else
            {
                todoListService.DeleteTask(task5.Text);
                MessageBox.Show("删除任务：" + task5.Text);
                task5.Text = "";
                setText();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (task1.Text == null)
                {
                    MessageBox.Show("任务为空");


                    return;
                }
                else
                {
                    todoListService.DeleteTask(task1.Text);
                    MessageBox.Show("完成任务：" + task1.Text);
                    task1.Text = "";

                }
            }
            checkBox1.Checked = false;
            setText();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (task2.Text == null)
                {
                    MessageBox.Show("任务为空");


                    return;
                }
                else
                {
                    todoListService.DeleteTask(task2.Text);
                    MessageBox.Show("完成任务：" + task2.Text);
                    task1.Text = "";

                }
            }
            checkBox2.Checked = false;
            setText();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                if (task3.Text == null)
                {
                    MessageBox.Show("任务为空");


                    return;
                }
                else
                {
                    todoListService.DeleteTask(task3.Text);
                    MessageBox.Show("完成任务：" + task3.Text);
                    task1.Text = "";

                }
            }
            checkBox3.Checked = false;
            setText();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                if (task4.Text == null)
                {
                    MessageBox.Show("任务为空");


                    return;
                }
                else
                {
                    todoListService.DeleteTask(task4.Text);
                    MessageBox.Show("完成任务：" + task4.Text);
                    task4.Text = "";

                }
            }
            checkBox4.Checked = false;
            setText();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                if (task5.Text == null)
                {
                    MessageBox.Show("任务为空");


                    return;
                }
                else
                {
                    todoListService.DeleteTask(task5.Text);
                    MessageBox.Show("完成任务：" + task5.Text);
                    task5.Text = "";

                }
            }
            checkBox5.Checked = false;
            setText();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (task2.Text == null)
                {
                    MessageBox.Show("任务为空");


                    return;
                }
                else
                {
                    todoListService.DeleteTask(task2.Text);
                    MessageBox.Show("完成任务：" + task2.Text);
                    task1.Text = "";

                }
            }
            checkBox2.Checked = false;
            setText();
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                if (task3.Text == null)
                {
                    MessageBox.Show("任务为空");


                    return;
                }
                else
                {
                    todoListService.DeleteTask(task3.Text);
                    MessageBox.Show("完成任务：" + task3.Text);
                    task1.Text = "";

                }
            }
            checkBox3.Checked = false;
            setText();
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                if (task4.Text == null)
                {
                    MessageBox.Show("任务为空");


                    return;
                }
                else
                {
                    todoListService.DeleteTask(task4.Text);
                    MessageBox.Show("完成任务：" + task4.Text);
                    task4.Text = "";

                }
            }
            checkBox4.Checked = false;
            setText();
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox5.Checked == true)
            {
                if (task5.Text == null)
                {
                    MessageBox.Show("任务为空");


                    return;
                }
                else
                {
                    todoListService.DeleteTask(task5.Text);
                    MessageBox.Show("完成任务：" + task5.Text);
                    task5.Text = "";

                }
            }
            checkBox5.Checked = false;
            setText();
        }
    }
}
