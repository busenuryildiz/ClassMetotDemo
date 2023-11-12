namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Buse";
            musteri1.Soyadi = "Yıldız";
            musteri1.Yas = 23;
            musteri1.KrediNotu = 82;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Burak";
            musteri2.Soyadi = "Yıldız";
            musteri2.Yas = 27;
            musteri2.KrediNotu = 58;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Belinay";
            musteri3.Soyadi = "Yıldız";
            musteri3.Yas = 19;
            musteri3.KrediNotu = 79;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID: " + musteri.Id);
                Console.WriteLine("Müşteri Adı: " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı: " + musteri.Soyadi);
                Console.WriteLine("Müşteri Yaşı: " + musteri.Yas);
                Console.WriteLine("Müşteri Kredi Notu: " + musteri.KrediNotu);
                Console.WriteLine("-----------------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri1);
            Console.WriteLine("-----------------------------------------");
            musteriManager.Listele(musteri1);

        }
    }
}