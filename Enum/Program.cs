using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enumeration(Numaralandırmalar) anlamına gelir! Eğer ki 1 gelirse şunu yap, 2 ye bunu yap dediğimiz yerlerde ve bunun gibi işlemlerde oldukça faydalı bir yapıdır!
            //Büyük projelerde önemi ölçülmeyecek kadar büyüktür!

            //Enum içerisinde değer vermezsek, değerler 0'dan başlar ve birer birer artar!

           Gunler gun = Gunler.pazartesi; //pazartesi gününü yakaladım ve gun adındaki değişkenime atadım!

            if (gun == Gunler.pazartesi) //gun==1 dersem kod okunamaz olur, bir daha acıldığında bu neydi dersin!
            {
                Console.WriteLine("Gün Pazartesidir.");
            }
            else if (gun == Gunler.sali)
            {
                Console.WriteLine("Gün Salidir.");
            }
            else if (gun == Gunler.carsamba)
            {
                Console.WriteLine("Gün Carsambadir.");
            }
            else if (gun == Gunler.persembe)
            {
                Console.WriteLine("Gün Persembedir.");
            }
            else if (gun == Gunler.cuma)
            {
                Console.WriteLine("Gün Cumadır.");
            }
            else if (gun == Gunler.cumartesi)
            {
                Console.WriteLine("Gün Cumartesidir.");
            }
            else if(gun==Gunler.pazar)
            {
                Console.WriteLine("Gün Pazardır.");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz!");
            }

            Console.ReadLine();
        }
    }
}
