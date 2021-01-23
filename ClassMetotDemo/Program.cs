using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Esma";
            musteri1.Soyad = "Karagülle";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri1);





        }
    }
}
