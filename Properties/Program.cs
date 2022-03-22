using System;

namespace Properties
{
    class Product
    {
        public string Name; //public tanımlamazsak product class ından erişemeyiz!

        private double Price;
        private string _name;

        public string Name2
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("name alanı boş geçilemez!");
                }

            }
        }

        //private double _price;

        private double _price;

        public double Price2 
        {
            get
            {
                return _price;
            }
            set 
            {
                if (value < 0)
                    _price = 0;
                else
                   _price = value;
            } 
        }

        public void SetPrice(double price)
        {
            if (price < 0)
                this.Price = 0;
            else
                this.Price = price;
        }
        public double GetPrice()
        {
            return this.Price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Propertysiz yapımı:");

            var p = new Product();
            p.Name = "Samsung S8";
            p.SetPrice(2000); //oluşturduğum setprice değeri sayesinde p nesnesine değer atayabildim!

            Console.WriteLine(p.GetPrice());

            Console.WriteLine("---------------------");

            Console.WriteLine("Property aracalığı ile yapımı:");

            var p2 = new Product();
            p2.Name2 = "Samsung S9";
             p2.Price2=3000;
            Console.WriteLine(p2.Price2);
            Console.WriteLine(p2.Name2);
        }
    }
}
