using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUK003;Initial Catalog=manjiree_architectures;Integrated Security=True");
            string u = textBox1.Text;
            string p = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select * from Login where username='"+u+"' and password='"+p+"'",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Login Successfull");
                Mainpageform m = new Mainpageform();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
