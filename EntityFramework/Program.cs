using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class ShopContext:DbContext //sql server'a bağlantı kuracağım kısım!
    {       
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //hangi db provider'ı kullancağımı belirlediğim alan!
        {
            optionsBuilder.UseSqlServer("Data Source=shop.db");
        }AAAA
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
    }
}
