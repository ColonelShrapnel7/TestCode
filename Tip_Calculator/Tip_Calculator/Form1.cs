using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{

    public partial class Form1 : Form
    {
        private double billamnt;
        private double tipamnt;
        private double tippercent;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void moreStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipamnt = billamnt * tippercent;
            textBox2.Text = tipamnt.ToString("N2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out billamnt))
            {
                tipamnt = billamnt * tippercent;
                textBox2.Text = tipamnt.ToString("N2");
                textBox4.Text = (billamnt + tipamnt.ToString("N2"));

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           if (double.TryParse(textBox3.Text, out tippercent))
            {
                tippercent = tippercent * 0.01;
            }
            else
            {
                tippercent = 0;
            }
            textBox1_TextChanged(sender, e);
        }
    }
}
