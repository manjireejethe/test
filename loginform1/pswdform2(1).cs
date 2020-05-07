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
    public partial class pswdform2 : Form
    {
        public pswdform2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=faculty-pc;Initial Catalog=architectures;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string np = textBox2.Text;
            string cp = textBox3.Text;
            if(np.Equals(cp))
            {
                SqlCommand cmd = new SqlCommand("update login set password='" + np + "'", con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if(i>0)
                {
                    MessageBox.Show("password changed");
                }
                else
                {
                    MessageBox.Show("please try again....");
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("enter same password");
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void pswdform2_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("select * from Login where password='" + textBox1.Text + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Enter correct password");
                textBox1.Text = "";
                textBox1.Focus();
            }
            con.Close();
        }
    }
}
