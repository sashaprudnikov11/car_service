using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fr2 = new Form2();
            fr2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr3 = new Form3();
            fr3.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fr4 = new Form4();
            fr4.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form fr3 = new Form3();
            fr3.Show();
            Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form fr3 = new Form3();
            fr3.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form fr5 = new Form5();
            fr5.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form fr6 = new Form6();
            fr6.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form fr7 = new Form7();
            fr7.Show();
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form fr8= new Form8();
            fr8.Show();
            Hide();
        }
    }
}
