using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRS_STORE
{
    public partial class loginpage : Form
    {
        //declaring value and variable
        int count = 5;
        public loginpage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the system
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            //declaring variable for username and password
            string uname, pword;
            uname = username.Text;
            pword = password.Text;

            if ((uname == "BRS") && (pword == "STORE"))//checking username and password to login
            {
                mainmenu frm = new mainmenu();
                this.Hide();
                MessageBox.Show("Login Successful.");
                frm.Show(); //Shows the mainmenu form
            }
            else
            {
                count--;
                if (count > 0)
                {
                    label6.Visible = true;
                    label6.Text = "You have only " + count + " attempt left.";

                    username.Clear(); //clearing username box
                    password.Clear(); //clearing password box 
                    username.Focus(); //focusing on username
                }
                else
                {
                    MessageBox.Show("Too many attempts. Exit and Try Again.", "Login Failed", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    Application.Exit(); //exits the system

                }
            }
        }

        private void loginpage_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = false; 
        }

    }
}
