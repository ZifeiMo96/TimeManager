using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIMEmanger;
using TIMEmanger.BO;

namespace TIMEmanager
{
    public partial class UserCenterFrom : Form
    {
        /// <summary>
        /// 模块名：AccountFrom
        /// 作用：用户中心界面，完成更换头像、用户名、密码
        /// 作者：黄诗雯
        /// </summary>
        
        public MainForm main;
        public UserBO userBO = new UserBO();
        public UserCenterFrom(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            rename.Text = main.user.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (changepassword.Text == confirmPassword.Text)
            {
                if (userBO.updatePwd(main.user.Id, oldPassword.Text, changepassword.Text))
                {                    
                    MessageBox.Show("修改成功");
                    main.ChangePageToAccountFrom();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }                
            }
            else
            {
                MessageBox.Show("再次输入密码不同，请重新输入");
            }          
        }

        ///<summary>
        ///将图片剪切成圆形
        ///</summary>
        ///<param name="img">图片</param>
        ///<param name="rec">矩形类</param>
        ///<param name="size">尺寸</param>
        ///<returns>图片</returns>
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string strPicPath = "";//存储路径
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(openPic.FileName);
                strPicPath = openPic.FileName;
                Image image = Image.FromFile(strPicPath);
                pictureBox1.BackgroundImage = CutEllipse(image, new Rectangle(0, 0, image.Width, image.Height), new Size(image.Width, image.Height));
                main.AccountButton.BackgroundImage = pictureBox1.BackgroundImage;
            }
        }


        private void rename_Click(object sender, EventArgs e)
        {

        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            changepassword.Text = "";           

        }

        private void confirmPassword_Click(object sender, EventArgs e)
        {
            confirmPassword.Text = "";

        }

        private void oldPassword_Click(object sender, EventArgs e)
        {
            oldPassword.Text = "";

        }

        private void oldPassword_TextChanged(object sender, EventArgs e)
        {
            oldPassword.ForeColor = Color.Black;
            oldPassword.PasswordChar = '*';
        }

        private void changepassword_TextChanged(object sender, EventArgs e)
        {
            changepassword.ForeColor = Color.Black;
            changepassword.PasswordChar = '*';
        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {
            confirmPassword.ForeColor = Color.Black;
            confirmPassword.PasswordChar = '*';
        }
    }
}
