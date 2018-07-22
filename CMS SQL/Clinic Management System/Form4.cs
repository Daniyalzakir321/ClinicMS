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
    public partial class Form4 : Form
    {
        Form11 o = new Form11();
        public Form4()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //admin
            Form10 f11 = new Form10();
            f11.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //admin
            Form10 f1 = new Form10();
            f1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //search MEdicine
            o.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select MID from Medicine ", o.sqlConnection1);
           SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["MID"]).ToString();

            }
            o.sqlConnection1.Close();



            ///////////





            int MID = 0;

            o.sqlConnection1.Open();
            SqlCommand cmd2 = new SqlCommand("select count(MID) from medicine", o.sqlConnection1);
           SqlDataReader dr11 = cmd2.ExecuteReader();
            while (dr11.Read())
            {
                MID = Convert.ToInt32(dr11[0]);
                MID++;
            }
            o.sqlConnection1.Close();
            this.textBox1.Text = "MID" + MID;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        

            //gridview to search medicine

            o.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select *from Medicine", o.sqlConnection1);
           SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            o.sqlConnection1.Close();

            ///////////////////////////////////
            /*
                        
            //Dtat type mismatch if i use this query
             * 
                        o.sqlConnection1.Open();
                        SqlCommand cmd = new SqlCommand("Select *from Medicine where MID='" + comboBox2.Text + "'", o.sqlConnection1);
                       SqlDataReader dlr = cmd.ExecuteReader();
                        DataTable dtt = new DataTable();
                        dtt.Load(dlr);
                        dataGridView1.DataSource = dtt;
                        o.sqlConnection1.Close();
        
                        */

        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                o.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("Insert into Medicine(MID,MedicinesName) values (@MID,@MedicinesName)", o.sqlConnection1);
                cmd.Parameters.AddWithValue("@MID", textBox1.Text);
                cmd.Parameters.AddWithValue("@MedicinesName", textBox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Added");
                o.sqlConnection1.Close();
            }
            catch { MessageBox.Show("Please Enter Medicine"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox6.Clear();
           

        }
    }
}
