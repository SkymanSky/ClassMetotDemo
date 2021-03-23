using System;
using System.Collections.Generic;
using System.Text;


namespace ClassMetotDemo
{
    public class MusteriManager
    {
        string MusteriAdi;

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " isminde bir musteri eklendi.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteri Id: " + musteri.MusteriId);
            Console.WriteLine("Musteri Adı: " + musteri.MusteriAdi);
            Console.WriteLine("Musteri Soyadı: " + musteri.MusteriSoyadi);
            Console.WriteLine("Musteri İkameti: " + musteri.MusteriIkamet);
                             
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " isminde bir musteri silindi.");

        }
    }
}
