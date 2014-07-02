using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace HeptaSoft.Common.Helpers
{
    /// <summary>
    /// Hash Helper class
    /// </summary>
    public static class HashHelper
    {
        /// <summary>
        /// Responsible for formating the hashes into a readable format.
        /// </summary>
        /// <param name="hashBuffer"></param>
        /// <returns></returns>
        private static string FormatHash(byte[] hashBuffer)
        {
            var stringBuilder = new StringBuilder(hashBuffer.Length * 2);
            foreach (byte num in hashBuffer)
            {
                stringBuilder.Append(num.ToString("X2", CultureInfo.InvariantCulture));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Computes a md5 hash from the input text.
        /// </summary>
        /// <param name="input">The text to compute.</param>
        /// <returns>The md5 hash string.</returns>
        public static string GetMd5Hash(string input)
        {
            byte[] hashBuffer = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
            return FormatHash(hashBuffer);
        }

        /// <summary>
        /// Computes a sha1 hash from the input text.
        /// </summary>
        /// <param name="input">The text to compute.</param>
        /// <returns>The sha1 hash string.</returns>
        public static string GetSha1Hash(string input)
        {
            byte[] hashBuffer = new SHA1CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
            return FormatHash(hashBuffer);
        }

        /// <summary>
        /// Computes a sha256 hash from the input text.
        /// </summary>
        /// <param name="input">The text to compute.</param>
        /// <returns>The sha256 hash string.</returns>
        public static string GetSha256Hash(string input)
        {
            byte[] hashBuffer = new SHA256CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
            return FormatHash(hashBuffer);
        }

        /// <summary>
        /// Computes a sha384 hash from the input text.
        /// </summary>
        /// <param name="input">The text to compute.</param>
        /// <returns>The sha384 hash string.</returns>
        public static string GetSha384Hash(string input)
        {
            byte[] hashBuffer = new SHA384CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
            return FormatHash(hashBuffer);
        }

        /// <summary>
        /// Computes a sha512 hash from the input text.
        /// </summary>
        /// <param name="input">The text to compute.</param>
        /// <returns>The sha512 hash string.</returns>
        public static string GetSha512Hash(string input)
        {
            byte[] hashBuffer = new SHA512CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
            return FormatHash(hashBuffer);
        }
    }
}
