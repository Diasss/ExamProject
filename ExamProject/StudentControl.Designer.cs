namespace ExamProject
{
    partial class StudentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slidePanel1 = new System.Windows.Forms.Panel();
            this.infoStudentButton = new System.Windows.Forms.Button();
            this.dismissStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addStudentControl1 = new ExamProject.AddStudentControl();
            this.dismissStudentControl1 = new ExamProject.dismissStudentControl();
            this.infoStudentControl1 = new ExamProject.InfoStudentControl();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 70);
            this.panel1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.slidePanel1);
            this.panel2.Controls.Add(this.infoStudentButton);
            this.panel2.Controls.Add(this.dismissStudentButton);
            this.panel2.Controls.Add(this.addStudentButton);
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 466);
            this.panel2.TabIndex = 3;
            // 
            // slidePanel1
            // 
            this.slidePanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.slidePanel1.Location = new System.Drawing.Point(0, 17);
            this.slidePanel1.Name = "slidePanel1";
            this.slidePanel1.Size = new System.Drawing.Size(13, 70);
            this.slidePanel1.TabIndex = 3;
            // 
            // infoStudentButton
            // 
            this.infoStudentButton.FlatAppearance.BorderSize = 0;
            this.infoStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoStudentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoStudentButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infoStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("infoStudentButton.Image")));
            this.infoStudentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoStudentButton.Location = new System.Drawing.Point(14, 169);
            this.infoStudentButton.Name = "infoStudentButton";
            this.infoStudentButton.Size = new System.Drawing.Size(153, 70);
            this.infoStudentButton.TabIndex = 2;
            this.infoStudentButton.Text = "Info";
            this.infoStudentButton.UseVisualStyleBackColor = true;
            this.infoStudentButton.Click += new System.EventHandler(this.infoStudentButton_Click);
            // 
            // dismissStudentButton
            // 
            this.dismissStudentButton.FlatAppearance.BorderSize = 0;
            this.dismissStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dismissStudentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dismissStudentButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dismissStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("dismissStudentButton.Image")));
            this.dismissStudentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dismissStudentButton.Location = new System.Drawing.Point(14, 93);
            this.dismissStudentButton.Name = "dismissStudentButton";
            this.dismissStudentButton.Size = new System.Drawing.Size(153, 70);
            this.dismissStudentButton.TabIndex = 1;
            this.dismissStudentButton.Text = "Dismiss";
            this.dismissStudentButton.UseVisualStyleBackColor = true;
            this.dismissStudentButton.Click += new System.EventHandler(this.dismissStudentButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.FlatAppearance.BorderSize = 0;
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudentButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("addStudentButton.Image")));
            this.addStudentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudentButton.Location = new System.Drawing.Point(14, 17);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(153, 70);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // addStudentControl1
            // 
            this.addStudentControl1.Location = new System.Drawing.Point(167, 70);
            this.addStudentControl1.Name = "addStudentControl1";
            this.addStudentControl1.Size = new System.Drawing.Size(586, 466);
            this.addStudentControl1.TabIndex = 4;
            // 
            // dismissStudentControl1
            // 
            this.dismissStudentControl1.Location = new System.Drawing.Point(167, 70);
            this.dismissStudentControl1.Name = "dismissStudentControl1";
            this.dismissStudentControl1.Size = new System.Drawing.Size(586, 466);
            this.dismissStudentControl1.TabIndex = 5;
            // 
            // infoStudentControl1
            // 
            this.infoStudentControl1.Location = new System.Drawing.Point(167, 70);
            this.infoStudentControl1.Name = "infoStudentControl1";
            this.infoStudentControl1.Size = new System.Drawing.Size(586, 466);
            this.infoStudentControl1.TabIndex = 6;
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.infoStudentControl1);
            this.Controls.Add(this.dismissStudentControl1);
            this.Controls.Add(this.addStudentControl1);
            this.Name = "StudentControl";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel slidePanel1;
        private System.Windows.Forms.Button infoStudentButton;
        private System.Windows.Forms.Button dismissStudentButton;
        private System.Windows.Forms.Button addStudentButton;
        private AddStudentControl addStudentControl1;
        private dismissStudentControl dismissStudentControl1;
        private InfoStudentControl infoStudentControl1;
    }
}
