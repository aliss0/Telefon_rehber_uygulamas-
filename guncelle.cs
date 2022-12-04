using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_rehber_uygulaması
{
    class guncelle
    {
        public static void Güncelle (List<hazirkayitgetir>liste)
        {

        
        bool deger = false;
            Console.WriteLine("Lütfen Numarasını Güncellemek İstediğiniz Kişinin Adını,Soyadını Veya Numarasından Birini Giriniz ");
            string degeral = Console.ReadLine();
            while (deger != true)
            {
                bool bak = false;
                while (bak != true)
                {
                    foreach (hazirkayitgetir item in liste)
                    {
                        if (item.Ad == degeral || item.Soyad == degeral || item.Numara == degeral)
                        {
                            Console.Write("Lütfen Yeni İsim Giriniz            :");
                            item.Ad = Console.ReadLine();
                            Console.Write("Lütfen Yeni Soyisim Giriniz          :");
                            item.Soyad = Console.ReadLine();
                            Console.Write("Lütfen Yeni Telefon Numarası Giriniz :");
                            item.Numara = Console.ReadLine();
                            deger = true;
                            bak = true;
                            break;

                        }
                    }
                    if (bak)
                    {
                        break;
                    }
                    Console.WriteLine("Aradığınız Kriterlere Uygun Kişi Rehberde Bulunamadı. Lütfen Bir Seçim Yapınız.");
                    Console.WriteLine("- Güncelleme İşlemini Bitir : (1)");
                    Console.WriteLine("- Güncelleme İşlemine Devam Et  : (2)");
                    int deger2 = Int32.Parse(Console.ReadLine());
                    switch (deger2)
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
}
