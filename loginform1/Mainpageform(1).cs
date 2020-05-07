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
            Form1 d = new Form1();
            d.Show();
            this.Hide();
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
    }
}
