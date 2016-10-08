using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rakiya_Virtual_Cooker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addItems();
        }

        void addItems()
        {
            domainUpDown1.Items.Add("Lb");
            domainUpDown1.Items.Add("pnd");
            domainUpDown1.Items.Add("litre");

            domainUpDown2.Items.Add("Lb");
            domainUpDown2.Items.Add("pnd");
            domainUpDown2.Items.Add("litre");

            domainUpDown3.Items.Add("Lb");
            domainUpDown3.Items.Add("pnd");
            domainUpDown3.Items.Add("litre");

            domainUpDown4.Items.Add("Lb");
            domainUpDown4.Items.Add("pnd");
            domainUpDown4.Items.Add("litre");

            domainUpDown5.Items.Add("Lb");
            domainUpDown5.Items.Add("pnd");
            domainUpDown5.Items.Add("litre");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }


        public void addfunct()
        {
            ArrayList mixup = new ArrayList();
            mixup.Add(textBox1.Text);
            mixup.Add(textBox2.Text);
            mixup.Add(textBox3.Text);
            mixup.Add(textBox4.Text);
            mixup.Add(textBox5.Text);
            mixup.Add(textBox6.Text);

            if (mixup.Contains("water"))
            {
                if (mixup.Contains("sugar"))
                {
                    if (mixup.Contains("fruit"))
                    {
                        MessageBox.Show("you just create a friut juice");
                    }
                    else
                        if (mixup.Contains("tang"))
                        {
                            MessageBox.Show("you just create a tang");
                        }
                    if (mixup.Contains("syrup"))
                    {
                        MessageBox.Show("you just create a syrup");
                    }
                }
                else
                    if (mixup.Contains("milk"))
                    {
                        if (mixup.Contains("fruit"))
                        {
                            if (mixup.Contains("strawberry"))
                            {
                                MessageBox.Show("you just create a strawberry milkshake");
                            }
                            else
                                if (mixup.Contains("peanut"))
                                {
                                    MessageBox.Show("you just create a peanut milkshake");
                                }
                        }
                    }
            }
            else
                if (mixup.Contains("sugar"))
                {
                    MessageBox.Show("");
                }
                else
                    if (mixup.Contains("fruits"))
                    {

                    }
                    else
                    {
                        MessageBox.Show("please enter show ingredients");
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        { 
            textBox5.Text = "";
        }

        private void massToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mass mass = new Mass();
            mass.Show();
        }

        private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Volume vol = new Volume();
            vol.Show();
        }

        private void timeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeTable time = new TimeTable();
            time.Show();
        }
    }
}
