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
using TIMEmanager.FormPage;
using TIMEmanger.FormPage;

namespace TIMEmanger
{
    public partial class CalendarForm : Form
    {

        public CalendarService servlet;

        public bool[] isDayButtonVisit;

        public string tyear;

        public string tmonth;

        public string tday;

        public string year;

        public string month;

        public string day;

        public int taskPageNumber;

        public int taskMaxPageNumber;

        public Button[] dayButton;

        public Entity.Tasks[] courseTask;

        public Entity.Tasks[] todoTask;

        public Entity.Tasks[] todoMenu;

        public taskAdd taskAdd;

        public MainForm fm;

        public CalendarForm(MainForm fm)
        {
            InitializeComponent();
            this.fm = fm;
            servlet = new CalendarService();
            isDayButtonVisit = new bool[42];
            dayButton = new Button[42];
            courseTask = new Entity.Tasks[5];
            todoMenu = new Entity.Tasks[3];
            todoTask = new Entity.Tasks[100];
            tyear = DateTime.Now.Year.ToString();
            tmonth = DateTime.Now.Month.ToString();
            tday = DateTime.Now.Day.ToString();
            year = DateTime.Now.Year.ToString();
            month = DateTime.Now.Month.ToString();
            day = DateTime.Now.Day.ToString();
            GetTask();
            taskPageNumber = 0;
            loadMenu();
            LoadButton();
            GetCourseTask();
            UpdateCourse();
            UpdateTodoList();
            initYearComboBox();
            initMonthComboBox();
            GenerateCalendar();
            AddButtonEvent();
            tagToday();
        }

        private void initYearComboBox()
        {
            yearComboBox.Text = year;
            int additem = Int32.Parse(year) - 100;
            for(int i = 0; i < 201; i++)
            {
                yearComboBox.Items.Add(additem);
                additem++;
            }
        }

        private int getTaskNumber()
        {
            int number= 0;
            for(int i = 0; i < 100; i++)
            {
                if (todoTask[i] != null) number++;
            }
            return number;
        }

        public void GetTask()
        {
            todoTask = servlet.getTask(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day), fm.user.Id);
            int number = getTaskNumber();
            if (number <= 0)
            {
                taskMaxPageNumber = 0;
            }
            else
            {
                taskMaxPageNumber = (number-1)/3;
            }
        }

        private void AddButtonEvent()
        {
            for(int  i = 0; i < 42; i++)
            {
                GetButton(i + 1).Click += new EventHandler(SetDate);
                GetButton(i + 1).Click += new EventHandler(BtnUpdate);

            }
        }

        private void SetDate(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            year = yearComboBox.Text;
            month = monthComboBox.Text;
            day = btn.Text;
            tagChoice(btn);
        }

        public void GetCourseTask()
        {
            courseTask = servlet.getCourse(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day),fm.user.Id);

        }

        private void tagToday()
        {
            Button btn;
            for (int i = 1; i <= 42; i++)
            {
                btn = GetButton(i);
                btn.BackColor = Color.FromArgb(255, 244, 244);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = Color.White;
            }
            if (this.year == tyear && this.month == tmonth)
            {
                int year = Int32.Parse(this.year);
                int month = Int32.Parse(this.month);
                int dayOrder = ParseTool.ParseDateToWeek(year, month, 1) + Int32.Parse(tday) - 1;
                btn = GetButton(dayOrder);
                btn.BackColor = Color.LightBlue;
            }
        }
        private void tagChoice(Button btn)
        {
            for (int i = 1; i <= 42; i++)
            {
                Button b = GetButton(i);
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.BorderColor = Color.White;
            }
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.DeepSkyBlue;
        }

        public void UpdateCourse()
        {
            
            Button btn;
            String text = "";
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        btn = class1Button;
                        break;
                    case 1:
                        btn = class2Button;
                        break;
                    case 2:
                        btn = class3Button;
                        break;
                    case 3:
                        btn = class4Button;
                        break;
                    case 4:
                        btn = class5Button;
                        break;
                    default:
                        btn = null;
                        break;
                }
                if (courseTask[i] == null)
                {
                    btn.Text = "";
                    btn.Visible = false;
                    continue;
                }
                text = courseTask[i].Name + "\n" +ParseTool.ParseTime(ParseTool.ParseClassStartToTime(courseTask[i].DairyStartTime), ParseTool.ParseClassEndToTime(courseTask[i].DairyFinishTime)) +"\n" + courseTask[i].Place;
                btn.Text = text;
                btn.Visible = true;
            }
        }

        public void UpdateTodoList()
        {
            Button btn;
            String text = "";
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        btn = TaskButton1;
                        break;
                    case 1:
                        btn = TaskButton2;
                        break;
                    case 2:
                        btn = TaskButton3;
                        break;
                    default:
                        btn = null;
                        break;
                }
                if (todoMenu[i] == null)
                {
                    btn.Text = "";
                    btn.Visible = false;
                    continue;
                }
                text = "任务:"+todoMenu[i].Name + "   DDL:" + ParseTool.ParseIntToDate(todoMenu[i].ExpectTime).ToString("yyyy-MM-dd");
                btn.Text = text;
                btn.Visible = true;
            }

        }

        private void BtnUpdate(object sender, EventArgs e)
        {
            GetCourseTask();
            UpdateCourse();
            GetTask();
            taskPageNumber = 0;
            loadMenu();
        }



        private void initMonthComboBox()
        {
            monthComboBox.Text = month;
            for(int i = 0; i < 12; i++)
            {
                monthComboBox.Items.Add(i + 1);
            }
        }
        
        private void LoadButton()
        {
            
            for(int i = 0; i < 42; i++)
            { 
                string name = "dayButton" + (i + 1);
                Button btn = (Button)this.tableLayoutPanel1.Controls.Find(name, false)[0];
                dayButton[i] = btn;
            }
        }

        private void GenerateCalendar()
        {
            Button btn;
            int year = Int32.Parse(this.year);
            int month = Int32.Parse(this.month);
            int dayNumber = daysInMonth();
            int dayOrder = ParseTool.ParseDateToWeek(year, month, 1);
            for(int i = 1; i < dayOrder; i++)
            {
                btn = GetButton(i);
                btn.Text = "";
                btn.Visible = false;
            }
            for(int i = 1; i <= dayNumber; i++)
            {
                btn = GetButton(dayOrder + i - 1);
                btn.Text = i.ToString();
                btn.Visible = true;
            }
            for(int i = dayOrder + dayNumber; i < 42; i++)
            {
                btn = GetButton(i);
                btn.Text = "";
                btn.Visible = false;
            }
        }

        private Button GetButton(int n)
        {
            return dayButton[n - 1];
        }

        private void todayLightUp()
        {

        }

        private void setYear(int year)
        {
            this.year = year.ToString();
            yearComboBox.Text = this.year;
        }

        private void setMonth(int month)
        {
            this.month = month.ToString();
            monthComboBox.Text = this.month;
        }


        private int daysInMonth()
        {
            int days = 0;
            int year = Int32.Parse(this.year);
            int month = Int32.Parse(this.month);
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:days = 31;break;
                case 4: case 6: case 9: case 11: days = 30; break;
                case 2:
                    if ((year % 100 != 0 && year % 4 == 0) || (year % 400 == 0)) days = 29;
                    else days = 28;
                    break;
                default:
                    days = 0; break;
            }
            return days;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }





        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            month = monthComboBox.Text;
            GenerateCalendar();
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = yearComboBox.Text;
            GenerateCalendar();
        }



        private void class1Button_Click(object sender, EventArgs e)
        {
            CourseShowForm showForm = new CourseShowForm(courseTask[0],this);
            showForm.ShowDialog();
        }

        private void class2Button_Click(object sender, EventArgs e)
        {
            CourseShowForm showForm = new CourseShowForm(courseTask[1],this);
            showForm.ShowDialog();
        }

        private void class3Button_Click(object sender, EventArgs e)
        {
            CourseShowForm showForm = new CourseShowForm(courseTask[2],this);
            showForm.ShowDialog();
        }

        private void class4Button_Click(object sender, EventArgs e)
        {
            CourseShowForm showForm = new CourseShowForm(courseTask[3],this);
            showForm.ShowDialog();
        }

        private void class5Button_Click(object sender, EventArgs e)
        {
            CourseShowForm showForm = new CourseShowForm(courseTask[4],this);
            showForm.ShowDialog();
        }

        private void TaskButton1_Click(object sender, EventArgs e)
        {
            ModifyTask showForm = new ModifyTask(todoMenu[0].Name, fm.user.Id);
            showForm.ShowDialog();
        }

        private void TaskButton2_Click(object sender, EventArgs e)
        {
            ModifyTask showForm = new ModifyTask(todoMenu[1].Name, fm.user.Id);
            showForm.ShowDialog();
        }

        private void TaskButton3_Click(object sender, EventArgs e)
        {
            ModifyTask showForm = new ModifyTask(todoMenu[2].Name, fm.user.Id);
            showForm.ShowDialog();
        }

        private void taskLastPageButton_Click(object sender, EventArgs e)
        {
            if (taskPageNumber-1 >= 0)
            {
                taskPageNumber--;
                loadMenu();
            }

        }

        private void taskNextPageButton_Click(object sender, EventArgs e)
        {
            if (taskPageNumber + 1 <= taskMaxPageNumber)
            {
                taskPageNumber++;
                loadMenu();
            }
            UpdateTodoList();
        }

        public void loadMenu()
        {
            for (int i = 0; i < 3; i++)
            {
                todoMenu[i] = todoTask[i + taskPageNumber * 3];
            }
            String pageNumber = (taskPageNumber + 1) + "/" + (taskMaxPageNumber + 1);
            menuLabel.Text = pageNumber;
            UpdateTodoList();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
            taskAdd = new taskAdd(fm.user.Id,dt,this);
            taskAdd.ShowDialog();
        }

        private void lastMonthButton_Click(object sender, EventArgs e)
        {
            int month = Int32.Parse(this.month);
            int year = Int32.Parse(this.year);
            if (month - 1 <= 0)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }
            setYear(year);
            setMonth(month);
            GenerateCalendar();
            tagToday();
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            int month = Int32.Parse(this.month);
            int year = Int32.Parse(this.year);
            if (month + 1 > 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
            setYear(year);
            setMonth(month);
            GenerateCalendar();
            tagToday();
        }
    }
}
