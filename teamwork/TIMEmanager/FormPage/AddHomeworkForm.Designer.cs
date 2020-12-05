namespace TIMEmanager
{
    partial class AddHomeworkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHomeworkForm));
            this.ddlDay = new System.Windows.Forms.DateTimePicker();
            this.lblDead = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlDay
            // 
            this.ddlDay.CalendarFont = new System.Drawing.Font("微软雅黑", 10F);
            this.ddlDay.Location = new System.Drawing.Point(60, 307);
            this.ddlDay.Name = "ddlDay";
            this.ddlDay.Size = new System.Drawing.Size(219, 28);
            this.ddlDay.TabIndex = 1;
            // 
            // lblDead
            // 
            this.lblDead.AutoSize = true;
            this.lblDead.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblDead.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDead.Location = new System.Drawing.Point(208, 265);
            this.lblDead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(95, 27);
            this.lblDead.TabIndex = 15;
            this.lblDead.Text = "Deadline";
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
            this.btnAdd.Location = new System.Drawing.Point(140, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(219, 45);
            this.btnAdd.TabIndex = 4;
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
            this.txtDiscription.Location = new System.Drawing.Point(60, 109);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(385, 127);
            this.txtDiscription.TabIndex = 0;
            this.txtDiscription.Text = "Discription";
            this.txtDiscription.Click += new System.EventHandler(this.txtDiscription_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(94, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add New Homework";
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(296, 307);
            this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(63, 28);
            this.numHour.TabIndex = 2;
            // 
            // numMinute
            // 
            this.numMinute.Location = new System.Drawing.Point(382, 307);
            this.numMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(63, 28);
            this.numMinute.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label.Location = new System.Drawing.Point(363, 308);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(17, 27);
            this.label.TabIndex = 15;
            this.label.Text = ":";
            // 
            // AddHomeworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(503, 439);
            this.Controls.Add(this.numMinute);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.ddlDay);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblDead);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.label1);
            this.Name = "AddHomeworkForm";
            this.Text = "B";
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ddlDay;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.Label label;
    }
}