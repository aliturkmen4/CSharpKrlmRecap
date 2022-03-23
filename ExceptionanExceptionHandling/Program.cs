using System;

namespace ExceptionandExceptionHandling
{

    class Program
    {
        static void Main(string[] args)
        {
            //Exception: Programı yazarken öngöremediğimiz hatalardır!


            //Unhandled exception. System.FormatException

            //Unhandled exception. System.DivideByZeroException

            //Unhandled exception. System.IndexOutofRangeExcepiton

            //Unhandled exception. System.NullReferenceExcepiton  

            //Exception Handling: Hataya karşı bir önlem almak!

            try
            {
                Console.Write("a:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                Console.Write("b:");
                int b = int.Parse(Console.ReadLine());

                var sonuc = a / b;
                Console.WriteLine("{0} / {1}={2}", a, b, sonuc);
                //b ye 0 verirsen dividebyzero hatası alırsın!
            }
            catch (DivideByZeroException ex) //exception handling kısmı
            {
                Console.WriteLine("b sıfır olamaz!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex) //exception handling kısmı
            {
                Console.WriteLine("sayısal bilgi girmelisiniz!");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bir hata oluştu!");
                Console.WriteLine(ex.Message);
            }
            finally //hata olsun ya da olmasın çalıştırılacak kod bloğunu buraya yaz
            {
                Console.WriteLine("finally bloğu çalıştı!");
            }

        }
    }
}
