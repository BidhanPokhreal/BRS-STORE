using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace BRS_STORE
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            listBoxQty.Items.Add(numericUpDown1.Text); //declaring
            int cost = 0; //declaring



            if ((string)name.SelectedItem == "Aline dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }


            else if ((string)name.SelectedItem == "Tent dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 140; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 140; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 140; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 140; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }


            else if ((string)name.SelectedItem == "Yoke dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 150; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 150; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 150; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 150; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }


            else if ((string)name.SelectedItem == "Empire line dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 120; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 120; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 120; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 120; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Shift dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 140; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 140; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 140; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 140; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Dirndl dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 200; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 200; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 200; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 200; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Sheath dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 100; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 100; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 100; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 100; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Low or drop waist dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 100; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 100; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 100; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 100; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Tunic dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 350; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 350; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 350; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 350; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Shirt waist dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 450; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 450; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 450; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 450; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Wrap around dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 200; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 200; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 200; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 200; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Baby doll dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 300; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 300; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 300; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 300; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Body con dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 350; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 350; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 350; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 350; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }
            else if ((string)name.SelectedItem == "Cocktail dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 425; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 425; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 425; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 425; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Debutante dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Skater dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 125; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }

            else if ((string)name.SelectedItem == "Camisole dress")
            {
                if ((string)rate.SelectedItem == "Excellent")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 425; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Good")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 425; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Average")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 425; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
                else if ((string)rate.SelectedItem == "Dissatisfied")
                {
                    listBoxItem.Items.Add(name.SelectedItem);
                    cost = Convert.ToInt32(numericUpDown1.Text) * 425; 
                    listBoxAmount.Items.Add(cost);
                    listBoxRate.Items.Add(rate.SelectedItem);
                }
            }        

            else
            {
                MessageBox.Show("Please select the Items In the List.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult exit; 
            exit = MessageBox.Show("Confirm you want to Exit", "Point if Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxAmount.Items.Clear(); 
            listBoxItem.Items.Clear(); 
            listBoxQty.Items.Clear();
            listBoxRate.Items.Clear();
            numericUpDown1.Value = 0; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Declaring variable
            int i = 0, result = 0;
            while(i<listBoxAmount.Items.Count)
            {
                result += Convert.ToInt32(listBoxAmount.Items[i]); 
                i++; 
            }
            textBoxTotal.Text = Convert.ToString((double)result);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

              private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
           panelvegeterian.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void save_Click(object sender, EventArgs e)
        {


            if (listBoxItem.Items.Count > 0)
            {
                
                using (TextWriter TW = new StreamWriter("D:\\sales.CSV", append:true)) 
                {
                    if (listBoxItem.Items.Count == listBoxQty.Items.Count)
                    {
                        for (int i = 0; i < listBoxItem.Items.Count; i++)
                        {
                            TW.Write(listBoxItem.Items[i].ToString() +",");
                            TW.Write(listBoxQty.Items[i].ToString() + ",");
                            TW.Write(listBoxAmount.Items[i].ToString() + ",");
                            TW.Write(listBoxRate.Items[i].ToString() + ",");
                            TW.WriteLine(DateTime.Now.ToShortDateString());

                        }
                        MessageBox.Show("Your records is saved successfully.");

                    }
                }
                 Process.Start("D:\\sales.CSV");
            }

            

        }

        private void buttonViewRecord_Click(object sender, EventArgs e)
        {
            viewRecord fm = new viewRecord();
            this.Hide();
            fm.Show(); 
        }

        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            
            iExit = MessageBox.Show("Are you sure to logout", "BRS STORE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                loginpage fm = new loginpage();
                this.Hide();
                fm.Show();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sort frm = new sort();
            this.Hide();
            frm.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBoxAmount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxQty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxItem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
           if ((string)name1.SelectedItem == "As per Cloth quality")
            {
                if ((string)rate1.SelectedItem == "Excellent")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Good")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Average")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Dissatisfied")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
            }

            else if ((string)name1.SelectedItem == "Staff friendliness")
            {
                if ((string)rate1.SelectedItem == "Excellent")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Good")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Average")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Dissatisfied")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
            }

            else if ((string)name1.SelectedItem == "Cleanliness")
            {
                if ((string)rate1.SelectedItem == "Excellent")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Good")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Average")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Dissatisfied")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
            }

            else if ((string)name1.SelectedItem == "Order Accuracy")
            {
                if ((string)rate1.SelectedItem == "Excellent")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Good")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Average")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Dissatisfied")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
            }

            else if ((string)name1.SelectedItem == "Store Ambiance")
            {
                if ((string)rate1.SelectedItem == "Excellent")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Good")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Average")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Dissatisfied")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
            }


            else if ((string)name1.SelectedItem == "Value for money")
            {
                if ((string)rate1.SelectedItem == "Excellent")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Good")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Average")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
                else if ((string)rate1.SelectedItem == "Dissatisfied")
                {
                    listBox3.Items.Add(name1.SelectedItem);
                    listBox4.Items.Add(rate1.SelectedItem);
                }
            }




        }

        private void name1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (listBox3.Items.Count > 0)
            {
                
                using (TextWriter TW = new StreamWriter("D:\\rate.csv", append: true))
                {
                    if (listBox3.Items.Count == listBox4.Items.Count)
                    {
                        for (int i = 0; i < listBox3.Items.Count; i++)
                        {
                            TW.Write(listBox3.Items[i].ToString() + ",");
                            TW.Write(listBox4.Items[i].ToString() + ",");
                      
                            TW.WriteLine(DateTime.Now.ToShortDateString());

                        }
                        MessageBox.Show("Your records is saved successfully.");

                    }
                }
                Process.Start("D:\\rate.csv");
            }
        }

        private void btnView1_Click(object sender, EventArgs e)
        {
            rateRecord fm = new rateRecord();
            this.Hide(); 
            fm.Show();  
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void price_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }
    }
}
