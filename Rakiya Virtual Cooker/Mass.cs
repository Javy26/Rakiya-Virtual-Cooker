using System;
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
    public partial class Mass : Form
    {
        public Mass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metricConverter();
        }

        public void metricConverter()
        {

            Double convert = 0;
            Double pnd = double.Parse(textBox1.Text);
            Double oz = double.Parse(textBox4.Text); ;
            Double grams = double.Parse(textBox3.Text);

            //pound radiobutton
            if (radioButton1.Checked)
            {
                convert = oz * 16;//pound to oz
                convert = grams * 453.592;//pound to gram
                textBox1.Text = pnd.ToString();
            }
            else
                if (radioButton2.Checked)//gram radiobutton
                {
                    convert = grams * 28.349;// oz to gram
                    convert = pnd * 0.0625;//oz to pound
                }
                else if (radioButton3.Checked)//oz radiobutton
                {
                    convert = oz * 0.035274;//  gram to oz
                    convert = pnd * 0.0022;//gram to pound
                }
                else
                {
                    MessageBox.Show("you didn't selected a radio metric");
                }
            
        }
    }
}
