using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic_Management_System
{
    public partial class Form6 : Form
    {
        Form11 o = new Form11();
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //admin
            Form10 f11 = new Form10();
            f11.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //search staff members
            Form5 f11 = new Form5();
            f11.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            o.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select SID from staff ", o.sqlConnection1);
           SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["SID"]).ToString();

            }
            o.sqlConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            o.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select *from Staff where SID = '" + comboBox1.Text + "'", o.sqlConnection1);
           SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox1.Text = dr["SID"].ToString();
                textBox2.Text = dr["SName"].ToString();
                textBox3.Text = dr["StaffType"].ToString();
                textBox4.Text = dr["Gender"].ToString();
                textBox5.Text = dr["DOB"].ToString();
                textBox6.Text = dr["Address"].ToString();
                textBox7.Text = dr["City"].ToString();
                textBox8.Text = dr["MobileNum"].ToString();
                textBox9.Text = dr["EmailID"].ToString();
                textBox10.Text = dr["Experience"].ToString();
               



            }
            o.sqlConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
            this.textBox8.Clear();
            this.textBox9.Clear();
            this.textBox10.Clear();
            
            this.textBox1.Clear();
            this.textBox3.Clear();
            

        }

        
    }
}
