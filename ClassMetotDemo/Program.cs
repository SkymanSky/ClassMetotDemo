using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)

        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Skyman";
            musteri1.MusteriSoyadi = "Sky";
            musteri1.MusteriIkamet = "İstanbul";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);

            Console.WriteLine("------Musteri Listesi------");
            musteriManager.Listele(musteri1);

            Console.WriteLine("---------------------------");
            musteriManager.Sil(musteri1);


        }
    }
}
