using HeptaSoft.Common.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HeptaSoft.CommonTests.Helpers
{
    public class SingleLevelPrimitives
    {
        public Guid Id { get; set; }
        public bool Boolean = true;
        public string StringVal = "One name";
        public string StringProp { get; set; }
        public double NumVal = 10.9;
        public decimal NumVal2 = 11;
        public long NumProp { get; set; }
        public float NumProp2 { get; set; }
        public byte ByteVal = 3;
        public byte ByteProp { get; set; }
        public object ObjectVal = (object)"Hello";
        public object ObjectProp { get; set; }
        public char CharVal = 'a';
        public char CharProp { get; set; }

        public SingleLevelPrimitives()
        {
            this.Id = Guid.NewGuid();
            this.StringProp = "Hello class";
            this.NumProp = 1111111;
            this.NumProp2 = (float)0.1;
            this.ByteProp = (byte)1;
            this.ObjectProp = (object)"World!";
            this.CharProp = 'b';
        }
    }

    public class MultiLevelClass
    {
        public Guid MLId { get; set; }
        public bool MLBoolean = true;
        public SingleLevelPrimitives primitivesClass = new SingleLevelPrimitives();
        public SingleLevelPrimitives primitivesClassProp { get; set; }

        public MultiLevelClass()
        {
            this.MLId = Guid.NewGuid();
            this.primitivesClassProp = new SingleLevelPrimitives();
        }
    }

    [TestClass]
    public class CloneHelperTests
    {
        private void AssertEqualPrimitiveClass(SingleLevelPrimitives primitiveClass1, SingleLevelPrimitives primitiveClass2)
        {
            #region Helpers

            Assert.AreNotEqual(primitiveClass1, primitiveClass2);

            Assert.AreEqual(primitiveClass1.Id, primitiveClass2.Id);
            Assert.AreEqual(primitiveClass1.Boolean, primitiveClass2.Boolean);
            Assert.AreEqual(primitiveClass1.StringVal, primitiveClass2.StringVal);
            Assert.AreEqual(primitiveClass1.StringProp, primitiveClass2.StringProp);
            Assert.AreEqual(primitiveClass1.NumVal, primitiveClass2.NumVal);
            Assert.AreEqual(primitiveClass1.NumVal2, primitiveClass2.NumVal2);
            Assert.AreEqual(primitiveClass1.NumProp, primitiveClass2.NumProp);
            Assert.AreEqual(primitiveClass1.NumProp2, primitiveClass2.NumProp2);
            Assert.AreEqual(primitiveClass1.ByteVal, primitiveClass2.ByteVal);
            Assert.AreEqual(primitiveClass1.ByteProp, primitiveClass2.ByteProp);
            Assert.AreEqual(primitiveClass1.ObjectVal, primitiveClass2.ObjectVal);
            Assert.AreEqual(primitiveClass1.ObjectProp, primitiveClass2.ObjectProp);
            Assert.AreEqual(primitiveClass1.CharVal, primitiveClass2.CharVal);
            Assert.AreEqual(primitiveClass1.CharProp, primitiveClass2.CharProp);
        }

            #endregion

        [TestMethod]
        public void CloneClass1_SingleLevelPrimitives_AllEqual()
        {
            var testClass = new SingleLevelPrimitives();

            var clonedTestClass = CloneHelper.Clone(testClass);

            Assert.IsNotNull(clonedTestClass);
            AssertEqualPrimitiveClass(testClass, clonedTestClass);
        }

        [TestMethod]
        public void CloneClass1_MultiLevelClass_AllEqual()
        {
            var testClass = new MultiLevelClass();

            var clonedTestClass = CloneHelper.Clone(testClass);

            Assert.IsNotNull(clonedTestClass);
            Assert.AreEqual(testClass.MLId, clonedTestClass.MLId);
            Assert.AreEqual(testClass.MLBoolean, clonedTestClass.MLBoolean);
            AssertEqualPrimitiveClass(testClass.primitivesClass, clonedTestClass.primitivesClass);
            AssertEqualPrimitiveClass(testClass.primitivesClassProp, clonedTestClass.primitivesClassProp);
        }

        [TestMethod]
        public void CloneClass1_MultiLevelClass_AbleToHandleNull()
        {
            var testClass = new MultiLevelClass();
            testClass.primitivesClass = null;

            var clonedTestClass = CloneHelper.Clone(testClass);

            Assert.IsNotNull(clonedTestClass);
            Assert.AreEqual(testClass.MLId, clonedTestClass.MLId);
            Assert.AreEqual(testClass.MLBoolean, clonedTestClass.MLBoolean);
            Assert.IsNull(clonedTestClass.primitivesClass);
            AssertEqualPrimitiveClass(testClass.primitivesClassProp, clonedTestClass.primitivesClassProp);
        }
    }
}
