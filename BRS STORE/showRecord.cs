using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BRS_STORE
{
    public partial class viewRecord : Form
    {
        
        DataSet ds = new DataSet(); //creating ds object

        public viewRecord()
        {
            InitializeComponent();
        }

        private void buttonviewRecord_Click(object sender, EventArgs e)
        {
            chartRate.Visible = false; //Giving Value
            dataGridView1.Visible = true; //Giving Value
            
            label1.Visible = false; //Giving Value

           
            
            label1.Enabled = false;
            chartRate.Enabled = false;

            string comma = ",";
            string tableName = "Table Menu";
            string file_path = "D:\\sales.CSV"; //Setting Path
            StreamReader reader = new StreamReader(file_path); //Reading Path


            ds.Tables.Add(tableName);
            ds.Tables[tableName].Columns.Add("ItemName"); //Add Column name IitemName
            ds.Tables[tableName].Columns.Add("Quantity"); //Add column name Quantity  
            ds.Tables[tableName].Columns.Add("Price(Rs.)"); //Add column name Price(Rs.)
            ds.Tables[tableName].Columns.Add("Date"); //Add Column name Date

            string allData = reader.ReadToEnd();
            string[] rows = allData.Split("\r".ToCharArray());

            foreach (String r in rows)
            {
                string[] items = r.Split(comma.ToCharArray());
                ds.Tables[tableName].Rows.Add(items);

            }
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewRecord_Load(object sender, EventArgs e)
        {
           
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

        private void button3_Click(object sender, EventArgs e)
        {
            mainmenu frm = new mainmenu();
            this.Hide();
            frm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            chartRate.Visible = true;
            
            dataGridView1.Visible = false;
            
            label1.Visible = false;           
            
            this.chartRate.Series["sales"].Points.AddXY("Aline dress", 154);
            this.chartRate.Series["sales"].Points.AddXY("Tent dress", 270);
            this.chartRate.Series["sales"].Points.AddXY("Shift dress", 165);
            this.chartRate.Series["sales"].Points.AddXY("Yoke dress", 350);
            this.chartRate.Series["sales"].Points.AddXY("Empire line dress", 260);

        }
    }
}
