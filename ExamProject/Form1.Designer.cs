namespace ExamProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.groupsButton = new System.Windows.Forms.Button();
            this.lessonsButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lessonsControl1 = new ExamProject.LessonsControl();
            this.studentControl1 = new ExamProject.StudentControl();
            this.homeControl1 = new ExamProject.HomeControl();
            this.teacherControl1 = new ExamProject.TeacherControl();
            this.groupControl1 = new ExamProject.GroupControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.slidePanel);
            this.panel1.Controls.Add(this.groupsButton);
            this.panel1.Controls.Add(this.lessonsButton);
            this.panel1.Controls.Add(this.studentButton);
            this.panel1.Controls.Add(this.teacherButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 572);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.slidePanel.Location = new System.Drawing.Point(0, 74);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(10, 65);
            this.slidePanel.TabIndex = 1;
            // 
            // groupsButton
            // 
            this.groupsButton.FlatAppearance.BorderSize = 0;
            this.groupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupsButton.Image = ((System.Drawing.Image)(resources.GetObject("groupsButton.Image")));
            this.groupsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupsButton.Location = new System.Drawing.Point(12, 346);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(172, 65);
            this.groupsButton.TabIndex = 4;
            this.groupsButton.Text = "Groups";
            this.groupsButton.UseVisualStyleBackColor = true;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // lessonsButton
            // 
            this.lessonsButton.FlatAppearance.BorderSize = 0;
            this.lessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lessonsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lessonsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lessonsButton.Image = ((System.Drawing.Image)(resources.GetObject("lessonsButton.Image")));
            this.lessonsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lessonsButton.Location = new System.Drawing.Point(12, 278);
            this.lessonsButton.Name = "lessonsButton";
            this.lessonsButton.Size = new System.Drawing.Size(172, 65);
            this.lessonsButton.TabIndex = 3;
            this.lessonsButton.Text = "Lessons";
            this.lessonsButton.UseVisualStyleBackColor = true;
            this.lessonsButton.Click += new System.EventHandler(this.lessonsButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.FlatAppearance.BorderSize = 0;
            this.studentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.studentButton.Image = ((System.Drawing.Image)(resources.GetObject("studentButton.Image")));
            this.studentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentButton.Location = new System.Drawing.Point(12, 210);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(172, 65);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "Students";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.FlatAppearance.BorderSize = 0;
            this.teacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherButton.Image = ((System.Drawing.Image)(resources.GetObject("teacherButton.Image")));
            this.teacherButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherButton.Location = new System.Drawing.Point(12, 142);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(172, 65);
            this.teacherButton.TabIndex = 1;
            this.teacherButton.Text = "Teachers";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(12, 74);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(172, 65);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(908, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lessonsControl1);
            this.panel2.Controls.Add(this.studentControl1);
            this.panel2.Controls.Add(this.homeControl1);
            this.panel2.Controls.Add(this.teacherControl1);
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Location = new System.Drawing.Point(183, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 536);
            this.panel2.TabIndex = 2;
            // 
            // lessonsControl1
            // 
            this.lessonsControl1.Location = new System.Drawing.Point(0, 0);
            this.lessonsControl1.Name = "lessonsControl1";
            this.lessonsControl1.Size = new System.Drawing.Size(753, 536);
            this.lessonsControl1.TabIndex = 3;
            // 
            // studentControl1
            // 
            this.studentControl1.Location = new System.Drawing.Point(0, 0);
            this.studentControl1.Name = "studentControl1";
            this.studentControl1.Size = new System.Drawing.Size(753, 536);
            this.studentControl1.TabIndex = 2;
            // 
            // homeControl1
            // 
            this.homeControl1.Location = new System.Drawing.Point(0, 0);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(753, 536);
            this.homeControl1.TabIndex = 0;
            // 
            // teacherControl1
            // 
            this.teacherControl1.Location = new System.Drawing.Point(0, 0);
            this.teacherControl1.Name = "teacherControl1";
            this.teacherControl1.Size = new System.Drawing.Size(753, 536);
            this.teacherControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(753, 536);
            this.groupControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.Button lessonsButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private HomeControl homeControl1;
        private TeacherControl teacherControl1;
        private StudentControl studentControl1;
        private LessonsControl lessonsControl1;
        private GroupControl groupControl1;
    }
}

