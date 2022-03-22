using System;

namespace MethodParameters
{
    class Islem
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Toplama()
        {
            return this.X + this.Y; //işlem sınıfının içerisindeki propertylere geçiş yapmak için this kullanıyoruz!
        }

        public int Toplama2(int a,int b)
        {
            return a + b;
        }

        public int Toplama3(int c,int d, int e = 0)
        {
            return c + d + e;
        }

        //BURASI ÖNEMLİ!!!!!!!!!!!!(Params Usage)!!!!!!!!!!!!!!!!!!!!!!!
        public int Toplama4(params int[] numbers) //kaç sayı toplayacağım bilinmiyorsa bu şekilde params kullanarak yap!
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;

            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Islem ıslem = new Islem();

            ıslem.X = 10;
            ıslem.Y = 15;
            Console.WriteLine (ıslem.Toplama()); //yukarıda method kısmında console uygulamasında çalışacağını belirtmediğim için burada ekrana yazdırmak için console.writeline yapmam lazım!

            Console.WriteLine("-------------------------------");
            
            Console.WriteLine(ıslem.Toplama2(b:10,a:38)); //parametrelerin sırasını hatırlamazsan bu şekilde hangi parametreye hangi değeri verdiğini belirte bilirsin!(Named parameter)

            Console.WriteLine("-------------------------------");

            Console.WriteLine(ıslem.Toplama3(10,13)); //3 parametreli methoda yukarıda e değerine 0 atayarak 2 parametre gönderirsem toplama işlemi için sonuca etki etmeyip istediğim şekilde kullanmış olurum(default)

            Console.WriteLine("-------------------------------");

            Console.WriteLine(ıslem.Toplama4(10,15,25,65,80)); //toplamak istediğim sayının adedini bilmediğimde params kullanarak bir dizi şekinde sayılar içeren method kullanarak yaptım!

        }
    }
}
