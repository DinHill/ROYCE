namespace DesktopInformationSystem
{
    partial class DashboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alldata_gridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.invidata_gridview = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alldata_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invidata_gridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.alldata_gridview);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 378);
            this.panel1.TabIndex = 0;
            // 
            // alldata_gridview
            // 
            this.alldata_gridview.AllowUserToAddRows = false;
            this.alldata_gridview.AllowUserToDeleteRows = false;
            this.alldata_gridview.AllowUserToResizeRows = false;
            this.alldata_gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.alldata_gridview.CausesValidation = false;
            this.alldata_gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alldata_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.alldata_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alldata_gridview.EnableHeadersVisualStyles = false;
            this.alldata_gridview.Location = new System.Drawing.Point(13, 45);
            this.alldata_gridview.Name = "alldata_gridview";
            this.alldata_gridview.ReadOnly = true;
            this.alldata_gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.alldata_gridview.RowHeadersVisible = false;
            this.alldata_gridview.RowHeadersWidth = 51;
            this.alldata_gridview.RowTemplate.Height = 24;
            this.alldata_gridview.Size = new System.Drawing.Size(839, 305);
            this.alldata_gridview.TabIndex = 1;
            this.alldata_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alldata_gridview_CellClick);
    
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "All data";
            // 
            // invidata_gridview
            // 
            this.invidata_gridview.AllowUserToAddRows = false;
            this.invidata_gridview.AllowUserToDeleteRows = false;
            this.invidata_gridview.AllowUserToResizeRows = false;
            this.invidata_gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.invidata_gridview.CausesValidation = false;
            this.invidata_gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invidata_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.invidata_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invidata_gridview.EnableHeadersVisualStyles = false;
            this.invidata_gridview.Location = new System.Drawing.Point(13, 45);
            this.invidata_gridview.Name = "invidata_gridview";
            this.invidata_gridview.ReadOnly = true;
            this.invidata_gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.invidata_gridview.RowHeadersVisible = false;
            this.invidata_gridview.RowHeadersWidth = 51;
            this.invidata_gridview.RowTemplate.Height = 24;
            this.invidata_gridview.Size = new System.Drawing.Size(839, 148);
            this.invidata_gridview.TabIndex = 1;
            this.invidata_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invidata_gridview_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.invidata_gridview);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(17, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 215);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Invidual data";
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
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardForm";
            this.Size = new System.Drawing.Size(900, 670);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alldata_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invidata_gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView alldata_gridview;
        private System.Windows.Forms.DataGridView invidata_gridview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
    }
}
