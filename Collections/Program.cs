using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eleman gruplamak için diziler ya da collectionlar kullanılabilir!

            //arraylar fixed size olduğu için collectionlara da ihtiyaç duyulur!

            //------------------------------------------

            //collections

            //=>non-generic
            //**ArrayList,SortedList

            //=>generic List<T> tip bildirimi yapman gerekiyor!
            //**int,string,Product

            //--------------------------------------------

            //ArrayList Kullanımı

            ArrayList myList = new ArrayList();

            myList.Add(10);
            myList.Add("10");
            myList.Add(10.5);

            ArrayList myList2 = new ArrayList() { 15, "abc", 10.5 }; //bu şekilde de elemanları gönderebiliriz!

            //Accessing Items

            Console.WriteLine(myList[0]);

            int sayı = (int)myList[0]; //gelen eleman object türünde olduğu için tür dönüşümünde bulundum!

            myList.Insert(1, 20); //1.indexe 20 değerini attım! diğerleri 1 aşağı kayar!

            myList.InsertRange(3, myList2); //3.indecten itibaren listeme myList2 listesinin elemanlarını ekler!

            Console.WriteLine("-------------------------");

            foreach (var item in myList) //GetEnumarator listeyi foreach içinde kullanmamı sağladı!
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            //Remove Items

            myList.Remove(10); //int olan 10 elemanlarını listeden siler.

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            myList.RemoveAt(2); //2.indexteki elemanı siler!

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            myList.RemoveRange(0, 2); //0.indexten başla 2 elemanı sil! 

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            Console.WriteLine(myList.Contains(10)); //myList'in içerisinde 10 değeri var mı?(true-false döner)

            Console.WriteLine("-------------------------");

            ArrayList sayilar = new ArrayList() { 10, 5, 4, 60 };

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            sayilar.Sort(); //farklı veri tiplerini karşılaştıramaz!

            Console.WriteLine("-------------------------");

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            //Generic List<T>

            //boyutu başta bilinmeyen listelerde kullanılır! Başta tip belirtilir!

            List<int> sayilar1 = new List<int>(); //içine sadece int bilgi bekler!

            sayilar1.Add(10);
            sayilar1.Add(20);
            sayilar1.Add(30);

            List<string> isimler1 = new List<string>();

            isimler1.Add("ali");
            isimler1.Add("eray");
            isimler1.Add("şerif");
            isimler1.Add("erdem");

            List<Product> urunler = new List<Product>()
            {
            new Product() { Name = "Samsung S6" },
            new Product() { Name = "Samsung S7" },
            new Product() { Name = "Samsung S8" },
            new Product() { Name = "Samsung S9" }
              };
            //süslü parantezin içine yazma constructor aracılığı ile eleman ekleme!

            List<Product> urunler2 = new List<Product>()
            {
                new Product() { Name = "Samsung S1" },
            new Product() { Name = "Samsung S2" },
            new Product() { Name = "Samsung S3" },
            new Product() { Name = "Samsung S4" }
            };

            urunler.AddRange(urunler2); //urunler üzerine urunler2 elemanları eklenmiş olur!

            //AddRange methodu listlerde kullanıldı için urunlerin tipi list olmalı, urunler2 nin tipi IList olabilir !!

            foreach (var sayi in sayilar1)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("-------------------------");

            foreach (var product in urunler)
            {
                Console.WriteLine(product.Name); //her bir productın name alanına ulaşıyorum!
            }
            Console.WriteLine("-------------------------");

            urunler.ForEach(p => Console.WriteLine(p.Name)); // yukarıdaki foreach bloğula aynı görevi yapar!

            Console.WriteLine("-------------------------");

            for (int i = 0; i < urunler2.Count; i++) //urunler2 nin eleman sayısı kadar dön dedim!
            {
                Console.WriteLine(urunler2[i].Name);
            }

            Console.WriteLine("-------------------------");

            int count = urunler.Count;

            Console.WriteLine(count); //urunler içerisindeki eleman sayısını getirir!

            Console.WriteLine("-------------------------");

            Console.WriteLine(urunler2[0].Name); //bize burdan nesne gelir ama nesnenin de name ine ulaşmak için Name ekle!!

            Console.WriteLine("-------------------------");

            //Insert Items
            sayilar1.Insert(1, 100); //sayılar1 in 1.indexine 100 sayısını ekledim!

            foreach (var sayi2 in sayilar1)
            {
                Console.WriteLine(sayi2);
            }

            Console.WriteLine("-------------------------");

            sayilar1.Insert(sayilar1.Count, 100); //sayılar1 in en sonuna 100 elemanını ekledim!!
            foreach (var sayi2 in sayilar1)
            {
                Console.WriteLine(sayi2);
            }

            Console.WriteLine("-------------------------");

            urunler.InsertRange(1, urunler2); //urunlere 1.indexten itibaren urunler2 yi ekledim!

            for (int i = 0; i < urunler.Count; i++) 
            {
                Console.WriteLine(urunler[i].Name);
            }

            Console.WriteLine("-------------------------");

            sayilar1.Remove(10); //10 elemanını siler!

            foreach (var sayi in sayilar1)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("-------------------------");

            sayilar1.RemoveAt(0); //o.indexteki elemanı siler!
        }
    }

    class Product
    {
        public string Name { get; set; }
    }
}
