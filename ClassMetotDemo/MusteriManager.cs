using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("ID=" +musteri.Id + " olan " + musteri.Ad + " " + musteri.Soyad +  " bilgilerine sahip müşteri eklendi");
        }

        public void Listele(Musteri[] musteriler)
        {
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(i+1 +".Müşterinin Bilgileri");
                Console.WriteLine("ID="+musteriler[i].Id);
                Console.WriteLine("AD="+musteriler[i].Ad);
                Console.WriteLine("SOYAD="+musteriler[i].Soyad);
                
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("ID=" + musteri.Id + " olan " + musteri.Ad + " " + musteri.Soyad + " bilgilerine sahip müşteri silindi");
        }
    }
}
