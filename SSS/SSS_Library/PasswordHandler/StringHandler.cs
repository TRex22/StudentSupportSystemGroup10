using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSS_Library.PasswordHandler
{
    public class StringHandler
    {
        public byte[] GetBytes(string str)
        {
            var bytes = new byte[str.Length * sizeof(char)];
            Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public string GetString(byte[] bytes)
        {
            //var chars = new char[bytes.Length / sizeof(char)];
            //Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            //return new string(chars);
            return Encoding.Default.GetString(bytes);
        }

        //TODO Perhaps make this more secure
        /// <summary>
        /// Found here: http://stackoverflow.com/questions/16953231/cryptography-net-avoiding-timing-attack
        /// May Need to Fix at some point.
        /// </summary>
        /// <param name="a">The first byte array.</param>
        /// <param name="b">The second byte array.</param>
        /// <returns>True if both byte arrays are equal.</returns>
        public bool SecureByteArrayEquals(ICollection<byte> a, IList<byte> b)
        {
            if (a.Count != b.Count)
                return false;

            return !a.Where((t, i) => t != b[i]).Any();
        }
    }
}
