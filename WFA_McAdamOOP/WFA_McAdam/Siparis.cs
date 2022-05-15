using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdam
{
    public class Siparis
    {
        public HamburgerMenu SeciliMenu { get; set; }
        public Boyut  Boyut { get; set; }

        public List<Ekstra> Ekstra { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        //Fiyat Hesapla

        public void Hesapla()
        {
            ToplamTutar = 0;
            //Menu Fiyatı
            ToplamTutar += SeciliMenu.Fiyat;
            //Boyut fiyatı
            switch (Boyut)
            {
                case Boyut.Küçük:
                    ToplamTutar += 0;
                    break;
                case Boyut.Orta:
                    ToplamTutar += 3;
                    break;
                case Boyut.Büyük:
                    ToplamTutar += 5;
                    break;
            }
            //Ekstra fiyatı
            foreach (Ekstra ekstra in Ekstra)
            {
                ToplamTutar += ekstra.Fiyat;
            }

            ToplamTutar *= Adet;




        }

        public override string ToString()
        {
            //Secili menu ad Küçük (Mayonez,Ketçap) 1 25
            if (Ekstra.Count < 1)
            {
                return $"{SeciliMenu} Menu, {Adet} Adet, {Boyut.ToString()} Toplam: {ToplamTutar.ToString("C2")}";
            }
            else
            {
                string ekstraBilgi = "";
                foreach (Ekstra ekstra in Ekstra)
                {
                    ekstraBilgi += ekstra.Ad + " ";
                }
                ekstraBilgi=ekstraBilgi.Trim();
                return $"{SeciliMenu} Menu, {Adet} Adet, {Boyut.ToString()}, Ekstra: ({ekstraBilgi}) {ToplamTutar.ToString("C2")}";
            }
        }

    }
}
