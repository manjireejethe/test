using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginform1
{
    public partial class empreportsforms : Form
    {
        public empreportsforms()
        {
            InitializeComponent();
        }

        private void empreportsforms_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAB12-PC;Initial Catalog=manjiri_architectures;Integrated Security=True");
           // SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
            DataSet ds = new DataSet();
            //da.Fill(ds,"employee");
            dataGridView1.DataSource=ds.Tables["empoyee"];

           /* SqlConnection con = new SqlConnection("Data Source=LAB12-PC;Initial Catalog=manjiri_architectures;Integrated Security=True");
            string c = comboBox1.SelectedItem.ToString();
            DataSet ds = new DataSet();
            SqlDataAdapter da;*/
        }
    }
}
