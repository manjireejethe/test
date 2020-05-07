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
    public partial class UpdateForm4 : Form
    {
        public UpdateForm4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUK003;Initial Catalog=manjiree_architectures;Integrated Security=True");
        public void bindData()
        {
            comboBox2.Items.Clear();
            SqlCommand cmd = new SqlCommand("select eid from employee", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        private void UpdateForm4_Load(object sender, EventArgs e)
        {
            bindData();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            SqlCommand cmd = new SqlCommand("select * from employee where eid=" + id, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                richTextBox1.Text = dr[2].ToString();
                if (dr[3].ToString().Equals("Male"))
                {
                    radioButton1.Checked = true;
                }
                if (dr[3].ToString().Equals("Female"))
                {
                    radioButton2.Checked = true;
                }
                comboBox1.SelectedText = dr[4].ToString();
                textBox4.Text = dr[5].ToString();
                textBox2.Text = dr[6].ToString();
                
                
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string g = "";
            if (radioButton1.Checked)
            {
                g = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                g = radioButton2.Text;
            }
           
            SqlCommand cmd = new SqlCommand("update employee set eid=@id ,name=@n,address=@addr,gender=@gen,designation=@des,sal=@sal,mobNo=@mob where eid=@id", con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(comboBox2.SelectedItem.ToString()));
            cmd.Parameters.AddWithValue("@n", textBox1.Text);
            cmd.Parameters.AddWithValue("@addr", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@gen", g);
            cmd.Parameters.AddWithValue("@des", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@sal", Convert.ToDouble(textBox4.Text));
          
            cmd.Parameters.AddWithValue("@mob", Convert.ToInt64(textBox2.Text));
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Employee updated successfully");
            }
            con.Close();
        }
    }
}
