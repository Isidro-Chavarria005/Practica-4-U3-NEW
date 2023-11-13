using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4_U3_NEW
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button2
            textBox1.Text = Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button1
            listBox1.Items.Add(textBox2.Text);
            f_num = float.Parse(textBox2.Text);
            Total += f_num;
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
