namespace DesktopInformationSystem
{
    partial class StudentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.studentdata_gridview = new System.Windows.Forms.DataGridView();
            this.deletestudent_button = new System.Windows.Forms.Button();
            this.clearstudent_button = new System.Windows.Forms.Button();
            this.updatestudent_button = new System.Windows.Forms.Button();
            this.addstudent_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.student_pss2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.student_email = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.student_cs1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.student_cs2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.student_pss1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_telephone = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdata_gridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.studentdata_gridview);
            this.panel1.Location = new System.Drawing.Point(17, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 378);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Data";
            // 
            // studentdata_gridview
            // 
            this.studentdata_gridview.AllowUserToAddRows = false;
            this.studentdata_gridview.AllowUserToDeleteRows = false;
            this.studentdata_gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.studentdata_gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentdata_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentdata_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentdata_gridview.EnableHeadersVisualStyles = false;
            this.studentdata_gridview.Location = new System.Drawing.Point(13, 45);
            this.studentdata_gridview.Name = "studentdata_gridview";
            this.studentdata_gridview.ReadOnly = true;
            this.studentdata_gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.studentdata_gridview.RowHeadersVisible = false;
            this.studentdata_gridview.RowHeadersWidth = 51;
            this.studentdata_gridview.RowTemplate.Height = 24;
            this.studentdata_gridview.Size = new System.Drawing.Size(839, 305);
            this.studentdata_gridview.TabIndex = 0;
            this.studentdata_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentdata_gridview_CellClick);
            // 
            // deletestudent_button
            // 
            this.deletestudent_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.deletestudent_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletestudent_button.ForeColor = System.Drawing.Color.White;
            this.deletestudent_button.Location = new System.Drawing.Point(550, 186);
            this.deletestudent_button.Name = "deletestudent_button";
            this.deletestudent_button.Size = new System.Drawing.Size(80, 40);
            this.deletestudent_button.TabIndex = 27;
            this.deletestudent_button.Text = "Delete";
            this.deletestudent_button.UseVisualStyleBackColor = false;
            this.deletestudent_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clearstudent_button
            // 
            this.clearstudent_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.clearstudent_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearstudent_button.ForeColor = System.Drawing.Color.White;
            this.clearstudent_button.Location = new System.Drawing.Point(450, 186);
            this.clearstudent_button.Name = "clearstudent_button";
            this.clearstudent_button.Size = new System.Drawing.Size(80, 40);
            this.clearstudent_button.TabIndex = 26;
            this.clearstudent_button.Text = "Clear";
            this.clearstudent_button.UseVisualStyleBackColor = false;
            this.clearstudent_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // updatestudent_button
            // 
            this.updatestudent_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.updatestudent_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatestudent_button.ForeColor = System.Drawing.Color.White;
            this.updatestudent_button.Location = new System.Drawing.Point(350, 186);
            this.updatestudent_button.Name = "updatestudent_button";
            this.updatestudent_button.Size = new System.Drawing.Size(80, 40);
            this.updatestudent_button.TabIndex = 25;
            this.updatestudent_button.Text = "Update";
            this.updatestudent_button.UseVisualStyleBackColor = false;
            this.updatestudent_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // addstudent_button
            // 
            this.addstudent_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.addstudent_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstudent_button.ForeColor = System.Drawing.Color.White;
            this.addstudent_button.Location = new System.Drawing.Point(250, 186);
            this.addstudent_button.Name = "addstudent_button";
            this.addstudent_button.Size = new System.Drawing.Size(80, 40);
            this.addstudent_button.TabIndex = 24;
            this.addstudent_button.Text = "Add";
            this.addstudent_button.UseVisualStyleBackColor = false;
            this.addstudent_button.Click += new System.EventHandler(this.add_button_Click);
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
            // student_pss2
            // 
            this.student_pss2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_pss2.Location = new System.Drawing.Point(723, 141);
            this.student_pss2.Name = "student_pss2";
            this.student_pss2.Size = new System.Drawing.Size(105, 28);
            this.student_pss2.TabIndex = 23;
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
            this.label7.Location = new System.Drawing.Point(457, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Previously Studied Subjects 2:";
            // 
            // student_name
            // 
            this.student_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(105, 52);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(101, 28);
            this.student_name.TabIndex = 13;
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
            // student_email
            // 
            this.student_email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_email.Location = new System.Drawing.Point(322, 52);
            this.student_email.Name = "student_email";
            this.student_email.Size = new System.Drawing.Size(224, 28);
            this.student_email.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.student_cs1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.student_cs2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.student_pss1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.deletestudent_button);
            this.panel2.Controls.Add(this.clearstudent_button);
            this.panel2.Controls.Add(this.updatestudent_button);
            this.panel2.Controls.Add(this.addstudent_button);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.student_pss2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.student_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.student_email);
            this.panel2.Controls.Add(this.student_telephone);
            this.panel2.Location = new System.Drawing.Point(17, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 240);
            this.panel2.TabIndex = 28;
            // 
            // student_cs1
            // 
            this.student_cs1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_cs1.Location = new System.Drawing.Point(203, 100);
            this.student_cs1.Name = "student_cs1";
            this.student_cs1.Size = new System.Drawing.Size(105, 28);
            this.student_cs1.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Current Subject 1:";
            // 
            // student_cs2
            // 
            this.student_cs2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_cs2.Location = new System.Drawing.Point(203, 139);
            this.student_cs2.Name = "student_cs2";
            this.student_cs2.Size = new System.Drawing.Size(105, 28);
            this.student_cs2.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Current Subject 2:";
            // 
            // student_pss1
            // 
            this.student_pss1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_pss1.Location = new System.Drawing.Point(723, 100);
            this.student_pss1.Name = "student_pss1";
            this.student_pss1.Size = new System.Drawing.Size(105, 28);
            this.student_pss1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Previously Studied Subjects 1:";
            // 
            // student_telephone
            // 
            this.student_telephone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_telephone.Location = new System.Drawing.Point(699, 52);
            this.student_telephone.Name = "student_telephone";
            this.student_telephone.Size = new System.Drawing.Size(125, 28);
            this.student_telephone.TabIndex = 17;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.exit.Location = new System.Drawing.Point(878, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 21);
            this.exit.TabIndex = 29;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "StudentForm";
            this.Size = new System.Drawing.Size(900, 670);
            this.Load += new System.EventHandler(this.StudentForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdata_gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView studentdata_gridview;
        private System.Windows.Forms.Button deletestudent_button;
        private System.Windows.Forms.Button clearstudent_button;
        private System.Windows.Forms.Button updatestudent_button;
        private System.Windows.Forms.Button addstudent_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox student_pss2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox student_telephone;
        private System.Windows.Forms.TextBox student_cs1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox student_cs2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox student_pss1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label exit;
    }
}
