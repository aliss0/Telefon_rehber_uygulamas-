using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_rehber_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            bool döngü = false;
            while (döngü != true)
            {
                hazir_kayit kayitlar = new hazir_kayit();
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz !!! ");
                Console.WriteLine("**********************************************");
                Console.WriteLine("");
                Console.WriteLine("(1) Yeni Bir Numara Kaydet");
                Console.WriteLine("(2) Var Olan Numarayı Sil");
                Console.WriteLine("(3) Var Olan Numarayı Güncelle");
                Console.WriteLine("(4) Rehberi Listele");
                Console.WriteLine("(5) Rehberde Arama Yap");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        {
                            kaydet.Kayıt(hazir_kayit.liste);
                            break;
                        }
                    case "2":
                        {
                            Silme.Sil(hazir_kayit.liste);
                           
                            break;
                        }
                    case "3":
                        {
                            guncelle.Güncelle(hazir_kayit.liste);
                            break;
                        }
                    case "4":
                        {
                            Listele.Listeleme(hazir_kayit.liste);
                            break;
                        }
                    case "5":
                        {
                            Arama.Ara(hazir_kayit.liste);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lütfen Geçerli Değer Giriniz !!!");
                            break;
                        }
                }
                Console.WriteLine("Başka bir işlem yapmak isterseniz (1) ");
                Console.WriteLine("Çıkış yapmak isterseniz           (2) ");
                string deger = Console.ReadLine();
                switch(deger)
                {
                    case "1":
                        {
                            break;
                        }
                    case "2":
                        {
                            döngü = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lütfen Geçerli Değer Giriniz !!!");
                            break;
                        }
                }

            }
        }
    }
}
