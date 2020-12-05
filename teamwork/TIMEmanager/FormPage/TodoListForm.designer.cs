namespace TIMEmanger
{
    partial class TodoListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoListForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.task2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.delete2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.task5 = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.delete5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.task1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.delete1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.task4 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.delete4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.task3 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.delete3 = new System.Windows.Forms.Button();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.add = new System.Windows.Forms.Button();
            this.deadlineDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgentDegreeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taskSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 318);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.task2);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.delete2);
            this.panel3.Location = new System.Drawing.Point(2, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 58);
            this.panel3.TabIndex = 2;
            // 
            // task2
            // 
            this.task2.BackColor = System.Drawing.Color.PowderBlue;
            this.task2.FlatAppearance.BorderSize = 0;
            this.task2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task2.Location = new System.Drawing.Point(58, 18);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(337, 37);
            this.task2.TabIndex = 4;
            this.task2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.task2.UseVisualStyleBackColor = false;
            this.task2.Click += new System.EventHandler(this.task2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(36, 30);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // delete2
            // 
            this.delete2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete2.BackColor = System.Drawing.Color.Transparent;
            this.delete2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete2.BackgroundImage")));
            this.delete2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete2.FlatAppearance.BorderSize = 0;
            this.delete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete2.ForeColor = System.Drawing.Color.Transparent;
            this.delete2.Location = new System.Drawing.Point(424, 18);
            this.delete2.Margin = new System.Windows.Forms.Padding(2);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(27, 26);
            this.delete2.TabIndex = 0;
            this.delete2.UseVisualStyleBackColor = false;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.task5);
            this.panel5.Controls.Add(this.checkBox5);
            this.panel5.Controls.Add(this.delete5);
            this.panel5.Location = new System.Drawing.Point(2, 254);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(462, 59);
            this.panel5.TabIndex = 1;
            // 
            // task5
            // 
            this.task5.BackColor = System.Drawing.Color.PowderBlue;
            this.task5.FlatAppearance.BorderSize = 0;
            this.task5.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task5.Location = new System.Drawing.Point(59, 11);
            this.task5.Name = "task5";
            this.task5.Size = new System.Drawing.Size(337, 41);
            this.task5.TabIndex = 4;
            this.task5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.task5.UseVisualStyleBackColor = false;
            this.task5.Click += new System.EventHandler(this.task5_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(35, 25);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged_1);
            // 
            // delete5
            // 
            this.delete5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete5.BackColor = System.Drawing.Color.Transparent;
            this.delete5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete5.BackgroundImage")));
            this.delete5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete5.FlatAppearance.BorderSize = 0;
            this.delete5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete5.ForeColor = System.Drawing.Color.Transparent;
            this.delete5.Location = new System.Drawing.Point(424, 18);
            this.delete5.Margin = new System.Windows.Forms.Padding(2);
            this.delete5.Name = "delete5";
            this.delete5.Size = new System.Drawing.Size(27, 26);
            this.delete5.TabIndex = 0;
            this.delete5.UseVisualStyleBackColor = false;
            this.delete5.Click += new System.EventHandler(this.delete5_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.task1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.delete1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 58);
            this.panel1.TabIndex = 0;
            // 
            // task1
            // 
            this.task1.BackColor = System.Drawing.Color.PowderBlue;
            this.task1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task1.Location = new System.Drawing.Point(57, 14);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(339, 35);
            this.task1.TabIndex = 2;
            this.task1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.task1.UseVisualStyleBackColor = false;
            this.task1.Click += new System.EventHandler(this.task1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // delete1
            // 
            this.delete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete1.BackColor = System.Drawing.Color.Transparent;
            this.delete1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete1.BackgroundImage")));
            this.delete1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete1.FlatAppearance.BorderSize = 0;
            this.delete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete1.ForeColor = System.Drawing.Color.Transparent;
            this.delete1.Location = new System.Drawing.Point(424, 18);
            this.delete1.Margin = new System.Windows.Forms.Padding(2);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(27, 26);
            this.delete1.TabIndex = 0;
            this.delete1.UseVisualStyleBackColor = false;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.task4);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.delete4);
            this.panel2.Location = new System.Drawing.Point(2, 191);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 58);
            this.panel2.TabIndex = 1;
            // 
            // task4
            // 
            this.task4.BackColor = System.Drawing.Color.PowderBlue;
            this.task4.FlatAppearance.BorderSize = 0;
            this.task4.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task4.Location = new System.Drawing.Point(58, 10);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(337, 39);
            this.task4.TabIndex = 5;
            this.task4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.task4.UseVisualStyleBackColor = false;
            this.task4.Click += new System.EventHandler(this.task4_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(35, 23);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged_1);
            // 
            // delete4
            // 
            this.delete4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete4.BackColor = System.Drawing.Color.Transparent;
            this.delete4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete4.BackgroundImage")));
            this.delete4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete4.FlatAppearance.BorderSize = 0;
            this.delete4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete4.ForeColor = System.Drawing.Color.Transparent;
            this.delete4.Location = new System.Drawing.Point(424, 16);
            this.delete4.Margin = new System.Windows.Forms.Padding(2);
            this.delete4.Name = "delete4";
            this.delete4.Size = new System.Drawing.Size(27, 26);
            this.delete4.TabIndex = 0;
            this.delete4.UseVisualStyleBackColor = false;
            this.delete4.Click += new System.EventHandler(this.delete4_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.task3);
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Controls.Add(this.delete3);
            this.panel4.Location = new System.Drawing.Point(2, 128);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 58);
            this.panel4.TabIndex = 1;
            // 
            // task3
            // 
            this.task3.BackColor = System.Drawing.Color.PowderBlue;
            this.task3.FlatAppearance.BorderSize = 0;
            this.task3.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task3.Location = new System.Drawing.Point(58, 16);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(338, 39);
            this.task3.TabIndex = 4;
            this.task3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.task3.UseVisualStyleBackColor = false;
            this.task3.Click += new System.EventHandler(this.task3_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(35, 28);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // delete3
            // 
            this.delete3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete3.BackColor = System.Drawing.Color.Transparent;
            this.delete3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete3.BackgroundImage")));
            this.delete3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete3.FlatAppearance.BorderSize = 0;
            this.delete3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete3.ForeColor = System.Drawing.Color.Transparent;
            this.delete3.Location = new System.Drawing.Point(424, 16);
            this.delete3.Margin = new System.Windows.Forms.Padding(2);
            this.delete3.Name = "delete3";
            this.delete3.Size = new System.Drawing.Size(27, 26);
            this.delete3.TabIndex = 0;
            this.delete3.UseVisualStyleBackColor = false;
            this.delete3.Click += new System.EventHandler(this.delete3_Click);
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataSource = this.taskSource1;
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.Transparent;
            this.add.Location = new System.Drawing.Point(436, 354);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(26, 27);
            this.add.TabIndex = 2;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // deadlineDataGridViewTextBoxColumn1
            // 
            this.deadlineDataGridViewTextBoxColumn1.DataPropertyName = "deadline";
            this.deadlineDataGridViewTextBoxColumn1.HeaderText = "deadline";
            this.deadlineDataGridViewTextBoxColumn1.Name = "deadlineDataGridViewTextBoxColumn1";
            // 
            // taskNameDataGridViewTextBoxColumn1
            // 
            this.taskNameDataGridViewTextBoxColumn1.DataPropertyName = "taskName";
            this.taskNameDataGridViewTextBoxColumn1.HeaderText = "taskName";
            this.taskNameDataGridViewTextBoxColumn1.Name = "taskNameDataGridViewTextBoxColumn1";
            // 
            // urgentDegreeDataGridViewTextBoxColumn1
            // 
            this.urgentDegreeDataGridViewTextBoxColumn1.DataPropertyName = "urgentDegree";
            this.urgentDegreeDataGridViewTextBoxColumn1.HeaderText = "urgentDegree";
            this.urgentDegreeDataGridViewTextBoxColumn1.Name = "urgentDegreeDataGridViewTextBoxColumn1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Location = new System.Drawing.Point(154, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.PowderBlue;
            this.next.Location = new System.Drawing.Point(246, 353);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(44, 23);
            this.next.TabIndex = 4;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "1";
            // 
            // taskSource1
            // 
            this.taskSource1.DataSource = typeof(TIMEmanger.TodoListService);
            // 
            // TodoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(482, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TodoListForm";
            this.Text = "TodoList";
            this.Load += new System.EventHandler(this.TodoList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button delete3;
        private System.Windows.Forms.Button delete4;
        private System.Windows.Forms.Button delete5;
        private System.Windows.Forms.BindingSource taskSource1;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgentDegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgentDegreeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button task2;
        private System.Windows.Forms.Button task5;
        private System.Windows.Forms.Button task1;
        private System.Windows.Forms.Button task4;
        private System.Windows.Forms.Button task3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label1;
    }
}