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
using TIMEmanger.Entity;
using TIMEmanger.BO;

namespace TIMEmanger
{
    public partial class LoginForm : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public User user;
        public UserBO userBO = new UserBO();
        public int Id;
        public string IdStr;
        public string Pwd;



        public LoginForm()
        {
            InitializeComponent();
            userBO.creatUserTable();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            IdStr = txtUsername.Text;
            Pwd = txtPassword.Text;
            //try
            {

                if (CheckUserAndPwd(IdStr, Pwd))
                {
                    MainForm main = new MainForm(this.user);
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("密码错误，请重新输入");
                }
            }/*
            catch (Exception)
            {
                MessageBox.Show("格式错误，请重新输入");
            }*/
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStrip_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private bool CheckUserAndPwd(string id, string pwd)
         {
            if (userBO.SearchForUserExistsByName(id))
            {
                user = userBO.SearchForUserByName(id);
                if (user.Pwd == pwd)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {

                user = new User(getId(),id, pwd);
                userBO.addUser(user);
                return true;
            }

        }

        private int getId()
        {
            for(int i = 1000; i < 10000; i++)
            {
                if (!userBO.SearchForUserExistsByID(i))
                    return i;
            }
            return 1000;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            /*
            try { Id = int.Parse(txtUsername.Text); }
            catch (Exception)
            {
                MessageBox.Show("格式错误，请重新输入");
            }*/
            txtUsername.ForeColor = Color.Black;

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.PasswordChar = '*';
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
