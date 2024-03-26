using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevNesne
{
    // Şekil sınıfı
    public class Sekil
    {
        // Renk seçmek için enum yapısı
        public enum ERenk
        {
            Kirmizi,
            Mavi,
            Yesil,
            Sari,
            Siyah
        }

        // Auto-implemented properties
        public int Id { get; set; }
        public string Ad { get; set; }
        public ERenk Renk { get; set; }


        // Parametreli yapıcı metot
        public Sekil(int id, string adi, ERenk rengi)
        {
            Id = id;
            Ad = adi;
            Renk = rengi;

        }
        // Bilgi yazdıran fonksiyon
        public virtual string BilgiYazdir()
        {
            return Id + " numaralı " + Renk + " " + Ad + " şeklinin ";
        }

        // Çevre hesaplayan fonksiyon
        public virtual double CevreHesapla()
        {
            return 0;
        }
        // Alan hesaplayan fonksiyon
        public virtual double AlanHesapla()
        {
            return 1;
        }
    }
}
