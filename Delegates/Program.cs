using System;

namespace Delegates
{
    class Program
    {
        delegate void Dikdortgen(double x, double y);

        static void Main(string[] args)
        {
            //Delegate: Temsilci =>methodları daha iyi yönetmek için var!

            //delegate tipin hangi metolara referans etmesini istiyorsan, o methodun şablonunda delegate tipi oluşturman gerekiyor!

            Dikdortgen test = new Dikdortgen(cevre); //delegate tipimden nesne oluşturdum!

            test += alan; //ilk oluşturulan nesne olan cevre ardından alanı getirir!

            test(4, 6);

            Console.WriteLine("-----------------------");

            test -= cevre; //test delegesinden çecreyi çıkardım artık sadece alanı referans eder!

            test(4, 6); //bu şekilde diyince bana delegate alanı referans ettiği için alanı çağıracaktır!

            Console.WriteLine("-----------------------");

            Dikdortgen test1 = cevre; //bu şekilde de kullanılabilir!

            test1(4, 6);

            Console.ReadLine();
        }

        static void cevre(double a,double b)
        {
            Console.WriteLine(2 * (a + b));
        }

        static void alan(double a,double b)
        {
            Console.WriteLine(a * b);
        }
    }
}
