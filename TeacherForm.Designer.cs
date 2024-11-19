namespace DesktopInformationSystem
{
    partial class TeacherForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteteacher_button = new System.Windows.Forms.Button();
            this.clearteacherdata_button = new System.Windows.Forms.Button();
            this.updateteacher_button = new System.Windows.Forms.Button();
            this.addteacher_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_subject2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.teacher_subject1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.teacher_email = new System.Windows.Forms.TextBox();
            this.teacherdata_gridview = new System.Windows.Forms.DataGridView();
            this.teacher_salary = new System.Windows.Forms.TextBox();
            this.teacher_telephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacherdata_gridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teacher Data";
            // 
            // deleteteacher_button
            // 
            this.deleteteacher_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.deleteteacher_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteteacher_button.ForeColor = System.Drawing.Color.White;
            this.deleteteacher_button.Location = new System.Drawing.Point(550, 186);
            this.deleteteacher_button.Name = "deleteteacher_button";
            this.deleteteacher_button.Size = new System.Drawing.Size(80, 40);
            this.deleteteacher_button.TabIndex = 27;
            this.deleteteacher_button.Text = "Delete";
            this.deleteteacher_button.UseVisualStyleBackColor = false;
            this.deleteteacher_button.Click += new System.EventHandler(this.deleteteacher_button_Click);
            // 
            // clearteacherdata_button
            // 
            this.clearteacherdata_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.clearteacherdata_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearteacherdata_button.ForeColor = System.Drawing.Color.White;
            this.clearteacherdata_button.Location = new System.Drawing.Point(450, 186);
            this.clearteacherdata_button.Name = "clearteacherdata_button";
            this.clearteacherdata_button.Size = new System.Drawing.Size(80, 40);
            this.clearteacherdata_button.TabIndex = 26;
            this.clearteacherdata_button.Text = "Clear";
            this.clearteacherdata_button.UseVisualStyleBackColor = false;
            this.clearteacherdata_button.Click += new System.EventHandler(this.clearteacherdata_button_Click);
            // 
            // updateteacher_button
            // 
            this.updateteacher_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.updateteacher_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateteacher_button.ForeColor = System.Drawing.Color.White;
            this.updateteacher_button.Location = new System.Drawing.Point(350, 186);
            this.updateteacher_button.Name = "updateteacher_button";
            this.updateteacher_button.Size = new System.Drawing.Size(80, 40);
            this.updateteacher_button.TabIndex = 25;
            this.updateteacher_button.Text = "Update";
            this.updateteacher_button.UseVisualStyleBackColor = false;
            this.updateteacher_button.Click += new System.EventHandler(this.updateteacher_button_Click);
            // 
            // addteacher_button
            // 
            this.addteacher_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.addteacher_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addteacher_button.ForeColor = System.Drawing.Color.White;
            this.addteacher_button.Location = new System.Drawing.Point(250, 186);
            this.addteacher_button.Name = "addteacher_button";
            this.addteacher_button.Size = new System.Drawing.Size(80, 40);
            this.addteacher_button.TabIndex = 24;
            this.addteacher_button.Text = "Add";
            this.addteacher_button.UseVisualStyleBackColor = false;
            this.addteacher_button.Click += new System.EventHandler(this.addteacher_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telephone:";
            // 
            // teacher_subject2
            // 
            this.teacher_subject2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_subject2.Location = new System.Drawing.Point(699, 141);
            this.teacher_subject2.Name = "teacher_subject2";
            this.teacher_subject2.Size = new System.Drawing.Size(125, 28);
            this.teacher_subject2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(600, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Subject 2:";
            // 
            // teacher_name
            // 
            this.teacher_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_name.Location = new System.Drawing.Point(105, 52);
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(101, 28);
            this.teacher_name.TabIndex = 13;
            // 
            // teacher_subject1
            // 
            this.teacher_subject1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_subject1.Location = new System.Drawing.Point(350, 141);
            this.teacher_subject1.Name = "teacher_subject1";
            this.teacher_subject1.Size = new System.Drawing.Size(196, 28);
            this.teacher_subject1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Subject 1:";
            // 
            // teacher_email
            // 
            this.teacher_email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_email.Location = new System.Drawing.Point(322, 52);
            this.teacher_email.Name = "teacher_email";
            this.teacher_email.Size = new System.Drawing.Size(224, 28);
            this.teacher_email.TabIndex = 15;
            // 
            // teacherdata_gridview
            // 
            this.teacherdata_gridview.AllowUserToAddRows = false;
            this.teacherdata_gridview.AllowUserToDeleteRows = false;
            this.teacherdata_gridview.AllowUserToResizeRows = false;
            this.teacherdata_gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.teacherdata_gridview.CausesValidation = false;
            this.teacherdata_gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherdata_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.teacherdata_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherdata_gridview.EnableHeadersVisualStyles = false;
            this.teacherdata_gridview.Location = new System.Drawing.Point(13, 45);
            this.teacherdata_gridview.Name = "teacherdata_gridview";
            this.teacherdata_gridview.ReadOnly = true;
            this.teacherdata_gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.teacherdata_gridview.RowHeadersVisible = false;
            this.teacherdata_gridview.RowHeadersWidth = 51;
            this.teacherdata_gridview.RowTemplate.Height = 24;
            this.teacherdata_gridview.Size = new System.Drawing.Size(839, 305);
            this.teacherdata_gridview.TabIndex = 0;
            this.teacherdata_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherdata_gridview_CellClick);
            // 
            // teacher_salary
            // 
            this.teacher_salary.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_salary.Location = new System.Drawing.Point(105, 141);
            this.teacher_salary.Name = "teacher_salary";
            this.teacher_salary.Size = new System.Drawing.Size(101, 28);
            this.teacher_salary.TabIndex = 19;
            // 
            // teacher_telephone
            // 
            this.teacher_telephone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_telephone.Location = new System.Drawing.Point(699, 52);
            this.teacher_telephone.Name = "teacher_telephone";
            this.teacher_telephone.Size = new System.Drawing.Size(125, 28);
            this.teacher_telephone.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Salary:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteteacher_button);
            this.panel2.Controls.Add(this.clearteacherdata_button);
            this.panel2.Controls.Add(this.updateteacher_button);
            this.panel2.Controls.Add(this.addteacher_button);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.teacher_subject2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.teacher_name);
            this.panel2.Controls.Add(this.teacher_subject1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.teacher_email);
            this.panel2.Controls.Add(this.teacher_salary);
            this.panel2.Controls.Add(this.teacher_telephone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(17, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 240);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.teacherdata_gridview);
            this.panel1.Location = new System.Drawing.Point(17, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 378);
            this.panel1.TabIndex = 25;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.exit.Location = new System.Drawing.Point(875, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 21);
            this.exit.TabIndex = 27;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherForm";
            this.Size = new System.Drawing.Size(900, 670);
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherdata_gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteteacher_button;
        private System.Windows.Forms.Button clearteacherdata_button;
        private System.Windows.Forms.Button updateteacher_button;
        private System.Windows.Forms.Button addteacher_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_subject2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.TextBox teacher_subject1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teacher_email;
        private System.Windows.Forms.DataGridView teacherdata_gridview;
        private System.Windows.Forms.TextBox teacher_salary;
        private System.Windows.Forms.TextBox teacher_telephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
    }
}
