using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RhysBuszkoGoogleCodeJam;

namespace ForgoneTest
{
    [TestClass]
    public class ForgoneTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Forgone = new Forgone();

            int[] result = Forgone.Input(18149);

            if (result[0] + result[1] != 18149)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
