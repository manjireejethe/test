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
    public partial class SearchForm6 : Form
    {
        public SearchForm6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=faculty-pc;Initial Catalog=architectures;Integrated Security=True");
            string c = comboBox1.SelectedItem.ToString();
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            switch(c)
            {
                case "ID": int id = Convert.ToInt32(textBox1.Text);
                     da = new SqlDataAdapter("select * from employee where eid="+id, con);
            da.Fill(ds, "employee");
            dataGridView1.DataSource = ds.Tables["employee"];
            break;
                case "Name": string n = textBox1.Text;
                   da = new SqlDataAdapter("select * from employee where name='"+n+"'", con);
            da.Fill(ds, "employee");
            dataGridView1.DataSource = ds.Tables["employee"];
            break;
            }
        }
    }
}
