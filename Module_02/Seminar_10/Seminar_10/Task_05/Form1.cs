using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LabelYes.ForeColor = Color.Green;
            LabelNo.ForeColor = Color.IndianRed;
        }
        Rate rate = new Rate();
        private void button1_Click(object sender, EventArgs e)
        {
            LabelYes.Text = rate.Yes++.ToString();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            LabelNo.Text = rate.No++.ToString();
        }        
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Visible = !button1.Visible;
        }
    }
}
