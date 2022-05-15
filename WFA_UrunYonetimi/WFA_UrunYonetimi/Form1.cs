using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_UrunYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Kitap
            Kitap kitap = new Kitap();
            kitap.KitapAd = "Mevsimler Geçerken";
            kitap.Yazar = "Ali";
            kitap.Fiyat = 20;
            Urun.urunlerList.Add(kitap);
            MessageBox.Show(kitap.ToString());

            //Cep Telefonu
            CepTelefonu telefon = new CepTelefonu();
            telefon.Marka = "Apple";
            telefon.Model = "İphone 11";
            telefon.Fiyat = 10000;
            Urun.urunlerList.Add(telefon);

            //Kırtasiye
            Kirtasiye kirtasiye = new Kirtasiye();
            kirtasiye.UrunAd = "Kalem";
            kirtasiye.Fiyat = 5;
            Urun.urunlerList.Add(kirtasiye);

            //Masaustu pc
            MasaustuBilgisayar pc = new MasaustuBilgisayar();
            pc.Marka = "Casper";
            pc.Model = "Casper model";
            pc.Fiyat = 20000;
            Urun.urunlerList.Add(pc);

            //Laptop
            Laptop lpc = new Laptop();
            lpc.Marka = "Asus";
            lpc.Model = "Asus model";
            lpc.Fiyat = 15000;
            Urun.urunlerList.Add(lpc);

            //Kart Oyunu
            KartOyunu kartOyunu = new KartOyunu();
            kartOyunu.Marka = "Oyuncakçı";
            kartOyunu.Fiyat = 20;
            Urun.urunlerList.Add(kartOyunu);

            //Pcoyun
            BilgisayarOyunu pcOyun = new BilgisayarOyunu();
            pcOyun.UrunAd = "Sims";
            pcOyun.Fiyat = 4000;
            Urun.urunlerList.Add(pcOyun);

            //Konsol oyun
            KonsolOyunu kOyun = new KonsolOyunu();
            kOyun.UrunAd = "Konsol oyunu";
            kOyun.Fiyat = 2000;
            Urun.urunlerList.Add(kOyun);






        }
    }
}
