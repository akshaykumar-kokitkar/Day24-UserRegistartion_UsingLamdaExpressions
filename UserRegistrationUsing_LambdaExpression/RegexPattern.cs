using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UserRegistrationUsing_LambdaExpression
{
    public class RegexPattern
    {
        //regex pattern
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

        public const string LASTNAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

        public const string PHONENUMBER_REGEX = "^[9]{1}[1]{1}[ ]{1}[0-9]{10}$";

        public const string EMAIL_REGEX = "^[a-z0-9A-Z]+([.][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";

        public const string PASSWORD_REGEX = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";

        //Func delegate lamda expression
        public Func<string, string, bool> ValidateFirstName = (firstname, FIRSTNAME_REGEX) => Regex.IsMatch(firstname, FIRSTNAME_REGEX);
        public Func<string, string, bool> ValidateLastName = (lastname, LASTNAME_REGEX) => Regex.IsMatch(lastname,LASTNAME_REGEX);
        public Func<string, string, bool> ValidatePhoneNum = (phonenum, PHONENUMBER_REGEX) => Regex.IsMatch(phonenum, PHONENUMBER_REGEX);
        public Func<string, string, bool> ValidateEmail =(email, EMAIL_REGEX) => Regex.IsMatch(email, EMAIL_REGEX);
        public Func<string, string, bool> ValidatePassword = (password, PASSWORD_REGEX) => Regex.IsMatch(password, PASSWORD_REGEX);
    }
}
