using System;

namespace Interface
{
    interface IKisi
    {
        string adSoyad { get; set; }

        string adres { get; set; }

        double maas { get; set; }
    }
    interface IPersonel //erişim bildirgeci almazlar!
    {
        string departman { get; set; }

        void bilgi();
    }
    class Yonetici : IPersonel,IKisi //implement interface yap IPerson yazdıktan sonra 
    {
        public Yonetici(string _adsoyad,string _adres,string _departman)
        {
            this.adSoyad = _adsoyad;
            this.adres = _adres;
            this.departman = _departman;
        }
        public string adSoyad { get; set ; }
        public string adres { get ; set ; }
        public string departman { get ; set ; }
        public double maas { get ; set ; }

        public void bilgi()
        {
            Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} bölümünde {this.adres} sehrinde yöneticidir.");
        }
    }
    class Isci : IPersonel,IKisi
    {
        public Isci(string _adsoyad, string _adres, string _departman)
        {
            this.adSoyad = _adsoyad;
            this.adres = _adres;
            this.departman = _departman;
        }
        public string adSoyad { get ; set ; }
        public string adres { get ; set ; }
        public string departman { get; set ; }
        public double maas { get ; set ; }

        public void bilgi()
        {
            Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} bölümünde {this.adres} sehrinde işçidir.");
        }
    }

    class Robot : IPersonel
    {
        public Robot(string _departman)
        {
            this.departman = _departman;            
        }
        public string departman { get ; set ; }

        public void bilgi()
        {
            Console.WriteLine($"{this.departman} bölümünde bir robottur.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Interface 

            //Yonetici y = new Yonetici();
            //Isci i = new Isci();

            //ya da bu şekilde:
            //IPersonel y = new Yonetici();
            //IPersonel i = new Isci();

            var personeller = new IPersonel[4];

            personeller[0] = new Yonetici("ali türkmen","antalya","muhasebe");
            personeller[1] = new Isci("asasa fdfsdf","fdsfsdf","bilgiislem");
            personeller[2] = new Yonetici("eray nurtekin","kırklareli","it");
            personeller[3] = new Robot("barista");

            foreach (var personel in personeller)
            {
                personel.bilgi();
            }
        }
    }
}
