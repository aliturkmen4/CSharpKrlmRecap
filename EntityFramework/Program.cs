using EntityFramework.NORTHWNDModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EntityFramework
{
    //public class ShopContext:DbContext //sql server'a bağlantı kuracağım kısım!
    //{
    //    public static readonly ILoggerFactory MyLoggerFactory
    //= LoggerFactory.Create(builder => { builder.AddConsole(); }); //bizim için oluşturulan SQL Sorgusunu görmemize yarar! 
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder
    //            .UseLoggerFactory(MyLoggerFactory)
    //            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ShopDb;Integrated security=true");
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<User>()
    //             .HasIndex(u => u.UserName)
    //              .IsUnique();

    //        modelBuilder.Entity<Product>().ToTable("Urunler"); //product tablosunun adını ürünler olarak adlandırdım!

    //        modelBuilder.Entity<Customer>() //max 11 karakter alacak bir required alan!
    //            .Property(p => p.IdentityNumber)
    //            .HasMaxLength(11)
    //            .IsRequired();

    //        modelBuilder.Entity<ProductCategory>()
    //                .HasKey(t => new { t.ProductId, t.CategoryId }); //productcategory entitysine geçiş yaptım ve bu entity nin bir key i olmasını sağladım , bu anahtarı da iki ıd kombinasyonu olacak şekilde belirttim! BUNU YAPTIKTAN SONRA TEKRARLAYAN KAYITLAR ARTIK DB TARAFINA KABUL EDİLMEZ!

    //        modelBuilder.Entity<ProductCategory>()
    //            .HasOne(pc => pc.Product) //burada productcategory tablosuna gittim ve buradakini product entity sinin bizim için tek bir tane olacağını söyledim!
    //            .WithMany(p => p.ProductCategories) //çoğul olduğunu burada söyledim!
    //            .HasForeignKey(pc => pc.ProductId); //productıd'nin bu tablonun foreign key'i olacağını söyledim!

    //        modelBuilder.Entity<ProductCategory>()
    //            .HasOne(pc => pc.Category) //burada productcategory tablosuna gittim ve buradakini category entity sinin bizim için tek bir tane olacağını söyledim!
    //            .WithMany(c => c.ProductCategories) //çoğul olduğunu burada söyledim!
    //            .HasForeignKey(pc => pc.CategoryId); //categoryıd'nin bu tablonun foreign key'i olacağını söyledim!
    //    }

    //    public DbSet<Product> Products { get; set; }
    //    public DbSet<Category> Categories { get; set; }

    //    public DbSet<User> Users { get; set; }

    //    public DbSet<Customer> Customers { get; set; }
    //    public DbSet<Adress> Adresses { get; set; } //bunu yazmayabilirim User tarafından zaten otomatik olarak kullanılacağı için!

    //}
    //------------------------------------------------------------------------------------//
    //One to Many İlişki
    public class User
    {
        public int Id { get; set; }
        //[Required]
        //[MaxLength(15), MinLength(8)]
        public string UserName { get; set; } //burada username'i reuired alan ve maxlength'i 15, minlength'i 8 olacak dedim!
        //[Column(TypeName ="varchar(20)")]
        public string Mail { get; set; }

        public Customer Customer { get; set; } //customer tablosunda da tek bir obje olarak tanımladım!(0ne to one relationship için!!!!)
        public List<Adress> Adresses { get; set; } //bir kullanıcının birden çok adresi olabileceği için list şeklinde tanımladım! //NAVIGATION PROPERTY
    }
    public class Adress //Bir kullanıcının birden çok adresi olabileceği için ayrı sınıf oalrak aç!
    {
        //public int Id { get; set; }

        //public string FullName { get; set; }

        //public string Title { get; set; }

        //public string Body { get; set; }

        //public User User { get; set; } //user 1 tane olacağı için tekil tanımladım! //NAVIGATION PROPERTY

        //public int UserId { get; set; } //foreignkey //UserId deyince user tablosunun bir referansı olduğunu anlıyor!
        //userıd ye int atadık, int nullable bir değer değil user tablosundan bir veri döndüremezsem 0 dönecek ve bende 0 user'ı olmadığı için hata alacağım! o yüzden int? yaparak bunu nullable yap!!!!!!!!!!!!!
    }

    //-------------------------------------------------------------------------------------//

    //One to One ilişki

    public class Customer
    {

        [Column("customer_id")] //uygulama tarafındaki id bilgisi veritabanında customer_id ye karşılık gelir!
        public int Id { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [NotMapped] //oluşacak customer tablosunda fullname'i görmememizi sağlar! 
        [Required]
        public string FullName { get; set; }

        public User User { get; set; }
        public int UserId { get; set; } //one to one relationship için buranın tek bir kayıda karşılık gelmesi (unique) olması lazım!
    }

    public class Supplier
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string TaxNumber { get; set; }
    }
    public class Product
    {
        //database tarafına otomatik oalrak bir sayı gönderilmeyeceğini belirledim!!
        //    public int ProductId { get; set; } //primary key ya da bu şekilde tip adı verilerek tanımlanır!
        //    //public int Id{ get; set; } //primary key (Id,<type-name>Id) olacak!

        //    [MaxLength(100)] //varchar değerime max 100 dedim!
        //    [Required] //alanı zorunlu kıldım!
        //    public string Name{ get; set; } //varchar(Max)

        //    public decimal Price { get; set; } //demical? dersem burası nullable olabilir demiş oluyorum!

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //burada bu bilginin 1 kere aktarılacağını bir daha değiştirilemeyeceğini belirttim!
        //    public DateTime InsertedDate { get; set; } = DateTime.Now; //obje oluşturulduğu zaman bilgiyi set ettim!

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)] //computed seçersem insert ve update sorgularında değiştirilen bir alan olacağını söyledim!!
        //    public DateTime LastUpdatedDate { get; set; } = DateTime.Now;

        //    public int CategoryId { get; set; }

        //    public List<ProductCategory> ProductCategories { get; set; }
        //}
        public class Category
        {
            //public int CategoryId { get; set; } //bunu kendisi key olarak algılar!

            //public string Name { get; set; }

            //public List<ProductCategory> ProductCategories { get; set; }
        }
        //-------------------------------------------------------------------------------------//

        //Many to Many İlişki

        // [NotMapped] //böyle dersem productcategorynin ilgili db içinde bir tablo olarak oluşturulmayacağını belirtiyorum!
        //[Table("UrunKategorileri")] //db içerisindeki tablolara isim verdim. productcategory artık urunkategorileri olarak karşıma gelcek
        public class ProductCategory //junction(geçiş) tablosu 
        {
            //public int ProductId { get; set; }

            // public Product Product { get; set; } //navigation property

            // public int CategoryId { get; set; }

            // public Category Category { get; set; } //navigation property

            //burada ProductId ve CategoryId de pk olacak şekilde ayarlayıp ,productcategory nesnesine ayrı bir id vermiyorum sebebi, bir product id karşına farklı categoryıd ler gelsin diye yani çoka çok ilişki kurmak için!
        }

        // Data Seeding

        //public static class DataSeeding
        //{
        //    public static void Seed(DbContext context) //genel bir context yapısından türetilecek context'i içine alacak!
        //    {
        //        if (context.Database.GetPendingMigrations().Count() == 0) //database 'e aktarılmayı bekleyen bir migration yoksa!
        //        {
        //            if(context is ShopContext) //gönderilen context Shop Context mi?
        //            {
        //                ShopContext _context = context as ShopContext;

        //                if (_context.Products.Count() == 0)
        //                {
        //                    _context.Products.AddRange(Products);
        //                }

        //                if (_context.Categories.Count() == 0)
        //                {
        //                    _context.Categories.AddRange(Categories);
        //                }
        //            }

        //            context.SaveChanges();
        //        }
        //    }

        //    private static Product[] Products =
        //    {
        //        new Product(){Name="Samsung S17",Price=15000},
        //        new Product(){Name="Samsung S27",Price=16000},
        //        new Product(){Name="Samsung S37",Price=17000},
        //        new Product(){Name="Samsung S47",Price=18000},
        //        new Product(){Name="Samsung S57",Price=19000}
        //    };

        //    private static Category[] Categories =
        //    {
        //        new Category(){Name="Telefon"},
        //        new Category(){Name="Elektronik"},
        //        new Category(){Name="Bilgisayar"}

        //    };
        //}

        class Program
        {
            static void Main(string[] args)
            {
                //migration => uygulama tarafındaki classların, db tarafındaki tablolara dönüştürülmesi!

                //yaptığın her değişiklikte bir migration oluşturup, kendin göndermelisin!

                //AddProduct();

                //GetAllProducts();

                //GetProductById(5); //id si 5 olanı getiriyor ekrana!

                //GetProductByName("Samsung"); //içerisinde samsung geçen bütün ürünleri bana getirir!

                //UpdateProduct();

                //DeleteProduct(2);

                ////InsertUsers();

                //InsertAdresses();

                #region IDGöndermedenOnetoMany
                //using (var db = new ShopContext()) //id bilgisi göndermeden user bilgilerine direk ilgili user objesi ile direkt ilişkilendirmiş oluyorum!(ID GÖNDERMEDEN INSERT ADRESSES)
                //{
                //    var users = db.Users.FirstOrDefault(i => i.UserName == "alitrkmn");

                //    if (users != null)
                //    {
                //        users.Adresses = new List<Adress>();
                //        users.Adresses.AddRange(
                //            new List<Adress>
                //            {
                //                new Adress{FullName="Ali Türkmen",Title="Ev adresi",Body="Antalya",UserId=1},
                //                new Adress{FullName="Ali Türkmen",Title="Ev adresi",Body="Antalya",UserId=1},
                //                new Adress{FullName="Ali Türkmen",Title="Ev adresi",Body="Antalya",UserId=1}

                //            }
                //        );
                //        db.SaveChanges();
                //    }
                //}
                #endregion

                #region OneToOnerRelationsecondway
                //using (var db=new ShopContext())
                //{
                //    var customer = new Customer
                //    {
                //        IdentityNumber="12313232",
                //        FirstName="Ali",
                //        LastName="Türkmen",
                //        User=db.Users.FirstOrDefault(i=>i.Id==3)
                //    };
                //    //db.Customers.Add(customer);
                //    //db.SaveChanges();

                //    var user = new User()
                //    {
                //        UserName = "deneme",
                //        Mail = "deneme@deneme.com",
                //        Customer = new Customer()
                //        {
                //            FirstName = "Deneme",
                //            LastName="Deneme",
                //            IdentityNumber= "12345"
                //        }

                //    };
                //    db.Users.Add(user);
                //    db.SaveChanges();
                //} 
                #endregion

                #region ManyToManyRelation
                //using (var db = new ShopContext())
                //{
                //    var products = new List<Product>
                //    {
                //        new Product(){Name="Samsung S5",Price=2000},
                //        new Product(){Name="Samsung S6",Price=3000},
                //        new Product(){Name="Samsung S7",Price=4000},
                //        new Product(){Name="Samsung S8",Price=5000},
                //    };

                //    //db.Products.AddRange(products);

                //    var categories = new List<Category>()
                //    {
                //        new Category(){Name="Telefon"},
                //        new Category(){Name="Telefon"},
                //        new Category(){Name="Telefon"},
                //    };

                //    //db.Categories.AddRange(categories);

                //    int[] ids = new int[2] { 1, 2 };

                //    var p = db.Products.Find(1); //find methodu benden id bilgisi bekler!

                //    p.ProductCategories = ids.Select(cid => new ProductCategory()
                //    {
                //        CategoryId = cid,
                //        ProductId = p.ProductId
                //    }).ToList();

                //    db.SaveChanges();
                //}
                #endregion

                #region ManuelAtama
                //using (var db=new ShopContext())
                //{
                //    //var p1 = new Product()
                //    //{
                //    //    Name = "Samsung S15",
                //    //    Price=12000
                //    //};

                //    //db.Products.AddRange(p1);

                //    var p3 = db.Products.FirstOrDefault();

                //    p3.Name = "Samsung S15";

                //    db.SaveChanges();
                //}

                //DataSeeding.Seed(new ShopContext()); 
                #endregion

                using (var db = new NORTHWNDContext())
                {
                    //Tüm müşteri kayıtlarını getiriniz!

                    #region müşterikayıtlarınıgetirme
                    //var customers = db.Customers.ToList();

                    //foreach (var item in customers)
                    //{
                    //    Console.WriteLine(item.FirstName + " "+ item.LastName);
                    //} 
                    #endregion

                    //Tüm müşteri kayıtlarının sadece adress ve city bilgilerini getiriniz!

                    #region sadeceadressvecitybilgilerinigetirme
                    //var customers = db.Customers.Select(c => new
                    //{
                    //    c.Address,
                    //    c.City
                    //}); ;

                    //foreach (var item in customers)
                    //{
                    //   Console.WriteLine(item.Address + " "+ item.City);
                    //} 
                    #endregion

                    //Londrada yaşayan müşterilerin contactname' ini getirir! 

                    #region londradayaşayanlarıncontactnameinigetirme
                    //var customers = db.Customers
                    //    .Where(i => i.City == "London")
                    //    .Select(s=>new { s.ContactName }) //içerisine belirtilen kolonu getirir sadece!
                    //    .ToList(); //where ile koşulumu koyup sorgumu belirtip to list e uygun olan sonuçları alıyorum!

                    //foreach (var item in customers)
                    //{
                    //    Console.WriteLine(item.ContactName);
                    //} 
                    #endregion
                }
            }
            //Veri Tabanına Kayıt Ekleme

            //static void AddProducts()
            //{
            //     using (var db = new ShopContext()) //=>using: işim bittiği zaman bellekten silinmesi için!!!!
            //    {
            //        var products = new List<Product>
            //        {
            //            new Product {Name = "Samsung S5",
            //            Price = 2000   },
            //            new Product {Name = "Samsung S6",
            //            Price = 3001   },
            //            new Product {Name = "Samsung S7",
            //            Price = 4002   },
            //            new Product {Name = "Samsung S8",
            //            Price = 5003   },
            //            new Product {Name = "Samsung S19",
            //            Price = 8603   }

            //        };
            //            //foreach (var item in products) //bu şekilde db e ekleyebilirim!
            //            //{
            //            //  db.Products.Add(item);
            //            //}

            //         db.Products.AddRange(products); //db'ye collection şeklinde eklemek için!
            //        db.SaveChanges();

            //        Console.WriteLine("Veriler eklendi!");
            //    } 
            //}

            //static void AddProduct()
            //{
            //    using (var db = new ShopContext()) //=>using: işim bittiği zaman bellekten silinmesi için!!!!
            //    {
            //        var p = new Product
            //        {

            //            Name = "Samsung S19",
            //            Price = 8008
            //        };

            //        db.Products.Add(p);

            //        db.SaveChanges();

            //        Console.WriteLine("Veri eklendi!");
            //    }
            //}

            //VeriTabanından Kayıt Seçme

            //static void GetAllProducts()
            //{
            //    using(var context=new ShopContext())
            //    {
            //        var products = context
            //            .Products
            //             //new le ananymous bir şekilde oluşturdum! BURADA PRODUCT İÇİNDEN NELERİ SEÇECEĞİMİ BELİRLİYORUM!
            //               //Select * from değilde * yerine tablo adı verme işlemim oluyor!!!!!!!
            //            .ToList(); //böyle dediğimizde bir listenin referansını alırız!! veritabanına select sorgusu göndermiş oluyorum!

            //        foreach (var p in products)
            //        {
            //            Console.WriteLine($"name: {p.Name} price:{p.Price}");
            //        }
            //    }
            //}

            //static void GetProductById(int id)
            //{
            //    using (var context = new ShopContext())
            //    {
            //        var result = context
            //            .Products
            //            .Where(p => p.ProductId == id) //productid si benim gönderdiğim id'ye koşulunu koydum!
            //            .Select(product => new //burada da id'yi seçmemesi için filtreleme yaptırdım!
            //           {
            //               product.Name,
            //                product.Price
            //            })
            //         .FirstOrDefault(); //bize uygun bir değer bulamazsa null değer gönderir!

            //      Console.WriteLine($"name: {result.Name} price:{result.Price}");
            //   }
            //}

            //static void GetProductByName(string name)
            //{
            //    using (var context = new ShopContext())
            //    {
            //        var products = context
            //            .Products
            //            .Where(p => p.Name.ToLower().Contains(name.ToLower())) //benim gönderdiğim name i önce küçük harfe çevirdim sonra bu db deki küçük harfe çevrilmiş name'lerin içinde var mı dedim!
            //            .Select(product => new //burada da id'yi seçmemesi için filtreleme yaptırdım!
            //            {
            //                product.Name,
            //                product.Price
            //            })
            //            .ToList(); //listeye çevirmesini sağladım!

            //        foreach (var p in products)
            //        {
            //            Console.WriteLine($"name: {p.Name} price:{p.Price}");
            //        }
            //    }
            //}

            ////Veri Tabanından Kayıt Güncelleme

            //static void UpdateProduct()
            //{
            //    #region updatefirstway
            //using(var db=new ShopContext())
            //    {
            //    //change tracking => alınan objenin takibi yapılır!
            //        var p = db
            //           .Products
            //          .AsNoTracking() //yaparsam p objesi takip edilmez! /change tracking kapatılır) yani yaptığım değişikliğin güncellemesini engellemiş oldum db tarafında!
            //          .Where(i => i.ProductId == 1)
            //          .FirstOrDefault(); //öncelikle güncelleyeceğim veriyi alıyorum!
            //      if (p != null)
            //       {
            //           p.Price *= 1.2m; //m koyarak decimal sayı ile olduğunu belirttim!
            //          db.SaveChanges(); //değişiklik yapılan alan güncellenmiş olur! update işlemi için change tracking sayesinde ayrı bir işleme gereksinim duyulmaz!

            //          Console.WriteLine("Güncelleme yapıldı!");
            //      } 
            //    #endregion

            //    #region updatesecondway
            //    using(var db=new ShopContext())
            //    {
            //       var entity = new Product()
            //      {
            //           ProductId=1
            //      };
            //       db.Products.Attach(entity); //change tracking'i ilgili entity için aktif etmiş oluyorum!

            //       entity.Price = 300;

            //       db.SaveChanges();
            //    } 

            //    //veri tabanından kayıt aldığın zaman güncelleme yapmayacaksan AsNoTracking() özelliğini kullanmalıyız ki change tracking ile objelerimin izi sürülmesin!
            //    #endregion

            //    #region updatethirdway
            //    //using (var db=new ShopContext())
            //    //{
            //    //    var p = db
            //    //        .Products
            //    //        .Where(i => i.ProductId == 1)
            //    //        .FirstOrDefault();
            //    //    if (p != null)
            //    //    {
            //    //        p.Price = 2800;
            //    //        db.Products.Update(p); //tek ürün güncellemek için!
            //    //        //db.Products.UpdateRange(); //bir listeyi güncellemek için!
            //    //        db.SaveChanges();
            //    //    }

            //    //} 
            //    #endregion

            //}
            ////Veri Tabanından Kayıt Silme
            //static void DeleteProduct(int id)
            //{
            //    #region deletefirstway
            //    //using (var db = new ShopContext())
            //    //{
            //    //    var p = db
            //    //        .Products
            //    //        .FirstOrDefault(i => i.ProductId == id); //select işlemi yapmamı sağlar!
            //    //    if (p != null)
            //    //    {
            //    //        db.Products.Remove(p); //benden remove içine generic bir entity bekler(bendeki p yani Product listem)
            //    //        db.SaveChanges();

            //    //        Console.WriteLine("veri slindi!");
            //    //    }
            //    //} 
            //    #endregion

            //    #region deletesecondway
            //    //using (var db=new ShopContext())
            //    //{
            //    //    var p = new Product
            //    //    {
            //    //        ProductId = 6
            //    //    };

            //    //    db.Entry(p).State = EntityState.Deleted; //ilgili objeyi context üzerinden sildiğimi change tracking'e haber vermiş oluyorum!

            //    //    db.Products.Remove(p);

            //    //    db.SaveChanges();
            //    //} 
            //    #endregion

            //}

            ////One to Many İlişki

            //#region InsertUsers()
            //static void InsertUsers()
            //{
            //    var use = new List<User>()
            //    {
            //        new User{UserName="alirkmn",Mail="info@alirkmn.com"},
            //        new User{UserName="rslakoz",Mail="info@rslatoz.com" },
            //        new User{UserName="eryntkn",Mail="info@erynrkn.com" },
            //        new User{UserName="srfhmhrs",Mail="info@srfhmhrs.com" },
            //        new User{UserName="snmksk",Mail="info@snmstk.com" }
            //    };

            //    using (var db = new ShopContext())
            //    {
            //        //db.Users.AddRange(use); //collection şeklinde eklemek için!
            //        //db.SaveChanges();

            //        foreach (var item in use)
            //        {
            //            db.Users.Add(item);

            //            db.SaveChanges();
            //        }
            //    }
            //}
            //#endregion

            //#region IDGöndererekOnetoMany
            //static void InsertAdresses()
            //{
            //    var adresses = new List<Adress>()
            //    {
            //        new Adress{FullName="Ali Türkmen",Title="Ev adresi",Body="Antalya",UserId=1},
            //        new Adress{FullName="Ali Türkmen",Title="İş adresi",Body="Antalya",UserId=1},
            //        new Adress{FullName="Resul Aktoz",Title="Ev adresi",Body="Adana",UserId=2},
            //        new Adress{FullName="Eray Nurtekin",Title="Ev adresi",Body="Kırklareli",UserId=3},
            //        new Adress{FullName="Eray Nurtekin",Title="İş adresi",Body="Kırklareli",UserId=3},
            //        new Adress{FullName="Şerif Ahmet Haras",Title="Ev adresi",Body="Manisa",UserId=4},
            //        new Adress{FullName="Sinem Kestek",Title="Ev adresi",Body="Eskişehir",UserId=5},
            //    };

            //    using (var db = new ShopContext())
            //    {
            //        db.Adresses.AddRange(adresses); //collection şeklinde eklemek için!
            //        db.SaveChanges();
            //    }
            //}
            //#endregion

            //Data Seeding: Test verilerini database oluşturma sırasında eklemek!!!!

            //Scaffolding Database: Elimizde var olan database'in ef core kullanarak şemasını uygulama tarafına aktarmaya denir! (DB FIRST)
        }
    }
}
