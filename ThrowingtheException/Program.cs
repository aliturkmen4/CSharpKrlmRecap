using System;
using System.Linq;

namespace ThrowingtheException
{
    class Program
    {
        static void check_password(string password)
        {
            if (password.Length < 8 && password.Length > 17)
                throw new Exception("Parola 7-15 karakter arasında olmalıdır!");
            if (!password.Any(char.IsDigit)) //any->bütün karakterleri kontrol eder,herhangi bir tanesi rakam değilse bize false değeri gelir!
                throw new Exception("Parola en az bir rakam içermelidir!");
            if (!password.Any(char.IsLetter))//any->bütün karakterleri kontrol eder,herhangi bir tanesi harf değilse bize false değeri gelir!
                throw new Exception("Parola en az bir harf içermelidir!");
        }
        static void Main(string[] args)
        {
            //bizim hata saydığımız bir durumu uygulama hata saymayabilir, o zaman kendimiz fırlatmalıyız!

            //int sayi = 10;
            //if (sayi > 5)
            //    throw new Exception("sayi 5ten büyük olamaz!");

            string parola = "aa143224aa";

            try
            {
                check_password(parola);
                Console.WriteLine("Parola geçerli!");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
