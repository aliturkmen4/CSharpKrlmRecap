using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary <TKey, TValue>

            //plaka => (34:İstanbul) , (35,İzmir)

            Dictionary<int, string> plakalar = new Dictionary<int, string>();

            plakalar.Add(34, "İstanbul");
            plakalar.Add(35, "İzmir");
            plakalar.Add(07, "Antalya");

            Dictionary<int, string> sayilar = new Dictionary<int, string>()
            {
                {1,"Bir"},
                {2,"İki"},
                {3,"Üç"}
            };

            Console.WriteLine(sayilar[1]); //Elemanlar 0dan başlayan index numarasına değil de bizim verdiğimiz index numaralarına bağlılar!

            Console.WriteLine("--------------------------");

            foreach (var plaka in plakalar)
            {
                Console.WriteLine($"{plaka.Key} {plaka.Value}"); //plakaların key ve value değerlerine bu şekilde ulaşılır!!
            }

            Console.WriteLine("--------------------------");

            Console.WriteLine(plakalar.ContainsKey(41)); //plakaların içinde 41 olan var mı?(true-false bilgisi)

            Console.WriteLine("--------------------------");

            Console.WriteLine(plakalar.ContainsKey(07));

            Console.WriteLine("--------------------------");

            plakalar.Remove(34); //34 key bilgisi olanı siler!

            //Hastable => Dictionary den farkı 'obje türünden' veri alması yani key değerime de string vs verebilirim!

            Hashtable ht = new Hashtable()
            {

            };

            ht.Add(1, "ali");
            ht.Add('E', "erdem");
            ht.Add("ahmet", "mehmet");
        }
    }
}
