namespace TIMEmanager
{
    partial class AddScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddScheduleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCoursePlace = new System.Windows.Forms.TextBox();
            this.cmbWeek = new System.Windows.Forms.ComboBox();
            this.txtCourseTeacher = new System.Windows.Forms.TextBox();
            this.cmbCourseStart = new System.Windows.Forms.ComboBox();
            this.cmbCourseEnd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(59, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Course";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCourseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseName.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Italic);
            this.txtCourseName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCourseName.Location = new System.Drawing.Point(34, 81);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(211, 23);
            this.txtCourseName.TabIndex = 0;
            this.txtCourseName.Text = "Description";
            this.txtCourseName.Click += new System.EventHandler(this.txtCourseName_Click_1);
            // 
            // txtCoursePlace
            // 
            this.txtCoursePlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoursePlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoursePlace.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Italic);
            this.txtCoursePlace.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCoursePlace.Location = new System.Drawing.Point(34, 110);
            this.txtCoursePlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCoursePlace.Name = "txtCoursePlace";
            this.txtCoursePlace.Size = new System.Drawing.Size(211, 23);
            this.txtCoursePlace.TabIndex = 1;
            this.txtCoursePlace.Text = "CoursePlace";
            this.txtCoursePlace.Click += new System.EventHandler(this.txtCoursePlace_Click);
            // 
            // cmbWeek
            // 
            this.cmbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbWeek.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmbWeek.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbWeek.FormattingEnabled = true;
            this.cmbWeek.Items.AddRange(new object[] {
            "MON",
            "TUE",
            "WED",
            "THU",
            "FRI",
            "SAT",
            "SUN"});
            this.cmbWeek.Location = new System.Drawing.Point(85, 187);
            this.cmbWeek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbWeek.Name = "cmbWeek";
            this.cmbWeek.Size = new System.Drawing.Size(160, 27);
            this.cmbWeek.TabIndex = 3;
            // 
            // txtCourseTeacher
            // 
            this.txtCourseTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCourseTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseTeacher.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Italic);
            this.txtCourseTeacher.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCourseTeacher.Location = new System.Drawing.Point(34, 139);
            this.txtCourseTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseTeacher.Name = "txtCourseTeacher";
            this.txtCourseTeacher.Size = new System.Drawing.Size(211, 23);
            this.txtCourseTeacher.TabIndex = 2;
            this.txtCourseTeacher.Text = "CourseTeacher";
            this.txtCourseTeacher.Click += new System.EventHandler(this.txtCourseTeacher_Click);
            // 
            // cmbCourseStart
            // 
            this.cmbCourseStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCourseStart.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmbCourseStart.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbCourseStart.FormattingEnabled = true;
            this.cmbCourseStart.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cmbCourseStart.Location = new System.Drawing.Point(122, 222);
            this.cmbCourseStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCourseStart.Name = "cmbCourseStart";
            this.cmbCourseStart.Size = new System.Drawing.Size(44, 27);
            this.cmbCourseStart.TabIndex = 4;
            this.cmbCourseStart.Click += new System.EventHandler(this.cmbCourseStart_Click);
            // 
            // cmbCourseEnd
            // 
            this.cmbCourseEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCourseEnd.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmbCourseEnd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbCourseEnd.FormattingEnabled = true;
            this.cmbCourseEnd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cmbCourseEnd.Location = new System.Drawing.Point(203, 222);
            this.cmbCourseEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCourseEnd.Name = "cmbCourseEnd";
            this.cmbCourseEnd.Size = new System.Drawing.Size(42, 27);
            this.cmbCourseEnd.TabIndex = 5;
            this.cmbCourseEnd.Click += new System.EventHandler(this.cmbCourseEnd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label2.Location = new System.Drawing.Point(30, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "From Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label3.Location = new System.Drawing.Point(173, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "to";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Location = new System.Drawing.Point(63, 325);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label4.Location = new System.Drawing.Point(30, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Week";
            // 
            // endTime
            // 
            this.endTime.CalendarFont = new System.Drawing.Font("微软雅黑", 10F);
            this.endTime.Location = new System.Drawing.Point(79, 293);
            this.endTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(167, 21);
            this.endTime.TabIndex = 7;
            // 
            // startTime
            // 
            this.startTime.CalendarFont = new System.Drawing.Font("微软雅黑", 10F);
            this.startTime.Location = new System.Drawing.Point(79, 266);
            this.startTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(167, 21);
            this.startTime.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label6.Location = new System.Drawing.Point(31, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label5.Location = new System.Drawing.Point(31, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "From";
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(282, 379);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCourseEnd);
            this.Controls.Add(this.cmbCourseStart);
            this.Controls.Add(this.cmbWeek);
            this.Controls.Add(this.txtCourseTeacher);
            this.Controls.Add(this.txtCoursePlace);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddScheduleForm";
            this.Text = "AddScheduleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCoursePlace;
        private System.Windows.Forms.ComboBox cmbWeek;
        private System.Windows.Forms.TextBox txtCourseTeacher;
        private System.Windows.Forms.ComboBox cmbCourseStart;
        private System.Windows.Forms.ComboBox cmbCourseEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}