using System;
using NUnit.Framework;
using Small_unit_testing;

namespace unittest
{
    [TestFixture]
    public class unit_test_framework
    {
        Unit_test test;
        [SetUp]
        public void SetUp()
        {
            test = new Unit_test();
        }
        
        [Test]
        public void Addition_test()
        {
            var result = test.Addition(3, 4);
            Assert.AreEqual(7,result);
        }
        [Test]
        public void subtraction_test()
        {
            var rsult = test.subtraction(5, 2);
            Assert.AreEqual(3,rsult);
        }
        [Test,Order(2)]
        public void subtraction_test_exception()
        {

            Assert.Catch<SystemException>(() => test.subtraction(1, 3));
            Assert.Throws<ArgumentException>(() => test.subtraction(1, 3)); ;
        }
       
        [TestCase(2,1, 1),Order(1)]
        public void sbtraction_test_multiple(int first, int second, int third)
        {
            var res = test.subtraction(first,second);
            Assert.AreEqual(third, res);
        }
        [TearDown]
        public void TearDown()
        {
            test.Dispose();
        }
        }
    }
