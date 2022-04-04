using System;

namespace EnumApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri(1,"Ali","Türkmen","Erkek","abc@gmail.com");

            //ctorsuz tanımlayacaksam müşteriyi aşağıdaki gibi!

            /*
            musteri.Id = 1;
            musteri.Isim = "Ali";
            musteri.Soyisim = "Türkmen";
            musteri.Cinsiyet = "Erkek";
            musteri.EmailAdresi = "abc@gmail.com";
            */

          MusteriDurum donendurum=  musteri.MusteriEkle(musteri); //oluşturmuş olduğum müşteriyi parametre olarak verdim! (başarılı bir işlemse enum döndüreceği için bunu musteridurum tipiyle yakalamam lazım!)

            if (donendurum==MusteriDurum.kayitbasarili) //fakat bu kod değişebilir ve büyük projede nereden geldiğini bulmak zor olabilir işte burada devreye enum lar girer!
            {
                Console.WriteLine("Müşteri başarılı bir şekilde eklenmiştir!");
            }

            Console.ReadLine();
        }
    }
}
