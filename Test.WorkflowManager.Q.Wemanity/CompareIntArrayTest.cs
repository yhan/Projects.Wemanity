using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rhino.Mocks;
using NUnit.Framework;
using WorkflowManager.Q.Wemanity;

namespace Test.WorkflowManager.Q.Wemanity
{
    [TestFixture]
    public class CompareIntArrayTest
    {
        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {

        }

        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void TestCompare()
        {
            var array = new[] {1, 2, 3};
            Assert.IsTrue(array.CompareTo(new[] { 2, 1, 3 }));
            Assert.IsFalse(array.CompareTo(new[] {  3 }));
        }

    }
}