using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav_ortalaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            int s1, s2, ort;
            s1 = Convert.ToInt32(textBox2.Text);
            s2 = Convert.ToInt32(textBox3.Text);
            listBox2.Items.Add(s1);
            listBox3.Items.Add(s2);
            ort = (s1 + s2) / 2;
            listBox4.Items.Add(ort.ToString());
            if (ort>0&&ort<50)
            {
                listBox5.Items.Add("kaldı");
            }
            else
            {
                listBox5.Items.Add("Geçti");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();


        }
    }
}
