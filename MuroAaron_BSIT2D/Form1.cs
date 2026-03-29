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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] userCredentials =
    {
        {"admin", "admin","aaron joseph muro " },
        {"cashier","password","sponge bob" }
    };
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Please enter username!!", "Validation");
                tbUsername.Focus();
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Validation");
                tbPassword.Focus();
            }
            else
            {
                for (int x = 0; x < userCredentials.GetLength(0); x++)
                {
                    if (tbUsername.Text == userCredentials[x, 0])
                    {
                        if (tbPassword.Text == userCredentials[x, 1])
                        {
                            frmhome frm = new frmhome();
                            MessageBox.Show("Welcome " + userCredentials[x, 2]);
                            this.Hide();
                            frm.Show();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username/Password");
                            break;
                        }
                    }
                }
            }
        }
    }
}
                
            
       

