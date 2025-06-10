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
    public partial class rateRecord : Form
    {
        public rateRecord()
        {
            InitializeComponent();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {

            chartRate1.Visible = true;
            label2.Visible = true;
            dataGridView1.Visible = false;
            
            label1.Visible = false;

            this.chartRate1.Series["sales"].Points.AddXY("Cleanliness", 160);
            this.chartRate1.Series["sales"].Points.AddXY("Store Ambiance", 260);
            this.chartRate1.Series["sales"].Points.AddXY("As per Cloth quality", 154);
            this.chartRate1.Series["sales"].Points.AddXY("Staff friendliness", 270);
            this.chartRate1.Series["sales"].Points.AddXY("Order Accuracy", 350);
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainmenu frm = new mainmenu();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Code for Dialog alert box..
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit!!", "BRS STORE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit(); //exits the system
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
