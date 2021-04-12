using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Submit(object sender, EventArgs e)
        {
            MessageBox.Show("Information Submited");
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string day = cbDay.SelectedItem.ToString();
            string month = cbMonth.SelectedItem.ToString();
            string year = cbYear.SelectedItem.ToString();
            var gender = gbGender.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            string email = txtEmail.Text;

            rtOutput.Text = string.Format("First Name: {0} \nLast Name: {1} \nDate of Birth: {2}/{3}/{4} \nGender: {5} \nEmail: {6}",fName,lName,day,month,year,gender,email);
            //rtOutput.Text = string.Format("Email: "+email);
            //rtOutput.Text = fName;
            //rtOutput.Text = lName;
            //rtOutput.Text = day;
            //rtOutput.Text = month;
            //rtOutput.Text = year;
           //rtOutput.Text = gender;
            //rtOutput.Text = email;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
