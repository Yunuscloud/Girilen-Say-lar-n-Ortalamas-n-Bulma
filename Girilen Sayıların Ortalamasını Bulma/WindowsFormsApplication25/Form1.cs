using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yunus = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(yunus);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int toplam = 0;
            while (sayac < listBox1.Items.Count)
            {
                toplam = toplam + Convert.ToInt32 (listBox1.Items[sayac]);
                sayac++;
            }
            label1.Text = "Ortalama : " + toplam / sayac;
            label2.Text = "Cevap : " + toplam;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
