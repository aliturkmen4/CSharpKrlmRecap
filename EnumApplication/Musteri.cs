using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EnumApplication
{
    public class Musteri
    {
        public int Id { get; set; }

        public string Isim { get; set; }

        public string Soyisim { get; set; }

        public string Cinsiyet { get; set; }

        public string EmailAdresi { get; set; }

        public Musteri(int id,string isim,string soyisim,string cinsiyet,string emailadresi)
        {
            this.Id = id;
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Cinsiyet = cinsiyet;
            this.EmailAdresi = emailadresi;
        }

        public static ArrayList musteriler = new ArrayList(); //Arraylist i static tanımlamasak herbir müşteri geldiğinde sıfırdan başlayacaktı!

        public MusteriDurum MusteriEkle(Musteri m1) //musteridurum tipinde bir enum döndüreceğini söyledim!
        {
            musteriler.Add(m1); //müşterimizi koleksiyona ekledik!

            return MusteriDurum.kayitbasarili; //değerin eklendiği anlamına gelsin!

        }


    }
}
