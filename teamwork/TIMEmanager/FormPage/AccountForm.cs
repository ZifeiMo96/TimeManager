using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIMEmanger
{
    public partial class AccountForm : Form
    {
        /// <summary>
        /// 模块名：AccountFrom
        /// 作用：账户界面
        /// 作者：黄诗雯
        /// </summary>



        public AccountForm()
        {
            InitializeComponent();

        }
        MainForm main;
        public AccountForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            main.ChangePageToCenterFrom();

        }
    }
}
