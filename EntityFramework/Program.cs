using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class ShopContext:DbContext //sql server'a bağlantı kuracağım kısım!
    {
        public static readonly ILoggerFactory MyLoggerFactory
    = LoggerFactory.Create(builder => { builder.AddConsole(); }); //bizim için oluşturulan SQL Sorgusunu görmemize yarar! 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ShopDb;Integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
    public class Product
    {
        //public int Id{ get; set; } //primary key (Id,<type-name>Id) olacak!
        public int ProductId { get; set; } //primary key ya da bu şekilde tip adı verilerek tanımlanır!

        [MaxLength(100)] //varchar değerime max 100 dedim!
        [Required] //alanı zorunlu kıldım!
        public string Name{ get; set; } //varchar(Max)

        public decimal Price { get; set; } //demical? dersem burası nullable olabilir demiş oluyorum!
    }
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //migration => uygulama tarafındaki classların, db tarafındaki tablolara dönüştürülmesi!

            //yaptığın her değişiklikte bir migration oluşturup, kendin göndermelisin!

        }

        static void AddProducts()
        {
             using (var db = new ShopContext()) //=>using: işim bittiği zaman bellekten silinmesi için!!!!
            {
                var products = new List<Product>
                {
                    new Product {Name = "Samsung S5",
                    Price = 2000   },
                    new Product {Name = "Samsung S6",
                    Price = 3001   },
                    new Product {Name = "Samsung S7",
                    Price = 4002   },
                    new Product {Name = "Samsung S8",
                    Price = 5003   }

                };
    //foreach (var item in products) //bu şekilde db e ekleyebilirim!
    //{
    //    db.Products.Add(item);
    //}

    db.Products.AddRange(products); //db'ye collection şeklinde eklemek için!
                db.SaveChanges();

                Console.WriteLine("Veriler eklendi!");
            } 
        }

        static void AddProduct()
        {
            using (var db = new ShopContext()) //=>using: işim bittiği zaman bellekten silinmesi için!!!!
            {
                var p= new Product
                {
                    Name = "Samsung S10",
                    Price = 8008
                };               
               
                 db.Products.Add(p);

                db.SaveChanges();

                Console.WriteLine("Veri eklendi!");
            }
        }
    }
}
