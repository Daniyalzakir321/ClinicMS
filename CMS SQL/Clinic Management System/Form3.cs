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
    public partial class Form3 : Form
    {
        Form11 o = new Form11();
        public Form3()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //admin
            Form10 f1 = new Form10();
            f1.Show();
            this.Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Patient
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {





            o.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select PID from Patient ", o.sqlConnection1);
           SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["PID"]).ToString();

            }
            o.sqlConnection1.Close();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            o.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select *from Patient where PID = '" + comboBox1.Text + "'", o.sqlConnection1);
           SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox16.Text = dr["Name"].ToString();
                textBox15.Text = dr["Age"].ToString();
                textBox14.Text = dr["Gender"].ToString();
                textBox17.Text = dr["CNIC"].ToString();

                textBox11.Text = dr["FatherName"].ToString();
                textBox13.Text = dr["MobileNum"].ToString();
                textBox10.Text = dr["MotherName"].ToString();
                textBox12.Text = dr["Address"].ToString();
                  textBox1.Text = dr["AdmitDate"].ToString();
                                textBox2.Text = dr["Disease"].ToString();
                                textBox8.Text = dr["DoctorID"].ToString();
                               textBox3.Text = dr["DoctorName"].ToString();

                               textBox4.Text = dr["WardType"].ToString();
                                textBox5.Text = dr["WardNum"].ToString();
                                textBox6.Text = dr["RoomNum"].ToString();
                                textBox7.Text = dr["BedNum"].ToString();
                
                            }
                            o.sqlConnection1.Close();

                
/////////////////////////////////////////////////
/*

                SqlCommand cmdd = new SqlCommand("Select *from Admit where AdmitID = '" + comboBox1.Text + "'", o.sqlConnection1);
               SqlDataReader ddr = cmdd.ExecuteReader();

                if (ddr.Read())
                {


                    textBox1.Text = ddr["AdmitDate"].ToString();
                    textBox2.Text = ddr["Disease"].ToString();
                    textBox8.Text = ddr["DoctorID"].ToString();
                    textBox3.Text = ddr["DoctorName"].ToString();

                    textBox4.Text = ddr["WardType"].ToString();
                    textBox5.Text = ddr["WardNum"].ToString();
                    textBox6.Text = ddr["RoomNum"].ToString();
                    textBox7.Text = ddr["BedNum"].ToString();

                }

                o.sqlConnection1.Close();
            
            
            */
    ///////////////////////////////////////////////////////////        
           
        
        
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        }
    
}