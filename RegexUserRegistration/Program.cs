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
                Console.WriteLine("Enter the validation to be executed : \n 1. First Name \n 2. LastName\n 3.Email\n 4.Mobile Number\n 5.Password1\n 6.Password2\n 7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(validation.ValidateFirstName("Anirudh"));
                        break;
                    case 2:
                        Console.WriteLine(validation.ValidateLastName("Anand"));
                        break;
                    case 3:
                        Console.WriteLine(validation.ValidateEmail("abc.xyz@bl.co.in"));
                        break;
                    case 4:
                        Console.WriteLine(validation.ValidateMobileNumber("91 7905142214"));
                        break;
                    case 5:
                        Console.WriteLine(validation.ValidatePassword1("aniruddh"));
                        break;
                    case 6:
                        Console.WriteLine(validation.ValidatePassword2("Aniruddh"));
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}