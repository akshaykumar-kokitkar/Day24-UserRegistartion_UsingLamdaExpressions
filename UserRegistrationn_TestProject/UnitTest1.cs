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
        public void GivenFirstName_WhenCheck_ShouldReturnTrue()
        {
            RegexPattern name = new RegexPattern();
            bool result = name.ValidateFirstName("Akshay", RegexPattern.FIRSTNAME_REGEX);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenLastName_WhenCheck_ShouldReturnTrue()
        {
            RegexPattern lastname = new RegexPattern();
            bool resultlastname = lastname.ValidateLastName("Kokitkar", RegexPattern.LASTNAME_REGEX);
            Assert.IsTrue(resultlastname);
        }
        [TestMethod]
        public void GivenPhoneNum_WhenCheck_ShouldReturnTrue()
        {
            RegexPattern phonenum = new RegexPattern();
            bool resultphonenum = phonenum.ValidatePhoneNum("91 9868511791", RegexPattern.PHONENUMBER_REGEX);
            Assert.IsTrue(resultphonenum);
        }
        [TestMethod]
        public void GivenEmailId_WhenCheck_ShouldReturnTrue()
        {
            RegexPattern emailid = new RegexPattern();
            bool resultemailid = emailid.ValidateEmail("akokitkar3@gmail.com", RegexPattern.EMAIL_REGEX);
            Assert.IsTrue(resultemailid);
        }
        [TestMethod]
        public void TGivenPassword_WhenCheck_ShouldReturnTrue()
        {
            RegexPattern pass = new RegexPattern();
            bool resultpass = pass.ValidatePassword("123A@demo789", RegexPattern.PASSWORD_REGEX);
            Assert.IsTrue(resultpass);
        }
    }
}