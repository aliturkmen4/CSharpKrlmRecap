using System;

namespace StaticMembers
{
    class Student //instance sınıf
    {
        public string Name { get; set; }

        public int StudentNumber { get; set; }

        public static string School = "my school";

        public static string Address = "my school address";

    public Student(string name,int studentnumber)
        {
            this.Name = name;
            this.StudentNumber = studentnumber;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"name: {this.StudentNumber} number:{this.StudentNumber} ");
        }

        public static void DisplaySchoolDetails()
        {
            Console.WriteLine($"school name: {School} address:{Address}");
        }
     
    }
    static class HelperMethod //static sınıf
    { //nesnesini üretmeden kullanıyorum!
        public static string KarakterDuzelt(string str)
        {
            return str
                .Replace("ö", "o")
                .Replace("ü", "u")
                .Replace("ç", "c")
                .Replace(" ", "-")
                .Replace("ğ", "g");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Çınar",100);

            var s2 = new Student("Sena", 150);

            var s3 = new Student("Ali", 200);

            s1.DisplayStudentDetails();

            s2.DisplayStudentDetails();

            s3.DisplayStudentDetails();

            Student.DisplaySchoolDetails(); //methodlara class üzerinden erişmek istersem static keywordunu kullan!

            string str = "ölçme ve değerlendirme";

            HelperMethod.KarakterDuzelt(str);

            Console.WriteLine(HelperMethod.KarakterDuzelt(str));

            //Math de static bir sınıftır!
        }
    }
}
