﻿
namespace Task_05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabelNo = new System.Windows.Forms.Label();
            this.LabelYes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(337, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Поймай меня";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelNo
            // 
            this.LabelNo.AutoSize = true;
            this.LabelNo.Location = new System.Drawing.Point(248, 296);
            this.LabelNo.Name = "LabelNo";
            this.LabelNo.Size = new System.Drawing.Size(22, 25);
            this.LabelNo.TabIndex = 1;
            this.LabelNo.Text = "0";
            // 
            // LabelYes
            // 
            this.LabelYes.AutoSize = true;
            this.LabelYes.Location = new System.Drawing.Point(515, 296);
            this.LabelYes.Name = "LabelYes";
            this.LabelYes.Size = new System.Drawing.Size(22, 25);
            this.LabelYes.TabIndex = 2;
            this.LabelYes.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelYes);
            this.Controls.Add(this.LabelNo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Поймай кнопку";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabelNo;
        private System.Windows.Forms.Label LabelYes;
    }
}

