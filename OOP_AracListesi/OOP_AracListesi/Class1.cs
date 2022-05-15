using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AracListesi
{
    internal class Araba
    {
        public string marka;
        public string model;
        public int uretimYil;
        public int sase;
        public int motorGuc;
        public string yakitTip;
        public string vites;
        public int jantBoyut;
        public string renk;
        public string kasaTip;
        public decimal Fiyat { get; set; }


        public decimal KDVDahilFiyat 
        {

            //read only
            get
            {
                return Fiyat * 1.18m;
            }
        
        }






    }
}
