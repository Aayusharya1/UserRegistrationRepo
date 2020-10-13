using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Xml.Schema;
using UserRegistrationRegex;

namespace UserRegistrationRegexTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow("Aayush")]
        [DataRow("AAYUSH")]
        public void Test_Valid_First_Name(string fname)
        {
            // Arrange
            bool expected = true;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateName(fname);

            //Assert
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]

        [DataRow("aayush")]
        [DataRow("Ay")]
        [DataRow("Aayush Arya")]
        public void Test_Invalid_First_Name(string fname)
        {
            // Arrange
            bool expected = false;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateName(fname);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("Arya")]
        [DataRow("Aryaaa")]
        public void Test_Valid_Last_Name(string Lname)
        {
            
            // Arrange
            bool expected = true;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateName(Lname);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("arya")]
        [DataRow("AAryaaa")]
        public void Test_Invalid_Last_Name(string Lname)
        {

            // Arrange
            bool expected = false;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateName(Lname);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        [DataRow("aayush@gmail.com")]
        [DataRow("aayush.cg@gmail.co.in")]
        [DataRow("aaay@gmail.co.in")]
        [DataRow("aayush01@gmail.com")]
        public void Test_Valid_Email(string email)
        {
            // Arrange
            bool expected = true;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateEmail(email);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        [DataRow("aayush.@gmail.com")]
        [DataRow("aaay@gmail.co.india")]
        [DataRow("aayush01@gmail.com.12")]
        public void Test_Invalid_Email(string email)
        {
            // Arrange
            bool expected = false;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateEmail(email);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        [DataRow("91 9811111111")]
       public void Test_Valid_Mobile_Number(string mobNo)
        {
            // Arrange
            bool expected = true;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateMobileNo(mobNo);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        [DataRow("919811111111")]
        public void Test_Invalid_Mobile_Number(string mobNo)
        {
            // Arrange
            bool expected = false;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidateMobileNo(mobNo);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        [DataRow("aaYu12sh@.aaa")]
        public void Test_Valid_Password(string password)
        {
            // Arrange
            bool expected = true;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidatePassword(password);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("aayu12sh@.aaa")]
        [DataRow("aayusharya")]
        public void Test_Invalid_Password(string password)
        {
            // Arrange
            bool expected = false;
            Pattern pattern = new Pattern();

            //Act
            bool actual = pattern.ValidatePassword(password);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
