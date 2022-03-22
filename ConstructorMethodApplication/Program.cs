using System;

namespace ConstructorMethodApplication
{
    class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
    }

    class Product
    {
        public Product()
        {
            this.ProductId = (new Random()).Next(11111, 99999); //nesne üretildiği anda değer vermekle uğraşmak istemediğimiz için ctor tanımlayıp propertyslere burada this keywordu kullanarak değer ataması yaparız!
            this.Comments = new Comment[3]; //product nesnesi oluşturulduğu anda burada 3tane objeyi productla ilişkilendirdim!
        }

        public Product(int productId) : this() //bunu diyerek bir önceki constructor'ı da çalıştırıyorum yani comm
        {
            this.ProductId = productId;
        }

        public Product(int productId, string name, double price, bool isApproved) : this(productId) //2.constructor çalıştıktan sonra çalıştırır! productıd yi burada set ettim! karışıklık olmaması için!
        {
            this.Name = name;
            this.Price = price;
            this.IsApproved = isApproved;
        }


        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
        public Comment[] Comments { get; set; } //buradan bir ürünün birden fazla ilişkili olduğu comment olabileceğini anlıyorum!
    }
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Comment { CommentId = 1, Text = "Güzel telefon" };

            var p1 = new Product(); //içi boş olan constructor'ın 1.overload hali

            p1.Comments[0] = c1;

            Console.WriteLine(p1.ProductId);
            Console.WriteLine(p1.Name); //string türü nullable olduğu için değer atanmadığı zaman bana boşluk getirdi!
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1.IsApproved);
            Console.WriteLine(p1.Comments[0].Text);

            Console.WriteLine("*********************");

            var p2 = new Product(1213); //içine ıd parametresi alan constructor'ın overload hali!

            p2.Comments[0] = c1;

            Console.WriteLine(p2.ProductId);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Price);
            Console.WriteLine(p2.IsApproved);
            Console.WriteLine(p2.Comments[0].Text);

            Console.WriteLine("*********************");

            var p3 = new Product(1231, "samsung s7", 3000, true);
            // içine 4 parametre alan constructor'ın overload hali!

            Console.WriteLine(p3.ProductId);
            Console.WriteLine(p3.Name);
            Console.WriteLine(p3.Price);
            Console.WriteLine(p3.IsApproved);

            p3.Comments[0] = c1;
            Console.WriteLine(p3.Comments[0].Text);
        }
    }
}
