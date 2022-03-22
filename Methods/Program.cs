using System;

namespace Methods
{

    class Person
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public void Intro()
        {
            Console.WriteLine($"name: {this.Name} age:{2022 - this.Year}"); //burada this person dan türetilecek olan p1,p2,p3 ü kastediyor!! böyle deyince sadece console uygulamasında çalışan bir şey elde etmiş oluyorum ama sonucumu web de ya da desktop uygulamasaında da istiyor olabilirim!

        }
        public string Intro2()
        {
            return $"name: {this.Name} age:{this.CalculateAge()}"; //böyle yaparsam bütün uygulamalarda çalışacak bir method elde etmiş olurum ve yukarıdaki method la aynı işi yapar! (Console uygulamasına bağımlı bir class değil!)
        }
        public int CalculateAge() //bu yazdığım methodu üsttteki methodda kullandırabilirim!
        {
            return DateTime.Now.Year - this.Year;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            // class => object(nesne)
            // Ogrenci => ogr1,ogr2

            Person p1 = new Person() 
            {
            Name="Ada",
            Year=2012
            };

            Person p2 = new Person() 
            { 
            Name="Yiğit",
            Year=2010
            };

            Person p3 = new Person() 
            { 
            Name="Çınar",
            Year=1999
            };

            //Console.WriteLine($"name: {p1.Name} age:{2022-p1.Year}");
            //Console.WriteLine($"name: {p2.Name} age:{2022 - p2.Year}");
            //Console.WriteLine($"name: {p3.Name} age:{2022 - p3.Year}");

            p1.Intro();
            p2.Intro();
            p3.Intro();

            Console.WriteLine("----------------------------------");

            var str1=p1.Intro2(); //return ettiğim değeri bu şekilde tutuyorum!
            var str2=p2.Intro2();
            var str3=p3.Intro2();

            Console.WriteLine(str1); //console ekranında yazırabilmek için!
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }
}
