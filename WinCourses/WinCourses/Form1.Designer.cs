namespace WinCourses
{
    partial class Form1
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
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCourseCode = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCourseID = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbCourseNameUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCourseCodeUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.dtCourses = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(146, 41);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(137, 22);
            this.tbCourseName.TabIndex = 0;
            this.tbCourseName.TextChanged += new System.EventHandler(this.tbCourseName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Code";
            // 
            // tbCourseCode
            // 
            this.tbCourseCode.Location = new System.Drawing.Point(146, 78);
            this.tbCourseCode.Name = "tbCourseCode";
            this.tbCourseCode.Size = new System.Drawing.Size(137, 22);
            this.tbCourseCode.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(208, 130);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(103, 130);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 5;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Course ID";
            // 
            // tbCourseID
            // 
            this.tbCourseID.Location = new System.Drawing.Point(146, 233);
            this.tbCourseID.Name = "tbCourseID";
            this.tbCourseID.Size = new System.Drawing.Size(137, 22);
            this.tbCourseID.TabIndex = 6;
            this.tbCourseID.TextChanged += new System.EventHandler(this.tbCourseID_TextChanged);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(305, 233);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbCourseNameUpdate
            // 
            this.tbCourseNameUpdate.Enabled = false;
            this.tbCourseNameUpdate.Location = new System.Drawing.Point(146, 282);
            this.tbCourseNameUpdate.Name = "tbCourseNameUpdate";
            this.tbCourseNameUpdate.Size = new System.Drawing.Size(137, 22);
            this.tbCourseNameUpdate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Course Name";
            // 
            // tbCourseCodeUpdate
            // 
            this.tbCourseCodeUpdate.Location = new System.Drawing.Point(146, 319);
            this.tbCourseCodeUpdate.Name = "tbCourseCodeUpdate";
            this.tbCourseCodeUpdate.Size = new System.Drawing.Size(137, 22);
            this.tbCourseCodeUpdate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Course Code";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(208, 362);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 13;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // dtCourses
            // 
            this.dtCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCourses.Location = new System.Drawing.Point(305, 41);
            this.dtCourses.Margin = new System.Windows.Forms.Padding(4);
            this.dtCourses.Name = "dtCourses";
            this.dtCourses.RowHeadersWidth = 51;
            this.dtCourses.Size = new System.Drawing.Size(480, 112);
            this.dtCourses.TabIndex = 14;
            this.dtCourses.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Edit Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtCourses);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCourseCodeUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCourseNameUpdate);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCourseID);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCourseCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCourseName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCourseCode;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCourseID;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbCourseNameUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCourseCodeUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.DataGridView dtCourses;
        private System.Windows.Forms.Label label6;
    }
}

