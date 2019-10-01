namespace ExamProject
{
    partial class ForgotPasswordForm
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
            this.emailCodeConfirmControl1 = new ExamProject.EmailCodeConfirmControl();
            this.restore1 = new ExamProject.Restore();
            this.confirmEmailToChangePassword1 = new ExamProject.ConfirmEmailToChangePassword();
            this.SuspendLayout();
            // 
            // emailCodeConfirmControl1
            // 
            this.emailCodeConfirmControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailCodeConfirmControl1.Location = new System.Drawing.Point(0, 0);
            this.emailCodeConfirmControl1.Name = "emailCodeConfirmControl1";
            this.emailCodeConfirmControl1.Size = new System.Drawing.Size(625, 336);
            this.emailCodeConfirmControl1.TabIndex = 2;
            // 
            // restore1
            // 
            this.restore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restore1.Location = new System.Drawing.Point(0, 0);
            this.restore1.Name = "restore1";
            this.restore1.Size = new System.Drawing.Size(625, 336);
            this.restore1.TabIndex = 1;
            // 
            // confirmEmailToChangePassword1
            // 
            this.confirmEmailToChangePassword1.Location = new System.Drawing.Point(0, 0);
            this.confirmEmailToChangePassword1.Name = "confirmEmailToChangePassword1";
            this.confirmEmailToChangePassword1.Size = new System.Drawing.Size(625, 336);
            this.confirmEmailToChangePassword1.TabIndex = 0;
            this.confirmEmailToChangePassword1.Load += new System.EventHandler(this.confirmEmailToChangePassword1_Load);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(625, 336);
            this.Controls.Add(this.confirmEmailToChangePassword1);
            this.Controls.Add(this.emailCodeConfirmControl1);
            this.Controls.Add(this.restore1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.Text = "Send";
            this.ResumeLayout(false);

        }

        #endregion

        private ConfirmEmailToChangePassword confirmEmailToChangePassword1;
        private Restore restore1;
        private EmailCodeConfirmControl emailCodeConfirmControl1;
    }
}