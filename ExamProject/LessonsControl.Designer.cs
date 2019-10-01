namespace ExamProject
{
    partial class LessonsControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonsControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lessonslabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slidePanel1 = new System.Windows.Forms.Panel();
            this.infoLessonsButton = new System.Windows.Forms.Button();
            this.deleteLessonsButton = new System.Windows.Forms.Button();
            this.addLessonsButton = new System.Windows.Forms.Button();
            this.deleteLessonControl1 = new ExamProject.DeleteLessonControl();
            this.addLessonControl1 = new ExamProject.AddLessonControl();
            this.infoLessonControl1 = new ExamProject.infoLessonControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Lessonslabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 70);
            this.panel1.TabIndex = 3;
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(618, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(132, 67);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 63);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Lessonslabel
            // 
            this.Lessonslabel.AutoSize = true;
            this.Lessonslabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lessonslabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lessonslabel.Location = new System.Drawing.Point(71, 16);
            this.Lessonslabel.Name = "Lessonslabel";
            this.Lessonslabel.Size = new System.Drawing.Size(143, 41);
            this.Lessonslabel.TabIndex = 1;
            this.Lessonslabel.Text = "Lessons";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.slidePanel1);
            this.panel2.Controls.Add(this.infoLessonsButton);
            this.panel2.Controls.Add(this.deleteLessonsButton);
            this.panel2.Controls.Add(this.addLessonsButton);
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 466);
            this.panel2.TabIndex = 4;
            // 
            // slidePanel1
            // 
            this.slidePanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.slidePanel1.Location = new System.Drawing.Point(0, 17);
            this.slidePanel1.Name = "slidePanel1";
            this.slidePanel1.Size = new System.Drawing.Size(13, 70);
            this.slidePanel1.TabIndex = 3;
            // 
            // infoLessonsButton
            // 
            this.infoLessonsButton.FlatAppearance.BorderSize = 0;
            this.infoLessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLessonsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLessonsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infoLessonsButton.Image = ((System.Drawing.Image)(resources.GetObject("infoLessonsButton.Image")));
            this.infoLessonsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoLessonsButton.Location = new System.Drawing.Point(14, 169);
            this.infoLessonsButton.Name = "infoLessonsButton";
            this.infoLessonsButton.Size = new System.Drawing.Size(153, 70);
            this.infoLessonsButton.TabIndex = 2;
            this.infoLessonsButton.Text = "Info";
            this.infoLessonsButton.UseVisualStyleBackColor = true;
            this.infoLessonsButton.Click += new System.EventHandler(this.infoLessonsButton_Click);
            // 
            // deleteLessonsButton
            // 
            this.deleteLessonsButton.FlatAppearance.BorderSize = 0;
            this.deleteLessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLessonsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteLessonsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteLessonsButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteLessonsButton.Image")));
            this.deleteLessonsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteLessonsButton.Location = new System.Drawing.Point(14, 93);
            this.deleteLessonsButton.Name = "deleteLessonsButton";
            this.deleteLessonsButton.Size = new System.Drawing.Size(153, 70);
            this.deleteLessonsButton.TabIndex = 1;
            this.deleteLessonsButton.Text = "Delete";
            this.deleteLessonsButton.UseVisualStyleBackColor = true;
            this.deleteLessonsButton.Click += new System.EventHandler(this.deleteLessonsButton_Click);
            // 
            // addLessonsButton
            // 
            this.addLessonsButton.FlatAppearance.BorderSize = 0;
            this.addLessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLessonsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLessonsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addLessonsButton.Image = ((System.Drawing.Image)(resources.GetObject("addLessonsButton.Image")));
            this.addLessonsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLessonsButton.Location = new System.Drawing.Point(14, 17);
            this.addLessonsButton.Name = "addLessonsButton";
            this.addLessonsButton.Size = new System.Drawing.Size(153, 70);
            this.addLessonsButton.TabIndex = 0;
            this.addLessonsButton.Text = "Add";
            this.addLessonsButton.UseVisualStyleBackColor = true;
            this.addLessonsButton.Click += new System.EventHandler(this.addLessonsButton_Click);
            // 
            // deleteLessonControl1
            // 
            this.deleteLessonControl1.Location = new System.Drawing.Point(167, 70);
            this.deleteLessonControl1.Name = "deleteLessonControl1";
            this.deleteLessonControl1.Size = new System.Drawing.Size(586, 466);
            this.deleteLessonControl1.TabIndex = 6;
            // 
            // addLessonControl1
            // 
            this.addLessonControl1.Location = new System.Drawing.Point(167, 70);
            this.addLessonControl1.Name = "addLessonControl1";
            this.addLessonControl1.Size = new System.Drawing.Size(586, 466);
            this.addLessonControl1.TabIndex = 5;
            // 
            // infoLessonControl1
            // 
            this.infoLessonControl1.Location = new System.Drawing.Point(167, 70);
            this.infoLessonControl1.Name = "infoLessonControl1";
            this.infoLessonControl1.Size = new System.Drawing.Size(586, 466);
            this.infoLessonControl1.TabIndex = 7;
            // 
            // LessonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoLessonControl1);
            this.Controls.Add(this.deleteLessonControl1);
            this.Controls.Add(this.addLessonControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LessonsControl";
            this.Size = new System.Drawing.Size(753, 536);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lessonslabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel slidePanel1;
        private System.Windows.Forms.Button infoLessonsButton;
        private System.Windows.Forms.Button deleteLessonsButton;
        private System.Windows.Forms.Button addLessonsButton;
        private AddLessonControl addLessonControl1;
        private DeleteLessonControl deleteLessonControl1;
        private infoLessonControl infoLessonControl1;
    }
}
