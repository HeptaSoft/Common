using HeptaSoft.Common.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeptaSoft.CommonTests.Helpers
{
    [TestClass]
    public class HashHelperTests
    {
        #region Md5

        /// <summary>
        /// Computes the md5 hash and expects a correct output.
        /// Correct hash taken from online application http://www.xorbin.com/tools/md5-hash-calculator
        /// </summary>
        [TestMethod]
        [Description("Computes the md5 hash and expects a correct output")]
        public void ComputeMd5Hash_ExpectedOutput_Test1()
        {
            // Arrange
            const string inputString = "passwordToHash";
            const string expectedOutput = "824850238aae70ec3717574a02aed59b";

            // Act
            var outputString = HashHelper.GetMd5Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        /// <summary>
        /// Computes the md5 hash and expects a correct output.
        /// Correct hash and sentence taken from wiki: https://en.wikipedia.org/wiki/Md5
        /// </summary>
        [TestMethod]
        [Description("Computes the md5 hash and expects a correct output")]
        public void ComputeMd5Hash_ExpectedOutput_Test2()
        {
            // Arrange
            const string inputString = "The quick brown fox jumps over the lazy dog";
            const string expectedOutput = "9e107d9d372bb6826bd81d3542a419d6";

            // Act
            var outputString = HashHelper.GetMd5Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        /// <summary>
        /// Computes the md5 hash and expects a correct output.
        /// Correct hash and sentence taken from wiki: https://en.wikipedia.org/wiki/Md5
        /// </summary>
        [TestMethod]
        [Description("Computes the md5 hash and expects a correct output")]
        public void ComputeMd5Hash_ExpectedOutput_Test3()
        {
            // Arrange
            const string inputString = "The quick brown fox jumps over the lazy dog.";
            const string expectedOutput = "e4d909c290d0fb1ca068ffaddf22cbd0";

            // Act
            var outputString = HashHelper.GetMd5Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        #endregion

        #region Sha1

        /// <summary>
        /// Computes the Sha1 hash and expects a correct output.
        /// Correct hash taken from online application http://www.xorbin.com/tools/Sha1-hash-calculator
        /// </summary>
        [TestMethod]
        [Description("Computes the Sha1 hash and expects a correct output")]
        public void ComputeSha1Hash_ExpectedOutput_Test1()
        {
            // Arrange
            const string inputString = "passwordToHash";
            const string expectedOutput = "54410cdc2af6e19331609beae42204dd668e26c4";

            // Act
            var outputString = HashHelper.GetSha1Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        /// <summary>
        /// Computes the Sha1 hash and expects a correct output.
        /// Correct hash and sentence taken from wiki: https://en.wikipedia.org/wiki/SHA-1
        /// </summary>
        [TestMethod]
        [Description("Computes the Sha1 hash and expects a correct output")]
        public void ComputeSha1Hash_ExpectedOutput_Test2()
        {
            // Arrange
            const string inputString = "The quick brown fox jumps over the lazy dog";
            const string expectedOutput = "2fd4e1c67a2d28fced849ee1bb76e7391b93eb12";

            // Act
            var outputString = HashHelper.GetSha1Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        /// <summary>
        /// Computes the Sha1 hash and expects a correct output.
        /// Correct hash and sentence taken from wiki: https://en.wikipedia.org/wiki/SHA-1
        /// </summary>
        [TestMethod]
        [Description("Computes the Sha1 hash and expects a correct output")]
        public void ComputeSha1Hash_ExpectedOutput_Test3()
        {
            // Arrange
            const string inputString = "The quick brown fox jumps over the lazy cog";
            const string expectedOutput = "de9f2c7fd25e1b3afad3e85a0bd17d9b100db4b3";

            // Act
            var outputString = HashHelper.GetSha1Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        #endregion

        #region Sha256

        /// <summary>
        /// Computes the sha256 hash and expects a correct output.
        /// Correct hash taken from online application http://www.xorbin.com/tools/sha256-hash-calculator
        /// </summary>
        [TestMethod]
        [Description("Computes the sha256 hash and expects a correct output")]
        public void ComputeSha256Hash_ExpectedOutput_Test1()
        {
            // Arrange
            const string inputString = "passwordToHash";
            const string expectedOutput = "155166377faa51932c3267608e4c95cd1e70768e69855f9a5363e83127a32d92";

            // Act
            var outputString = HashHelper.GetSha256Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        /// <summary>
        /// Computes the sha256 hash and expects a correct output.
        /// Correct hash and sentence taken from wiki: https://en.wikipedia.org/wiki/SHA-2
        /// </summary>
        [TestMethod]
        [Description("Computes the sha256 hash and expects a correct output")]
        public void ComputeSha256Hash_ExpectedOutput_Test2()
        {
            // Arrange
            const string inputString = "The quick brown fox jumps over the lazy dog";
            const string expectedOutput = "d7a8fbb307d7809469ca9abcb0082e4f8d5651e46d3cdb762d02d0bf37c9e592";

            // Act
            var outputString = HashHelper.GetSha256Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        /// <summary>
        /// Computes the sha256 hash and expects a correct output.
        /// Correct hash and sentence taken from wiki: https://en.wikipedia.org/wiki/SHA-2
        /// </summary>
        [TestMethod]
        [Description("Computes the sha256 hash and expects a correct output")]
        public void ComputeSha256Hash_ExpectedOutput_Test3()
        {
            // Arrange
            const string inputString = "The quick brown fox jumps over the lazy dog.";
            const string expectedOutput = "ef537f25c895bfa782526529a9b63d97aa631564d5d789c2b765448c8635fb6c";

            // Act
            var outputString = HashHelper.GetSha256Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        #endregion

        #region Sha384

        /// <summary>
        /// Computes the Sha384 hash and expects a correct output.
        /// Correct hash taken from online application http://www.md5calc.com/
        /// </summary>
        [TestMethod]
        [Description("Computes the Sha384 hash and expects a correct output")]
        public void ComputeSha384Hash_ExpectedOutput_Test1()
        {
            // Arrange
            const string inputString = "passwordToHash";
            const string expectedOutput = "8bd50aedbd510f20d49ec040bbd499176f9120846b6bfd7922444b03a881fd898e697f82e91f08cb70f19c66f6ebbbb0";

            // Act
            var outputString = HashHelper.GetSha384Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        /// <summary>
        /// Computes the Sha384 hash and expects a correct output.
        /// Correct hash and sentence taken from wiki: https://en.wikipedia.org/wiki/SHA-2
        /// </summary>
        [TestMethod]
        [Description("Computes the Sha384 hash and expects a correct output")]
        public void ComputeSha384Hash_ExpectedOutput_Test2()
        {
            // Arrange
            const string inputString = "The quick brown fox jumps over the lazy dog";
            const string expectedOutput = "ca737f1014a48f4c0b6dd43cb177b0afd9e5169367544c494011e3317dbf9a509cb1e5dc1e85a941bbee3d7f2afbc9b1";

            // Act
            var outputString = HashHelper.GetSha384Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        /// <summary>
        /// Computes the Sha384 hash and expects a correct output.
        /// Correct hash and sentence taken from wiki: https://en.wikipedia.org/wiki/SHA-2
        /// </summary>
        [TestMethod]
        [Description("Computes the Sha384 hash and expects a correct output")]
        public void ComputeSha384Hash_ExpectedOutput_Test3()
        {
            // Arrange
            const string inputString = "The quick brown fox jumps over the lazy dog.";
            const string expectedOutput = "ed892481d8272ca6df370bf706e4d7bc1b5739fa2177aae6c50e946678718fc67a7af2819a021c2fc34e91bdb63409d7";

            // Act
            var outputString = HashHelper.GetSha384Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        #endregion

        #region Sha512

        /// <summary>
        /// Computes the Sha512 hash and expects a correct output.
        /// Correct hash taken from online application http://www.md5calc.com/
        /// </summary>
        [TestMethod]
        [Description("Computes the Sha512 hash and expects a correct output")]
        public void ComputeSha512Hash_ExpectedOutput_Test1()
        {
            // Arrange
            const string inputString = "passwordToHash";
            const string expectedOutput = "d8ffbc89ac48e4c30adc9990c7639c4e4cb19c74c7c29fc06e218d27a0c80e035e68efadaf1240aba17b22ae315acaf1f39cd616ad1f7be3c583e036bf238f9e";

            // Act
            var outputString = HashHelper.GetSha512Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        /// <summary>
        /// Computes the Sha512 hash and expects a correct output.
        /// Correct hash and sentence taken from wiki: https://en.wikipedia.org/wiki/SHA-2
        /// </summary>
        [TestMethod]
        [Description("Computes the Sha512 hash and expects a correct output")]
        public void ComputeSha512Hash_ExpectedOutput_Test2()
        {
            // Arrange
            const string inputString = "The quick brown fox jumps over the lazy dog";
            const string expectedOutput = "07e547d9586f6a73f73fbac0435ed76951218fb7d0c8d788a309d785436bbb642e93a252a954f23912547d1e8a3b5ed6e1bfd7097821233fa0538f3db854fee6";

            // Act
            var outputString = HashHelper.GetSha512Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        /// <summary>
        /// Computes the Sha512 hash and expects a correct output.
        /// Correct hash and sentence taken from wiki: https://en.wikipedia.org/wiki/SHA-2
        /// </summary>
        [TestMethod]
        [Description("Computes the Sha512 hash and expects a correct output")]
        public void ComputeSha512Hash_ExpectedOutput_Test3()
        {
            // Arrange
            const string inputString = "The quick brown fox jumps over the lazy dog.";
            const string expectedOutput = "91ea1245f20d46ae9a037a989f54f1f790f0a47607eeb8a14d12890cea77a1bbc6c7ed9cf205e67b7f2b8fd4c7dfd3a7a8617e45f3c463d481c7e586c39ac1ed";

            // Act
            var outputString = HashHelper.GetSha512Hash(inputString);

            // Assert
            Assert.IsTrue(expectedOutput.ToUpperInvariant() == outputString.ToUpperInvariant());
        }

        #endregion
    }
}
