using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSS_Library.PasswordHandler;

namespace SSS_Tests
{
    [TestClass]
    public class PasswordHandlerUnitTest
    {
        private static readonly StringHandler _stringHandler = new StringHandler();
        private readonly PasswordBuilder _passwordBuilder = new PasswordBuilder(_stringHandler);

        [TestMethod]
        public void TestPasswordHasing()
        {
            //make a password
            string test = "HereBeDragons64";
            string hash;
            string salt;
            _passwordBuilder.CreateHash(test, out hash, out salt);

            //get back 

            var returnTest = _passwordBuilder.ComputeHash_ShaSalt(test, _stringHandler.GetBytes(salt));
            var testString = Convert.ToBase64String(returnTest);
            Assert.AreEqual(testString, hash);

            //check if check works
            var check = _passwordBuilder.CheckPassword(test, hash, salt);
            Assert.IsTrue(check);
        }
    }
}
