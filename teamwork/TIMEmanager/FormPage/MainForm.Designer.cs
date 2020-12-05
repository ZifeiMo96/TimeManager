namespace TIMEmanger
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.moreItemButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.todoListButton = new System.Windows.Forms.Button();
            this.clockButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.itePanel = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip.Size = new System.Drawing.Size(556, 27);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip_MouseDown);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.menuPanel.Controls.Add(this.moreItemButton);
            this.menuPanel.Controls.Add(this.scheduleButton);
            this.menuPanel.Controls.Add(this.todoListButton);
            this.menuPanel.Controls.Add(this.clockButton);
            this.menuPanel.Controls.Add(this.calendarButton);
            this.menuPanel.Controls.Add(this.AccountButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 27);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(78, 407);
            this.menuPanel.TabIndex = 1;
            // 
            // moreItemButton
            // 
            this.moreItemButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moreItemButton.BackgroundImage")));
            this.moreItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moreItemButton.FlatAppearance.BorderSize = 0;
            this.moreItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreItemButton.Location = new System.Drawing.Point(10, 341);
            this.moreItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moreItemButton.Name = "moreItemButton";
            this.moreItemButton.Size = new System.Drawing.Size(56, 60);
            this.moreItemButton.TabIndex = 5;
            this.moreItemButton.UseVisualStyleBackColor = true;
            this.moreItemButton.Click += new System.EventHandler(this.moreItemButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.scheduleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scheduleButton.BackgroundImage")));
            this.scheduleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scheduleButton.FlatAppearance.BorderSize = 0;
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleButton.ForeColor = System.Drawing.Color.Black;
            this.scheduleButton.Location = new System.Drawing.Point(10, 276);
            this.scheduleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(56, 60);
            this.scheduleButton.TabIndex = 4;
            this.scheduleButton.UseVisualStyleBackColor = false;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // todoListButton
            // 
            this.todoListButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("todoListButton.BackgroundImage")));
            this.todoListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.todoListButton.FlatAppearance.BorderSize = 0;
            this.todoListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoListButton.Location = new System.Drawing.Point(10, 211);
            this.todoListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.todoListButton.Name = "todoListButton";
            this.todoListButton.Size = new System.Drawing.Size(56, 60);
            this.todoListButton.TabIndex = 3;
            this.todoListButton.UseVisualStyleBackColor = true;
            this.todoListButton.Click += new System.EventHandler(this.todoListButton_Click);
            // 
            // clockButton
            // 
            this.clockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clockButton.BackgroundImage")));
            this.clockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clockButton.FlatAppearance.BorderSize = 0;
            this.clockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clockButton.Location = new System.Drawing.Point(10, 146);
            this.clockButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clockButton.Name = "clockButton";
            this.clockButton.Size = new System.Drawing.Size(56, 60);
            this.clockButton.TabIndex = 2;
            this.clockButton.UseVisualStyleBackColor = true;
            this.clockButton.Click += new System.EventHandler(this.clockButton_Click);
            // 
            // calendarButton
            // 
            this.calendarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calendarButton.BackgroundImage")));
            this.calendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calendarButton.FlatAppearance.BorderSize = 0;
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.Location = new System.Drawing.Point(10, 82);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(56, 60);
            this.calendarButton.TabIndex = 1;
            this.calendarButton.UseVisualStyleBackColor = true;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AccountButton.BackgroundImage")));
            this.AccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AccountButton.FlatAppearance.BorderSize = 0;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Location = new System.Drawing.Point(5, 5);
            this.AccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(68, 72);
            this.AccountButton.TabIndex = 0;
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.BackgroundImageChanged += new System.EventHandler(this.AccountButton_BackgroundImageChanged);
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // itePanel
            // 
            this.itePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.itePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itePanel.ForeColor = System.Drawing.Color.Black;
            this.itePanel.Location = new System.Drawing.Point(78, 27);
            this.itePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itePanel.Name = "itePanel";
            this.itePanel.Size = new System.Drawing.Size(478, 407);
            this.itePanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 434);
            this.Controls.Add(this.itePanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel itePanel;
        private System.Windows.Forms.Button moreItemButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button todoListButton;
        private System.Windows.Forms.Button clockButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        public System.Windows.Forms.Button AccountButton;
    }
}

