using System;

namespace ClassApplication
{
    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ürün adeti giriniz:");
            int urunadet = int.Parse(Console.ReadLine());

            Product[] products = new Product[urunadet];

            int i = 0;

            Product p;

            do
            {
                p=new Product(); //döngü her döndüğünde p ye bir içi boş aktarılacak ve bizim tarafımızdan doldurulacak!

                Console.WriteLine("Ürün adı giriniz:");
                p.Name = Console.ReadLine(); //nesnesini ürettiğim product alanına okunan değeri atadım!

                Console.WriteLine("Ürün fiyatı giriniz:");
                p.Price = double.Parse(Console.ReadLine());

                Console.WriteLine("Ürün açıklaması giriniz:");
                p.Description = Console.ReadLine();

                products[i] = p;
                i++;

            } while (urunadet>i);

            Console.WriteLine("--------------------------");

            for (int j = 0; j < products.Length; j++)
            {
                Console.WriteLine("Ürün adı:"+products[j].Name+" Ürün fiyatı:"+products[j].Price+" Ürün açıklaması:"+products[j].Description);
            }
        }
    }
}
