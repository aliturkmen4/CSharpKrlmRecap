using System;
using System.Collections;

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

        }
    }
}
