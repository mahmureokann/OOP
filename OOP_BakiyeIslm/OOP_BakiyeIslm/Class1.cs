using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BakiyeIslm
{
    internal class BakiyeIslemi
    {
        
        
        public int guncelBakiyee;

        private int _cekilenTutar;

        public int cekilenTutar
        {
            get
            {
                return _cekilenTutar;
            }
            set 
            {
                if (0<value)
                {
                    _cekilenTutar = value;
                    
                }
            }
        }
        private int _yatirilanTutar;

        public int YatirilanTutar
        {
            get
            {
                return _yatirilanTutar; //Fırlat
            }
           
            set 
            {
                if (value<0)
                {
                    _yatirilanTutar = value;
                }
                 
            }
        }


    }
}
