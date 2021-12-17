using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.DeepPink;
        }
        double step;
        private void Form1_Load(object sender, EventArgs e)
        {
            step = 0.2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (step > 0)
            {
                string s = label1.Text;
                if (s.Length > 0)
                    label1.Text = s.Substring(0, s.Length - 1);
                else 
                if (this.Opacity > 0)
                    this.Opacity -= step;
                else
                {
                    label1.Text = "Кот убежал!";
                    step = -step;
                }
                
            }
            else
            {
                this.Opacity -= step;
            }
        }
    }
}
