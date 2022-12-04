using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_rehber_uygulaması
{
    class hazirkayitgetir
    {
        private string ad;
        private string soyad;
        private string numara;
        public hazirkayitgetir(string ad, string soyad, string numara)
        {
            this.ad = ad;
            this.soyad =soyad;
            this.numara = numara;
        }

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        public string Numara
        {
            get
            {
                return numara;
            }

            set
            {
                numara = value;
            }
        }
    }
       
}
