using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_rehber_uygulaması
{
    class hazir_kayit
    {
        public static List<hazirkayitgetir> liste = new List<hazirkayitgetir>();

        public  hazir_kayit()
        {
            hazirkayitgetir kayit1 = new hazirkayitgetir("Ali", "Uygun", "5550001233");
            hazirkayitgetir kayit2 = new hazirkayitgetir("Çağrı", "Dönmez", "555000456");
            hazirkayitgetir kayit3 = new hazirkayitgetir("Veli", "Özdemir", "553231233");
            hazirkayitgetir kayit4 = new hazirkayitgetir("Resül", "Karamoçu", "55578933");
            hazirkayitgetir kayit5 = new hazirkayitgetir("Kübra", "Uygun", "555896233");
            liste.Add(kayit1);
            liste.Add(kayit2);
            liste.Add(kayit3);
            liste.Add(kayit4);
            liste.Add(kayit5);


        }

    }
}
