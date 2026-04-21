using MySql.Data.MySqlClient;
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
        MyDataBase db = new MyDataBase();

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
                DataTable dt = db.ExecuteReturnQuery("SELECT * from tblLoginCredentials WHERE user_username = @uname and user_password = @pword;",
                    new MySqlParameter("@uname",tbUsername.Text),
                    new MySqlParameter("@pword",tbPassword.Text));

                if(dt.Rows.Count == 1)
                {
                    frmhome frm = new frmhome();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            if (db.TestConnection() == true)
            {
                MessageBox.Show("Connected to Database");
            }
            else
            {
                MessageBox.Show("DataBase Connection Failed!");
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}