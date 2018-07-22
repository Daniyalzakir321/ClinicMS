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
    public partial class Form8 : Form
    {
        Form11 o = new Form11();
        public Form8()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //admin
            Form10 f11 = new Form10();
            f11.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            //Searchdoctor or other consultant
            o.sqlConnection1.Open();
           SqlCommand cmd33 = new SqlCommand("select DoctorID from Doctor ", o.sqlConnection1);
           SqlDataReader dr33 = cmd33.ExecuteReader();
            while (dr33.Read())
            {
                comboBox4.Items.Add(dr33["DoctorID"]).ToString();

            }
            o.sqlConnection1.Close();

            //////////////////////////////

            int AID = 0;

            o.sqlConnection1.Open();
           SqlCommand cmd1 = new SqlCommand("select count(AID) from Appointment", o.sqlConnection1);
           SqlDataReader d = cmd1.ExecuteReader();
            while (d.Read())
            {
                AID = Convert.ToInt32(d[0]);
                AID++;
            }
            o.sqlConnection1.Close();
            this.textBox16.Text = "" + AID;


            //Search patient
            o.sqlConnection1.Open();
           SqlCommand cmd2 = new SqlCommand("select PID from Patient ", o.sqlConnection1);
           SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox3.Items.Add(dr2["PID"]).ToString();

            }
            o.sqlConnection1.Close();






            //Search appointment
            o.sqlConnection1.Open();
           SqlCommand cmd3 = new SqlCommand("select AID from Appointment ", o.sqlConnection1);
           SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3["AID"]).ToString();

            }
            o.sqlConnection1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //gridview to search appointment

                o.sqlConnection1.Open();
               SqlCommand cmd4 = new SqlCommand("Select *from Appointment where AID='" + comboBox2.Text + "'", o.sqlConnection1);
               SqlDataReader dr5 = cmd4.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr5);
                dataGridView1.DataSource = dt;
                o.sqlConnection1.Close();
            }
            catch { MessageBox.Show("Go Back And Come Again"); }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            o.sqlConnection1.Open();
           SqlCommand cmd6 = new SqlCommand("Select *from Patient where PID = '" + comboBox3.Text + "'", o.sqlConnection1);
           SqlDataReader dr7 = cmd6.ExecuteReader();

            if (dr7.Read())
            {

                textBox1.Text = dr7["Name"].ToString();
                textBox2.Text = dr7["Disease"].ToString();
            }
            o.sqlConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                o.sqlConnection1.Open();
               SqlCommand cmd8 = new SqlCommand("Insert into Appointment(AID,ConsultantName,AdmitDate,ReleaseDate,PID,PName,Disease) values (@AID,@ConsultantName,@AdmitDate,@ReleaseDate,@PID,@PName,@Disease)", o.sqlConnection1);
                cmd8.Parameters.AddWithValue("@AID", textBox16.Text);
                cmd8.Parameters.AddWithValue("@ConsultantName", textBox15.Text);
                cmd8.Parameters.AddWithValue("@AdmitDate", dateTimePicker1.Text);
                cmd8.Parameters.AddWithValue("@ReleaseDate", dateTimePicker2.Text);
                cmd8.Parameters.AddWithValue("@PID", comboBox3.Text);
                cmd8.Parameters.AddWithValue("@PName", textBox1.Text);
                cmd8.Parameters.AddWithValue("@Disease", textBox2.Text);
                cmd8.ExecuteNonQuery();
                
                o.sqlConnection1.Close();
                MessageBox.Show("Appointment Saved");

            }
            catch { MessageBox.Show("Please Enter All Fields Correctly"); }



        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doctor ID 
            o.sqlConnection1.Open();
         
           SqlCommand cmddd = new SqlCommand("Select *from Doctor where DoctorID = '" + comboBox4.Text + "'", o.sqlConnection1);
           SqlDataReader dnrnn = cmddd.ExecuteReader();

            if (dnrnn.Read())
            {
                this.textBox15.Text = dnrnn["DoctorName"].ToString();
               
               

            }
            o.sqlConnection1.Close();
           
        }
    }
}
