using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            buttonDelete.Visible = false;
        }
        string[] strs = new string[] { "one", "two", "three", "four" };
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(strs);
            buttonDelete.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n < 0)
                MessageBox.Show("Нет выделенных элементов");
            else
                listBox1.Items.RemoveAt(n);
        }
    }
}
