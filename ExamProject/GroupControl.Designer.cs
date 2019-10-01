namespace ExamProject
{
    partial class GroupControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slidePanel1 = new System.Windows.Forms.Panel();
            this.infoGroupButton = new System.Windows.Forms.Button();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.infoGroupControl1 = new ExamProject.InfoGroupControl();
            this.deleteGroupControl1 = new ExamProject.DeleteGroupControl();
            this.addGroupControl1 = new ExamProject.AddGroupControl();
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
            this.label1.Size = new System.Drawing.Size(139, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Groups";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.slidePanel1);
            this.panel2.Controls.Add(this.infoGroupButton);
            this.panel2.Controls.Add(this.deleteGroupButton);
            this.panel2.Controls.Add(this.addGroupButton);
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
            // infoGroupButton
            // 
            this.infoGroupButton.FlatAppearance.BorderSize = 0;
            this.infoGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoGroupButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoGroupButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infoGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("infoGroupButton.Image")));
            this.infoGroupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoGroupButton.Location = new System.Drawing.Point(14, 169);
            this.infoGroupButton.Name = "infoGroupButton";
            this.infoGroupButton.Size = new System.Drawing.Size(153, 70);
            this.infoGroupButton.TabIndex = 2;
            this.infoGroupButton.Text = "Info";
            this.infoGroupButton.UseVisualStyleBackColor = true;
            this.infoGroupButton.Click += new System.EventHandler(this.infoGroupButton_Click);
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.FlatAppearance.BorderSize = 0;
            this.deleteGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGroupButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteGroupButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteGroupButton.Image")));
            this.deleteGroupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteGroupButton.Location = new System.Drawing.Point(14, 93);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(153, 70);
            this.deleteGroupButton.TabIndex = 1;
            this.deleteGroupButton.Text = "Delete";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // addGroupButton
            // 
            this.addGroupButton.FlatAppearance.BorderSize = 0;
            this.addGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGroupButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGroupButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("addGroupButton.Image")));
            this.addGroupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addGroupButton.Location = new System.Drawing.Point(14, 17);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(153, 70);
            this.addGroupButton.TabIndex = 0;
            this.addGroupButton.Text = "Add";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // infoGroupControl1
            // 
            this.infoGroupControl1.Location = new System.Drawing.Point(167, 70);
            this.infoGroupControl1.Name = "infoGroupControl1";
            this.infoGroupControl1.Size = new System.Drawing.Size(586, 466);
            this.infoGroupControl1.TabIndex = 6;
            // 
            // deleteGroupControl1
            // 
            this.deleteGroupControl1.Location = new System.Drawing.Point(167, 70);
            this.deleteGroupControl1.Name = "deleteGroupControl1";
            this.deleteGroupControl1.Size = new System.Drawing.Size(586, 466);
            this.deleteGroupControl1.TabIndex = 5;
            // 
            // addGroupControl1
            // 
            this.addGroupControl1.Location = new System.Drawing.Point(167, 70);
            this.addGroupControl1.Name = "addGroupControl1";
            this.addGroupControl1.Size = new System.Drawing.Size(586, 466);
            this.addGroupControl1.TabIndex = 4;
            // 
            // GroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteGroupControl1);
            this.Controls.Add(this.addGroupControl1);
            this.Controls.Add(this.infoGroupControl1);
            this.Name = "GroupControl";
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
        private System.Windows.Forms.Button infoGroupButton;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.Button addGroupButton;
        private AddGroupControl addGroupControl1;
        private DeleteGroupControl deleteGroupControl1;
        private InfoGroupControl infoGroupControl1;
    }
}
