using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_rehber_uygulaması
{
    class Arama
    {
        public static void Ara(List<hazirkayitgetir> liste)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int deger = Int32.Parse(Console.ReadLine());
            switch (deger)
            {
                case 1:
                    {
                        Console.Write("İsim yada Soyisim Giriniz: ");
                        string Ads = Console.ReadLine();
                        foreach (var item in liste)
                        {
                            if (item.Ad == Ads || item.Soyad == Ads)
                            {
                                Console.WriteLine("İsim: {0}", item.Ad);
                                Console.WriteLine("Soyisim: {0}", item.Soyad);
                                Console.WriteLine("Numara: {0}", item.Numara);
                                Console.WriteLine("-");
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("Numara giriniz: ");
                        string number = Console.ReadLine();
                        foreach (var item in liste)
                        {
                            if (item.Numara == number)
                            {
                                Console.WriteLine("İsim: {0}", item.Ad);
                                Console.WriteLine("Soyisim: {0}", item.Soyad);
                                Console.WriteLine("Numara: {0}", item.Numara);
                                Console.WriteLine("-");
                            }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Geçerli Bir Değer Giriniz!!!");
                        break;
                    }
            }
        }
    }
}

