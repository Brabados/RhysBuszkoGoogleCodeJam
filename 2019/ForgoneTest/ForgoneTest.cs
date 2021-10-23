using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RhysBuszkoGoogleCodeJam;


    [TestClass]
    public class ForgoneTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Forgone = new Forgone();

            int[] result = Forgone.Input(18149);

            Assert.AreEqual(result[0] + result[1], 18149);
            
        }

        [TestMethod]
        public void testCharArrayConverterForLeadingAndTrailing0()
        {

            var Forgone = new Forgone();

            char[] TestArray = new char[] { '0', '0', '3', '6', '9' };

            int Result = Forgone.CharArrayToInt(TestArray);

            Assert.AreEqual(Result, 369);
        }


    }

