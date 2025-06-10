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
    public partial class sort : Form
    {
        DataSet ds = new DataSet();
        public sort()
        {
            InitializeComponent();
        }

        private void sort_Load(object sender, EventArgs e)
        {
            string comma = ",";
            string tableName = "Table Menu";
            string file_path = "D:\\sales.CSV";
            StreamReader reader = new StreamReader(file_path);


            ds.Tables.Add(tableName);
            ds.Tables[tableName].Columns.Add("ItemID");
            ds.Tables[tableName].Columns.Add("ItemName");
            ds.Tables[tableName].Columns.Add("ItemPrice(Rs.)");
            ds.Tables[tableName].Columns.Add("ItemCategory");
            ds.Tables[tableName].Columns.Add("Item Rate");

            string allData = reader.ReadToEnd();
            string[] rows = allData.Split("\r".ToCharArray());

            foreach (String r in rows)
            {
                string[] items = r.Split(comma.ToCharArray());
                DataRow dataRow = ds.Tables[tableName].Rows.Add(items);

            }
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNameSort_Click(object sender, EventArgs e)
        {
            //Sorting by item name.
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending); //Sort in ascending order
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sorting by Item price
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending); //sort in ascending order
        }

       
        private void button8_Click(object sender, EventArgs e)
        {
            //Move to mainmenu page
            mainmenu frm = new mainmenu();
            this.Hide(); //close the page
            frm.Show(); //call mainmenu page
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit!!", "BRS STORE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
