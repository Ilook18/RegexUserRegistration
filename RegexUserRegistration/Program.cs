using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistration validation = new UserRegistration();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the User Registration validation program");
                Console.WriteLine("Enter the validation to be executed : \n 1. First Name \n 2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(validation.ValidateFirstName("Anirudh"));
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}