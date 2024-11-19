namespace DesktopInformationSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.student_button = new System.Windows.Forms.Button();
            this.teacher_button = new System.Windows.Forms.Button();
            this.admin_button = new System.Windows.Forms.Button();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dasboardForm1 = new DesktopInformationSystem.DashboardForm();
            this.adminForm1 = new DesktopInformationSystem.AdminForm();
            this.teacherForm1 = new DesktopInformationSystem.TeacherForm();
            this.studentForm1 = new DesktopInformationSystem.StudentForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.student_button);
            this.panel1.Controls.Add(this.teacher_button);
            this.panel1.Controls.Add(this.admin_button);
            this.panel1.Controls.Add(this.dashboard_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 670);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ROYCE.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(107, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // student_button
            // 
            this.student_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_button.Location = new System.Drawing.Point(84, 456);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(125, 33);
            this.student_button.TabIndex = 9;
            this.student_button.Text = "Student";
            this.student_button.UseVisualStyleBackColor = true;
            this.student_button.Click += new System.EventHandler(this.student_button_Click);
            // 
            // teacher_button
            // 
            this.teacher_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_button.Location = new System.Drawing.Point(84, 403);
            this.teacher_button.Name = "teacher_button";
            this.teacher_button.Size = new System.Drawing.Size(125, 33);
            this.teacher_button.TabIndex = 8;
            this.teacher_button.Text = "Teacher";
            this.teacher_button.UseVisualStyleBackColor = true;
            this.teacher_button.Click += new System.EventHandler(this.teacher_button_Click);
            // 
            // admin_button
            // 
            this.admin_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_button.Location = new System.Drawing.Point(84, 352);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(125, 33);
            this.admin_button.TabIndex = 7;
            this.admin_button.Text = "Admin";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_button.Location = new System.Drawing.Point(84, 300);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(125, 33);
            this.dashboard_button.TabIndex = 6;
            this.dashboard_button.Text = "Dashboard";
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desktop Information System";
            // 
            // dasboardForm1
            // 
            this.dasboardForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.dasboardForm1.Location = new System.Drawing.Point(303, 0);
            this.dasboardForm1.Name = "dasboardForm1";
            this.dasboardForm1.Size = new System.Drawing.Size(900, 670);
            this.dasboardForm1.TabIndex = 5;

            // 
            // adminForm1
            // 
            this.adminForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.adminForm1.Location = new System.Drawing.Point(303, 0);
            this.adminForm1.Name = "adminForm1";
            this.adminForm1.Size = new System.Drawing.Size(900, 670);
            this.adminForm1.TabIndex = 3;
            // 
            // teacherForm1
            // 
            this.teacherForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.teacherForm1.Location = new System.Drawing.Point(303, 0);
            this.teacherForm1.Name = "teacherForm1";
            this.teacherForm1.Size = new System.Drawing.Size(900, 670);
            this.teacherForm1.TabIndex = 2;
            // 
            // studentForm1
            // 
            this.studentForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.studentForm1.Location = new System.Drawing.Point(303, 0);
            this.studentForm1.Name = "studentForm1";
            this.studentForm1.Size = new System.Drawing.Size(900, 670);
            this.studentForm1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 670);
            this.Controls.Add(this.dasboardForm1);
            this.Controls.Add(this.adminForm1);
            this.Controls.Add(this.teacherForm1);
            this.Controls.Add(this.studentForm1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button student_button;
        private System.Windows.Forms.Button teacher_button;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Label label1;
        private DesktopInformationSystem.StudentForm studentForm1;
        private DesktopInformationSystem.TeacherForm teacherForm1;
        private DesktopInformationSystem.AdminForm adminForm1;
        private DesktopInformationSystem.DashboardForm dasboardForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}