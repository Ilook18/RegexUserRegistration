using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    public class UserRegistration
    {
        public static string REGEX_FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string REGEX_LAST_NAME = "[A-Z]{1}[a-z]{2,}$";
        public static string REGEX_EMAIL = "^[a-z]{3,}[_+-.]{0,1}[a-z]{3,}[@][a-z]{2,}[.][a-z]{2}[.][a-z]{2}$";
        public static string REGEX_MOBILE = "^[1,9]{2} [6-9]{1}[0-9]{9}$";
         public static string REGEX_PASSWORD_1 = "^(?=.{8,})";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRST_NAME);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LAST_NAME);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidateMobileNumber(string mobile)
        {
            return Regex.IsMatch(mobile, REGEX_MOBILE);
        }
        public bool ValidatePassword1(string pass1)
        {
            return Regex.IsMatch(pass1, REGEX_PASSWORD_1);
        }

    }
}
