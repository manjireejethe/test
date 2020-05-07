using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform1
{
    public partial class Mainpageform : Form
    {
        public Mainpageform()
        {
            InitializeComponent();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addempform3 em = new Addempform3();
            em.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm4 u = new UpdateForm4();
            u.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleteform5 d = new Deleteform5();
            d.Show();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empreportsforms ef = new empreportsforms();
            ef.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pswdform2 pf = new pswdform2();
            pf.Show();
        }

        private void Mainpageform_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm6 sf = new SearchForm6();
            sf.Show();
        }
    }
}
