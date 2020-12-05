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
using TIMEmanger.BO;
using TIMEmanger.Entity;
namespace TIMEmanager.FormPage
{
    public partial class ModifyTask : Form
    {
        public string theTaskName;
        public TaskBO taskBO = new TaskBO();
        public TodoListService todoListService = new TodoListService();
        public Tasks tasks = new Tasks();
        public int Id;
        public ModifyTask(string name, int id)
        {
            try
            {
                InitializeComponent();
                theTaskName = name;
                taskName.Text = theTaskName;
                Id = id;
                tasks = taskBO.searchByName(theTaskName, Id).FirstOrDefault();
                Console.WriteLine(tasks.Summary);
                DateTime date = ParseTool.ParseIntToDate(tasks.ExpectTime);
                endTime.Value = date;
                txtDiscription.Text = tasks.Summary;
            }
            catch(Exception)
            {
                MessageBox.Show("任务不存在");
            }
        }

        private void ModifyTask_Load(object sender, EventArgs e)
        {

        }

        private void addTask_Click(object sender, EventArgs e)
        {
            string name = taskName.Text;
            long endtime = todoListService.ConvertDayToLong(endTime.Value, "0000");

            Tasks task = new Tasks();
            task.Name = name;
            task.ExpectTime = endtime;
            task.UserId = Id;
            task.Summary = txtDiscription.Text;
            todoListService.DeleteTask(name);
            todoListService.AddTask(task);
            
            MessageBox.Show("修改成功");
        }

        private void txtDiscription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
