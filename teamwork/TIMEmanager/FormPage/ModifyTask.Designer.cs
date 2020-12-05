namespace TIMEmanager.FormPage
{
    partial class ModifyTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyTask));
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.addTask = new System.Windows.Forms.Button();
            this.taskName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // endTime
            // 
            this.endTime.CalendarFont = new System.Drawing.Font("微软雅黑", 10F);
            this.endTime.Location = new System.Drawing.Point(86, 133);
            this.endTime.Margin = new System.Windows.Forms.Padding(2);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(155, 21);
            this.endTime.TabIndex = 29;
            // 
            // addTask
            // 
            this.addTask.BackColor = System.Drawing.Color.Transparent;
            this.addTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTask.BackgroundImage")));
            this.addTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTask.FlatAppearance.BorderSize = 0;
            this.addTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addTask.ForeColor = System.Drawing.Color.DodgerBlue;
            this.addTask.Location = new System.Drawing.Point(57, 301);
            this.addTask.Margin = new System.Windows.Forms.Padding(2);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(146, 30);
            this.addTask.TabIndex = 28;
            this.addTask.Text = "Modify";
            this.addTask.UseVisualStyleBackColor = false;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // taskName
            // 
            this.taskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskName.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Italic);
            this.taskName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.taskName.Location = new System.Drawing.Point(30, 85);
            this.taskName.Margin = new System.Windows.Forms.Padding(2);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(220, 23);
            this.taskName.TabIndex = 26;
            this.taskName.Text = "TaskName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(72, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Modify Task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "DeadLine";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscription.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Italic);
            this.txtDiscription.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDiscription.Location = new System.Drawing.Point(30, 179);
            this.txtDiscription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(220, 89);
            this.txtDiscription.TabIndex = 31;
            this.txtDiscription.Text = "Discription";
            this.txtDiscription.TextChanged += new System.EventHandler(this.txtDiscription_TextChanged);
            // 
            // ModifyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(314, 378);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ModifyTask";
            this.Text = "ModifyTask";
            this.Load += new System.EventHandler(this.ModifyTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscription;
    }
}