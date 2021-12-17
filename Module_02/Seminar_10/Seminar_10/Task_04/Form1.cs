using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size s = this.ClientSize;
            button1.Location = new Point(
                s.Width / 2 - button1.Width / 2,
                s.Height / 2 - button1.Height / 2);
        }

        bool mode = false;

        private void button1_Click(object sender, EventArgs e)
        {
            int w = this.Size.Width;
            int h = this.Size.Height;

            this.Location = new Point(
                (this.MaximumSize.Width - w) / 2 + 20,
                (this.MaximumSize.Height - h) / 2 + 20);

            if (!mode)
            {
                if (w > MinimumSize.Width || h > MinimumSize.Height)
                {
                    this.Size = new Size(w / 3 * 2, h / 3 * 2);
                    CenterToScreen();
                    return;
                }
                else
                {
                    mode = true;
                    button1.Text = "Увеличить форму";
                }
            }

            if (w < this.MaximumSize.Width || h < this.MaximumSize.Height)
            {
                this.Size = new Size(w / 2 * 3, h / 2 * 3);
                CenterToScreen();
                return;
            }
            else
            {
                mode = false;
                button1.Text = "Уменьшить форму";
                this.Size = new Size(w / 3 * 2, h / 3 * 2);
                CenterToScreen();
                return;
            }
        }
    }
}
