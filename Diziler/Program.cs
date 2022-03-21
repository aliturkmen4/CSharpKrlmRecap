using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello there. My name is Ali Türkmen";

            //Console.WriteLine(msg.Split());

            var result = msg.Split(); // boşluk karakterlerden string ifademi bölerek her bir elemanı bir dizi içerisine atar! ve dizi içerisinden her bir elemana ulaşmak için bir index numarası veriliyor!
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);
            Console.WriteLine(result[3]);
            Console.WriteLine(result[4]);
            Console.WriteLine(result[5]);
            //yukarıda ilk 6 kelimeyi ekrana yazdırdım!

            //string ifadelerde aslında bir dizidir!

            Console.WriteLine(msg[0]);
            Console.WriteLine(msg[1]);
            Console.WriteLine(msg[2]);
            Console.WriteLine(msg[3]);
            Console.WriteLine(msg[4]);
            // böyle yapınca da hello kelimesinin harflerini yazdırdım!

            string[] isimler = new string[5];
            string[] isimler2 = { "Ahmet", "Çınar", "Ada", "Yiğit", "Sena" }; //aşağıdaki gibi tek tek tanımlamak yerine bu şekilde de yapılabilir!
            
            //tek bir değişken ismiyle aynı tür bilgileri bir değişken içerisinde saklamaya yarar!

            isimler[0] = "Ahmet";
            isimler[1] = "Çınar";
            isimler[2] = "Ada";
            isimler[3] = "Yiğit";
            isimler[4] = "Sena";

            Console.WriteLine(isimler[1]);

            int[] numaralar = new int[5];
            numaralar[0] = 101;
            numaralar[1] = 102;
            numaralar[2] = 103;
            numaralar[3] = 104;
            numaralar[4] = 105;

            Console.WriteLine($"öğrenci adı:{isimler[0]} ve numara: {numaralar[3]}");
            Console.WriteLine($"öğrenci adı:{isimler[2]} ve numara: {numaralar[1]}");
            Console.WriteLine($"öğrenci adı:{isimler[1]} ve numara: {numaralar[0]}");
            Console.WriteLine($"öğrenci adı:{isimler[3]} ve numara: {numaralar[2]}");
            Console.WriteLine($"öğrenci adı:{isimler[4]} ve numara: {numaralar[4]}");
        }
    }
}
