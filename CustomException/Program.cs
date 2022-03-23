using System;

namespace CustomException
{

    class LoginException : Exception //exception sınıfından türetilmesi lazım!
    {
        public LoginException(string message): base(message)
        {

        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            //Login => username,password
            try
            {
                Login("alitürkmen", "1234561212");
                Console.WriteLine("Login başarılı!");
            }
            catch (LoginException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void Login(string username,string password)
        {
            if(username.Contains(" "))
            {
                throw new LoginException("username boşluk içeremez!");
            }
            if (password.Length<8)
            {
                throw new LoginException("parola min 8 karakter olmalıdır!");
            }
        }
    }
}
