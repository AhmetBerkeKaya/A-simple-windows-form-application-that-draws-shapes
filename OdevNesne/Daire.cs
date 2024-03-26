using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevNesne
{
    public class Daire : Sekil    // Kalıtım
    {
        // Tanımlama ve auto implemented properties
        public double cevre;
        public double Cap { get; set; }
        public double Aci { get; set; }

        // Constructor method
        public Daire(int id, string adi, ERenk rengi, double cap, double aci):base(id, adi, rengi)
        {
            Cap = cap;
            Aci = aci;
        }

        // Çok biçimlilik kullanılarak çevre hesaplayan metot
        public override double CevreHesapla()
        {
            if (Aci == 360)
            {
                cevre = (Math.PI * Cap);
            }
            else
            {
                cevre = ((Math.PI * Cap) * (Aci / 360));
            }
            return cevre;
        }
        // Çok biçimlilik kullanılarak alan hesaplayan metot
        public override double AlanHesapla()
        {
            return (Math.PI / 360) * Math.Pow(Cap, 2) * Aci;
        }
        // Çok biçimlilik kullanılarak bilgi yazdıran metot
        public override string BilgiYazdir()
        {
            return base.BilgiYazdir()+ "çapı "+Cap+" açısı "+Aci +" alanı " + AlanHesapla() + " ve çevresi " + CevreHesapla() + " dir. ";
        }
    }
}
