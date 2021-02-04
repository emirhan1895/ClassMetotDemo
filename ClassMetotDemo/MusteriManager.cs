using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri listeye eklendi!! " + musteri.Id + ". " +"Adı: "+ musteri.Ad + ", "+  "Soyad: "+ musteri.Soyad + ", "+ "Yaş: "+ musteri.Yas +", "+ "Cinsiyet: " + musteri.Cinsiyet);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!! " + musteri.Id + ". " + "Adı: " + musteri.Ad + ", " + "Soyad: " + musteri.Soyad + ", " + "Yaş: " + musteri.Yas + ", " + "Cinsiyet: " + musteri.Cinsiyet);
        }

    }
}
