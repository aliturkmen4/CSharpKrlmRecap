using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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

            AddProduct();

            GetAllProducts();

            GetProductById(1); //id si 1 olanı getiriyor ekrana!

            GetProductByName("Samsung"); //içerisinde samsung geçen bütün ürünleri bana getirir!

            UpdateProduct();
        }

        //Veri Tabanına Kayıt Ekleme

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

        //VeriTabanından Kayıt Seçme

        static void GetAllProducts()
        {
            using(var context=new ShopContext())
            {
                var products = context
                    .Products
                     //new le ananymous bir şekilde oluşturdum! BURADA PRODUCT İÇİNDEN NELERİ SEÇECEĞİMİ BELİRLİYORUM!
                       //Select * from değilde * yerine tablo adı verme işlemim oluyor!!!!!!!
                    .ToList(); //böyle dediğimizde bir listenin referansını alırız!! veritabanına select sorgusu göndermiş oluyorum!

                foreach (var p in products)
                {
                    Console.WriteLine($"name: {p.Name} price:{p.Price}");
                }
            }
        }

        static void GetProductById(int id)
        {
            using (var context = new ShopContext())
            {
                var result = context
                    .Products
                    .Where(p => p.ProductId == id) //productid si benim gönderdiğim id'ye koşulunu koydum!
                    .Select(product => new //burada da id'yi seçmemesi için filtreleme yaptırdım!
                    {
                        product.Name,
                        product.Price
                    })
                    .FirstOrDefault(); //bize uygun bir değer bulamazsa null değer gönderir!

                Console.WriteLine($"name: {result.Name} price:{result.Price}");
            }
        }

        static void GetProductByName(string name)
        {
            using (var context = new ShopContext())
            {
                var products = context
                    .Products
                    .Where(p => p.Name.ToLower().Contains(name.ToLower())) //benim gönderdiğim name i önce küçük harfe çevirdim sonra bu db deki küçük harfe çevrilmiş name'lerin içinde var mı dedim!
                    .Select(product => new //burada da id'yi seçmemesi için filtreleme yaptırdım!
                    {
                        product.Name,
                        product.Price
                    })
                    .ToList(); //listeye çevirmesini sağladım!

                foreach (var p in products)
                {
                    Console.WriteLine($"name: {p.Name} price:{p.Price}");
                }
            }
        }

        //Veri Tabanından Kayıt Güncelleme

        static void UpdateProduct()
        {
            #region updatefirstway
            //using(var db=new ShopContext())
            //{
            //    //change tracking => alınan objenin takibi yapılır!
            //    var p = db
            //        .Products
            //        .AsNoTracking() //yaparsam p objesi takip edilmez! /change tracking kapatılır) yani yaptığım değişikliğin güncellemesini engellemiş oldum db tarafında!
            //        .Where(i => i.ProductId == 1)
            //        .FirstOrDefault(); //öncelikle güncelleyeceğim veriyi alıyorum!
            //    if (p != null)
            //    {
            //        p.Price *= 1.2m; //m koyarak decimal sayı ile olduğunu belirttim!
            //        db.SaveChanges(); //değişiklik yapılan alan güncellenmiş olur! update işlemi için change tracking sayesinde ayrı bir işleme gereksinim duyulmaz!

            //        Console.WriteLine("Güncelleme yapıldı!");
            //    } 
            #endregion

            #region updatesecondway
            //using(var db=new ShopContext())
            //{
            //    var entity = new Product()
            //    {
            //        ProductId=1
            //    };
            //    db.Products.Attach(entity); //change tracking'i ilgili entity için aktif etmiş oluyorum!

            //    entity.Price = 300;

            //    db.SaveChanges();
            //} 

            //veri tabanından kayıt aldığın zaman güncelleme yapmayacaksan AsNoTracking() özelliğini kullanmalıyız ki change tracking ile objelerimin izi sürülmesin!
            #endregion

            #region updatethirdway
            //using (var db=new ShopContext())
            //{
            //    var p = db
            //        .Products
            //        .Where(i => i.ProductId == 1)
            //        .FirstOrDefault();
            //    if (p != null)
            //    {
            //        p.Price = 2800;
            //        db.Products.Update(p); //tek ürün güncellemek için!
            //        //db.Products.UpdateRange(); //bir listeyi güncellemek için!
            //        db.SaveChanges();
            //    }

            //} 
            #endregion

        }

        
    }
}
