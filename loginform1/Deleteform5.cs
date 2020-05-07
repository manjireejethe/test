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
    public partial class Deleteform5 : Form
    {
        public Deleteform5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUK003;Initial Catalog=manjiree_architectures;Integrated Security=True");
        private void Deleteform5_Load(object sender, EventArgs e)
        {
            bindData();
        }

        public void bindData()
        {
            comboBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("select eid from employee", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            SqlCommand cmd = new SqlCommand("delete from employee where eid=" + id, con);
            con.Open();
            int i = cmd.ExecuteNonQuery(); con.Close();
            if (i > 0)
            {
                MessageBox.Show("Employee deleted successfully");
                bindData();
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
