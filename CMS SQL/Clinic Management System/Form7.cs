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
    public partial class Form7 : Form
    {
        Form11 o = new Form11();
        public Form7()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {////////////////////////////////////// 

                //gridview to search medicine

                o.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("Select *from Invoice where PID='" + comboBox2.Text + "'", o.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                o.sqlConnection1.Close();
                o.sqlConnection1.Close();
            }
            catch { MessageBox.Show("Go Back And Come Again"); }

            ///////////////////////////////////
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //admin
            Form10 f11 = new Form10();
            f11.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {  
            
            
            //add invoice
            o.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select PID from Patient ", o.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["PID"]).ToString();

            }
            o.sqlConnection1.Close();







            //Search invoice
            o.sqlConnection1.Open();
            SqlCommand cmdd = new SqlCommand("select PID from Invoice ", o.sqlConnection1);
            SqlDataReader drr = cmdd.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr["PID"]).ToString();

            }
            o.sqlConnection1.Close();



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
            //Search invoice
            o.sqlConnection1.Open();
            SqlCommand cd = new SqlCommand("Select *from Patient where PID = '" + comboBox3.Text + "'", o.sqlConnection1);
            SqlDataReader dnr = cd.ExecuteReader();

            if (dnr.Read())
            {
                textBox15.Text = dnr["Name"].ToString();
                textBox13.Text = dnr["MobileNum"].ToString();

            }
            o.sqlConnection1.Close();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //add invoice

                o.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("Insert into Invoice(PID,PName,MobileNum,UltraSound,Drip,Lab,Others,Total) values (@PID,@PName,@MobileNum,@UltraSound,@Drip,@Lab,@Others,@Total)", o.sqlConnection1);
                cmd.Parameters.AddWithValue("@PID", comboBox3.Text);
                cmd.Parameters.AddWithValue("@PName", textBox15.Text);
                cmd.Parameters.AddWithValue("@MobileNum", Convert.ToInt32(textBox13.Text));
                cmd.Parameters.AddWithValue("@UltraSound", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@Drip", Convert.ToInt32(textBox2.Text));
                cmd.Parameters.AddWithValue("@Lab", Convert.ToInt32(textBox3.Text));
                cmd.Parameters.AddWithValue("@Others", Convert.ToInt32(textBox4.Text));
                cmd.Parameters.AddWithValue("@Total", Convert.ToInt32(textBox5.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Invoice Generated");
                o.sqlConnection1.Close();
            }
            catch { MessageBox.Show("Please Enter All Fields Correctly"); }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           


           

         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int p = Convert.ToInt32(textBox1.Text);
                int r = Convert.ToInt32(textBox2.Text);
                int i = Convert.ToInt32(textBox3.Text);
                int f = Convert.ToInt32(textBox4.Text);

                int t = p + r + i + f;
                textBox5.Text = t.ToString();
            }
            catch { MessageBox.Show("Please Enter Numbers Only"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
