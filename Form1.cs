using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer500_Tick(object sender, EventArgs e)
        {
            
            int time = Convert.ToInt32(label1.Text);
            time++;
            if (time > 9)
            {
                time = 0;
            }
            
            label1.Text = (time).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer500.Start();
            timer1000.Start();
            timer1500.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(label3.Text);
            time++;
            if (time > 9)
            {
                time = 0;
            }

            label3.Text = (time).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1000_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(label3.Text);
            time++;
            if (time > 9)
            {
                time = 0;
            }

            label3.Text = (time).ToString();
        }

        private void timer1500_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(label2.Text);
            time++;
            if (time > 9)
            {
                time = 0;
            }

            label2.Text = (time).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer500.Stop();
            timer1000.Stop();
            timer1500.Stop();
        }
    }
}
