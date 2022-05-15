using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_UrunYonetimi
{
    public abstract class Urun
    {
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }

        public static List<Urun> urunlerList = new List<Urun>();



    }
}
