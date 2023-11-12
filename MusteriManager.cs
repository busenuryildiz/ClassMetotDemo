using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "Numaralı müşteri" + " " + musteri.Adi + " " + musteri.Soyadi + " Listeye eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "Numaralı müşteri" + " " + musteri.Adi + " " + musteri.Soyadi + " Listeden silindi");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "Numaralı müşteri" + " " + musteri.Adi + " " + musteri.Soyadi + " Listelendi");
            Console.WriteLine("Müşteri ID: " + musteri.Id );
            Console.WriteLine("Müşteri Adı Soyadı: " + musteri.Adi+" "+musteri.Soyadi);
            Console.WriteLine("Müşteri Yaşı: " + musteri.Yas);
            Console.WriteLine("Kredi Notu: " + musteri.KrediNotu);

        }
    }
}
