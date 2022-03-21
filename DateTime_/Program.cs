using System;
using System.Globalization;

namespace DateTime_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime simdi = DateTime.Now; //bilgisayarın şu anki tarih ve saat bilgilerini getirir!          
            Console.WriteLine(simdi);
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.Year); //şuanki zamanın sadece yıl bilgisini almaya yarar!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.Month); //şuanki zamanın sadece ay bilgisini almaya yarar!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.Day); //şuanki zamanın sadece gün bilgisini almaya yarar!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.Hour); //şuanki zamanın sadece saat bilgisini almaya yarar!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.Minute); //şuanki zamanın sadece dakika bilgisini almaya yarar!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.Second); //şuanki zamanın sadece saniye bilgisini almaya yarar!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.DayOfWeek); //şu anki sadece zamanın haftanın hangi gününde olduğumuz bilgisini getirmeye yarar!
            Console.WriteLine("------------------");

            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

            Console.WriteLine(aylar[simdi.Month-1]); // şu anki ayım mart mart 3 olarak gelecek aylar[2] de mart'a denk geleceği için -1 koydum!
            Console.WriteLine("------------------");

            DateTime dt = new DateTime(2018, 2, 15, 14, 30, 21); //datetime içerisindeki objeleri kendim belirttim!
            DateTime dt1 = dt.AddDays(2); //mevcut gün üzerine 2 gün ekler! 15+2=17 yapar!
            Console.WriteLine(dt1);
            Console.WriteLine("------------------");

            DateTime dt2 = dt.AddHours(5); //mevcut saat üzerine 5 saat ekledim!
            Console.WriteLine(dt2);
            Console.WriteLine("------------------");

            //TimeSpan objesi iki tarih arası farkı bize verir!!

            var fark = simdi - dt;
            Console.WriteLine(fark.TotalDays); //gün bazında iki saat arasındaki farkı buldum!
            Console.WriteLine("------------------");

            Console.WriteLine(fark.TotalHours); //saat bazında iki tarih arasındaki farkı buldum!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi);
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.ToString("d")); //21.03.2022 formatında döndürür
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.ToString("D")); // 21 Mart 2022 Pazartesi formatında döndürür!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.ToString("F")); //21 Mart 2022 Pazartesi 15:01:48 formatında döndürür!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.ToString("M")); //21 Mart formatında döndürür!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.ToString("t")); //15:01 formatında döndürür!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.ToString("T")); //15:01:48 fotmatında döndürür!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.ToString("Y")); //Mart 2022 formatında döndürür!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.ToString("hh:mm:ss")); //istidiğim formatı bu şekilde bende verebilirim!!
            Console.WriteLine("------------------");

            Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy"));
            //istidiğim formatı bu şekilde bende verebilirim!!
            //Pzt Mar 21, 2022 bu formatta bir çıktı alırım!
            Console.WriteLine("------------------");

            CultureInfo culture = new CultureInfo("en");
            //verileri istediğim dilde getirmeme yaradı!
            //CultureInfı kullanabilmek için gloablization kütüphanesini yukarı ekle!!!
            Console.WriteLine(simdi.ToString("F",culture));
        }
    }
}
