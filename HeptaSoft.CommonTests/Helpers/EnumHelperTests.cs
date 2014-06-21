using HeptaSoft.Common.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeptaSoft.CommonTests.Helpers
{
    [TestClass]
    public class EnumHelperTests
    {
        enum EmptyTestEnum
        {
        }

        enum TestEnum
        {
            Hello = 0,
            World = 20,
            My = 10,
        }

        #region GetEnumIds

        [TestMethod]
        [Description("Tests the GetEnumIds with an non enum class.")]
        public void GetEnumIds_NotEnum_NullExpected()
        {
            var list = EnumHelper.GetEnumIds<EnumHelperTests>();

            Assert.IsNull(list);
        }
        
        [TestMethod]
        [Description("Tests the GetEnumIds with an empty enum definition.")]
        public void GetEnumIds_EmptyEnum_EmptyListExpected()
        {
            var list = EnumHelper.GetEnumIds<EmptyTestEnum>();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count == 0);
        }

        [TestMethod]
        [Description("Tests the GetEnumIds with a correct enum.")]
        public void GetEnumIds_CorrectEnum_EnumListExpected()
        {
            var list = EnumHelper.GetEnumIds<TestEnum>();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count == 3);
            Assert.IsTrue(list.Contains(TestEnum.Hello));
            Assert.IsTrue(list.Contains(TestEnum.My));
            Assert.IsTrue(list.Contains(TestEnum.World));
        }

        #endregion

        #region GetEnumNames
        
        [TestMethod]
        [Description("Tests the GetEnumNames with an non enum class.")]
        public void GetEnumNames_NotEnum_NullExpected()
        {
            var list = EnumHelper.GetEnumNames<EnumHelperTests>();

            Assert.IsNull(list);
        }

        [TestMethod]
        [Description("Tests the GetEnumNames with an empty enum definition.")]
        public void GetEnumNames_EmptyEnum_EmptyListExpected()
        {
            var list = EnumHelper.GetEnumNames<EmptyTestEnum>();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count == 0);
        }
        
        [TestMethod]
        [Description("Tests the GetEnumNames with a correct enum.")]
        public void GetEnumNames_CorrectEnum_EnumNameListExpected()
        {
            var list = EnumHelper.GetEnumNames<TestEnum>();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count == 3);
            Assert.IsTrue(list.Contains("Hello"));
            Assert.IsTrue(list.Contains("My"));
            Assert.IsTrue(list.Contains("World"));
        }

        #endregion
    }
}
