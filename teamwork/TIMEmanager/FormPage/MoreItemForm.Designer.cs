namespace TIMEmanger
{
    partial class MoreItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreItemForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerifyCode = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGetCode = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(268, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 56);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(202, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "从教务系统导入课程";
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVerifyCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerifyCode.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Italic);
            this.txtVerifyCode.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtVerifyCode.Location = new System.Drawing.Point(378, 287);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(130, 35);
            this.txtVerifyCode.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(192, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(316, 35);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Italic);
            this.txtID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID.Location = new System.Drawing.Point(192, 169);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(316, 35);
            this.txtID.TabIndex = 9;
            this.txtID.Text = "UserID";
            this.txtID.Click += new System.EventHandler(this.txtID_Click);
            // 
            // btnGetCode
            // 
            this.btnGetCode.BackColor = System.Drawing.Color.Transparent;
            this.btnGetCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetCode.BackgroundImage")));
            this.btnGetCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetCode.FlatAppearance.BorderSize = 0;
            this.btnGetCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCode.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetCode.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGetCode.Location = new System.Drawing.Point(190, 281);
            this.btnGetCode.Name = "btnGetCode";
            this.btnGetCode.Size = new System.Drawing.Size(168, 46);
            this.btnGetCode.TabIndex = 13;
            this.btnGetCode.Text = "获取验证码";
            this.btnGetCode.UseVisualStyleBackColor = false;
            this.btnGetCode.Click += new System.EventHandler(this.btnGetCode_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImport.BackgroundImage")));
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImport.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnImport.Location = new System.Drawing.Point(192, 456);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(316, 65);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "申请导入";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // MoreItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(723, 608);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnGetCode);
            this.Controls.Add(this.txtVerifyCode);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MoreItemForm";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVerifyCode;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGetCode;
        private System.Windows.Forms.Button btnImport;
    }
}