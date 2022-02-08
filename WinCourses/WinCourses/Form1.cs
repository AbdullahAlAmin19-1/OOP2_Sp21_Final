using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinCourses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string cName = tbCourseName.Text.Trim();
            string cCode = tbCourseCode.Text.Trim();
            var conn = DBConnection.Connect();
            int flag = 1;
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
            string queryName = "select * from courses where Course_Name = '" + cName + "'";
            SqlCommand cmdName = new SqlCommand(queryName, conn);
            
             if (cmdName.ExecuteReader().Read())
            {
                MessageBox.Show("Course Name Exist");
                flag = 0;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string queryCode = "select * from courses where Course_Code = '" + cCode + "'";
                SqlCommand cmdCode = new SqlCommand(queryCode, conn);

                if (cmdCode.ExecuteReader().Read())
                {
                    MessageBox.Show("Course Code Exist");
                    flag = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flag == 1)
            {
                string query = string.Format("insert into courses values ('{0}','{1}')", cName, cCode);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Course Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert Course");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Course Already Exist");
            }
            conn.Close();

            RefreshValues();
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
            
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
            dtCourses.Visible = true;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var conn = DBConnection.Connect();
            conn.Open();
            int id = Int32.Parse(tbCourseID.Text);
            string query = "select * from courses where ID = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Course c = new Course();

            while (reader.Read())
            {
                c.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                c.Course_Name = reader.GetString(reader.GetOrdinal("Course_Name"));
                c.Course_Code = reader.GetString(reader.GetOrdinal("Course_Code"));

            }
            conn.Close();
            tbCourseNameUpdate.Text = c.Course_Name;
            tbCourseCodeUpdate.Text = c.Course_Code;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbCourseID.Text.Trim());
            string cName = tbCourseNameUpdate.Text.Trim();
            string cCode = tbCourseCodeUpdate.Text.Trim();

            var conn = DBConnection.Connect();
            conn.Open();
            string query = string.Format("update courses set Course_Name='{0}',Course_Code='{1}' where ID={2}", cName, cCode, id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
        }

        List<Course> GetAllCourses()
        {
            var conn = DBConnection.Connect();
            List<Course> courses = new List<Course>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from courses";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course c = new Course();
                    c.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    c.Course_Name = reader.GetString(reader.GetOrdinal("Course_Name"));
                    c.Course_Code = reader.GetString(reader.GetOrdinal("Course_Code"));
                    courses.Add(c);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return courses;
        }
        void RefreshValues()
        {
            tbCourseName.Text = "";
            tbCourseCode.Text = "";
        }

        private void tbCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCourseID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
