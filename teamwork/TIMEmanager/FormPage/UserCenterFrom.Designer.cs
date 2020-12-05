namespace TIMEmanager
{
    partial class UserCenterFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCenterFrom));
            this.button1 = new System.Windows.Forms.Button();
            this.changepassword = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.rename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openPic = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.oldPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(304, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 20;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changepassword
            // 
            this.changepassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changepassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changepassword.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changepassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.changepassword.Location = new System.Drawing.Point(316, 331);
            this.changepassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changepassword.Name = "changepassword";
            this.changepassword.Size = new System.Drawing.Size(231, 31);
            this.changepassword.TabIndex = 19;
            this.changepassword.Text = " Password";
            this.changepassword.Click += new System.EventHandler(this.changepassword_Click);
            this.changepassword.TextChanged += new System.EventHandler(this.changepassword_TextChanged);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPassword.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmPassword.Location = new System.Drawing.Point(316, 377);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(231, 31);
            this.confirmPassword.TabIndex = 18;
            this.confirmPassword.Text = " Password";
            this.confirmPassword.Click += new System.EventHandler(this.confirmPassword_Click);
            this.confirmPassword.TextChanged += new System.EventHandler(this.confirmPassword_TextChanged);
            // 
            // rename
            // 
            this.rename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rename.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rename.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.rename.Location = new System.Drawing.Point(316, 239);
            this.rename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rename.Name = "rename";
            this.rename.ReadOnly = true;
            this.rename.Size = new System.Drawing.Size(231, 31);
            this.rename.TabIndex = 17;
            this.rename.Text = " Username";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线 Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "用户名";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(239, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openPic
            // 
            this.openPic.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线 Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "请输入新密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("等线 Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "请确认新密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("等线 Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "请输入旧密码";
            // 
            // oldPassword
            // 
            this.oldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldPassword.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.oldPassword.Location = new System.Drawing.Point(316, 285);
            this.oldPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(231, 31);
            this.oldPassword.TabIndex = 24;
            this.oldPassword.Text = " OldPassword";
            this.oldPassword.Click += new System.EventHandler(this.oldPassword_Click);
            this.oldPassword.TextChanged += new System.EventHandler(this.oldPassword_TextChanged);
            // 
            // UserCenterFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(643, 507);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changepassword);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserCenterFrom";
            this.Text = "UserCenterFrom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox changepassword;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox rename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oldPassword;
    }
}