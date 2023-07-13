using System;
using System.IO;
using System.Windows.Forms;

namespace Txt_Telefon_Rehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string a, b, c, d;

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("TelefonRehberi.txt");

            while (!sr.EndOfStream)
            {
                string[] numaralar = sr.ReadLine().Split(';');

                if ((textBox1.Text == numaralar[0]) && (textBox2.Text == numaralar[1]))
                {
                    textBox3.Text = numaralar[2];
                }
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            d = a + ";" + b + ";" + c + ";";
            StreamWriter sw = new StreamWriter("TelefonRehberi.txt", true);
            sw.WriteLine(d);
            sw.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("Kişi Kaydedildi");
        }
    }
}
