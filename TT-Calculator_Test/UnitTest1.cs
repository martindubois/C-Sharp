
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-Calculator_Test/UnitTest1.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TT_Calculator_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Add()
        {
            TT_Calculator.Calculator lC = new TT_Calculator.Calculator();

            lC.Push(1);
            lC.Push(2);

            Assert.AreEqual(3, lC.Add());
        }

        [TestMethod]
        public void Test_Div()
        {
            TT_Calculator.Calculator lC = new TT_Calculator.Calculator();

            lC.Push(1);
            lC.Push(2);

            Assert.AreEqual(0.5, lC.Div());
        }

        [TestMethod]
        public void Test_Mul()
        {
            TT_Calculator.Calculator lC = new TT_Calculator.Calculator();

            lC.Push(1);
            lC.Push(2);

            Assert.AreEqual(2, lC.Mul());
        }

        [TestMethod]
        public void Test_Sub()
        {
            TT_Calculator.Calculator lC = new TT_Calculator.Calculator();

            lC.Push(1);
            lC.Push(2);

            Assert.AreEqual(-1, lC.Sub());
        }
    }
}
