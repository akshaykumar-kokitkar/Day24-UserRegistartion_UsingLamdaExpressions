using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUsing_LambdaExpression
{
    public class ReflectionUserRegistration
    {
        public static void ReflectionTest()
        {

            Type type = Type.GetType("UserRegistrationUsing_LambdaExpression.RegexApplication");
            Console.WriteLine("Full Name :{0}", type.FullName);
            Console.WriteLine("Class name is : {0}", type.Name);
            Console.WriteLine("--------------------------------\nMethods in RegexApplication class\n--------------------------------");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine("--------------------------------\nProperties in RegexApplication class\n--------------------------------");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine("--------------------------------\nConstructors in RegexApplication class\n--------------------------------");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
