using System;
using System.Collections;
using System.Security.Cryptography;

namespace SSS_Library.PasswordHandler
{
    public class PasswordBuilder
    {
        //TODO allow for more control at some point
        public const int HashSize = 64;
        public const int SaltSize = 64;
        
        private static StringHandler _stringHandler;

        public PasswordBuilder(StringHandler stringHandler)
        {
            _stringHandler = stringHandler;
        }

        /// <summary>
        /// Creates a salted SHA512 hash of the password.
        /// </summary>
        /// <param name="password">The password to hash.</param>
        /// <param name="hash">The returned hash</param>
        /// <param name="salt">The returned salt</param>
        public void CreateHash(string password, out string hash, out string salt)
        {
            // Generate a random salt
            var rnd = new RNGCryptoServiceProvider();
            var rndSalt = new byte[SaltSize];
            rnd.GetBytes(rndSalt);

            // Hash the password and encode the parameters
            var shaHash = ComputeHash_ShaSalt(password, rndSalt);

            salt = Convert.ToBase64String(rndSalt);
            hash = Convert.ToBase64String(shaHash);
        }

        /// <summary>
        /// Checks if the password given when salted and hashed matches with the hash stored from the originally generated password.
        /// </summary>
        /// <param name="password">The password to check.</param>
        /// <param name="hash">A hash from the correct password.</param>
        /// <param name="salt">The Salt from the correct password store</param>
        /// <returns>True if the password is correct.</returns>
        public bool CheckPassword(string password, string hash, string salt)
        {
            var testHash = ComputeHash_ShaSalt(password, _stringHandler.GetBytes(salt));
            //TODO Make more secure
            var testString = Convert.ToBase64String(testHash);
            //return _stringHandler.SecureByteArrayEquals(_stringHandler.GetBytes(hash), testHash);
            return testString.Equals(hash);
        }

        /// <summary>
        /// Computes the SHA512 Salted Hash of a password.
        /// </summary>
        /// <param name="password">The password to hash.</param>
        /// <param name="salt">The salt.</param>
        /// <returns>A SHA512 hash of the password.</returns>
        public byte[] ComputeHash_ShaSalt(string password, byte[] salt)
        {
            var sha = new SHA512Cng();
            var concatStr = _stringHandler.GetBytes(String.Concat(password, salt));
            return sha.ComputeHash(concatStr);
        }
    }
}