using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIMEmanger;

namespace TIMEmanager.FormPage
{
    public partial class CourseShowForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public CalendarForm c;

        public TIMEmanger.Entity.Tasks course;

        public CourseShowForm(TIMEmanger.Entity.Tasks t,CalendarForm calendarForm)
        {
            InitializeComponent();
            c = calendarForm;
            course = t;
            nameTextBox.Text = course.Name;
            teacherTextBox.Text = course.TeacherName;
            placeTextBox.Text = course.Place;
            timeTextBox.Text = ParseTool.ParseTime(ParseTool.ParseClassStartToTime(course.DairyStartTime), ParseTool.ParseClassEndToTime(course.DairyFinishTime));
            summaryTextBox.Text = course.Summary;
            bindingSource.DataSource = course;
            summaryTextBox.DataBindings.Add("Text", bindingSource, "Summary");

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            c.UpdateCourse();
            this.Close();
        }

        private void CourseShowForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
