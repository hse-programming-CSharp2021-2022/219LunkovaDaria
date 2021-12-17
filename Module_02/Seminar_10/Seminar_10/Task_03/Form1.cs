using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] strs = new string[] { "one", "two", "three" };
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Lines = strs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = string.Join(" ", textBox1.Lines);
            MessageBox.Show(s);
        }
    }
}
