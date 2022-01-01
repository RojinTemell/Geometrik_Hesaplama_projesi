using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometrik_hesaplama_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            Cember cember = new Cember();
            Dikdortgen dikdortgen = new Dikdortgen();
            double a1, a2;
            a1 = Convert.ToDouble(textBox1.Text);
            a2 = Convert.ToDouble(textBox2.Text);
            if (comboBox1.SelectedIndex == 0)
            {

                label4.Text = kare.Cevre_hesapla(a1, a2).ToString();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label4.Text = cember.Cevre_hesapla(a1, a2).ToString();
            }
            else
            {
                label4.Text = dikdortgen.Cevre_hesapla(a1, a2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Kare kare = new Kare();
            Cember cember = new Cember();
            Dikdortgen dikdortgen = new Dikdortgen();
            double a1, a2;
            a1 = Convert.ToDouble(textBox1.Text);
            a2 = Convert.ToDouble(textBox2.Text);
            if (comboBox1.SelectedIndex == 0)
            {

                label5.Text = kare.Alan_hesapla(a1, a2).ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label5.Text = cember.Alan_hesapla(a1, a2).ToString();
            }
            else
            {
                label5.Text = dikdortgen.Alan_hesapla(a1, a2).ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
            label5.Text = "";
            comboBox1.Text = "";
        }
    }
}
