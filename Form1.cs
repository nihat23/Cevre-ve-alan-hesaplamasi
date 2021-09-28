using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çevre_ve_Alan__Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Hesapla_Click(object sender, EventArgs e)
        {
            double uzunkenar, kisakenar, cevre, alan;

            try
            {
                uzunkenar = Convert.ToDouble(textBox2.Text);
                kisakenar = Convert.ToDouble(textBox1.Text);

                alan = uzunkenar * kisakenar;
                label5Alan.Text = alan.ToString()+" "+"M2";

                cevre = (uzunkenar + kisakenar) * 2;
                label6Cevre.Text = cevre.ToString()+" "+"M2";
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Sayısal deger yada boş geçılemez..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

           

        }

        private void button1Hesapla_MouseHover(object sender, EventArgs e)
        {
            button1Hesapla.BackColor = Color.Green;
        }

        private void button1Hesapla_MouseLeave(object sender, EventArgs e)
        {
            button1Hesapla.BackColor = Color.Red;
        }
    }
}
