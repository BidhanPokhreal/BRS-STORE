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
    public partial class BootStart : Form
    {
        public BootStart()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2; //providing value 
            if (progressBar1.Value >= 100) //checking time of progressbabr
            {
                loginpage frm = new loginpage();
                this.Hide();
                frm.Show(); //move to login page 

                timer1.Enabled = true; //enabling time
                progressBar1.Visible = false;
                timer1.Enabled = false; //stopped progressbar activity

            }
        }

        private void BootStart_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
