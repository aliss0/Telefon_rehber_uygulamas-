using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_rehber_uygulaması
{
    class Listele
    {
        public static void Listeleme(List<hazirkayitgetir> liste)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**************************");
            foreach(var item in liste)
            {
                Console.WriteLine("İsim: {0}", item.Ad);
                Console.WriteLine("Soyisim: {0}", item.Soyad);
                Console.WriteLine("Numara: {0}", item.Numara);
                Console.WriteLine("-");
            }
        }
    }
}
