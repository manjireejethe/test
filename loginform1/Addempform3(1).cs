using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace loginform1
{
    public partial class Addempform3 : Form
    {
        public Addempform3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addempform3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string g = "";
            if(radioButton1.Checked)
            {
                g = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                g = radioButton2.Text;
            }
            SqlConnection con = new SqlConnection("Data Source=faculty-pc;Initial Catalog=architectures;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into employee values(@id,@n,@sal,@addr,@des,@mob,@gen)", con);
            cmd.Parameters.AddWithValue("id", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("n", textBox4.Text);
            cmd.Parameters.AddWithValue("sal",Convert.ToDouble(textBox5.Text));
            cmd.Parameters.AddWithValue("addr", richTextBox1.Text);
            cmd.Parameters.AddWithValue("des", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("mob",Convert.ToInt64(textBox6.Text));
            cmd.Parameters.AddWithValue("gen", g);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                MessageBox.Show("Employee added successfully");
            }
            con.Close();
        }
    }
}
