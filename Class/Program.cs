using System;

namespace Class
{
    class Ogrenci
    {
        public int Ogrno { get; set; }

        public string Ad { get; set; }

        public string Sube { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //class içerisine gruplamak istediğim verileri tanımlıyorum ! örneğin bir öğrencinin öğr. no, ad soyad ve şube bilgisi gibi bunu arrayle vs. yapmak yerine farklı tür veri tanımlayabileceğim classla yapmak daha mantıklı!
            // =>class tan türetilen yapıya nesne denir! her bir öğrenci için öğrenci sınıfından bir kopya (nesne) oluşturmamız gerekiyor!

            //bir araba sınıfı düşünelim;
            // => marka,model,renk,agırlık bu arabanın propertyleri olurken;
            //=> start(),stop(),hızlan(),yavasla() gibi eylem bildirenler ise methoddur.
            //buradaki nesnelerim opel, mazda,toyota,hyundai vs dir. bu yeteneklerin(method ve property) hepsi nesne üzerine gider!

            int[] ogrno = { 100, 200, 300 };
            string[] adsoyad = { "Çınar", "Ada", "Yiğit" };
            string[] sube = {"10A","10B","11A" };

            Console.WriteLine($"no: {ogrno[0]} ad:{adsoyad[0]} sube: {sube[0]}");
            Console.WriteLine($"no: {ogrno[1]} ad:{adsoyad[1]} sube: {sube[1]}");
            Console.WriteLine($"no: {ogrno[2]} ad:{adsoyad[2]} sube: {sube[2]}");

            Console.WriteLine("-----------------------");

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Ad = "Çınar";
            ogr1.Ogrno = 100;
            ogr1.Sube = "10A";

            Console.WriteLine(ogr1.Ogrno+" "+ogr1.Ad+" "+ogr1.Sube);

            Console.WriteLine("------------------------");

            Ogrenci ogr2 = new Ogrenci()
            {
                Ogrno=200,
                Ad="Ada",
                Sube="10B"
            };

            Console.WriteLine(ogr2.Ogrno + " " + ogr2.Ad + " " + ogr2.Sube);

            Console.WriteLine("------------------------");

            Ogrenci ogr3 = new Ogrenci()
            {
                Ogrno = 300,
                Ad = "Yiğit",
                Sube = "11A"
            };

            Console.WriteLine($"no:{ogr3.Ogrno} ad:{ogr3.Ad} sube:{ogr3.Sube}");

            Console.WriteLine("------------------------");

            Ogrenci[] ogrenciler = new Ogrenci[3]; //artık bir öğrenci tipim var bu tipte bir dizi tanımlayabilirim!

            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;
            ogrenciler[2] = ogr3;

            for (int i = 0; i < ogrenciler.Length; i++) //öğrencilerin i. indexindeki ad, ogrno ve sube bilgilerini bu sekilde yazırabilirim! 
            {
                Console.WriteLine($"no:{ogrenciler[i].Ogrno} ad:{ogrenciler[i].Ad} sube:{ogrenciler[i].Sube}");
            }
        }
    }
}
