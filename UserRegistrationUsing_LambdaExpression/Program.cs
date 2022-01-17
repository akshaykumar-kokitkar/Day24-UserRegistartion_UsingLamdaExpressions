using System;

namespace UserRegistrationUsing_LambdaExpression
{
    public class RegexApplication : Exception
    {
        class CustomException : Exception
        {
            public CustomException
                (String message) : base(message)
            {

            }
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome To User Registration Using Lambda Expression !");
                Console.WriteLine("Choose what to Enter:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. First Name.\n2. Last Name.\n3. Phone Number.\n4. Email Id.\n5. Password.");
                Console.WriteLine("-------------------------");

                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            try
                            {
                                Console.WriteLine("Enter your First Name:");
                                RegexPattern name = new RegexPattern();
                                bool result = name.ValidateFirstName(Console.ReadLine());
                                if (result == false)
                                {
                                    throw new CustomException("Must contain characters only. Having first letter capital with minimum 3 characters.\n---------------");
                                }
                            }
                            catch (CustomException e)
                            {
                                Console.WriteLine("----------Invalid Input----------");
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.WriteLine("Enter your Last Name:");
                                RegexPattern lastname = new RegexPattern();
                                bool resultlastname = lastname.ValidateLastName(Console.ReadLine());
                                Console.WriteLine(resultlastname);
                                if (resultlastname == false)
                                {
                                    throw new CustomException("Must contain characters only. Having first letter capital with minimum 3 characters.\n---------------");
                                }
                            }
                            catch (CustomException e)
                            {
                                Console.WriteLine("----------Invalid Input----------");
                                Console.WriteLine(e.Message);
                            }
                            break;

                        case 3:
                            try
                            {
                                Console.WriteLine("Enter your Phone Number:");
                                RegexPattern phonenum = new RegexPattern();
                                bool resultphonenum = phonenum.ValidatePhoneNum(Console.ReadLine());
                                Console.WriteLine(resultphonenum);
                                if (resultphonenum == false)
                                {
                                    throw new CustomException("Must contain integers only. Starting with '91' and space and having exact 10 digits as Phone Number.\n---------------");
                                }
                            }
                            catch (CustomException e)
                            {
                                Console.WriteLine("----------Invalid Input----------");
                                Console.WriteLine(e.Message);
                            }
                            break;

                        case 4:
                            try
                            {
                                Console.WriteLine("Enter your Email Id:");
                                RegexPattern emailid = new RegexPattern();
                                bool resultemailid = emailid.ValidateEmail(Console.ReadLine());
                                Console.WriteLine(resultemailid);
                                if (resultemailid == false)
                                {
                                    throw new CustomException("Must contain Alphabet and Numeric Combination only.\nEnding with proper domain address e.g. '@gmail.com'\n---------------");
                                }
                            }
                            catch (CustomException e)
                            {
                                Console.WriteLine("----------Invalid Input----------");
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 5:
                            try
                            {
                                Console.WriteLine("Enter your Password:");
                                RegexPattern pass = new RegexPattern();
                                bool resultpass = pass.ValidatePassword(Console.ReadLine());
                                Console.WriteLine(resultpass);
                                if (resultpass == false)
                                {
                                    throw new CustomException("Must contain Alphanumeric combination.\nConsisting atleast 1 uppercase character, atleast 1 numeric value.\nAnd exactly one special character.\n---------------");
                                }
                            }
                            catch (CustomException e)
                            {
                                Console.WriteLine("----------Invalid Input----------");
                                Console.WriteLine(e.Message);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Input !");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Choose what to Enter:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. First Name.\n2. Last Name.\n3. Phone Number.\n4. Email Id.\n5. Password.");
                Console.WriteLine("-------------------------");

                Console.ReadKey();
            }

        }
    }
}
