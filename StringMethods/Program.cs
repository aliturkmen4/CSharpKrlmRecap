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

            Console.WriteLine(msg.IndexOf("name")); //name kelimesi kaçıncı indexten itibaren başlıyor bilgisini verir.

            Console.WriteLine(msg.Substring(5)); //bize 5.indexten itibaren bilgiyi getirir! ' there. My name is ALİ Türkmen' olarak!

            Console.WriteLine(msg.Substring(5,10)); //5.indexten 10 index getir! ' there.My ' getirir!

            int index = msg.IndexOf("name");
            Console.WriteLine(msg.Substring(index)); // önce name in kaçıncı index olduğunu buldum sonra o indexten sona kadar gitmesini sağladım!

            Console.WriteLine(msg.Replace(" ","-")); //boşluk karakterlerini - karakterleri ile değiştirdim!

            Console.WriteLine(msg.Insert(0,"---")); //0.karakterden başlasın --- eklesin dedim!

            Console.WriteLine(msg.Insert(msg.Length,"---")); //string ifademin en sonuna --- eklesin dedim!

            Console.WriteLine(msg.Remove(5)); //5.indexten itibaren sil dedim!

            Console.WriteLine(msg.Remove(5,10)); //5.indexten itibaren 10 tane sil dedim!
        }
    }
}
