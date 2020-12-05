using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIMEmanger.FormPage;
using TIMEmanger.BO;
using TIMEmanger.Entity;

namespace TIMEmanger
{
    public partial class ClockForm : Form
    {
        bool counting;
        long TimeCount;
        System.Timers.Timer Mytimer;
        public delegate void SetControlValue(long value);
        public TodoListService todoListService = new TodoListService();
        public taskAdd taskAdd;
        List<Tasks> allTask;
        public int Id;
        public ClockForm(int id)
        {
            InitializeComponent();
            Image image = pictureBox1.Image;
            this.pictureBox1.Image = CutEllipse(image, new Rectangle(0, 0, image.Width, image.Height), new Size(image.Width, image.Height));
            counting = false;
            Id = id;
            taskBindingSource1.DataSource = todoListService;
           
            label1.Parent = pictureBox1;
            label1.Location = new Point(35, 70);
            SearchAll();


        }

        private Image CutEllipse(Image img, Rectangle rec, Size size)
        {

            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (TextureBrush br = new TextureBrush(img, System.Drawing.Drawing2D.WrapMode.Clamp, rec))
                {
                    br.ScaleTransform(bitmap.Width / (float)rec.Width, bitmap.Height / (float)rec.Height);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.FillEllipse(br, new Rectangle(Point.Empty, size));
                }
            }
            return bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clock_Load(object sender, EventArgs e)
        {
            int interval = 1000;
            SearchAll();
            Mytimer = new System.Timers.Timer(interval);
            //设置重复计时
            Mytimer.AutoReset = true;
            Mytimer.Elapsed += new System.Timers.ElapsedEventHandler(Mytimer_tick);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!counting) // counting为假开始计时
            {
                try
                {
                    TimeCount = int.Parse(timeSet.Text) * 60;
                }
                catch (FormatException)
                {
                    MessageBox.Show("请输入正确的时间格式");
                }
                Mytimer.Start();
                counting = true;

            }
            else
            {
                Mytimer.Stop();
                label1.Text = "";
                counting = false;
            }
        }
        private void Mytimer_tick(object sender, System.Timers.ElapsedEventArgs e)
        { 
            if (TimeCount >= 0) { 
            this.Invoke(new SetControlValue(ShowTime), TimeCount);
            TimeCount--;
            }
            else
            {
                Mytimer.Stop();
                TimeCount = 0;
                MessageBox.Show("真棒，你已经达成了一个番茄任务");
            }


        }
        private void ShowTime(long t)
        {
            TimeSpan temp = new TimeSpan(0, 0, (int)t);
            label1.Text = string.Format("{0:00}:{1:00}:{2:00}", temp.Hours, temp.Minutes, temp.Seconds);
            //timerText.Text = "132";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (taskAdd == null || taskAdd.IsDisposed)
            {
                taskAdd = new taskAdd(Id);
            }
            taskAdd.ShowDialog();
            allTask = todoListService.SearchAll(Id);
            comboBox1.DataSource = allTask;
        }
        public void SearchAll()
        {
            comboBox1.Refresh();
            allTask = todoListService.SearchAll(Id);
            comboBox1.DataSource = allTask;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timerText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
