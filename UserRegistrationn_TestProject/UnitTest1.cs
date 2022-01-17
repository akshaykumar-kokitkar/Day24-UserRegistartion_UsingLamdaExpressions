using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationUsing_LambdaExpression;

namespace UserRegistrationn_TestProject
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        //Act
        //Asser
        [TestMethod]
        public void TestFirstNameReturnsTrue()
        {
            RegexPattern firstname = new RegexPattern();
            bool result = firstname.ValidateFirstName("Akshay");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestLastNameReturnsTrue()
        {
            RegexPattern lastname = new RegexPattern();
            bool resultlastname = lastname.ValidateLastName("Kokitkar");
            Assert.IsTrue(resultlastname);
        }
        [TestMethod]
        public void TestPhoneNumberReturnsTrue()
        {
            RegexPattern phonenum = new RegexPattern();
            bool resultphonenum = phonenum.ValidatePhoneNum("91 1234567890");
            Assert.IsTrue(resultphonenum);
        }
        [TestMethod]
        public void TestEmailIdReturnsTrue()
        {
            RegexPattern emailid = new RegexPattern();
            bool resultemailid = emailid.ValidateEmail("akokitkar3@gmail.com");
            Assert.IsTrue(resultemailid);
        }
        [TestMethod]
        public void TestPasswordReturnsTrue()
        {
            RegexPattern pass = new RegexPattern();
            bool resultpass = pass.ValidatePassword("asdf123@Aktest");
            Assert.IsTrue(resultpass);
        }
    }
}