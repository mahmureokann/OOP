using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_UrunYonetimi
{
    public class Laptop:Urun,IYetenekler
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public string add()
        {
            return Marka + "eklendi";
        }

        public string delete()
        {
            return Marka + "silindi";
        }

        public string gonder()
        {
            return Marka + "mail gönderildi";
        }

        public string kampanya(decimal indirim)
        {
            return Marka + " " + indirim + " ";
        }

        public string update()
        {
            return Marka + "Guncellendi";
        }
    }
}
