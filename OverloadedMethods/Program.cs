using System;

namespace OverloadedMethods
{
    class Islem
    {
        public int Toplama(int a,int b)
        {
            return a + b;
        }
        public int Toplama(int a,int b,int c)
        {
            return a + b + c;
        }
        public int Toplama(int a,int b,int c,int d)
        {
            return a + b + c + d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var ıslem = new Islem();

            Console.WriteLine(ıslem.Toplama(2,3)); //ilk methodu (2parametre alanı kullanır!) toplama methodunun üstüne gelirsen 2 overload u daha olduğunu söyler! 

            Console.WriteLine(ıslem.Toplama(4,6,9)); //ikinci methodu(3parametre alanı kullanır!)

            Console.WriteLine(ıslem.Toplama(21,4,77,8)); //üçüncü methodu(4parametre alanı kullanır!)

            //methodları aşırı yüklemek için yapmamız gereken aynı isimdeki methodun parametre sayılarının farklı olması gerekiyor!
        }
    }
}
