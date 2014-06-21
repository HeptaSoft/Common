using System;
using HeptaSoft.Common.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeptaSoft.CommonTests.Helpers
{
    [TestClass]
    public class StringHelperTests
    {
        #region AllNullOrEmpty

        [TestMethod]
        [Description("Tests the AllNullOrEmpty with a null value and expects exception.")]
        [ExpectedException(typeof (ArgumentNullException))]
        public void AllNullOrEmpty_NotCastedNull_ExceptionExpected()
        {
            var condition = StringHelper.AllNullOrEmpty(null);
        }

        [TestMethod]
        [Description("Tests the AllNullOrEmpty with all null/empty strings and expects true as answer.")]
        public void AllNullOrEmpty_EmptyAndNullStrings_True()
        {
            var condition = StringHelper.AllNullOrEmpty("", string.Empty, (string)null, "");
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [Description("Tests the AllNullOrEmpty with a one not empty string and expects false as answer.")]
        public void AllNullOrEmpty_OneNotEmptyString_False()
        {
            var condition = StringHelper.AllNullOrEmpty("", string.Empty, "hel lo", (string)null, "");
            Assert.IsFalse(condition);
        }
        
        #endregion

        #region AllNullOrWhiteSpace

        [TestMethod]
        [Description("Tests the AllNullOrWhiteSpace with a null value and expects exception.")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AllNullOrWhiteSpace_NotCastedNull_ExceptionExpected()
        {
            var condition = StringHelper.AllNullOrWhiteSpace(null);
        }

        [TestMethod]
        [Description("Tests the AllNullOrWhiteSpace with all null/empty strings and expects true as answer.")]
        public void AllNullOrWhiteSpace_EmptyAndNullStrings_True()
        {
            var condition = StringHelper.AllNullOrWhiteSpace("", "        ", string.Empty, (string)null, "   ", " ");
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [Description("Tests the AllNullOrWhiteSpace with a one not empty string and expects false as answer.")]
        public void AllNullOrWhiteSpace_OneNotEmptyString_False()
        {
            var condition = StringHelper.AllNullOrWhiteSpace("", "        ", string.Empty, " wo r ld ", (string)null, "", "   ");
            Assert.IsFalse(condition);
        }
        #endregion

        #region AnyNullOrEmpty

        [TestMethod]
        [Description("Tests the AnyNullOrEmpty with a null value and expects exception.")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AnyNullOrEmpty_NotCastedNull_ExceptionExpected()
        {
            var condition = StringHelper.AnyNullOrEmpty(null);
        }

        [TestMethod]
        [Description("Tests the AnyNullOrEmpty with a null or empty strings and expects true as answer.")]
        public void AnyNullOrEmpty_EmptyOrNullStrings1_True()
        {
            var condition = StringHelper.AnyNullOrEmpty("hello", "", "world");
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [Description("Tests the AnyNullOrEmpty with a null or empty strings and expects true as answer.")]
        public void AnyNullOrEmpty_EmptyOrNullStrings2_True()
        {
            var condition = StringHelper.AnyNullOrEmpty("hello", string.Empty, "world");
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [Description("Tests the AnyNullOrEmpty with a null or empty strings and expects true as answer.")]
        public void AnyNullOrEmpty_EmptyOrNullStrings3_True()
        {
            var condition = StringHelper.AnyNullOrEmpty("hello", (string)null, "world");
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [Description("Tests the AnyNullOrEmpty with a space string and expects false as answer.")]
        public void AnyNullOrEmpty_SpaceString_False()
        {
            var condition = StringHelper.AnyNullOrEmpty("hello", " ", "world");
            Assert.IsFalse(condition);
        }

        [TestMethod]
        [Description("Tests the AnyNullOrEmpty with a one not empty string and expects false as answer.")]
        public void AnyNullOrEmpty_AllNotEmptyStrings_False()
        {
            var condition = StringHelper.AnyNullOrEmpty("Hello", "hel lo", "wworld", "dsdd", "!!!");
            Assert.IsFalse(condition);
        }

        #endregion
        
        #region AnyNullOrWhiteSpace
        
        [TestMethod]
        [Description("Tests the AnyNullOrWhiteSpace with a null value and expects exception.")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AnyNullOrWhiteSpace_NotCastedNull_ExceptionExpected()
        {
            var condition = StringHelper.AnyNullOrWhiteSpace(null);
        }

        [TestMethod]
        [Description("Tests the AnyNullOrWhiteSpace with a null or empty strings and expects true as answer.")]
        public void AnyNullOrWhiteSpace_EmptyOrNullStrings1_True()
        {
            var condition = StringHelper.AnyNullOrWhiteSpace("hello", "", "world");
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [Description("Tests the AnyNullOrWhiteSpace with a null or empty strings and expects true as answer.")]
        public void AnyNullOrWhiteSpace_EmptyOrNullStrings2_True()
        {
            var condition = StringHelper.AnyNullOrWhiteSpace("hello", string.Empty, "world");
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [Description("Tests the AnyNullOrWhiteSpace with a null or empty strings and expects true as answer.")]
        public void AnyNullOrWhiteSpace_EmptyOrNullStrings3_True()
        {
            var condition = StringHelper.AnyNullOrWhiteSpace("hello", (string)null, "world");
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [Description("Tests the AnyNullOrWhiteSpace with a space string and expects false as answer.")]
        public void AnyNullOrWhiteSpace_SpaceString_True()
        {
            var condition = StringHelper.AnyNullOrWhiteSpace("hello", " ", "world");
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [Description("Tests the AnyNullOrWhiteSpace with a one not empty string and expects false as answer.")]
        public void AnyNullOrWhiteSpace_AllNotEmptyStrings_False()
        {
            var condition = StringHelper.AnyNullOrWhiteSpace("Hello", "  hel lo", "ww  orld", "dsd d", "!!!");
            Assert.IsFalse(condition);
        }
     
        #endregion
    }
}
