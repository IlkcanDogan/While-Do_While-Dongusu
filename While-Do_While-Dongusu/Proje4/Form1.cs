using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            int basamak = 0;

            while (sayi > 0)
            {
                basamak++; //1     
               
                sayi = sayi / 10;
             
              
            }

            MessageBox.Show("Girdiğiz sayı " + basamak.ToString() + " basamaklı");
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {

            //while döngüsünde, döngü başlamadan bir sayı artmadığı için "sayac <= 100" yazmamız gerekirdi.
            int toplam = 0;
            int sayac = 0;

            do
            {
                sayac++;
                toplam += sayac;

            } while (sayac < 100);
            MessageBox.Show("Toplam: " + toplam.ToString() + " ,Sayac: " + sayac.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
