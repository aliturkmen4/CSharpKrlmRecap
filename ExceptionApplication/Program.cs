using System;
using System.Collections.Generic;

namespace ExceptionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //"1","2","5a","10b","abc","10","50"
            //1.Liste içerisindeki sayısal değerleri bulunuz!

            var liste = new List<string>()
            {
                "1","2","5a","10b","abc","10","50"
            };

            foreach (var item in liste)
            {
                try
                {
                    int a = int.Parse(item);
                    Console.WriteLine(a);
                }
                catch (Exception)
                {
                    continue; //bunu koymazsam hatayı bulunca döngüden ayrılır ve 5a dan sonraki sayılar değerleri alamam!

                    
                }
            }

            //2.kullanıcı 'q' değerini girmedikçe aldığınız her değerin sayısal olup olmadığını kontrol edin aksi halde hata mesajı verdirin!

            Console.WriteLine("--------------------------------");

            while (true)
            {
                Console.WriteLine("sayı: ");
                string input = Console.ReadLine();

                if (input == "q")
                    break;
                try
                {
                    int sayi = int.Parse(input);
                    Console.WriteLine("girdiğiniz sayı:{0}", sayi);
                }
                catch (Exception)
                {
                    Console.WriteLine("geçersiz sayı");
                }
                
            }
        }
    }
}
