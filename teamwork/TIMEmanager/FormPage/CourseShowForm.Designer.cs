namespace TIMEmanager.FormPage
{
    partial class CourseShowForm
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.teacherTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 120);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(94, 170);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "备注";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "上课地点";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "上课时间";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Location = new System.Drawing.Point(3, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 30);
            this.label.TabIndex = 3;
            this.label.Text = "授课教师";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(103, 2);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(161, 25);
            this.nameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "课程名";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.summaryTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.placeTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.timeTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.teacherTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 45);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 290);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryTextBox.Location = new System.Drawing.Point(103, 122);
            this.summaryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.Size = new System.Drawing.Size(161, 166);
            this.summaryTextBox.TabIndex = 11;
            // 
            // placeTextBox
            // 
            this.placeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeTextBox.Location = new System.Drawing.Point(103, 92);
            this.placeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.ReadOnly = true;
            this.placeTextBox.Size = new System.Drawing.Size(161, 25);
            this.placeTextBox.TabIndex = 10;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeTextBox.Location = new System.Drawing.Point(103, 62);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(161, 25);
            this.timeTextBox.TabIndex = 9;
            // 
            // teacherTextBox
            // 
            this.teacherTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherTextBox.Location = new System.Drawing.Point(103, 32);
            this.teacherTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherTextBox.Name = "teacherTextBox";
            this.teacherTextBox.ReadOnly = true;
            this.teacherTextBox.Size = new System.Drawing.Size(161, 25);
            this.teacherTextBox.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(120, 343);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(99, 32);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "关闭";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(344, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // CourseShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(344, 388);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CourseShowForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CourseShowForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox teacherTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}