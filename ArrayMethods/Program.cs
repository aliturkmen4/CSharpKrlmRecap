using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ahmet", "Çınar", "Ada", "Yiğit", "Sena" };
            int[] numaralar = { 5, 6, 3, 8, 11 };
            isimler[0] = "Ali";
            isimler.SetValue("Ahmet", 1); //atamak istediğin değeri ve kaçınca indexe atamak istediğini yazıyorsun!

            Console.WriteLine(isimler.GetValue(1)); //aşağıdakiyle aynı görevi yapar, 1.indexteki değeri ekrana yazdırır!
            Console.WriteLine(isimler[1]);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(Array.IndexOf(isimler, "Ali")); // ali isimler dizisinin kaçıncı indexi dedim!
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine(isimler.Length); //isimler dizisinin uzunluğu yani kaç elemanı olduğu!
            Console.WriteLine("------------------------------------------------");

            Array.Sort(isimler); //isimler dizisini alfabetik sıraya göre sıralar!
            Console.WriteLine(isimler.GetValue(0)); //isme göre alfabetik olarak sıraladığımdan 0.index yani ilk eleman olarak ada geldi!
            Console.WriteLine("------------------------------------------------");
            Array.Sort(numaralar); //sayıları küçükten büyüğe sıralar!

            Console.WriteLine(numaralar.GetValue(0));
            Console.WriteLine("------------------------------------------------");

            Array.Reverse(isimler); //string bir dizinin elemanlarını sondaki başa baştaki sona gelecek şekilde ters çevirir!

            Array.Reverse(numaralar); //int bir dizinin elemanlarını sondaki başa baştaki sona gelecek şekilde ters çevirir!

            Console.WriteLine(isimler.GetValue(0));
            Console.WriteLine(numaralar.GetValue(0));

            Console.WriteLine("------------------------------------------------");

            Array.Clear(isimler, 0, 2); //isimler dizisinin 0.indexinden itibaren iki tane elemanı sil!

            Console.WriteLine(isimler[0]); //böyle dersem bana bir boşluk karakter gönderilir(stringler nullable olduğu için) çünkü az önce sıfırıncı elemanı sildim!

            Console.WriteLine("------------------------------------------------");

            Array.Clear(numaralar, 0, 2);

            Console.WriteLine(numaralar.GetValue(0)); //böyle dersem 0 gönderilir(integerlar nullable olmadığı için) çünkü az önce sıfırıncı elemanı sildim!

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine(isimler[^1]); //carrot karakteri sondan getirir! indexleme sondan olursa 1den başlar!!!! dizinin son elemanını getirir!!

            Console.WriteLine("------------------------------------------------");

            foreach (var isim in isimler) //isimler dizisinin collection kısmına veriyor bunun içerisindeki elemanlar tek tek isim içerisine sırayla kopyalanıyor!
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("------------------------------------------------");
            string[] isimler2 = { "Ayşe", "Fatma", "Hayriye", "Dursun" };
            var result = isimler2[1..4]; //1.indexten başla 4.indexe kadar git!(4 dahil değil)!!(1,2 ve 3.indexi alır!)

            foreach (var isim in result)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("------------------------------------------------");
            var result2 = isimler2[2..]; //2.indexten başla ve hepsini getir demek!
            foreach (var isim in result2)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("------------------------------------------------");
            string msg2 = "Hello world!";
            Console.WriteLine(msg2[0..5]); //0. indexten 4.index dahil olana kadar getirdi yani hello yazısını!
        }
    }
}
