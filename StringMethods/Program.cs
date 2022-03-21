using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello there.My name is Ali Türkmen.   ";

            Console.WriteLine(msg.Length); //msg stringinin uzunluğunu buldum!

            Console.WriteLine(msg.ToLower()); //string karakterleri küçük harfe çevirir!

            Console.WriteLine(msg.ToUpper()); //string karakterleri büyük harfe çevirir!

            Console.WriteLine(msg.Trim()); //string ifadenin sağında ve solunda yer alan bütün boşluk karakterlerini siler!

            Console.WriteLine(msg.TrimStart()); //string ifadenin başında yer alan boşluk karakterlerini siler!!

            Console.WriteLine(msg.TrimEnd()); //string ifadenin sonunda yer alan boşluk karakterlerini siler!!

            Console.WriteLine(msg.Split()[0]); //string karakter içerisindeki bütün kelimeleri boşluk karakterden sonra ayırır ve yazdırır! 0. indexi yani ilk kelime olan hello yu getirir!

            Console.WriteLine(msg[4]); //bana 5. harfi yani 4.indexi getirir!

            Console.WriteLine(msg.StartsWith("H")); //benim string ifadem H ile mi başlıyor dedim true false bilgisi döndürür!!

            Console.WriteLine(msg.EndsWith("Türkmen.")); //benim string ifadem Türkmen ile mi bitiyor dedim?

            Console.WriteLine(msg.Contains("there")); //string ifadem their kelimesini içeriyor mu dedim? true-false bilgisi döndürür!


        }
    }
}
