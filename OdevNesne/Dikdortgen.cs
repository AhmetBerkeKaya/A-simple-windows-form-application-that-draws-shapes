using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevNesne
{
    public class Dikdortgen : Sekil
    {
        // Auto implemented properties
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
        // Parametreli constructor methot
        public Dikdortgen(int id, string adi, ERenk rengi, double en, double boy):base(id, adi, rengi)
        {
            Genislik = en;
            Yukseklik = boy;
        }

        // Çok biçimlilik kullanılarak alan hesaplayan metot
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
        // Çok biçimlilik kullanılarak çevre hesaplayan metot
        public override double CevreHesapla()
        {
            return 2 * (Genislik + Yukseklik);
        }
        // Çok biçimlilik kullanılarak bilgi yazdıran metot
        public override string BilgiYazdir()
        {
            return base.BilgiYazdir()+" genişliği "+ Genislik+" yüksekliği "+Yukseklik +" alanı " + AlanHesapla() + " ve çevresi " + CevreHesapla() + " dir.";
        }
    }
}
