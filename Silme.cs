using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_rehber_uygulaması
{
    class Silme
    {

        public static void Sil (List<hazirkayitgetir> liste)
        {
            bool deger = false;
            while (deger != true)
            {
                Console.WriteLine("Lütfen Numarasını Silmek İstediğiniz Kişinin Adını,Soyadını Veya Numarasından Birini Giriniz ");
                string degeral = Console.ReadLine();
                foreach (hazirkayitgetir item in liste)
                {
                    if (item.Ad == degeral || item.Soyad == degeral || item.Numara == degeral)
                    {
                        Console.Write("{0} İsimli Kişiyi Rehberden Siliyorsunuz, Onay İçin(y) İptal İçin (n)", item.Ad);

                        char ok = char.Parse(Console.ReadLine());
                        if (ok== 'y')
                        {
                            hazir_kayit.liste.Remove(item);
                            deger = true;
                            break;
                        }
                        else
                        {
                            deger = true;
                            break;
                        }
                    }
                }
                Console.WriteLine("Aradığınız Kriterlere Uygun Kişi rehberde bulunamadı. Lütfen Bir Seçim Yapınız.");
                Console.WriteLine("- Silmeyi İptal Et : (1)");
                Console.WriteLine("- Silme İşlemini Tekrar Et  : (2)");
                int degeral2 = Int32.Parse(Console.ReadLine());
                switch (degeral2)
                {
                    case 1:
                        {
                            deger = true;
                            break;
                        }
                    case 2: break;
                    default:
                        {
                            Console.WriteLine("Yanlış Değer Girdiniz !!!");
                            break;
                        }
                }
            }
        }
    }
}
