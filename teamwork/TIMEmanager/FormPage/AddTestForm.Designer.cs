namespace TIMEmanager
{
    partial class AddTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTestForm));
            this.numMinuteFrom = new System.Windows.Forms.NumericUpDown();
            this.numHourFrom = new System.Windows.Forms.NumericUpDown();
            this.testTime = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.lblDead = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numHourTo = new System.Windows.Forms.NumericUpDown();
            this.numMinuteTo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuteFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHourFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHourTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuteTo)).BeginInit();
            this.SuspendLayout();
            // 
            // numMinuteFrom
            // 
            this.numMinuteFrom.Location = new System.Drawing.Point(191, 314);
            this.numMinuteFrom.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinuteFrom.Name = "numMinuteFrom";
            this.numMinuteFrom.Size = new System.Drawing.Size(52, 28);
            this.numMinuteFrom.TabIndex = 4;
            // 
            // numHourFrom
            // 
            this.numHourFrom.Location = new System.Drawing.Point(124, 314);
            this.numHourFrom.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHourFrom.Name = "numHourFrom";
            this.numHourFrom.Size = new System.Drawing.Size(51, 28);
            this.numHourFrom.TabIndex = 3;
            // 
            // testTime
            // 
            this.testTime.CalendarFont = new System.Drawing.Font("微软雅黑", 10F);
            this.testTime.Location = new System.Drawing.Point(62, 272);
            this.testTime.Name = "testTime";
            this.testTime.Size = new System.Drawing.Size(338, 28);
            this.testTime.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label.Location = new System.Drawing.Point(175, 314);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(17, 27);
            this.label.TabIndex = 21;
            this.label.Text = ":";
            // 
            // lblDead
            // 
            this.lblDead.AutoSize = true;
            this.lblDead.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblDead.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDead.Location = new System.Drawing.Point(163, 184);
            this.lblDead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(158, 27);
            this.lblDead.TabIndex = 22;
            this.lblDead.Text = "Place And Time";
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
            this.btnAdd.Location = new System.Drawing.Point(114, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(219, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDiscription
            // 
            this.txtDiscription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscription.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Italic);
            this.txtDiscription.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDiscription.Location = new System.Drawing.Point(62, 107);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(338, 58);
            this.txtDiscription.TabIndex = 0;
            this.txtDiscription.Text = "Discription";
            this.txtDiscription.Click += new System.EventHandler(this.txtDiscription_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(117, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add New Test";
            // 
            // txtPlace
            // 
            this.txtPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlace.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Italic);
            this.txtPlace.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPlace.Location = new System.Drawing.Point(62, 224);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(338, 35);
            this.txtPlace.TabIndex = 1;
            this.txtPlace.Text = "Place";
            this.txtPlace.Click += new System.EventHandler(this.txtPlace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(57, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(245, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label4.Location = new System.Drawing.Point(329, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = ":";
            // 
            // numHourTo
            // 
            this.numHourTo.Location = new System.Drawing.Point(278, 314);
            this.numHourTo.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHourTo.Name = "numHourTo";
            this.numHourTo.Size = new System.Drawing.Size(52, 28);
            this.numHourTo.TabIndex = 5;
            // 
            // numMinuteTo
            // 
            this.numMinuteTo.Location = new System.Drawing.Point(347, 314);
            this.numMinuteTo.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinuteTo.Name = "numMinuteTo";
            this.numMinuteTo.Size = new System.Drawing.Size(53, 28);
            this.numMinuteTo.TabIndex = 6;
            // 
            // AddTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(447, 454);
            this.Controls.Add(this.numMinuteTo);
            this.Controls.Add(this.numHourTo);
            this.Controls.Add(this.numMinuteFrom);
            this.Controls.Add(this.numHourFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.testTime);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDead);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.label1);
            this.Name = "AddTestForm";
            this.Text = "AddTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.numMinuteFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHourFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHourTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuteTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numMinuteFrom;
        private System.Windows.Forms.NumericUpDown numHourFrom;
        private System.Windows.Forms.DateTimePicker testTime;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numHourTo;
        private System.Windows.Forms.NumericUpDown numMinuteTo;
    }
}