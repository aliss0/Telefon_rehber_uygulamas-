using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_rehber_uygulaması
{
    class kaydet
    {
        public static void Kayıt(List<hazirkayitgetir>liste)
        {
            Console.WriteLine("Lütfen Eklemek İstediğiniz Kişinin Adını Giriniz             :");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen Eklemek İstediğiniz Kişinin Soyadını Giriniz           :");
            string soyad = Console.ReadLine();
            Console.WriteLine("Lütfen Eklemek İstediğiniz Kişinin Telefon Numarasını Giriniz :");
            string numara = Console.ReadLine();
            hazirkayitgetir ekle = new hazirkayitgetir(ad, soyad, numara);
            hazir_kayit.liste.Add(ekle);
        }
    }
}
