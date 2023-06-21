using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolfpack_heplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MenzilHesapla(object sender, EventArgs e)
        {
            try 
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    float hedef = float.Parse(textBox1.Text), periskop = float.Parse(textBox2.Text), mesafe = 0;
                    if (radioButton1.Checked == true)
                    {
                        mesafe = (hedef / periskop) * 4;
                    }
                    else
                    {
                        mesafe = (hedef / periskop);
                    }
                    label3.Text = mesafe + "hm";
                    label4.Text = (mesafe) + "km";
                }
            } 
            catch(Exception) 
            {
                MessageBox.Show("ya bir hata oldu yada senin küçük beynin rakam girmen gereken yerlere harf girdin");
            }
        }
        private void HizHesaplama(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text != "" && textBox4.Text != "" &&textBox5.Text!="")
                {
                    float hedef = float.Parse(textBox3.Text), dakika = float.Parse(textBox4.Text),saniye =float.Parse(textBox5.Text) ,sure = 0, sonuc = 0;
                    sure = (dakika *60) + saniye;
                    sonuc = hedef / sure;
                    label7.Text = (sonuc * 1.944) + "knot";
                    label8.Text = sonuc *3.6 + "kmh";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ya bir hata oldu yada senin küçük beynin rakam girmen gereken yerlere harf girdin");
            }
            
        }
    }
}
