using System;

namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }

        public string SurName { get; set; }
        public Person()
        {
            Console.WriteLine("Person nesnesi oluşturuldu!");
        }
        public Person(string name,string surname)
        {
            this.Name = name;
            this.SurName = surname;
            Console.WriteLine("Person nesnesi oluşturuldu!");
        }
        public virtual void Intro() //ortak olmayan studentname'e buradan erişemeyeceğim için virtual işaretleyip student'ın içinde override edeceğim!
        {
            Console.WriteLine($"name:{this.Name} surname:{this.SurName}");
        }       
    }
    class Student:Person //person'ın taşıdığı bütün özellikler student sınıfına dahil edilmiş oldu!
    {
        public string StudentNumber { get; set; }
        public Student()
        {
            Console.WriteLine("Student nesnesi oluşturuldu!");
        }
        public Student(string name, string surname,string studentnumber):base(name,surname) //this yapısyla name,surname i zaten person'ın içinde aldım burada tekrar almamak için base yapısını kullanıyorum!
        {
            this.StudentNumber = studentnumber; //bunu person sınıfından alamayacağı için burda this lemen lazım!
            Console.WriteLine("Student nesnesi oluşturuldu!");
        }
        public override void Intro() //ortak olmayan studentname'e persondan erişemeyeceğim için virtual işaretleyip student'ın içinde override edeceğim!
        {
            Console.WriteLine($"name:{this.Name} surname:{this.SurName} studentnumber:{this.StudentNumber}");
        }
    }
    class Teacher:Person
    {
        public string Branch { get; set; }

        public Teacher(string name,string surname,string branch) :base(name,surname)
        {
            this.Branch = branch;
            Console.WriteLine("Teacher nesnesi oluşturuldu!");
        }

        public void Teach()
        {
            Console.WriteLine("I am teaching!");
        }
        public override void Intro() //ortak olmayan branch'e persondan erişemeyeceğim için virtual işaretlenen teacher'ın içinde override edeceğim!
        {
            Console.WriteLine($"name:{this.Name} surname:{this.SurName} studentnumber:{this.Branch}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance(Kalıtım): Miras Alma

            var person = new Person();
            var student = new Student(); //student nesnesi oluşturulduğunda ilk başta person'ın constructor'ı oluşturulur!
            var teacher = new Teacher("Resul","Aktoz","Physic");
            Console.WriteLine("--------------------------------");
            
            Console.WriteLine("--------------------------------");
            var person1 = new Person("Ali", "Türkmen");
            Console.WriteLine(person1.Name+" "+person1.SurName);
            Console.WriteLine("--------------------------------");
            var student1 = new Student("Eray", "Nurtekin","12345");
            Console.WriteLine(student1.Name + " " + student1.SurName+" "+student1.StudentNumber);
            Console.WriteLine("--------------------------------");
            person1.Intro();
            student1.Intro();           
            Console.WriteLine("--------------------------------");
            teacher.Intro();
            Console.WriteLine("--------------------------------");
            teacher.Teach();


        }
    }
}
