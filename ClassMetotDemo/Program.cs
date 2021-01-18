using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ömer";
            musteri1.Soyadi = "DAL";
            musteri1.Yasi = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Cemal";
            musteri2.Soyadi = "KÖPRÜLÜ";
            musteri2.Yasi = 21;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Engin";
            musteri3.Soyadi = "DEMİROĞ";
            musteri3.Yasi = 34;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("------------------------------------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

           

            Console.WriteLine("---------------");
            musteriManager.Listele(musteri1);
            Console.WriteLine("---------------");
            musteriManager.Listele(musteri2);
            Console.WriteLine("---------------");
            musteriManager.Listele(musteri3);

        }
    }
}
