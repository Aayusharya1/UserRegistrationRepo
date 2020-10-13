using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Schema;
using UserRegistrationRegex;

namespace UserRegistrationRegexTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Valid_First_Name()
        {
            // Arrange
            string fname = "Aayush";
            bool expected = true;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateName(fname);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Test_Valid_Last_Name()
        {
            // Arrange
            string Lname = "Arya";
            bool expected = true;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateName(Lname);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Test_Valid_Email()
        {
            // Arrange
            string email = "Aayush.arya@gmail.com";
            bool expected = true;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateEmail(email);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Test_Valid_Mobile_Number()
        {
            // Arrange
            string MobNo = "91 9999888877";
            bool expected = true;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateMobileNo(MobNo);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Test_Valid_Password()
        {
            // Arrange
            string password = "aaYu12sh@.aaa";
            bool expected = false;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidatePassword(password);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
