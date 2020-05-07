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
    public partial class Empreports : Form
    {
        public Empreports()
        {
            InitializeComponent();
        }

        private void Empreports_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=faculty-pc;Initial Catalog=architectures;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "employee");
            dataGridView1.DataSource = ds.Tables["employee"];
        }
    }
}
