using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entity
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TcKimlikNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; } // 1 Erkek, 0 Kadin
        public string Birim { get; set; }

        // Bu property ComboBox'tan personel isim ve soyismini gormek icin olusturuyoruz, o yuzden set metodunu kaldirdik. Ayrica DB'de olmayacak.
        public string IsimSoyisim { get { return Isim + " " + Soyisim; } }

        // Nav Prop
        public IletisimBilgisi IletisimBilgisi { get; set; }
    }
}
