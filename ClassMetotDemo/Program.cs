using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Kemal";
            musteri1.Soyad = "Sancak";
            musteri1.Cinsiyet = "Erkek";
            musteri1.Yas = 28;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Selin";
            musteri2.Soyad = "Baytar";
            musteri2.Cinsiyet = "Kadın";
            musteri2.Yas = 22;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Hakan";
            musteri3.Soyad = "Kızak";
            musteri3.Cinsiyet = "Erkek";
            musteri3.Yas = 25;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Ayşe";
            musteri4.Soyad = "Ay";
            musteri4.Cinsiyet = "Kadın";
            musteri4.Yas = 27;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Ad = "Emirhan";
            musteri5.Soyad = "Cebiroğlu";
            musteri5.Cinsiyet = "Erkek";
            musteri5.Yas = 19;

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3,musteri4 };

            Console.WriteLine("Müşteri Listesi:");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + ". " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Cinsiyet + " " + musteri.Yas);
            }

            Console.WriteLine("---------------------------------------");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriEkle(musteri5);


            MusteriManager musteriManager1 = new MusteriManager();

            musteriManager1.MusteriSil(musteri2);


            
        }
    }
}
