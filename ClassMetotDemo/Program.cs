using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Zeynep";
            musteri1.MusteriSoyadi = "ÖZBALKANLILAR";
            musteri1.TcKimlikNo = "45287641256";
            musteri1.MusteriTipi = "Maaş";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Mehmet";
            musteri2.MusteriSoyadi = "BAYRAM";
            musteri2.TcKimlikNo = "456214578411";
            musteri2.MusteriTipi = "KOBİ";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Tufan";
            musteri3.MusteriSoyadi = "ÖZBALKANLILAR";
            musteri3.TcKimlikNo = "45512565899";
            musteri3.MusteriTipi = "Emekli";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriTipi);
            }

        }
    }
}
