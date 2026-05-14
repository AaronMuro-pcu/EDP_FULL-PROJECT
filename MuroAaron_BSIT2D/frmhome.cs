using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuroAaron_BSIT2D
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rform f = new Rform();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sform s = new Sform();
            s.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pform p = new Pform();
            p.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vform v = new Vform();
            v.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            this.Hide();
            frm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tform t = new Tform();
            t.Show();

        }

        private void frmhome_Load(object sender, EventArgs e)
        {

        }

        private void frmhome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
