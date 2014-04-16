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

        [TestMethod]
        [Description("Tests the GetEnumsList with an non enum class.")]
        public void GetEnumList_NotEnum_NullExpected()
        {
            var list = EnumHelper.GetEnumsList<EnumHelperTests>();

            Assert.IsNull(list);
        }

        [TestMethod]
        [Description("Tests the GetEnumNamesList with an non enum class.")]
        public void GetEnumNamesList_NotEnum_NullExpected()
        {
            var list = EnumHelper.GetEnumNamesList<EnumHelperTests>();

            Assert.IsNull(list);
        }

        [TestMethod]
        [Description("Tests the GetEnumsList with an empty enum definition.")]
        public void GetEnumList_EmptyEnum_EmptyListExpected()
        {
            var list = EnumHelper.GetEnumsList<EmptyTestEnum>();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count == 0);
        }

        [TestMethod]
        [Description("Tests the GetEnumNamesList with an empty enum definition.")]
        public void GetEnumNamesList_EmptyEnum_EmptyListExpected()
        {
            var list = EnumHelper.GetEnumNamesList<EmptyTestEnum>();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count == 0);
        }

        [TestMethod]
        [Description("Tests the GetEnumsList with a correct enum.")]
        public void GetEnumList_CorrectEnum_EnumListExpected()
        {
            var list = EnumHelper.GetEnumsList<TestEnum>();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count == 3);
            Assert.IsTrue(list.Contains(TestEnum.Hello));
            Assert.IsTrue(list.Contains(TestEnum.My));
            Assert.IsTrue(list.Contains(TestEnum.World));
        }

        [TestMethod]
        [Description("Tests the GetEnumNamesList with a correct enum.")]
        public void GetEnumNamesList_CorrectEnum_EnumNameListExpected()
        {
            var list = EnumHelper.GetEnumNamesList<TestEnum>();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count == 3);
            Assert.IsTrue(list.Contains("Hello"));
            Assert.IsTrue(list.Contains("My"));
            Assert.IsTrue(list.Contains("World"));
        }

    }
}
