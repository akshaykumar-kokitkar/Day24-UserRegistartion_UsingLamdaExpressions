using System;

namespace UserRegistrationUsing_LambdaExpression
{
    public class RegexApplication : Exception
    {
        public RegexApplication(string message) : base(message) { }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration using Lambda Expression !");
            Console.WriteLine("-------------------------");
            Console.WriteLine("To register please choose any option below");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. First Name. \n2. Last Name. \n3. Phone Number \n4. Email Id \n5. Password \n6. Exit");
            Console.WriteLine("-------------------------");
            var userinput = Console.ReadLine();

            while (true)
            {
                try
                {
                    switch (userinput)
                    {
                        case "1":
                            try
                            {
                                Console.WriteLine("Enter your first name");
                                RegexPattern firstname = new RegexPattern();
                                bool result = firstname.ValidateFirstName(Console.ReadLine(), RegexPattern.FIRSTNAME_REGEX);
                                Console.WriteLine(result);
                                if (result == false)
                                {
                                    throw new RegexApplication("Must contain character only and first letter should capital with minimum 3 character");
                                }
                            }
                            catch(RegexApplication e)
                            {
                                Console.WriteLine("----------Invalid Input----------");
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "2":
                            try
                            {
                                Console.WriteLine("Enter your Last Name:");
                                RegexPattern lastname = new RegexPattern();
                                bool resultlastname = lastname.ValidateLastName(Console.ReadLine(), RegexPattern.LASTNAME_REGEX);
                                Console.WriteLine(resultlastname);
                                if (resultlastname == false)
                                {
                                    throw new RegexApplication("Must contain characters only. anf first letter should capital with minimum 3 characters.\n---------------");
                                }
                            }
                            catch (RegexApplication e)
                            {
                                Console.WriteLine("----------Invalid Input----------");
                                Console.WriteLine(e.Message);
                            }
                            break;

                        case "3":
                            try
                            {
                                Console.WriteLine("Enter your Phone Number:");
                                RegexPattern phonenum = new RegexPattern();
                                bool resultphonenum = phonenum.ValidatePhoneNum(Console.ReadLine(), RegexPattern.PHONENUMBER_REGEX);
                                Console.WriteLine(resultphonenum);
                                if (resultphonenum == false)
                                {
                                    throw new RegexApplication("Must contain integers only. Starting with '91' and space and having exact 10 digits as Phone Number.\n----------------");
                                }
                            }
                            catch (RegexApplication e)
                            {
                                Console.WriteLine("----------Invalid Input----------");
                                Console.WriteLine(e.Message);
                            }
                            break;

                        case "4":
                            try
                            {
                                Console.WriteLine("Enter your Email Id:");
                                RegexPattern emailid = new RegexPattern();
                                bool resultemailid = emailid.ValidateEmail(Console.ReadLine(), RegexPattern.EMAIL_REGEX);
                                Console.WriteLine(resultemailid);
                                if (resultemailid == false)
                                {
                                    throw new RegexApplication("Must contain Alphabet and Numeric Combination only.\nEnding with proper domain address e.g. '@gmail.com'\n---------------");
                                }
                            }
                            catch (RegexApplication e)
                            {
                                Console.WriteLine("----------Invalid Input----------");
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "5":
                            try
                            {
                                Console.WriteLine("Enter your Password:");
                                RegexPattern pass = new RegexPattern();
                                bool resultpass = pass.ValidatePassword(Console.ReadLine(), RegexPattern.PASSWORD_REGEX);
                                Console.WriteLine(resultpass);
                                if (resultpass == false)
                                {
                                    throw new RegexApplication("Must contain Alphanumeric combination.\nConsisting atleast 1 uppercase character, atleast 1 numeric value.\n and compulsary one special character.\n-----------------");
                                }
                            }
                            catch (RegexApplication e)
                            {
                                Console.WriteLine("----------Invalid Input----------");
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Invalid Input !");
                            break;
                    }
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Choose what to Enter:");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("1. First Name.\n2. Last Name.\n3. Phone Number.\n4. Email Id.\n5. Password.\n6. Exit");
                    Console.WriteLine("-------------------------");
                    userinput = Console.ReadLine();
                }
                
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
        }

        }
    }
}
