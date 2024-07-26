using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ieee_2
{
    class araba : araba_detay
    {
        public string renk;
        public string model;
        public int hiz;
        public int fiyat;
        public char durum;
        public double motor;
        private string marka;
        private int yil;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }
        
        public string MARKA {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
    }
}
