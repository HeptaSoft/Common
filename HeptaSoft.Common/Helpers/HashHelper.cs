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
        /// Computes a sha256 hash from the input text.
        /// </summary>
        /// <param name="input">The input text.</param>
        /// <returns>The sha256 hash string.</returns>
        public static string ComputeSha256Hash(string input)
        {
            byte[] hashBuffer = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            var stringBuilder = new StringBuilder(hashBuffer.Length * 2);
            foreach (byte num in hashBuffer)
            {
                stringBuilder.Append(num.ToString("X2", CultureInfo.InvariantCulture));
            }
            return stringBuilder.ToString();
        }
    }
}
