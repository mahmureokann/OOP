using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_UrunYonetimi
{
    public class Kitap:Urun,IYetenekler
    {
        public string KitapAd { get; set; }
        public string Yazar { get; set; }

        public string add()
        {
            return KitapAd + "eklendi";
        }

        public string delete()
        {
            return KitapAd + "silindi";
        }

        public string gonder()
        {
            return KitapAd + "mail gönderildi";
        }

        public string kampanya(decimal indirim )
        {
            return  KitapAd+" "+indirim+" ";
        }

        public string update()
        {
            return KitapAd + "Guncellendi";
        }

        public override string ToString()
        {
            return KitapAd;
        }
    }
}
