using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Tarık";
            musteri.Soyad = "Göşker";
            musteri.Eposta = "tarikgosker@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";
            musteri2.Eposta = "engindemirog@gmail.com";

            Musteri[] musteriListe = new Musteri[] { musteri, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Silme(musteri);
            musteriManager.Ekle(musteri2);
            musteriManager.Silme(musteri2);
            musteriManager.Listeleme(musteriListe);

            Console.ReadKey();
        
        
        }
    }
}
