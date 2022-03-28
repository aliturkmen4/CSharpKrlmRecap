using System;
using System.ComponentModel.DataAnnotations;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Attributes => öz nitelikler : bir nesneye veya bir methoda veya propertylere uygulayabileceğimiz ekstra yapılardır!

            Customer _customer = new Customer() { Id = 1, LastName = "Türkmen", Age = 26 };

            CustomerDal customedal = new CustomerDal();

            customedal.Add(_customer);

            Console.ReadLine();
        }
        [ToTable("Customers")]
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty] //propertylerde kullancağım için [AttributeUsage(AttributeTargets.Property)] demeliyim!
            public string FirstName { get; set; }
            [RequiredProperty]
            [RequiredProperty] //=>allow multiple=true dersem iki kere uygulayabilmeme izin verir! false dersem izin vermez!
            public string LastName { get; set; }
            [RequiredProperty]
            public int Age { get; set; }
        }

        class CustomerDal
        {
            [Obsolete("Don't use Add, instead use AddNew method!")] //bu attributte ile add'i kullanma yerine add new'i kullan diye diğer yazılımcılara mesaj bıraktım!
            public void Add(Customer customer) 
            {
                Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }

            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
        }


        // [AttributeUsage(AttributeTargets.All)] //attribute a attribute tanımlamış oldum! Bu attribute u herkese kullanabilirsin demek!

        // [AttributeUsage(AttributeTargets.Class)] => bu şekilde dersem required property sadece class ların üstüne eklenbilir demek oluyor!

        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple =true)] // =>property veya field lara uygulayabilirsin demek!
        class RequiredPropertyAttribute : Attribute
        {

        }

        [AttributeUsage(AttributeTargets.Class)]
        class ToTableAttribute : Attribute //içine parametre aldığı için constructorını oluşturdum!
        {
            string _tableName;

            public ToTableAttribute(string tableName)
            {
                this._tableName = tableName;
            }
        }
    }
}
