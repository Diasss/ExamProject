namespace ExamProject
{
    partial class TeacherControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dismissTeacherButton = new System.Windows.Forms.Button();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.infoTeacherButton = new System.Windows.Forms.Button();
            this.slidePanel1 = new System.Windows.Forms.Panel();
            this.infoTeacherControl1 = new ExamProject.InfoTeacherControl();
            this.dismissTeacherControl1 = new ExamProject.DismissTeacherControl();
            this.addTeacherControl1 = new ExamProject.AddTeacherControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teachers";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.slidePanel1);
            this.panel2.Controls.Add(this.infoTeacherButton);
            this.panel2.Controls.Add(this.dismissTeacherButton);
            this.panel2.Controls.Add(this.addTeacherButton);
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 466);
            this.panel2.TabIndex = 2;
            // 
            // dismissTeacherButton
            // 
            this.dismissTeacherButton.FlatAppearance.BorderSize = 0;
            this.dismissTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dismissTeacherButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dismissTeacherButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dismissTeacherButton.Image = ((System.Drawing.Image)(resources.GetObject("dismissTeacherButton.Image")));
            this.dismissTeacherButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dismissTeacherButton.Location = new System.Drawing.Point(14, 93);
            this.dismissTeacherButton.Name = "dismissTeacherButton";
            this.dismissTeacherButton.Size = new System.Drawing.Size(153, 70);
            this.dismissTeacherButton.TabIndex = 1;
            this.dismissTeacherButton.Text = "Dismiss";
            this.dismissTeacherButton.UseVisualStyleBackColor = true;
            this.dismissTeacherButton.Click += new System.EventHandler(this.dismissTeacherButton_Click);
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.FlatAppearance.BorderSize = 0;
            this.addTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeacherButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeacherButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addTeacherButton.Image = ((System.Drawing.Image)(resources.GetObject("addTeacherButton.Image")));
            this.addTeacherButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTeacherButton.Location = new System.Drawing.Point(14, 17);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(153, 70);
            this.addTeacherButton.TabIndex = 0;
            this.addTeacherButton.Text = "Add";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // infoTeacherButton
            // 
            this.infoTeacherButton.FlatAppearance.BorderSize = 0;
            this.infoTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoTeacherButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTeacherButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infoTeacherButton.Image = ((System.Drawing.Image)(resources.GetObject("infoTeacherButton.Image")));
            this.infoTeacherButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoTeacherButton.Location = new System.Drawing.Point(14, 169);
            this.infoTeacherButton.Name = "infoTeacherButton";
            this.infoTeacherButton.Size = new System.Drawing.Size(153, 70);
            this.infoTeacherButton.TabIndex = 2;
            this.infoTeacherButton.Text = "Info";
            this.infoTeacherButton.UseVisualStyleBackColor = true;
            this.infoTeacherButton.Click += new System.EventHandler(this.infoTeacherButton_Click);
            // 
            // slidePanel1
            // 
            this.slidePanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.slidePanel1.Location = new System.Drawing.Point(0, 17);
            this.slidePanel1.Name = "slidePanel1";
            this.slidePanel1.Size = new System.Drawing.Size(13, 70);
            this.slidePanel1.TabIndex = 3;
            // 
            // infoTeacherControl1
            // 
            this.infoTeacherControl1.Location = new System.Drawing.Point(167, 70);
            this.infoTeacherControl1.Name = "infoTeacherControl1";
            this.infoTeacherControl1.Size = new System.Drawing.Size(586, 466);
            this.infoTeacherControl1.TabIndex = 5;
            // 
            // dismissTeacherControl1
            // 
            this.dismissTeacherControl1.Location = new System.Drawing.Point(167, 70);
            this.dismissTeacherControl1.Name = "dismissTeacherControl1";
            this.dismissTeacherControl1.Size = new System.Drawing.Size(586, 466);
            this.dismissTeacherControl1.TabIndex = 4;
            // 
            // addTeacherControl1
            // 
            this.addTeacherControl1.Location = new System.Drawing.Point(167, 70);
            this.addTeacherControl1.Name = "addTeacherControl1";
            this.addTeacherControl1.Size = new System.Drawing.Size(586, 466);
            this.addTeacherControl1.TabIndex = 3;
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
            // TeacherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoTeacherControl1);
            this.Controls.Add(this.dismissTeacherControl1);
            this.Controls.Add(this.addTeacherControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherControl";
            this.Size = new System.Drawing.Size(753, 536);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dismissTeacherButton;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Panel slidePanel1;
        private System.Windows.Forms.Button infoTeacherButton;
        private AddTeacherControl addTeacherControl1;
        private DismissTeacherControl dismissTeacherControl1;
        private InfoTeacherControl infoTeacherControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
