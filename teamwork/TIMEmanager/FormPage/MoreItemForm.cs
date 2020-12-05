using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIMEmanger.Entity;
using TIMEmanager;
using System.Threading;

namespace TIMEmanger
{
    public partial class MoreItemForm : Form
    {
        string verifyCode;
        string userID;
        string password;
        JiaoWuLogin login;
        List<Tasks> clist;
        public User user;


        public ScheduleService ss = new ScheduleService();

        public MoreItemForm(User user)
        {
            InitializeComponent();
            this.user=user;


        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {
            userID = txtID.Text;
            password = txtPassword.Text;
            login = new JiaoWuLogin(userID, password);
            login.user = user;
            pictureBox1.Image = Image.FromFile("father.jpg");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                verifyCode = txtVerifyCode.Text;
                login.LoginSys2(verifyCode);
                JiaoWuGetCourse ew = new JiaoWuGetCourse();
                ew.user = user;

                clist = ew.GetCourse(login);

                foreach (Tasks c in clist)
                {
                    ss.AddTask(c);

                }
                MessageBox.Show("成功");

            }
            catch(CaptchaErrorException)
            {
                MessageBox.Show("验证码错误", "登陆错误");
            }
            catch (PasswordErrorException)
            {
                MessageBox.Show("用户名/密码错误", "登陆错误");
            }

        }

        private void txtID_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtID.ForeColor = Color.Black;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }
    }
}
