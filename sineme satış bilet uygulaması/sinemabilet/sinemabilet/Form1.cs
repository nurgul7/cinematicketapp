using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemabilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // butandan etkilenip sürekli aynı sonucu bize döndermemesi için global alnda tanımlıyoruz
        //eğer aşağıda tanımlasaydık hesapla butonuna her bastığımızda 0 layacaktı kasatutarını
        int kasatutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int bilet, su, icecek, misir,toplam;//değişkenler tanımlıyoruz
            bilet =Convert.ToInt32(textbilet.Text);//int değişkenlerini alabilmesi için çeviriyoruz
            su=Convert.ToInt32(textsu.Text);
            icecek=Convert.ToInt32(texticecek.Text);
            misir=Convert.ToInt32(textmisir.Text);

            toplam = bilet * 45 + su * 5 + icecek * 25 + misir * 20;

            kasatutar = toplam + kasatutar;

            labeltoplam.Text=toplam.ToString()+" TL";//int olan değişkenleri label e string formatta yazdıra bilmek için ToString e çeviriyoruz.
            label7.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)//temizle butonu
        {
            textbilet.Text = " ";
            texticecek.Text = " ";
            textmisir.Text = " ";
            textsu.Text = " ";
            textbilet.Focus();//temizleme işlemi bittikten sonra imlec ilk textbox ta bekliyor
        }

      
    }
}
