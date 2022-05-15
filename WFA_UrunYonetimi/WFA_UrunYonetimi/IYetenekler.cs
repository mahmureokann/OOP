using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_UrunYonetimi
{
    internal interface IYetenekler
    {
        string delete();
        string add();
        string update();
       // List listeleme();
        string kampanya(decimal indirim);
        string gonder();
    }
}
