using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevNesne
{
    public class EskenarUcgen : Sekil     // Kalıtım
    {
        // Auto implemented properties
        public double Kenar { get; set; }

        // Constructor method
        public EskenarUcgen(int id, string adi , ERenk rengi, double kenar):base(id, adi, rengi)
        {
            Kenar = kenar;
        }
        // Çok biçimlilik kullanılarak ALAN hesaplayan metot
        public override double AlanHesapla()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(Kenar, 2);
        }
        // Çok biçimlilik kullanılarak ÇEVRE hesaplayan metot
        public override double CevreHesapla()
        {
            return  3 * Kenar;
        }
        // Çok biçimlilik kullanılarak BİLGİ YAZDIRAN metot
        public override string BilgiYazdir()
        {
            return base.BilgiYazdir()+" kenar uzunluğu "+Kenar +" alanı " + AlanHesapla() + " ve çevresi " + CevreHesapla() + " dir.";
        }
    }
}
